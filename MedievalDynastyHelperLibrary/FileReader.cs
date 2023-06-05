using Newtonsoft.Json;

namespace MedievalDynastyHelperLibrary
{
    public static class FileReader
    {
        private static string filePath = "C:\\Users\\Cruz Sanchez\\Desktop\\repos\\MedievalDynastyHelper/Crops.json";

        public static List<Crop> ReadCropFile()
        {
            var data = File.ReadAllText(filePath);

            var crops = JsonConvert.DeserializeObject<List<Crop>>(data);

            return crops;
        }
    }
}
