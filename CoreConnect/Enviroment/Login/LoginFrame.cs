using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enviroment {
    public partial class LoginFrame : Form {
        public LoginFrame() {
            InitializeComponent();
            Size = new Size(1302, 730);
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            Icon = new Icon("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Images & Videos\\Logo.ico");
            Load += CustomForm_Load;

            LoginPanelFrameWork log = new LoginPanelFrameWork(50,Color.Transparent, Color.Transparent, this);
            log.SetBounds(0,0,1302,730);
            this.Controls.Add(log);

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

