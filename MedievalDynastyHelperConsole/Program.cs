using MedievalDynastyHelperLibrary;

namespace MedievalDynastyHelperConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var crops = FileReader.ReadCropFile();
        }
    }
}