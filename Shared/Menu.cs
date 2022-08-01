namespace MenuLayout.Shared
{
    public class Menu
    {
        public string? Icon { get; set; }
        public string? Title { get; set; }
        public string? Subtitle { get; set; }
        public string? Link { get; set; }
        public List<ChildMenu>? Children { get; set; }
    }

    public class ChildMenu
    {
        public string? Icon { get; set; }
        public string? Title { get; set; }
        public string? Link { get; set; }
        public string? Subtitle { get; set; }
    }
}
