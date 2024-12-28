using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Enviroment.AdministrativeViewPort {
    
    
    public class ClassSchedulaing : Panel {
        TableLayoutPanel TimeeTable = new TableLayoutPanel();
        private List<string> s = new List<string>{"A", "B","C", "D","E", "F","G", "H",};
        public ClassSchedulaing() {
            
            this.Size = new Size(200,200);
            TimeeTable.RowCount = 4;
            TimeeTable.ColumnCount = 6;
            TimeeTable.Dock = DockStyle.Fill;

            for (int i = 0; i < 6; i++) {
                for (int j = 0; j < 4; j++) {
                    Panel p = new Panel();
                    p.Size = new Size(170,100);
                    if (j%2 == 0){
                        p.BackColor = Color.Blue;
                    }else{
                        p.BackColor = Color.Red;
                    }
                    TimeeTable.Controls.Add(p,i,j);
                }
            }
            Controls.Add(TimeeTable);

            TableLayoutPanel panel = new TableLayoutPanel();
            panel.ColumnCount = 1;
            panel.RowCount = s.Count;
            panel.SetBounds(1180, 0, 200, 550);
            panel.AutoScroll = true;

            for (int i = 0; i < s.Count; i++) {
                Panel pa = new Panel();
                pa.Text = s[i];
                pa.BackColor = Color.Aquamarine;
                pa.Size = new Size(200,50);
                panel.Controls.Add(pa,0,i);
            }
            
            Controls.Add(panel);
        }
    }
}