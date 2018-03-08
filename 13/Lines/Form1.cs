using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopyLandscape {
	public partial class Form1 : Form {
		Graphics graphics;
		public Form1() {
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs e) {
			graphics = e.Graphics;
			graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

			Pen pen = new Pen(Brushes.BlueViolet, 8);
			// Упростите код с помощью цикла for
                int coordinates2 = 80;
                int coordinates = 20;
                for (int lines = 0; lines <= 6; lines++)
                {
                    coordinates2 = coordinates2 + 60;
                    coordinates = coordinates + 60;

                    graphics.DrawLine(pen, coordinates, 40, coordinates2, 80); // первая пара чисел - координаты начала отрезка, вторая - координаты конца
                }
		}
	}
}
