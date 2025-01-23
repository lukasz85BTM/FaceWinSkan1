﻿using System;
using System.IO;
using System.Collections.Generic;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using System.Linq;

public class FaceTrainer
{
    private List<string> _names;  // Lista nazw przypisanych do etykiet

    public FaceTrainer()
    {
        _names = new List<string>();
    }

    public void TrainModel(string faceFolderPath, string modelSavePath)
    {
        // Sprawdzamy, czy folder z obrazami istnieje
        if (!Directory.Exists(faceFolderPath))
        {
            throw new DirectoryNotFoundException("Folder z obrazami nie został znaleziony: " + faceFolderPath);
        }

        // Pobieramy wszystkie pliki graficzne (jpg, png, jpeg) z folderu Face oraz jego podfolderów
        string[] imageFiles = Directory.GetFiles(faceFolderPath, "*.*", SearchOption.AllDirectories)
            .Where(s => s.EndsWith(".jpg") || s.EndsWith(".jpeg") || s.EndsWith(".png"))
            .ToArray();

        if (imageFiles.Length == 0)
        {
            throw new FileNotFoundException("Brak zdjęć w folderze: " + faceFolderPath);
        }

        // Inicjalizujemy obiekty do przechowywania zdjęć i etykiet
        VectorOfMat images = new VectorOfMat();
        List<int> labels = new List<int>(); // Zmieniamy na List<int>

        foreach (string file in imageFiles)
        {
            // Wczytujemy obrazek (w trybie grayscale)
            Mat image = CvInvoke.Imread(file, ImreadModes.Grayscale);
            if (image.IsEmpty)
            {
                throw new Exception("Nie udało się wczytać obrazu: " + file);
            }

            // Pobieramy etykietę z nazwy pliku
            int label = GetLabelFromFile(file);
            images.Push(image); // Dodajemy obraz do wektora
            labels.Add(label);  // Dodajemy etykietę do listy

            // Pobieramy nazwisko z folderu i przypisujemy do etykiety
            string name = new DirectoryInfo(Path.GetDirectoryName(file)).Name;
            if (label >= 0 && label < _names.Count)
            {
                _names[label] = name;  // Przypisujemy nazwisko do odpowiedniej etykiety
            }
            else
            {
                _names.Add(name);  // Dodajemy nową nazwę dla nowej etykiety
            }
        }

        // Inicjalizujemy rozpoznawanie twarzy
        var faceRecognizer = new LBPHFaceRecognizer();
        faceRecognizer.Train(images, new VectorOfInt(labels.ToArray()));  // Używamy poprawnego typu danych

        // Sprawdzamy, czy folder docelowy istnieje, jeśli nie, tworzymy go
        string directoryPath = Path.GetDirectoryName(modelSavePath);
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        try
        {
            // Zapisujemy model w podanej ścieżce
            faceRecognizer.Write(modelSavePath);
            Console.WriteLine("Model zapisany w: " + modelSavePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Błąd zapisu modelu: " + ex.Message);
            throw new Exception("Wystąpił błąd podczas zapisywania modelu: " + ex.Message);
        }
    }

    // Metoda do przypisania etykiety na podstawie nazwy pliku
    private int GetLabelFromFile(string filePath)
    {
        string fileName = Path.GetFileNameWithoutExtension(filePath);
        string[] parts = fileName.Split('_');  // Dzielimy nazwę pliku na części

        if (parts.Length > 0)
        {
            // Używamy ostatniej części jako etykiety, która powinna być liczbą
            string labelPart = parts[parts.Length - 1];  // Ostatnia część po podziale

            int label;
            if (int.TryParse(labelPart, out label))
            {
                return label;
            }
            else
            {
                throw new FormatException("Nieprawidłowy format etykiety w pliku: " + filePath);
            }
        }

        return -1;  // Jeśli nie udało się znaleźć etykiety
    }

    // Metoda do rozpoznawania twarzy i zwracania nazwy osoby
    public string RecognizeFace(string modelPath, string imagePath)
    {
        // Sprawdzamy, czy model i obraz istnieją
        if (!File.Exists(modelPath))
        {
            throw new FileNotFoundException("Model nie został znaleziony: " + modelPath);
        }

        if (!File.Exists(imagePath))
        {
            throw new FileNotFoundException("Obraz do rozpoznania nie został znaleziony: " + imagePath);
        }

        // Wczytanie modelu
        var faceRecognizer = new LBPHFaceRecognizer();
        faceRecognizer.Read(modelPath);

        // Wczytanie obrazu do rozpoznania
        Mat image = CvInvoke.Imread(imagePath, ImreadModes.Grayscale);
        if (image.IsEmpty)
        {
            throw new Exception("Nie udało się wczytać obrazu: " + imagePath);
        }

        // Rozpoznawanie twarzy
        var result = faceRecognizer.Predict(image);

        // Zwracamy nazwisko na podstawie etykiety
        if (result.Label != -1 && result.Label < _names.Count)
        {
            return _names[result.Label];  // Zwracamy nazwisko osoby przypisanej do etykiety
        }

        return "Nie rozpoznano twarzy.";
    }


}
