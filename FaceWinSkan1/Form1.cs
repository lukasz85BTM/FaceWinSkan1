using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.IO;
using Emgu.CV.CvEnum;

namespace FaceWinSkan1
{
    public partial class Form1 : Form
    {
        private VideoCapture _capture = null;
        private Mat _frame = new Mat();
        private FaceRecognizer _faceRecognizer;
        private string _mappingFilePath = "mapping.csv";

        public Form1()
        {
            InitializeComponent();

            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.ItemHeight = 15;
            this.listBoxLog.Name = "listBoxLog";
            this.Controls.Add(this.listBoxLog);

            InitializeFaceDetectors();
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;

            buttonRecognize.Enabled = true;
            // Ścieżka do modelu
            string modelPath = Path.Combine(Application.StartupPath, "path", "to", "save", "model.xml");
            try
            {
                // Inicjalizacja FaceRecognizer
                _faceRecognizer = new FaceRecognizer(modelPath);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd przy inicjalizacji rozpoznawania twarzy: {ex.Message}");
            }
        }

        private void LogAction(string message, string logLevel = "INFO")
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string logEntry = $"[{timestamp}] [{logLevel}] {message}";
            listBoxLog.Items.Add(logEntry);
            listBoxLog.SelectedIndex = listBoxLog.Items.Count - 1;

            // Dodatkowo zapisuj logi do pliku
            File.AppendAllText("application.log", logEntry + Environment.NewLine);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LogAction("Rozpoczęcie wykrywania kamer...");
            for (int i = 0; i < 10; i++)
                {
                    try
                    {   
                        
                        using (var tempCapture = new VideoCapture(i))
                        {
                            if (tempCapture.IsOpened)
                            {
                                comboBoxKamery.Items.Add($"Kamera {i}");
                                LogAction($"Znaleziono kamerę {i}");
                        }

                        }
                        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Błąd podczas wykrywania kamery: {ex.Message}");
                        LogAction($"Błąd podczas wykrywania kamery {i}: {ex.Message}");
                    }
            }
            if (comboBoxKamery.Items.Count > 0)
            {
                    comboBoxKamery.SelectedIndex = 0;
                    LogAction("Kamery zostały załadowane.");
            }
        }
        
        public class FaceRecognition
        {
            public Rectangle[] DetectFacesInFrame(Mat frame)
            {
                CascadeClassifier faceDetector = new CascadeClassifier("haarcascade_frontalface_default.xml");
                var faces = faceDetector.DetectMultiScale(frame, 1.1, 10, Size.Empty);
                return faces;
            }
            public List<Image<Bgr, byte>> SaveDetectedFaces(Mat frame, string baseSavePath, string faceName)
            {
                // Pełna ścieżka folderu osoby
                string personDirectory = Path.Combine(baseSavePath, faceName);

                // Sprawdzanie, czy folder istnieje, jeśli nie, tworzenie
                if (!Directory.Exists(personDirectory))
                {
                    Directory.CreateDirectory(personDirectory);
                }

                // Inicjalizacja detektora twarzy
                CascadeClassifier faceDetector = new CascadeClassifier("haarcascade_frontalface_default.xml");
                
                // Wykrywanie twarzy
                //var faces = faceDetector.DetectMultiScale(frame, 1.1, 10, Size.Empty);
                var faces = faceDetector.DetectMultiScale(frame, 1.1, 10, new Size(30, 30));

                List<Image<Bgr, byte>> detectedFaces = new List<Image<Bgr, byte>>();

                // Iteracja po wykrytych twarzach
                int faceCount = 0;
                foreach (var face in faces)
                {
                    // Wycinanie obszaru z wykrytą twarzą
                    Mat faceMat = new Mat(frame, face);
                    Image<Bgr, byte> faceImage = faceMat.ToImage<Bgr, byte>();
                    detectedFaces.Add(faceImage);

                    // Tworzenie unikalnej nazwy pliku
                    string fileName;
                    do
                    {
                        // Dodanie milisekund do nazwy pliku
                        fileName = Path.Combine(personDirectory, $"{faceName}_{DateTime.Now:yyyyMMdd_HHmmss_fff}_{faceCount}.jpg");
                        faceCount++;
                    } while (File.Exists(fileName));

                    // Zapis wykrytej twarzy jako czystego obrazu bez modyfikacji
                    faceImage.Save(fileName);

                }

                return detectedFaces;
            }
        }
        
        private List<CascadeClassifier> _faceDetectors;

        private void InitializeFaceDetectors()
        {
            _faceDetectors = new List<CascadeClassifier>
            {
                new CascadeClassifier("haarcascade_frontalface_default.xml"), // Twarz
                new CascadeClassifier("haarcascade_profileface.xml"), // Profil Twarzy
                new CascadeClassifier("haarcascade_eye.xml") // Dodaj detektor oczu
            };
        }

        private void btnKamera_Click(object sender, EventArgs e)
        {
            try
            {
                if (_capture == null)
                {
                    int cameraIndex = comboBoxKamery.SelectedIndex;
                    _capture = new VideoCapture(cameraIndex);
                    _capture.ImageGrabbed += ProcessFrame;
                    _capture.Start();
                    btnKamera.Text = "Zatrzymaj Kamerę";
                    LogAction("Kamera została uruchomiona.");
                }
                else
                {
                    _capture.Stop();
                    _capture.Dispose();
                    _capture = null;
                    pictureBoxCamera.Image = null;
                    btnKamera.Text = "Uruchom Kamerę";
                    LogAction("Kamera została wyłączona.");
                }
            }
            catch (Exception ex)
            {
                LogAction($"Błąd podczas uruchamiania kamery: {ex.Message}", "ERROR");
            }
            
        }
        private readonly List<MCvScalar> _colors = new List<MCvScalar>
        {
            new MCvScalar(255, 0, 0), // Niebieski
            new MCvScalar(0, 255, 0), // Zielony
            new MCvScalar(0, 0, 255), // Czerwony
            new MCvScalar(255, 255, 0), // Żółty
            new MCvScalar(255, 0, 255), // Różowy
            new MCvScalar(0, 255, 255)  // Turkusowy
        };

        private void ProcessFrame(object sender, EventArgs e)
        {
            if (_capture != null && _capture.Ptr != IntPtr.Zero)
            {
                // Ustawienie statusu kamery na "Aktywna"
                toolStripStatusLabel2.Text = "Status kamery: Aktywna";

                // Przechwytywanie obrazu z kamery
                _capture.Retrieve(_frame, 0);

                // Przekształcenie obrazu na odcienie szarości
                Mat grayFrame = new Mat();
                CvInvoke.CvtColor(_frame, grayFrame, ColorConversion.Bgr2Gray);

                // Zastosowanie histogram equalization
                CvInvoke.EqualizeHist(grayFrame, grayFrame);

                int detectorIndex = 0; // Licznik detektorów

                // Zmienna przechowująca indeks, aby przypisać obrazy do pictureBox
                int faceCounter = 1; //Licznik Twarzy

                // Pętla po detektorach twarzy
                foreach (var detector in _faceDetectors)
                {
                    try
                    {
                        // Detekcja twarzy
                        var faces = detector.DetectMultiScale(grayFrame, 1.1, 10, Size.Empty);
                        var color = _colors[detectorIndex % _colors.Count];
                        
                        foreach (var face in faces)
                        {
                            // Rysowanie prostokąta wokół twarzy
                            CvInvoke.Rectangle(_frame, face, color, 2);

                            string label = GetLabelForFace(face);
                            Point labelPoint = new Point(face.X, face.Y - 10);
                            CvInvoke.PutText(_frame, label, labelPoint, FontFace.HersheySimplex, 0.5, color, 2);

                            // Wycinek obrazu twarzy
                            Mat faceMat = new Mat(grayFrame, face);
                            Image<Gray, byte> grayFaceImage = faceMat.ToImage<Gray, byte>();

                            // Przekształcanie obrazu twarzy na bitmapę
                            Bitmap faceBitmap = new Bitmap(grayFaceImage.ToBitmap());

                            // Skalowanie obrazu twarzy do odpowiednich rozmiarów kontrolki
                            Bitmap scaledFaceBitmap = new Bitmap(faceBitmap, new Size(pictureBoxRecognizedFace.Width, pictureBoxRecognizedFace.Height));

                            // Przypisanie twarzy do odpowiednich kontrolkach
                            switch (faceCounter)
                            {
                                case 1:
                                    pictureBoxRecognizedFace.Image = scaledFaceBitmap;  // Pierwsza twarz do pictureBoxRecognizedFace
                                    break;
                                case 2:
                                    face2.Image = new Bitmap(faceBitmap, new Size(face2.Width, face2.Height)); // Druga twarz do face2
                                    break;
                                case 3:
                                    face3.Image = new Bitmap(faceBitmap, new Size(face3.Width, face3.Height)); // Trzecia twarz do face3
                                    break;
                                case 4:
                                    face4.Image = new Bitmap(faceBitmap, new Size(face4.Width, face4.Height)); // Czwarta twarz do face4
                                    break;
                            }

                            // Zwiększanie licznika dla twarzy
                            faceCounter++;

                            // Jeśli wykryliśmy 4 twarze, zatrzymajmy dodawanie
                            if (faceCounter > 4) break;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Logowanie błędów
                        Console.WriteLine($"Błąd w detektorze {detectorIndex}: {ex.Message}");
                    }
                    detectorIndex++;
                }

                // Wyświetlanie obrazu z kamery
                Image<Bgr, byte> image = _frame.ToImage<Bgr, byte>();
                Bitmap bitmap = image.ToBitmap();
                pictureBoxCamera.Image = bitmap; // Wyświetlanie obrazu z kamery w kontrolce PictureBox

            }
            else
            {
                // Ustawienie statusu kamery na "Nieaktywna"
                toolStripStatusLabel2.Text = "Status kamery: Nieaktywna";

                // Logowanie, że kamera jest nieaktywna
                LogAction("Błąd: Kamera nie jest prawidłowo zainicjowana.");
            }
        }
        
        private string GetLabelForFace(Rectangle face)
        {
            // Przyklad: odczyt etykiety z mapping.csv
            // Możesz dopasować rozpoznaną twarz do istniejących danych
            return "Nieznana twarz"; // Domyślnie
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _capture?.Dispose();
        }

        public void DetectFacesInFrame(Mat frame)
        {
            CascadeClassifier faceDetector = new CascadeClassifier("haarcascade_frontalface_default.xml");

            // Optymalizacja parametrów
            var faces = faceDetector.DetectMultiScale(frame, 1.1, 4, new Size(30, 30));


            foreach (var face in faces)
            {
                CvInvoke.Rectangle(frame, face, new MCvScalar(0, 0, 255), 2);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (_capture != null && _capture.Ptr != IntPtr.Zero)
            {
                string savePath = Path.Combine(Application.StartupPath, "Face");
                if (!Directory.Exists(savePath))
                {
                    Directory.CreateDirectory(savePath);
                }

                string faceName = txtFaceName.Text;
                if (string.IsNullOrEmpty(faceName))
                {
                    MessageBox.Show("Proszę wprowadzić nazwę osoby.", "Błąd");
                    return;
                }

                // Tworzenie instancji rozpoznawania twarzy
                FaceRecognition faceRecognition = new FaceRecognition();

                // Zapisywanie wykrytych twarzy
                List<Image<Bgr, byte>> detectedFaces = faceRecognition.SaveDetectedFaces(_frame, savePath, faceName);

                if (detectedFaces.Count > 0)
                {
                    pictureBoxRecognizedFace.Image = detectedFaces[0].ToBitmap();
                    LogAction($"Wykryte twarze zostały zapisane w katalogu 'Face'.");

                    // Zapis nazwy osoby do pliku mapowania
                    string mappingFilePath = Path.Combine(Application.StartupPath, "mapping.csv");
                    int generatedLabel = AddOrUpdateName(faceName, mappingFilePath);

                    MessageBox.Show($"Wykryte twarze zostały zapisane w katalogu 'Face' i przypisano etykietę {generatedLabel} dla '{faceName}'.");
                }
                else
                {
                    MessageBox.Show("Nie wykryto żadnych twarzy.");
                }
            }
            else
            {
                MessageBox.Show("Kamera nie jest uruchomiona.");
                LogAction("Próba zapisania twarzy bez uruchomionej kamery.");
            }
        }
        private int AddOrUpdateName(string name, string mappingFilePath)
        {
            Dictionary<int, string> labelNameMapping = new Dictionary<int, string>();
            int nextLabel = 1; // Startujemy od 1

            // Odczyt istniejących mapowań z pliku
            if (File.Exists(mappingFilePath))
            {
                foreach (var line in File.ReadAllLines(mappingFilePath))
                {
                    var parts = line.Split(',');
                    if (parts.Length == 2 && int.TryParse(parts[0], out int existingLabel))
                    {
                        labelNameMapping[existingLabel] = parts[1].Trim();
                        nextLabel = Math.Max(nextLabel, existingLabel + 1);
                    }
                }
            }

            // Sprawdzenie, czy nazwa już istnieje
            foreach (var kvp in labelNameMapping)
            {
                if (kvp.Value.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    // Zwracamy istniejącą etykietę
                    return kvp.Key;
                }
            }

            // Dodanie nowej nazwy z automatycznie wygenerowaną etykietą
            labelNameMapping[nextLabel] = name;

            // Zapis mapowania z powrotem do pliku
            using (var writer = new StreamWriter(mappingFilePath))
            {
                foreach (var kvp in labelNameMapping)
                {
                    writer.WriteLine($"{kvp.Key},{kvp.Value}");
                }
            }

            return nextLabel; // Zwracamy nową etykietę
        }


        private void TrainButton_Click(object sender, EventArgs e)
        {
            // Ścieżka do folderu, w którym zapisane są wykryte twarze
            string faceFolderPath = Path.Combine(Application.StartupPath, "Face");

            // Ścieżka do miejsca, w którym zapiszemy model
            string modelSavePath = Path.Combine(Application.StartupPath, "path", "to", "save", "model.xml");

            Console.WriteLine("Model Save Path: " + modelSavePath);  // Logowanie ścieżki do zapisu modelu

            // Tworzenie obiektu FaceTrainer
            FaceTrainer trainer = new FaceTrainer();

            try
            {
                // Wytrenuj model na zdjęciach z folderu Face i zapisz go
                trainer.TrainModel(faceFolderPath, modelSavePath);
                MessageBox.Show("Model został wytrenowany i zapisany!");
                LogAction("Model został wytrenowany i zapisany!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas trenowania modelu: " + ex.Message);
                LogAction("Wystąpił błąd podczas trenowania modelu: " + ex.Message);
            }
        }

        private void buttonRecognize_Click(object sender, EventArgs e)
        {
            // Ścieżka do modelu
            string modelFolder = Path.Combine(Application.StartupPath, "path", "to", "save");
            string modelFileName = "model.xml";
            string modelPath = Path.Combine(modelFolder, modelFileName);

            // Sprawdzenie, czy model istnieje
            if (!File.Exists(modelPath))
            {
                labelResult.Text = "Model nie został znaleziony!";
                labelResult.ForeColor = Color.Red;
                return;
            }

            // Pobranie obrazu z PictureBox
            if (pictureBoxCamera.Image == null)
            {
                labelResult.Text = "Brak obrazu w kamerze.";
                labelResult.ForeColor = Color.Red;
                return;
            }

            Bitmap imageToRecognize = new Bitmap(pictureBoxCamera.Image);

            try
            {
                // Tworzenie obiektu FaceRecognizer
                FaceRecognizer recognizer = new FaceRecognizer(modelPath);

                // Rozpoznawanie twarzy
                var result = recognizer.RecognizeFace(imageToRecognize);

                // Wyświetlenie wyniku w label
                labelResult.Text = $"Etykieta: {result.label}\nPewność: {result.confidence:F2}";
                labelResult.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                labelResult.Text = $"Błąd: {ex.Message}";
                labelResult.ForeColor = Color.Red;
            }
        }
        
        private void btn_ImageFace_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Ścieżka folderu, gdzie metoda guna2Button2_Click zapisuje zdjęcia
                string imagePath = Path.Combine(Application.StartupPath, "Face");

                if (Directory.Exists(imagePath))
                {
                    // Otwórz folder zdjęć
                    System.Diagnostics.Process.Start("explorer.exe", imagePath);
                }
                else
                {
                    MessageBox.Show("Folder zapisanych zdjęć nie istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas otwierania folderu zdjęć: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_model_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Ścieżka folderu, gdzie metoda TrainButton_Click zapisuje model
                string modelPath = Path.Combine(Application.StartupPath, "path", "to", "save" );

                if (Directory.Exists(modelPath))
                {
                    // Otwórz folder modelu
                    System.Diagnostics.Process.Start("explorer.exe", modelPath);
                }
                else
                {
                    MessageBox.Show("Folder modelu nie istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas otwierania folderu modelu: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Pobranie obrazu z PictureBox
            if (pictureBoxCamera.Image == null)
            {
                labelResult.Text = "Brak obrazu w kamerze.";
                labelResult.ForeColor = Color.Red;
                return;
            }

            Bitmap imageToRecognize = new Bitmap(pictureBoxCamera.Image);

            try
            {
                // Ścieżka do modelu
                string modelFolder = Path.Combine(Application.StartupPath, "path", "to", "save");
                string modelFileName = "model.xml";
                string modelPath = Path.Combine(modelFolder, modelFileName);

                // Tworzenie obiektu FaceRecognizer
                FaceRecognizer recognizer = new FaceRecognizer(modelPath);

                // Rozpoznawanie twarzy
                var result = recognizer.RecognizeFace(imageToRecognize);

                // Wyświetlenie wyniku w label
                labelResult.Text = $"Etykieta: {result.label}\nPewność: {result.confidence:F2}";
                labelResult.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                labelResult.Text = $"Błąd: {ex.Message}";
                labelResult.ForeColor = Color.Red;
            }
        }
    }
}

