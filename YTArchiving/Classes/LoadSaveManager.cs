using Newtonsoft.Json;
using YTArchiving.Models;

namespace YTArchiving.Classes
{
    internal static class LoadSaveManager
    {
        //Constants

        private const string fileName = "Data.json";
        private const string folderName = "YTArchiving";

        // Internal Methods

        internal static List<SubFolder> Load()
        {
            string path = GetPath();

            if (!File.Exists(path))
            {
                return new();
            }

            string fileContents = File.ReadAllText(path);

            var deserialisedObject = JsonConvert.DeserializeObject<List<SubFolder>>(fileContents);

            return deserialisedObject ?? throw new Exception($"Unable to deserialise {path}");
        }

        internal static void Save(List<SubFolder> listToSave)
        {
            string path = GetPath();

            string fileContents = JsonConvert.SerializeObject(listToSave);

            FileInfo fileInfo = new(path);
            fileInfo.Directory?.Create();

            File.WriteAllText(path, fileContents);
        }

        // Private Methods

        private static string GetPath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), folderName, fileName);
        }
    }
}
