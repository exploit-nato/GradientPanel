using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace [namespace]
{
    internal class GradientPanel : Panel
    {   
        public Color top { get; set; }
        public Color bottom { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,this.top,this.bottom,90F);
            Graphics g = e.Graphics;
            g.FillRectangle(brush,this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
