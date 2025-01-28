using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Enviroment.InstructorViewPort {
    public class InstructorPanel : roundPanel{
        private bool isDragging = false;
        private Color s, e;
        internal Form f;
        
        PictureBox ProfileButton, QuestionButton, SettingButton, LogoutButton;

        internal HomePage home;
        private ClassPage classPage;
        private ResourcePage resource;
        private RequestPage request;
        private ProfilePage profile;
        private InfoPage info;
        private LogoutPage logout;
        
        ToolBarPanel toolbar;
        
        public InstructorPanel(int r, Color s, Color e, Form form) : base(r,s,e) {
            this.s = s;
            this.e = e;
            this.f = form;
            
            ToolBarPanel toolbar = new ToolBarPanel(1,Color.Transparent, Color.Transparent, form);
            toolbar.SetBounds(0,0,1500,60);
            
            // Home Label Click Action
            toolbar.HomeLabel.Click += (sender, args) => {
                HideAll();
                home.Show();
            };
            
            // Class Label Click Action
            toolbar.ClassLabel.Click += (sender, args) => {
                HideAll();
                classPage.Show();
            };
            
            
            
            this.Controls.Add(toolbar);

            ProfileButton = new PictureBox();
            BottomIcons(ProfileButton, 15,580,30,30,"C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Icons\\Male User.png");
            ProfileButton.Click += (sender, args) => {
                HideAll();
                profile.Show();
            };
            
            QuestionButton = new PictureBox();
            BottomIcons(QuestionButton, 15,625,30,30,"C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Icons\\Help.png");
            QuestionButton.Click += (sender, args) => {
                HideAll();
                info.Show();
            };
            
            SettingButton = new PictureBox();
            BottomIcons(SettingButton, 15,670,30,30,"C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Icons\\Settings.png");
            
            LogoutButton = new PictureBox();
            BottomIcons(LogoutButton, 15,715,30,30,"C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Icons\\Logout Rounded.png");
            LogoutButton.Click += (sender, args) => {
                HideAll();
                logout.Show();
                logout.time.Start();
            };

            // Home Page
            home = new HomePage(50,Color.FromArgb(103, 125, 155, 170),Color.FromArgb(192, 63, 78, 91));
            home.SetBounds(70, 70, 1360, 660);
            home.Hide();
            this.Controls.Add(home);
            
            // Info Page
            classPage = new ClassPage(50,Color.FromArgb(103, 125, 155, 170),Color.FromArgb(192, 63, 78, 91));
            classPage.SetBounds(70, 70, 1360, 660);
            this.Controls.Add(classPage);
            
            // Info Page
            info = new InfoPage(50,Color.FromArgb(103, 125, 155, 170),Color.FromArgb(192, 63, 78, 91));
            info.SetBounds(70, 70, 1360, 660);
            this.Controls.Add(info);

            profile = new ProfilePage(50, Color.FromArgb(103, 125, 155, 170), Color.FromArgb(192, 63, 78, 91));
            profile.SetBounds(70, 70, 1360, 660);
            profile.Show();
            this.Controls.Add(profile);
            
            // Logout Page
            logout = new LogoutPage(50,Color.FromArgb(103, 125, 155, 170),Color.FromArgb(192, 63, 78, 91),this);
            logout.SetBounds(70,70,1360,660);
            this.Controls.Add(logout);
            
            notificationBar Nbar = new notificationBar(1,Color.FromArgb(72, 85, 99), Color.FromArgb(72, 85, 99), form);
            Nbar.SetBounds(0,755,1500,30);
            this.Controls.Add(Nbar);
        }

        public void LabelButtonClicked(Label label, roundPanel panel) {
            label.Click += (sender, args) => {
                HideAll();
                panel.Show();
            };
        } 
        
        public void PagePanelFormat(roundPanel p) {
            p = new roundPanel(50,Color.FromArgb(103, 125, 155, 170),Color.FromArgb(192, 63, 78, 91));
            p.SetBounds(70,70,1360,660);
            this.Controls.Add(logout);
        }

        public void HideAll() {
            home.Hide();
            classPage.Hide();
            info.Hide();
            profile.Hide();
        }
        
        public void BottomIcons(PictureBox button, int x, int y, int length, int width, string path) {
            button.Image = Image.FromFile(path);
            BackgroundImageLayout = ImageLayout.None;
            button.SetBounds(x,y,length,width);
            this.Controls.Add(button);
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle,s,this.e,LinearGradientMode.ForwardDiagonal)) {
                e.Graphics.FillRectangle(brush,ClientRectangle);
            }
        }
    }

    public class ToolBarPanel : roundPanel {
        
        internal Label HomeLabel, ClassLabel, ResourceLabel, Request;
        
        public ToolBarPanel(int r, Color s, Color e, Form form) : base(r, s, e) {

            PictureBox miniLogo = new PictureBox() {
                Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Icons\\image.png"),
                BackgroundImageLayout = ImageLayout.None
            };
            miniLogo.SetBounds(7,7,75,75);
            this.Controls.Add(miniLogo);
            
            HomeLabel = new Label();
            HeaderFormat(HomeLabel,"Home",700,20,100,50);
            
            ClassLabel = new Label();
            HeaderFormat(ClassLabel,"Class",850,20,100,50);
            
            ResourceLabel = new Label();
            HeaderFormat(ResourceLabel,"Resource",1000,20,130,50);
            
            Request = new Label();
            HeaderFormat(Request,"Request",1180,20,130,50);
            
            // Closing & Minimizing Buttons
            // Closing 
            roundPanel ClosingPanel = new roundPanel(40, Color.Transparent, Color.Transparent);
            ClosingPanel.SetBounds(1435,10,39,39);
            ClosingPanel.BackColor = Color.Transparent;
            Label CloseButton = new Label();
            CloseButton.BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\Cancel.png");
            CloseButton.SetBounds(-1,0,40,40);

            CloseButton.Click += (sender, args) => {
                Application.Exit();
            }; 
            
            CloseButton.MouseEnter += (sender, args) => {
                ClosingPanel.start = Color.Red;
                ClosingPanel.Invalidate();
            };

            CloseButton.MouseLeave += (sender, args) => {
                ClosingPanel.start = Color.Transparent;
                ClosingPanel.BackColor = Color.Transparent;
                ClosingPanel.Invalidate();
            }; 
            
            ClosingPanel.Controls.Add(CloseButton);
            this.Controls.Add(ClosingPanel);
            
            // Minimization 
            roundPanel MinPanel = new roundPanel(40, Color.Transparent, Color.Transparent);
            MinPanel.SetBounds(1390,10,39,39);
            MinPanel.BackColor = Color.Transparent;
            Label MinButton = new Label();
            MinButton.BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\Minus.png");
            MinButton.SetBounds(0,0,40,40);

            MinButton.Click += (sender, args) => {
                form.WindowState = FormWindowState.Minimized;
            }; 
            
            MinButton.MouseEnter += (sender, args) => {
                MinPanel.start = Color.FromArgb(127, 157, 184);
                MinPanel.Invalidate();
            };

            MinButton.MouseLeave += (sender, args) => {
                MinPanel.start = Color.Transparent;
                MinPanel.BackColor = Color.Transparent;
                MinPanel.Invalidate();
            }; 
            
            MinPanel.Controls.Add(MinButton);
            this.Controls.Add(MinPanel);
        }

        public void HeaderFormat(Label label, string text, int X, int Y, int length, int width) {
            label.Text = text;
            label.SetBounds(X,Y,length,width);
            label.ForeColor = Color.White;
            label.Font = new Font("arial", 18, FontStyle.Regular);
            this.Controls.Add(label);
        }
    }
    
    public class notificationBar : roundPanel{
        public notificationBar(int r, Color s, Color e, Form form) : base(r, s, e) {
            
        }
    }
}