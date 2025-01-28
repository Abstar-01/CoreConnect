using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net.Mime;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using AForge.Imaging.Filters;
using ContentAlignment = System.Drawing.ContentAlignment;
using System.Data.Sql;
using System.Data.SqlClient;
using Enviroment.StudentViewPort;

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

            Label Greeting = new Label();
            Greeting.Text = "Core Connect is an all-in-one portal designed for students, staff, and administrators of the university.";
            Greeting.SetBounds(70,150,350,70);
            Greeting.ForeColor = Color.White;
            Greeting.BackColor = Color.Transparent;
            Greeting.Font = new Font("arial", 12, FontStyle.Regular);
            this.Controls.Add(Greeting);


            PictureBox point1 = new PictureBox();
            string Point1path = "C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Icons\\1.png";
            string Point1text = "Enter in your Username and ID Code";
            PointFormat(point1, 70,220,400,25,Point1text,Point1path);
            
            roundPanel ConnectLine1 = new roundPanel(1,Color.White, Color.White);
            ConnectLine1.SetBounds(85,240,1,15);
            this.Controls.Add(ConnectLine1);
            
            PictureBox point2 = new PictureBox();
            string Point2path = "C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Icons\\2.png";
            string Point2text = "Enter in your Password";
            PointFormat(point2, 70,255,400,25,Point2text,Point2path);
            
            roundPanel ConnectLine2 = new roundPanel(1,Color.White, Color.White);
            ConnectLine2.SetBounds(85,275,1,15);
            this.Controls.Add(ConnectLine2);
            
            PictureBox point3 = new PictureBox();
            string Point3path = "C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Icons\\3.png";
            string Point3text = "Click Sign In and access your personalized dashboard";
            PointFormat(point3, 70,290,400,25,Point3text,Point3path);
            
            
            ///////////////////////////
            // Sliding Panel Remark //
            /////////////////////////
            roundPanel SlidingBackground = new roundPanel(1,Color.Transparent, Color.Transparent);
            SlidingBackground.BackColor = Color.Transparent;
            SlidingBackground.SetBounds(560,0,620,1460);
            Controls.Add(SlidingBackground);
            
            roundPanel LoginTitleBackground = new roundPanel(50, Color.FromArgb(56, 255, 255, 255), Color.FromArgb(89, 255, 228, 196));
            LoginTitleBackground.SetBounds(10, -50, 600, 250);
            LoginTitleBackground.BackColor = Color.Transparent;
            SlidingBackground.Controls.Add(LoginTitleBackground);
            
            Label LoginTitle = new Label();
            LoginTitle.Text = "LOGIN";
            LoginTitle.SetBounds(100,100,400,150);
            LoginTitle.ForeColor = Color.Transparent;
            LoginTitle.Font = new Font("Supreme Extrabold", 80, FontStyle.Bold );
            LoginTitleBackground.Controls.Add(LoginTitle);
            
            LoginTab tab = new LoginTab(50, Color.FromArgb(56, 255, 255, 255), Color.FromArgb(89, 255, 228, 196));
            tab.SetBounds(10, 220, 600, 380);
            tab.BackColor = Color.Transparent;
            SlidingBackground.Controls.Add(tab);

            roundPanel SignUpBackground = new roundPanel(50,Color.FromArgb(56, 255, 255, 255),Color.FromArgb(56, 255, 255, 255));
            SignUpBackground.SetBounds(10, 620, 600, 80);
            SignUpBackground.BackColor = Color.Transparent;

            roundPanel Bar1 = new roundPanel(20,Color.FromArgb(56, 255, 255, 255),Color.FromArgb(56, 255, 255, 255));
            Bar1.SetBounds(30,30,150,20);
            SignUpBackground.Controls.Add(Bar1);
            
            // Sign Up Label
            Label SignUpLabel = new Label();
            SignUpLabel.Text = "Create an account";
            SignUpLabel.Font = new Font("Arial Rounded MT Bold", 17, FontStyle.Regular);
            SignUpLabel.SetBounds(183, 24, 225, 25);
            SignUpLabel.ForeColor = Color.White;
            SignUpBackground.Controls.Add(SignUpLabel);
            SignUpLabel.Click += (sender, args) => {
                if (SlidingBackground.Location.Y != -605) {
                    Timer slideTimer = new Timer();
                    slideTimer.Interval = 1; 
                    int targetY = -605;
                    int currentY = SlidingBackground.Location.Y;

                    slideTimer.Tick += (o, eventArgs) => {
                        
                        int step = Math.Max(5, (currentY - targetY) / 10); // Decrease the step as it gets closer
                        currentY -= step;

                        if (currentY > targetY) {
                            SlidingBackground.SetBounds(560, currentY, 620, 1460);
                            SlidingBackground.Invalidate();
                        } else {
                            SlidingBackground.SetBounds(560, targetY, 620, 1460);
                            SlidingBackground.Invalidate();
                            slideTimer.Stop();
                            slideTimer.Dispose();
                        }
                    };

                    slideTimer.Start();
                }
            };
            SlidingBackground.Controls.Add(SignUpBackground);
            
            roundPanel Bar2 = new roundPanel(20,Color.FromArgb(56, 255, 255, 255),Color.FromArgb(56, 255, 255, 255));
            Bar2.SetBounds(410,30,150,20);
            SignUpBackground.Controls.Add(Bar2);
            
            // Sign Up Tab Declaration
            SignupTab signupTab = new SignupTab(50, Color.FromArgb(56, 255, 255, 255), Color.FromArgb(56, 255, 255, 255));
            signupTab.SetBounds(10,720,600,480);
            SlidingBackground.Controls.Add(signupTab);

            signupTab.BackToLogin.Click += (sender, args) => {
                if (SlidingBackground.Location.Y != 0) {
                    Timer slideTimer = new Timer();
                    slideTimer.Interval = 1; 
                    int targetY = 0;
                    int currentY = SlidingBackground.Location.Y;

                    slideTimer.Tick += (o, eventArgs) => {
                        
                        int step = Math.Max(5, -(currentY - targetY) / 10); // Decrease the step as it gets closer
                        currentY += step;

                        if (currentY < targetY) {
                            SlidingBackground.SetBounds(560, currentY, 620, 1460);
                            SlidingBackground.Invalidate();
                        } else {
                            SlidingBackground.SetBounds(560, targetY, 620, 1460);
                            SlidingBackground.Invalidate();
                            slideTimer.Stop();
                            slideTimer.Dispose();
                        }
                    };

                    slideTimer.Start();
                }
                
            };
            
            // Back Button
            roundPanel BackButtonBackground = new roundPanel(30,Color.FromArgb(56, 255, 255, 255), Color.FromArgb(56, 255, 255, 255));
            BackButtonBackground.SetBounds(10,1220,290,60);

            PictureBox BackArrow = new PictureBox {
                Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\Back.png"),
                BackgroundImageLayout = ImageLayout.None
            };
            BackArrow.SetBounds(10,18,25,25);
            BackButtonBackground.Click += (sender, args) => {
                signupTab.Authentication.Show();
                signupTab.SetDetails.Hide();
            };
            BackButtonBackground.Controls.Add(BackArrow);
            
            Label BackLabel = new Label();
            BackLabel.Text = "Back";
            BackLabel.Font = new Font("Century Gothic", 18, FontStyle.Regular);
            BackLabel.SetBounds(104,14,150,50);
            BackLabel.ForeColor = Color.White;
            BackLabel.Click += (sender, args) => {
                signupTab.Authentication.Show();
                signupTab.SetDetails.Hide();
            };
            BackButtonBackground.Controls.Add(BackLabel);
            
            SlidingBackground.Controls.Add(BackButtonBackground);
            
            // Forward Button
            roundPanel ProceedButtonBackground = new roundPanel(30,Color.FromArgb(56, 255, 255, 255), Color.FromArgb(56, 255, 255, 255));
            ProceedButtonBackground.SetBounds(315,1220,290,60);
            PictureBox ForwardArrow = new PictureBox {
                Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\Forward.png"),
                BackgroundImageLayout = ImageLayout.None
            };
            ForwardArrow.SetBounds(245,18,25,25);
            ProceedButtonBackground.Click += (sender, args) => {
                signupTab.SetDetails.Show();
                signupTab.Authentication.Hide();
                
            };
            ProceedButtonBackground.Controls.Add(ForwardArrow);
            
            Label ForwardLabel = new Label();
            ForwardLabel.Text = "Next";
            ForwardLabel.Font = new Font("Century Gothic", 18, FontStyle.Regular);
            ForwardLabel.SetBounds(75,14,150,50);
            ForwardLabel.ForeColor = Color.White;
            ForwardLabel.Click += (sender, args) => {
                signupTab.SetDetails.Show();
                signupTab.Authentication.Hide();
            };
            ProceedButtonBackground.Controls.Add(ForwardLabel);
            
            SlidingBackground.Controls.Add(ProceedButtonBackground);
            
            // Closing & Minimization Bar
            // Closing 
            roundPanel ClosingPanel = new roundPanel(40, Color.Transparent, Color.Transparent);
            ClosingPanel.SetBounds(1235,10,39,39);
            ClosingPanel.BackColor = Color.Transparent;
            Label CloseButton = new Label();
            CloseButton.BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\Cancel.png");
            CloseButton.SetBounds(-1,0,40,40);

            CloseButton.Click += (sender, args) => {
                Application.Exit();
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

        public void PointFormat(PictureBox point,int x, int y, int length,int height, string text, string path) {
            point.Image = Image.FromFile(path);
            point.BackgroundImageLayout = ImageLayout.None;
            point.SetBounds(x,y,30,30);
            point.BackColor = Color.Transparent;
            this.Controls.Add(point);

            Label FollowingText = new Label();
            FollowingText.Text = text;
            FollowingText.Font = new Font("arial", 12, FontStyle.Regular);
            FollowingText.ForeColor = Color.White;
            FollowingText.BackColor = Color.Transparent;
            FollowingText.SetBounds(x + 40,y + 5,length,height);
            this.Controls.Add(FollowingText);
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
