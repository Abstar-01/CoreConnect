using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Enviroment.InstructorViewPort
{
    public partial class InstructorFrame : Form {
        
        public InstructorFrame() {
            InitializeComponent();
            Size = new Size(1500,820);
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            Load += CustomForm_Load;

            InstructorPanel instructorPanel = new InstructorPanel(50, Color.FromArgb(72, 85, 99), Color.FromArgb(41, 50, 60), this);
            instructorPanel.BackColor = Color.Transparent;
            instructorPanel.SetBounds(0,0,1500,820);
            this.Controls.Add(instructorPanel);
            
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