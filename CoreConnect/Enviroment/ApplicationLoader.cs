using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Timer = System.Windows.Forms.Timer;

namespace Enviroment {
    
    public partial class ApplicationLoader : Form {
        
        public ApplicationLoader() {
            InitializeComponent();
            Size = new Size(680,510);
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            Load += CustomForm_Load;

            PictureBox background = new PictureBox
            {
                Size = new Size(680,510),
                Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Application Loader Images & Icons\\OpenningGif.gif"),
                SizeMode = PictureBoxSizeMode.Normal,
            };

            PictureBox Logo = new PictureBox {
                Size = new Size(0,0),
                BackgroundImage = Image.FromFile(
                        "C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Application Loader Images & Icons\\CONNECT.png"),
            };
            Controls.Add(Logo);

            Label Title1 = new Label();
            Title1.Text = "Core";
            Title1.SetBounds(400,0,0,20);
            Title1.Font = new Font("Felix Titling", 25, FontStyle.Bold);
            Controls.Add(Title1);
            
            
            Label Title2 = new Label();
            Title2.Text = "Connect";
            Title2.SetBounds(400,20,0,20);
            Title2.Font = new Font("Felix Titling", 48, FontStyle.Bold);
            Controls.Add(Title2);
            
            Thread thread = new Thread(() => {
                Thread.Sleep(8650);
                BackColor = Color.White;
                Controls.Remove(background);
                Thread.Sleep(1000);
                Logo.SetBounds(-70,0,360,360);
                
                Thread.Sleep(1000);
                Title1.SetBounds(295,170,200,40);
                
                Thread.Sleep(500);
                Title2.SetBounds(280, 200, 380, 120);
                
                
            });
            thread.Start();
            
            Timer timer = new Timer {
                Interval = 50
            };
            
            Controls.Add(background);
            
        }
        private void CustomForm_Load(object sender, EventArgs e) {
            int radius = 80;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(this.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(this.Width - radius, this.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            
            this.Region = new Region(path);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED: Enables double buffering
                cp.Style |= 0x02000000;  // WS_CLIPCHILDREN: Avoid redrawing child controls
                return cp;
            }
        }
    }
    class LoagerPanel : roundPanel {
    
        private roundPanel loader = new roundPanel(20, Color.FromArgb(133, 2, 254), Color.FromArgb(255, 33, 100));
        
        public LoagerPanel(int r, Color s, Color e) : base(r,s,e ) {
            this.DoubleBuffered = true;
            loader.SetBounds(0,20,50,50);
            
            
        }
    }
}