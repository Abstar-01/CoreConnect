using System.Drawing;
using System.Windows.Forms;

namespace Enviroment.StudentViewPort {
    
    public class StudentMainPanel : roundPanel {
        public StudentMainPanel(int r, Color s, Color e) : base(r,s,e) {
            BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Images\\Background.jpeg");
            this.DoubleBuffered = true;
            
            Tab tabBar = new Tab(50, Color.FromArgb(123, 226, 219, 208), Color.FromArgb(123, 226, 219, 208));
            tabBar.SetBounds(365,700,700,80);

            tabBar.MouseEnter += (sender, args) => {
                tabBar.start = Color.White;
                tabBar.end = Color.White;
                tabBar.Invalidate();
            };
            
            tabBar.MouseLeave += (sender, args) => {
                tabBar.start = Color.FromArgb(123, 226, 219, 208);
                tabBar.end = Color.FromArgb(123, 226, 219, 208);
                tabBar.Invalidate();
            };
            
            Controls.Add(tabBar);
            
        }    
    }

    public class Tab : roundPanel {
        public Tab(int r, Color s, Color e) : base(r, s, e) {
            PictureBox HomeLogo = new PictureBox();
            HomeLogo.BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Icons\\HomeS.png");
            HomeLogo.SetBounds(26, 5, 70, 70);
            Controls.Add(HomeLogo);
            
            PictureBox ProfileLogo = new PictureBox();
            ProfileLogo.BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Icons\\ProfilePicS.png");
            ProfileLogo.SetBounds(122, 5, 70, 70);
            Controls.Add(ProfileLogo);
            
            PictureBox InboxLogo = new PictureBox();
            InboxLogo.BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Icons\\InboxS.png");
            InboxLogo.SetBounds(218, 5, 70, 70);
            Controls.Add(InboxLogo);
            
            PictureBox ClassLogo = new PictureBox();
            ClassLogo.BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Icons\\ClassS.png");
            ClassLogo.SetBounds(314, 5, 70, 70);
            Controls.Add(ClassLogo);
            
            PictureBox ResourceLogo = new PictureBox();
            ResourceLogo.BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Icons\\HomeS.png");
            ResourceLogo.SetBounds(410, 5, 70, 70);
            Controls.Add(ResourceLogo);
            
            PictureBox RequestLogo = new PictureBox();
            RequestLogo.BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Icons\\RequestS.png");
            RequestLogo.SetBounds(506, 5, 70, 70);
            Controls.Add(RequestLogo);
            
            PictureBox LogoutLogo = new PictureBox();
            LogoutLogo.BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Icons\\HomeS.png");
            LogoutLogo.SetBounds(602, 5, 70, 70);
            Controls.Add(LogoutLogo);
        }
    }
}