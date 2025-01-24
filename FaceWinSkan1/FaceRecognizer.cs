using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using System;
using System.Drawing;
using System.IO;

public class FaceRecognizer
{
    private LBPHFaceRecognizer _faceRecognizer;

    public FaceRecognizer(string modelPath)
    {
        if (!File.Exists(modelPath))
        {
            throw new FileNotFoundException("Model nie został znaleziony: " + modelPath);
        }

        try
        {
            _faceRecognizer = new LBPHFaceRecognizer();
            _faceRecognizer.Read(modelPath);

            if (_faceRecognizer == null)
            {
                throw new InvalidOperationException("Nie udało się załadować modelu.");
            }

            Console.WriteLine("Model został załadowany z: " + modelPath);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Błąd podczas ładowania modelu: {ex.Message}");
            throw;
        }
    }

    // Metoda istniejąca (rozpoznawanie z pliku)
    public (int label, double confidence) RecognizeFace(string imagePath)
    {
        if (!File.Exists(imagePath))
        {
            throw new FileNotFoundException("Obraz nie został znaleziony: " + imagePath);
        }

        try
        {
            // Wczytaj obraz w odcieniach szarości
            using (Image<Gray, byte> grayImage = new Image<Gray, byte>(imagePath))
            {
                CvInvoke.EqualizeHist(grayImage, grayImage);

                // Rozpoznaj twarz
                var result = _faceRecognizer.Predict(grayImage.Mat);

                Console.WriteLine($"Rozpoznano twarz. Etykieta: {result.Label}, Pewność: {result.Distance}");
                return (result.Label, result.Distance);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Błąd podczas rozpoznawania twarzy: {ex.Message}");
            return (-1, double.MaxValue); // Zwraca -1 w przypadku błędu
        }
    }

    // Nowa metoda: rozpoznawanie twarzy z Bitmap
    public (int label, double confidence) RecognizeFace(Bitmap bitmap)
    {
        if (bitmap == null)
        {
            Console.WriteLine("Bitmapa jest pusta.");
            return (-1, double.MaxValue);
        }

        try
        {
            using (Image<Gray, byte> grayImage = bitmap.ToImage<Gray, byte>())
            {
                if (grayImage == null || grayImage.Width == 0 || grayImage.Height == 0)
                {
                    Console.WriteLine("Nieprawidłowy obraz.");
                    return (-1, double.MaxValue);
                }

                CvInvoke.EqualizeHist(grayImage, grayImage);

                var result = _faceRecognizer.Predict(grayImage.Mat);

                Console.WriteLine($"Rozpoznano twarz. Etykieta: {result.Label}, Pewność: {result.Distance}");
                return (result.Label, result.Distance);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Błąd podczas rozpoznawania twarzy: {ex.Message}");
            return (-1, double.MaxValue);
        }
    }
}
