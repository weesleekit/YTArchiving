namespace YTArchivingConsole.Models
{
    internal class SubFolder
    {
        public string Name { get; set; }
        public List<SubFolder> Folders { get; set; }
        public List<Subscription> Subscriptions { get; set; }
    }
}
