using System;
using System.Collections.Generic;
using System.Drawing;
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
                p = new Panel();
                p.Text = names[i];
                p.Size = new Size(700, 70);
                p.BackColor = Color.LightGreen;
                p.Click += changed;
                panel.Controls.Add(p, 0, i);
            }
            panel.BackColor = Color.Aqua;
            Controls.Add(panel);
            
        }

        public void changed(object obj, EventArgs e) {
            p.BackColor = Color.Red;
            p.Invalidate();
        }
    }
}