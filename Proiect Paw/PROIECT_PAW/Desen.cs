using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROIECT_PAW
{
    public partial class Desen : Form
    {
        private List<Actiune> actiuni;
        private const int margine = 10;

        Color culoareBari = Color.Blue;
        Color culoareText = Color.Red;
        Font fontText = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
        public Desen(List<Actiune> actiuni)
        {
            this.actiuni = new List<Actiune>(actiuni);
            InitializeComponent();
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (actiuni.Count>0)
            {
                Graphics g = e.Graphics;
                Rectangle rectangle = new Rectangle(panel1.ClientRectangle.X + 2 * margine,
                    panel1.ClientRectangle.Y + 2 * margine, panel1.ClientRectangle.Width - 2 * margine,
                    panel1.ClientRectangle.Height - 2 * margine);
                Pen pen = new Pen(Color.Black, 3);
                g.DrawRectangle(pen, rectangle);

                double latime = rectangle.Width / actiuni.Count / 3;
                double distanta = (rectangle.Width - actiuni.Count * latime) / (actiuni.Count + 1);
                double vMax = actiuni.Max(max => max.VALOARE);

                Brush brBari = new SolidBrush(culoareBari);
                Brush brText = new SolidBrush(culoareText);

                Rectangle[] rectangles = new Rectangle[actiuni.Count];
                for (int i = 0; i < actiuni.Count; i++)
                {
                    rectangles[i] = new Rectangle((int)(rectangle.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rectangle.Location.Y + rectangle.Height - actiuni[i].VALOARE / vMax * rectangle.Height),
                        (int)(latime),
                        (int)(actiuni[i].VALOARE / vMax * rectangle.Height));
                    g.DrawString(actiuni[i].DATA.ToString(), fontText, brText, new Point(
                        rectangles[i].Location.X, rectangles[i].Location.Y - fontText.Height));
                }

                g.FillRectangles(brBari, rectangles);

                for (int i = 0; i < actiuni.Count - 1; i++)
                {
                    g.DrawLine(pen, new Point((int)(rectangles[i].Location.X + latime / 2),
                        rectangles[i].Location.Y), new Point((int)(rectangles[i + 1].Location.X + latime / 2),
                        rectangles[i + 1].Location.Y));
                }
            }
        }
    }
}
