using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net.Mime;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using AForge.Imaging.Filters;

namespace Enviroment {
    public class LoginPanelFrameWork : roundPanel {
        
        public LoginPanelFrameWork(int r, Color s, Color e, Form form) : base(r,s,e) {
            this.DoubleBuffered = true;
            this.BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Images & Videos\\LoginBackground.jpg");
            this.BackgroundImageLayout = ImageLayout.None;

            roundPanel Logo = new roundPanel(350,Color.Transparent,Color.Transparent);
            Logo.SetBounds(100,200,350,350);
            Logo.BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Images & Videos\\CONNECT.png");
            this.Controls.Add(Logo);

            LoginTab tab = new LoginTab(50, Color.FromArgb(56, 255, 255, 255), Color.FromArgb(89, 255, 228, 196));
            tab.SetBounds(600, 100, 600, 500);
            tab.BackColor = Color.Transparent;
            this.Controls.Add(tab);
            
            
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
