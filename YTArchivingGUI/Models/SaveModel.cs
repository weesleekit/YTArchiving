namespace YTArchivingGUI.Models
{
    internal class SaveModel
    {
        public string BasePath { get; set; } = @"C:\YT Archive Output";
        public List<SubFolder> SubFolders { get; set; } = new();
    }
}
