namespace YTArchivingGUI.Models
{
    internal class SubFolder
    {
        public string Name { get; set; }
        public List<Subscription> Subscriptions { get; set; } = new List<Subscription>();
    }
}
