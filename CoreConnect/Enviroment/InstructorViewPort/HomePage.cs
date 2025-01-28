using System.Drawing;
using System.Windows.Forms;
using Image = AForge.Imaging.Image;

namespace Enviroment.InstructorViewPort {

    public class HomePage : roundPanel{
        
        string Unfilled = "C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Icons\\Circle.png";
        string Filled = "C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Icons\\Filled Circle.png";

        private PictureBox WelcomePanelButton, Updates_And_NotificationButton;
        internal WelcomePanel welcomePanel = new WelcomePanel(50,Color.Transparent, Color.Transparent);
        private Updates_And_NotificationPanel updatePanel = new Updates_And_NotificationPanel(50, Color.Aqua, Color.Aqua);
        
        public HomePage(int r, Color s, Color e) : base(r,s,e) {

            welcomePanel.SetBounds(5,5,1250,650);
            welcomePanel.Show();
            this.Controls.Add(welcomePanel);
            
            updatePanel.SetBounds(5,5,250,250);
            this.Controls.Add(updatePanel);
            
            WelcomePanelButton = new PictureBox();
            ButtonFormat(WelcomePanelButton,1280,175,Filled);
            WelcomePanelButton.Click += (sender, args) => {
                SwitchOfButtonHighlight();
                WelcomePanelButton.Image = Image.FromFile(Filled);
            };
            
            Updates_And_NotificationButton = new PictureBox();
            ButtonFormat(Updates_And_NotificationButton,1280,450,Unfilled);
            Updates_And_NotificationButton.Click += (sender, args) => {
                SwitchOfButtonHighlight();
                Updates_And_NotificationButton.Image = Image.FromFile(Filled);
            };
            
            // Line 1 
            roundPanel line1 = new roundPanel(1,Color.White, Color.White);
            line1.SetBounds(1292,175, 1, 300);
            this.Controls.Add(line1);
            
        }
        
        public void ButtonFormat(PictureBox pb, int x, int y, string path) {
            pb.SetBounds(x,y,25,25);
            pb.BackColor = Color.Transparent;
            pb.Image = Bitmap.FromFile(path);
            pb.BackgroundImageLayout = ImageLayout.None;
            this.Controls.Add(pb);
        }

        public void SwitchOfButtonHighlight() {
            WelcomePanelButton.Image = Image.FromFile(Unfilled);
            Updates_And_NotificationButton.Image = Image.FromFile(Unfilled);
        }
    }

    public class WelcomePanel : roundPanel {
        public WelcomePanel(int r, Color s, Color e) : base(r, s, e) {
            this.Hide();
            PictureBox Backimage = new PictureBox() {
                Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Images\\Welcome Back.png"),
                BackgroundImageLayout = ImageLayout.None
            };
            Backimage.SetBounds(10,15,1200,680);
            this.Controls.Add(Backimage);

            Label WelcomeBackLabel1 = new Label();
            TitileFormat(WelcomeBackLabel1,"WELCOME",300,100,900,225);
            Backimage.Controls.Add(WelcomeBackLabel1);
        }
        
        public void TitileFormat(Label label,string s, int x, int y, int length, int width) {
            label.Text = s;
            label.SetBounds(x,y,length,width);
            label.Font = new Font("Arial Black", 100,FontStyle.Bold);
            label.ForeColor = Color.White;
        }
    }

    public class Updates_And_NotificationPanel : roundPanel {
        public Updates_And_NotificationPanel(int r, Color s, Color e) : base(r, s, e) {
            this.Hide();
        }
    }
}