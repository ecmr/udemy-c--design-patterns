using System.Drawing;
using System.Windows.Forms;

namespace Command
{
    public class UpdateForeColor : ICommand
    {
        public Control UI { get; set; }
        public Color Color { get; set; }

        public void UpdateColor()
        {
            UI.ForeColor = Color;
        }
    }
}
