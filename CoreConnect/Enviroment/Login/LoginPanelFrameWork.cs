using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net.Mime;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using AForge.Imaging.Filters;
using ContentAlignment = System.Drawing.ContentAlignment;

namespace Enviroment {
    public class LoginPanelFrameWork : roundPanel {
        
        public LoginPanelFrameWork(int r, Color s, Color e, Form form) : base(r,s,e) {
            this.DoubleBuffered = true;
            this.BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Images & Videos\\LoginBackground.jpg");
            this.BackgroundImageLayout = ImageLayout.None;

            Label welcome = new Label();
            welcome.Text = "WELCOME";
            welcome.SetBounds(50,50,500,60);
            welcome.BackColor = Color.Transparent;
            welcome.ForeColor = Color.White;
            welcome.Font = new Font("arial", 45, FontStyle.Regular);
            Controls.Add(welcome);

            Label subWelcome = new Label();
            subWelcome.Text = "To CoreConnect";
            subWelcome.SetBounds(65,110,250,20);
            subWelcome.BackColor = Color.Transparent;
            subWelcome.ForeColor = Color.White;
            subWelcome.Font = new Font("arial", 16, FontStyle.Regular);
            Controls.Add(subWelcome);

            roundPanel line1 = new roundPanel(1, Color.White, Color.White);
            line1.SetBounds(70,140,350,5);
            Controls.Add(line1);
            
            roundPanel Logo = new roundPanel(350,Color.Transparent,Color.Transparent);
            Logo.SetBounds(-25,375,350,350);
            Logo.BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Images & Videos\\CONNECT.png");
            this.Controls.Add(Logo);

            roundPanel LogoHandler = new roundPanel(650, Color.White, Color.White);
            LogoHandler.SetBounds(-250,350,650,650);
            this.Controls.Add(LogoHandler);
            
            roundPanel LoginTitleBackground = new roundPanel(50, Color.FromArgb(56, 255, 255, 255), Color.FromArgb(89, 255, 228, 196));
            LoginTitleBackground.SetBounds(570, -50, 600, 250);
            LoginTitleBackground.BackColor = Color.Transparent;
            this.Controls.Add(LoginTitleBackground);
            
            Label LoginTitle = new Label();
            LoginTitle.Text = "LOGIN";
            LoginTitle.SetBounds(100,100,400,150);
            LoginTitle.ForeColor = Color.Transparent;
            LoginTitle.Font = new Font("Supreme Extrabold", 80, FontStyle.Bold );
            LoginTitleBackground.Controls.Add(LoginTitle);
            
            LoginTab tab = new LoginTab(50, Color.FromArgb(56, 255, 255, 255), Color.FromArgb(89, 255, 228, 196));
            tab.SetBounds(570, 220, 600, 380);
            tab.BackColor = Color.Transparent;
            this.Controls.Add(tab);

            roundPanel FreePanel = new roundPanel(50,Color.FromArgb(56, 255, 255, 255),Color.FromArgb(56, 255, 255, 255));
            FreePanel.SetBounds(570, 620, 600, 100);
            FreePanel.BackColor = Color.Transparent;
            this.Controls.Add(FreePanel);
            
            // Closing & Minimization Bar
            // Closing 
            roundPanel ClosingPanel = new roundPanel(40, Color.Transparent, Color.Transparent);
            ClosingPanel.SetBounds(1235,10,39,39);
            ClosingPanel.BackColor = Color.Transparent;
            Label CloseButton = new Label();
            CloseButton.BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\Cancel.png");
            CloseButton.SetBounds(-1,0,40,40);

            CloseButton.Click += (sender, args) => {
                form.Close();
            }; 
            
            CloseButton.MouseEnter += (sender, args) => {
                ClosingPanel.start = Color.Red;
                ClosingPanel.start = Color.Red;
                ClosingPanel.Invalidate();
            };

            CloseButton.MouseLeave += (sender, args) => {
                ClosingPanel.start = Color.Transparent;
                ClosingPanel.start = Color.Transparent;
                ClosingPanel.BackColor = Color.Transparent;
                ClosingPanel.Invalidate();
            }; 
            
            ClosingPanel.Controls.Add(CloseButton);
            this.Controls.Add(ClosingPanel);
            
            
            // Minimization 
            roundPanel MinPanel = new roundPanel(40, Color.Transparent, Color.Transparent);
            MinPanel.SetBounds(1190,10,39,39);
            MinPanel.BackColor = Color.Transparent;
            Label MinButton = new Label();
            MinButton.BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\Minus.png");
            MinButton.SetBounds(0,0,40,40);

            MinButton.Click += (sender, args) => {
                form.WindowState = FormWindowState.Minimized;
            }; 
            
            MinButton.MouseEnter += (sender, args) => {
                MinPanel.start = Color.FromArgb(36, 0, 70);
                MinPanel.start = Color.FromArgb(123, 44, 191);
                MinPanel.Invalidate();
            };

            MinButton.MouseLeave += (sender, args) => {
                MinPanel.start = Color.Transparent;
                MinPanel.start = Color.Transparent;
                MinPanel.BackColor = Color.Transparent;
                MinPanel.Invalidate();
            }; 
            
            MinPanel.Controls.Add(MinButton);
            this.Controls.Add(MinPanel);
        }
    }

    public class roundPanel : Panel {
        private int radius;
        public Color start, end;

        public roundPanel(int radius, Color start, Color end ) {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            
            this.radius = radius;
            this.start = start;
            this.end = end;
        }
        
        protected override void OnPaint(PaintEventArgs e){
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(this.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(this.Width - radius, this.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            
            this.Region = new Region(path);

            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.start, this.end, LinearGradientMode.Horizontal)) {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
    
    public class BlurredPanel : Panel
    {
        private Bitmap back;

        public BlurredPanel(Bitmap back) {
            this.back = back;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (back != null)
            {
                // Apply the blur effect
                Bitmap blurredBackground = BlurEffect.ApplyGaussianBlur(back);

                // Draw the blurred background
                e.Graphics.DrawImage(blurredBackground, 0, 0, this.Width, this.Height);
            }
        }
    }

    public class BlurEffect
    {
        public static Bitmap ApplyGaussianBlur(Bitmap originalImage)
        {
            // Create the Gaussian blur filter with a specified radius
            var blur = new GaussianBlur(60); // 5 is the radius, adjust for more/less blur

            // Apply the filter and return the blurred image
            return blur.Apply(originalImage);
        }
    }
}
