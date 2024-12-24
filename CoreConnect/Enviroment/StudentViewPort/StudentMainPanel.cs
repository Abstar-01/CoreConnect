using System;
using System.Drawing;
using System.Windows.Forms;

namespace Enviroment.StudentViewPort {
    
    public class StudentMainPanel : roundPanel {
        
        // Tab Bar
        Tab tabBar;

        internal Form form;
        // Home Page
        internal HomePagePanel Home;
        // Profile page
        ProfilePagePanel Profile;
        // Indox Page
        InboxPagePanel inbox;
        // Class Page
        ClassPagePanel Class; 
        // Resource Page
        ResourcePagePanel Resource;
        // Request Page
        RequestPagePanel Request;
        // Logout Page
        LogoutPagePanel Logout;
        
        public StudentMainPanel(int r, Color s, Color e, Form form) : base(r,s,e) {
            BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Images\\Background.jpeg");
            this.DoubleBuffered = true;
            
            this.form = form;
            
            Home = new HomePagePanel(50, Color.FromArgb(123, 226, 219, 208), Color.FromArgb(123, 226, 219, 208));
            Home.SetBounds(100,70,1230,650);
            Controls.Add(Home);
            
            Profile = new ProfilePagePanel(50, Color.FromArgb(123, 226, 219, 208), Color.FromArgb(123, 226, 219, 208));
            Profile.SetBounds(100,70,1230,650);
            
            inbox = new InboxPagePanel(50, Color.FromArgb(123, 226, 219, 208), Color.FromArgb(123, 226, 219, 208));
            inbox.SetBounds(100,70,1230,650);
            
            Class = new ClassPagePanel(50, Color.FromArgb(123, 226, 219, 208), Color.FromArgb(123, 226, 219, 208));
            Class.SetBounds(100,70,1230,650);
            
            Resource = new ResourcePagePanel(50, Color.FromArgb(123, 226, 219, 208), Color.FromArgb(123, 226, 219, 208));
            Resource.SetBounds(100,70,1230,650);
            
            Request = new RequestPagePanel(50, Color.FromArgb(123, 226, 219, 208), Color.FromArgb(123, 226, 219, 208));
            Request.SetBounds(100,70,1230,650);
            
            Logout = new LogoutPagePanel(50, Color.FromArgb(123, 226, 219, 208), Color.FromArgb(123, 226, 219, 208), this);
            Logout.SetBounds(100,70,1230,650);
            
            tabBar = new Tab(50, Color.FromArgb(123, 226, 219, 208), Color.FromArgb(123, 226, 219, 208));
            tabBar.SetBounds(365,740,700,90);
            
            tabBar.HomeLogo.Click  += (sender, args) => {
                PageRemoval();
                Controls.Add(Home);
            }; 
            tabBar.ProfileLogo.Click += (sender, args) => {
                PageRemoval();
                Controls.Add(Profile);
            }; 
            tabBar.InboxLogo.Click  += (sender, args) => {
                PageRemoval();
                Controls.Add(inbox);
            }; 
            tabBar.ClassLogo.Click += (sender, args) => {
                PageRemoval();
                Controls.Add(Class);
            }; 
            tabBar.ResourceLogo.Click  += (sender, args) => {
                PageRemoval();
                Controls.Add(Resource);
            }; 
            tabBar.RequestLogo.Click += (sender, args) => {
                PageRemoval();
                Controls.Add(Request);
            }; 
            tabBar.LogoutLogo.Click  += (sender, args) => {
                PageRemoval();
                Controls.Add(Logout);
                Logout.starting();
            }; 
            
            Controls.Add(tabBar);
            
            // Closing Button
            roundPanel closingBackground = new roundPanel(40,Color.Transparent, Color.Transparent);
            closingBackground.BackColor = Color.Transparent;
            closingBackground.SetBounds(1360,10,39,39);
            PictureBox ClosingButton = new PictureBox {
                Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Icons\\Cancel.png")
            };
            ClosingButton.Click += (sender, args) => {
                Application.Exit();
            };
            ClosingButton.MouseEnter += (sender, args) => {
                closingBackground.start = Color.Red;
                closingBackground.end = Color.Red;
                closingBackground.Invalidate();
            };
            ClosingButton.MouseLeave += (sender, args) => {
                closingBackground.start = Color.Transparent;
                closingBackground.end = Color.Transparent;
                closingBackground.BackColor = Color.Transparent;
                closingBackground.Invalidate();
            };
            closingBackground.Controls.Add(ClosingButton);
            Controls.Add(closingBackground);
            
            // Minimization Button
            roundPanel MinimizeBackground = new roundPanel(40,Color.Transparent, Color.Transparent);
            MinimizeBackground.BackColor = Color.Transparent;
            MinimizeBackground.SetBounds(1315,10,39,39);
            PictureBox MinimizeButton = new PictureBox {
                Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Icons\\Minus.png")
            };
            MinimizeButton.Click += (sender, args) => {
                form.WindowState = FormWindowState.Minimized;
            };
            MinimizeButton.MouseEnter += (sender, args) => {
                MinimizeBackground.start = Color.FromArgb(185, 203, 165);
                MinimizeBackground.end = Color.FromArgb(202, 219, 183);
                MinimizeBackground.Invalidate();
            };
            MinimizeButton.MouseLeave += (sender, args) => {
                MinimizeBackground.start = Color.Transparent;
                MinimizeBackground.end = Color.Transparent;
                MinimizeBackground.BackColor = Color.Transparent;
                MinimizeBackground.Invalidate();
            };
            MinimizeBackground.Controls.Add(MinimizeButton);
            Controls.Add(MinimizeBackground);
        }

        public void PageRemoval() {
            Controls.Remove(Home);
            Controls.Remove(Profile);
            Controls.Remove(inbox);
            Controls.Remove(Class);
            Controls.Remove(Resource);
            Controls.Remove(Request);
            Controls.Remove(Logout);
        }
    }

    public class Tab : roundPanel {
        
        public PictureBox HomeLogo, ProfileLogo, InboxLogo, ClassLogo, ResourceLogo, RequestLogo, LogoutLogo;
        public Timer HomeTimerUP, ProfileTimerUP, InboxTimerUP, ClassTimerUP, ResourceTimerUP, RequestTimerUP, LogoutTimerUP;
        public Timer HomeTimerDOWN, ProfileTimerDOWN, InboxTimerDOWN, ClassTimerDOWN, ResourceTimerDOWN, RequestTimerDOWN, LogoutTimerDOWN;
        
        public Tab(int r, Color s, Color e) : base(r, s, e) {
            this.DoubleBuffered = true;
            // Home Button 
            HomeLogo = new PictureBox();
            TabButtonsImplementation(HomeLogo, 32,2,70,70,"C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Icons\\HomeS.png");
            SettingMovement(HomeLogo, HomeTimerUP, HomeTimerDOWN,-8,3);
            
            // Profile Button 
            ProfileLogo = new PictureBox();
            TabButtonsImplementation(ProfileLogo, 134, 15, 40, 40,"C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Icons\\ProfileS.png");
            SettingMovement(ProfileLogo, ProfileTimerUP, ProfileTimerDOWN,6,15);
            
            // Inbox Button 
            InboxLogo = new PictureBox();
            TabButtonsImplementation(InboxLogo,206, 2, 70, 70,"C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Icons\\InboxS.png");
            SettingMovement(InboxLogo, InboxTimerUP, InboxTimerDOWN,-8,2);
            
            // Class Button 
            ClassLogo = new PictureBox();
            TabButtonsImplementation(ClassLogo,308,5,60,60,"C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Icons\\ClassS.png");
            SettingMovement(ClassLogo, ClassTimerUP,ClassTimerDOWN,-3,5);
            
            // Resource Button 
            ResourceLogo = new PictureBox();
            TabButtonsImplementation(ResourceLogo,400,2,70,70,"C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Icons\\ResourceS.png");
            SettingMovement(ResourceLogo, ResourceTimerUP, ResourceTimerDOWN,-8,2);
            
            // Request Button 
            RequestLogo = new PictureBox();
            TabButtonsImplementation(RequestLogo, 502,5,60,60,"C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Icons\\RequestS.png");
            SettingMovement(RequestLogo, RequestTimerUP, RequestTimerDOWN,-4,5);
            
            // Logout Button 
            LogoutLogo = new PictureBox();
            TabButtonsImplementation(LogoutLogo, 594,2,70,70,"C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Icons\\LogoutS.png");
            SettingMovement(LogoutLogo, LogoutTimerUP, LogoutTimerDOWN,-8,2);
        }

        public void TabButtonsImplementation(PictureBox p,int X, int Y, int width, int hieght, string s) {
            p.BackgroundImage = Image.FromFile(s);
            p.SetBounds(X, Y, width, hieght);
            Controls.Add(p);
        }

        public void SettingMovement(PictureBox pan, Timer UP, Timer DOWN, int Max, int Min) {
            pan.MouseEnter += (sender, args) => {
                if(DOWN != null){DOWN.Stop();}
                UP = new Timer {
                    Interval = 10
                };
                UP.Tick += (o, eventArgs) => {
                    int y = pan.Location.Y - 1, x = pan.Location.X;
                    if (y > Max) {
                        pan.SetBounds(x,y,pan.Width,pan.Height);
                        pan.Invalidate();
                    }else {
                        UP.Stop();
                    }
                };
                UP.Start();
            };

            pan.MouseLeave += (sender, args) => {
                if(UP != null){UP.Stop();}
                DOWN = new Timer {
                    Interval = 10
                };
                DOWN.Tick += (o, eventArgs) => {
                    int y = pan.Location.Y + 1, x = pan.Location.X;
                    if (y < Min) {
                        pan.SetBounds(x,y,pan.Width,pan.Height);
                        pan.Invalidate();
                    }else {
                        DOWN.Stop();
                    }
                };
                DOWN.Start();
            };
        } 
    }
}