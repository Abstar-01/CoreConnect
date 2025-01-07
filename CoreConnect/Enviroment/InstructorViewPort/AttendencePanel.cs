using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;
using System.Xml;

namespace Enviroment.InstructorViewPort
{
    public class AttendencePanel : Panel {
        
        private List<string> names = new List<string> { "Abel", "John", "Ben", "Mark"};
        public Panel p;
        public AttendencePanel()
        {
            TableLayoutPanel panel = new TableLayoutPanel();
            panel.ColumnCount = 4;
            panel.RowCount = names.Count;
            panel.SetBounds(0,0,700,420);

            for (int i = 0; i < names.Count; i++) {
                panel.Controls.Add(new panel(names[i]), 0, i);
            }
            panel.BackColor = Color.Aqua;
            Controls.Add(panel);
            
        }
    }
    public class panel : Panel {
        Color startColor, endColor;      
        public panel(string s) {
            this.Text = s;
            this.Size = new Size(700, 70);
            this.BackColor = Color.LightGreen;
            
            startColor = Color.Blue;
            endColor = Color.Red;
            
            string pic =
                "C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\CheckCircle.png";
            PictureBox blue = new PictureBox {
                Image = Image.FromFile(pic),
            };
            blue.SetBounds(10, 10, 25, 25);
            blue.BackColor = Color.Transparent;
            blue.Click += (sender, args) => {
                startColor = Color.Blue;
                endColor = Color.Aqua;
                Invalidate();
            };
            Controls.Add(blue);
            
            PictureBox Red = new PictureBox {
                Image = Image.FromFile(pic),
            };
            Red.SetBounds(50, 10, 25, 25);
            Red.BackColor = Color.Transparent;
            Red.Click += (sender, args) => {
                startColor = Color.Brown;
                endColor = Color.Red;
                Invalidate();
            };
            Controls.Add(Red);
            
            PictureBox Green = new PictureBox {
                Image = Image.FromFile(pic),
            };
            Green.SetBounds(90, 10, 25, 25);
            Green.BackColor = Color.Transparent;
            Green.Click += (sender, args) => {
                startColor = Color.DarkGreen;
                endColor = Color.Green;
                Invalidate();
            };
            Controls.Add(Green);
            
            this.Click += (sender, args) => {
                Console.WriteLine(s);
                BackColor = Color.Brown;
            };
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            using (LinearGradientBrush b = new LinearGradientBrush(ClientRectangle,startColor,endColor,LinearGradientMode.Horizontal)) {
                e.Graphics.FillRectangle(b,ClientRectangle);
            }
        }
    }
}