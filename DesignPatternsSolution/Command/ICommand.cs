namespace Command
{
    public interface ICommand
    {
        System.Windows.Forms.Control UI { get; set; }
        System.Drawing.Color Color { get; set; }
        void UpdateColor();
    }
}
