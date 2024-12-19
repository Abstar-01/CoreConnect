using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Enviroment.StudentViewPort
{
    public partial class StudentFrame : Form
    {
        public StudentFrame() {
            InitializeComponent();
            Size = new Size(1430,850);
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            Load += CustomForm_Load;
            
            StudentMainPanel main = new StudentMainPanel(50,Color.Transparent,Color.Transparent);
            main.BackColor = Color.Transparent;
            main.SetBounds(0,0,1430,850);
            Controls.Add(main);
        }
        
        private void CustomForm_Load(object sender, EventArgs e) {
            int radius = 50;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(this.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(this.Width - radius, this.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            
            this.Region = new Region(path);
        }
    }
}