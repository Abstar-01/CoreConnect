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
                tabBar.CheckSwitch();
                tabBar.HomeCase = false;
                Controls.Add(Home);
            }; 
            tabBar.ProfileLogo.Click += (sender, args) => {
                PageRemoval();
                tabBar.CheckSwitch();
                tabBar.ProfileCase = false;
                Controls.Add(Profile);
            }; 
            tabBar.InboxLogo.Click  += (sender, args) => {
                PageRemoval();
                tabBar.CheckSwitch();
                tabBar.InboxCase = false;
                Controls.Add(inbox);
            }; 
            tabBar.ClassLogo.Click += (sender, args) => {
                PageRemoval();
                tabBar.CheckSwitch();
                tabBar.ClassCase = false;
                Controls.Add(Class);
            }; 
            tabBar.ResourceLogo.Click  += (sender, args) => {
                PageRemoval();
                tabBar.CheckSwitch();
                tabBar.ResourceCase = false;
                Controls.Add(Resource);
            }; 
            tabBar.RequestLogo.Click += (sender, args) => {
                PageRemoval();
                tabBar.CheckSwitch();
                tabBar.RequestCase = false;
                Controls.Add(Request);
            }; 
            tabBar.LogoutLogo.Click  += (sender, args) => {
                PageRemoval();
                tabBar.CheckSwitch();
                tabBar.LogoutCase = false;
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

        public Label HomeTitle, ProfileTitle, InboxTitle, ClassTitle, ResourceTitle, RequestTitle, LogoutTitle;
        public bool HomeCase = false, ProfileCase = true, InboxCase = true, ClassCase = true, ResourceCase = true, RequestCase = true, LogoutCase = true;
        
        public Tab(int r, Color s, Color e) : base(r, s, e) {
            this.DoubleBuffered = true;
            // Home Button 
            HomeLogo = new PictureBox();
            HomeTitle = new Label();
            TitleSettlement(HomeTitle, 42,50,50,20, "Home");
            TabButtonsImplementation(HomeLogo, 32,-8,70,70,"C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Icons\\HomeS.png");
            SettingMovement(HomeLogo, HomeTimerUP, HomeTimerDOWN,-8,3, HomeCase, HomeTitle);
            
            // Profile Button 
            ProfileLogo = new PictureBox();
            ProfileTitle = new Label();
            TitleSettlement(ProfileTitle, 142,50,60,20, "Profile");
            TabButtonsImplementation(ProfileLogo, 134, 15, 50, 50,"C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Icons\\ProfileS.png");
            SettingMovement(ProfileLogo, ProfileTimerUP, ProfileTimerDOWN,6,15, ProfileCase, ProfileTitle);
            
            // Inbox Button 
            InboxLogo = new PictureBox();
            InboxTitle = new Label();
            TitleSettlement(InboxTitle, 220,50,50,20, "Inbox");
            TabButtonsImplementation(InboxLogo,206, 2, 70, 70,"C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Icons\\InboxS.png");
            SettingMovement(InboxLogo, InboxTimerUP, InboxTimerDOWN,-8,2, InboxCase, InboxTitle);
            
            // Class Button 
            ClassLogo = new PictureBox();
            ClassTitle = new Label();
            TitleSettlement(ClassTitle, 300,50,50,20, "Class");
            TabButtonsImplementation(ClassLogo,308,5,60,60,"C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Icons\\ClassS.png");
            SettingMovement(ClassLogo, ClassTimerUP,ClassTimerDOWN,-3,5, ClassCase,ClassTitle);
            
            // Resource Button 
            ResourceLogo = new PictureBox();
            ResourceTitle = new Label();
            TitleSettlement(ResourceTitle, 400,50,50,20, "Resource");
            TabButtonsImplementation(ResourceLogo,400,2,70,70,"C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Icons\\ResourceS.png");
            SettingMovement(ResourceLogo, ResourceTimerUP, ResourceTimerDOWN,-8,2, ResourceCase, ResourceTitle);
            
            // Request Button 
            RequestLogo = new PictureBox();
            RequestTitle = new Label();
            TitleSettlement(RequestTitle, 502,50,50,20, "Request");
            TabButtonsImplementation(RequestLogo, 502,5,60,60,"C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Icons\\RequestS.png");
            SettingMovement(RequestLogo, RequestTimerUP, RequestTimerDOWN,-4,5, RequestCase, RequestTitle);
            
            // Logout Button 
            LogoutLogo = new PictureBox();
            LogoutTitle = new Label();
            TitleSettlement(LogoutTitle, 600,50,50,20, "Logout");
            TabButtonsImplementation(LogoutLogo, 594,2,70,70,"C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Icons\\LogoutS.png");
            SettingMovement(LogoutLogo, LogoutTimerUP, LogoutTimerDOWN,-8,2, LogoutCase, LogoutTitle);
        }

        public void TitleSettlement(Label l, int x, int y, int length, int width, string s) {
            l.Text = s;
            l.SetBounds(x,y,length,width);
            l.ForeColor = Color.White;
            l.Font = new Font("arial", 12, FontStyle.Regular);
            l.BackColor = Color.Transparent;
            Controls.Add(l);
        }
        
        public void TabButtonsImplementation(PictureBox p,int X, int Y, int width, int hieght, string s) {
            p.BackgroundImage = Image.FromFile(s);
            p.BackgroundImageLayout = ImageLayout.None;
            p.SetBounds(X, Y, width, hieght);
            Controls.Add(p);
        }

        public void SettingMovement(PictureBox pan, Timer UP, Timer DOWN, int Max, int Min, bool check, Label l) {
            pan.MouseEnter += (sender, args) => {
                if(DOWN != null){DOWN.Stop();}
                    UP = new Timer
                    {
                        Interval = 10
                    };
                    UP.Tick += (o, eventArgs) =>
                    {
                        int y = pan.Location.Y - 1, x = pan.Location.X;
                        if (y > Max) {
                            pan.SetBounds(x, y, pan.Width, pan.Height);
                            pan.Invalidate();
                        }else {
                            Controls.Add(l);
                            Controls.SetChildIndex(l, 0);
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
                Console.WriteLine(check);
                if (check) {
                    DOWN.Tick += (o, eventArgs) => {
                        int y = pan.Location.Y + 1, x = pan.Location.X;
                        if (y < Min) {
                            pan.SetBounds(x, y, pan.Width, pan.Height);
                            pan.Invalidate();
                        }else {
                            Controls.Remove(l);
                            DOWN.Stop();
                        }
                    };
                    DOWN.Start();
                }
            };
        }

        public void CheckSwitch(){
            HomeCase = true;
            ProfileCase = true;
            InboxCase = true;
            ClassCase = true;
            ResourceCase = true;
            RequestCase = true;
            LogoutCase = true;
        }
    }
}