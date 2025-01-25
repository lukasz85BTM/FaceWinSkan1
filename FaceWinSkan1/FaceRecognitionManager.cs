using System.Collections.Generic;

public class FaceRecognitionManager
{
    private readonly string _modelPath;
    private readonly Dictionary<int, string> _labelToName;

    public FaceRecognitionManager(string modelPath)
    {
        _modelPath = modelPath;

        // Zainicjalizuj mapowanie etykiet na imiona
        _labelToName = new Dictionary<int, string>
        {
            { 0, "Łukasz" },
            { 1, "Julia" },
            { 2, "Piotr" }
        };
    }


}
