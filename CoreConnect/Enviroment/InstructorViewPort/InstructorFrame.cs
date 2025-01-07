using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Enviroment.InstructorViewPort {
    public partial class InstructorFrame : Form {
        public InstructorFrame() {
            InitializeComponent();
            Size = new Size(1302, 730);
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            Icon = new Icon("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Images & Videos\\Logo.ico");
            Load += CustomForm_Load;
            
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
        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED: Enables double buffering
                cp.Style |= 0x02000000;  // WS_CLIPCHILDREN: Avoid redrawing child controls
                return cp;
            }
        }
    }
}