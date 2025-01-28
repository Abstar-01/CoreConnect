using System.Drawing;
using System.Windows.Forms;

namespace Enviroment.InstructorViewPort
{
    public class InfoPage : roundPanel
    {
        private PictureBox InfoPanelButton,FeedbackPanelButton,DetailPanelButton;
        
        // Application Information
        AppInfoPanel appinfo = new AppInfoPanel(50, Color.Transparent, Color.Transparent);
        
        // Feed Back panel that accepts Users Complaints and Comments
        FeedbackInfoPanel feedbackinfo = new FeedbackInfoPanel(50, Color.Transparent, Color.Transparent);
        
        // Detail panel is a panel that houses the contect information for further technical assistance
        DetailsInfoPanel detailinfo = new DetailsInfoPanel(50, Color.Transparent, Color.Transparent);
        
        string Unfilled =
            "C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Icons\\Circle.png";

        private string Filled =
            "C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Icons\\Filled Circle.png"; 
        public InfoPage(int r, Color s, Color e) : base(r,s,e) {
            this.Hide();
            
            // Application Panel
            appinfo.SetBounds(5,5,1250,650);
            this.Controls.Add(appinfo);
            
            InfoPanelButton = new PictureBox();
            ButtonFormat(InfoPanelButton,1280,150,Filled);
            InfoPanelButton.Click += (sender, args) => {
                SwitchOfButtonHighlight();
                InfoPanelButton.Image = Image.FromFile(Filled);
                appinfo.Show();
            };
            
            // Feedback Panel
            feedbackinfo.SetBounds(5,5,1250,650);
            feedbackinfo.Hide();
            this.Controls.Add(feedbackinfo);
            
            FeedbackPanelButton = new PictureBox();
            ButtonFormat(FeedbackPanelButton,1280,300,Unfilled);
            FeedbackPanelButton.Click += (sender, args) => {
                SwitchOfButtonHighlight();
                FeedbackPanelButton.Image = Image.FromFile(Filled);
                feedbackinfo.Show();
            };
            
            DetailPanelButton = new PictureBox();
            ButtonFormat(DetailPanelButton,1280,450,Unfilled);
            DetailPanelButton.Click += (sender, args) => {
                SwitchOfButtonHighlight();
                DetailPanelButton.Image = Image.FromFile(Filled);
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
            appinfo.Hide();
            InfoPanelButton.Image = Image.FromFile(Unfilled);
            
            feedbackinfo.Hide();
            FeedbackPanelButton.Image = Image.FromFile(Unfilled);
            
            detailinfo.Hide();
            DetailPanelButton.Image = Image.FromFile(Unfilled);
        }
    }

    public class AppInfoPanel : roundPanel {
        private roundPanel UserRoles, SystemInformation, Troubleshooting, SystemRest;
        
        // Images References
        string WhiteProfile = "C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Icons\\User.png";
        string BlackProfile = "C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Icons\\DarkUser.png";
        
        
        public AppInfoPanel(int r, Color s, Color e) : base(r, s, e) {
            Label InformationLabel1 = new Label();
            InformationLabel1.Text = "USER";
            InformationLabel1.Font = new Font("Folklore", 140, FontStyle.Regular);
            InformationLabel1.ForeColor = Color.White;
            InformationLabel1.BackColor = Color.Transparent;
            InformationLabel1.SetBounds(50,150,600,160);
            this.Controls.Add(InformationLabel1);
            
            Label InformationLabel2 = new Label();
            InformationLabel2.Text = "SUPPORT";
            InformationLabel2.Font = new Font("Folklore", 100, FontStyle.Regular);
            InformationLabel2.ForeColor = Color.White;
            InformationLabel2.BackColor = Color.Transparent;
            InformationLabel2.SetBounds(50,310,720,160);
            this.Controls.Add(InformationLabel2);
            
            PictureBox QuestionMark = new PictureBox() {
                Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Images\\Question.png"),
                BackgroundImageLayout = ImageLayout.None
            };
            QuestionMark.SetBounds(350,105,500,500);
            this.Controls.Add(QuestionMark);
            
            // User Support Types
            UserRoles = new roundPanel(50,Color.Transparent, Color.Transparent);
            TabFormat(UserRoles, 650,70,250, 250);
            
            // User Support Types
            SystemInformation = new roundPanel(50,Color.Transparent, Color.Transparent);
            TabFormat(SystemInformation, 920,70,250, 250);
            
            // User Support Types
            Troubleshooting= new roundPanel(50,Color.Transparent, Color.Transparent);
            TabFormat(Troubleshooting, 650,340,250, 250);
            
            // User Support Types
            SystemRest = new roundPanel(50,Color.Transparent, Color.Transparent);
            TabFormat(SystemRest, 920,340,250, 250);
            
        }

        public void TabFormat(roundPanel panel, int x, int y, int width, int height) {
            panel = new roundPanel(50,Color.Transparent, Color.Transparent);
            panel.SetBounds(x + 5,y + 5,width - 10, height - 10);
            this.Controls.Add(panel);
            
            roundPanel panelBackground = new roundPanel(50,Color.White, Color.White);
            panelBackground.SetBounds(x,y,width, height);
            this.Controls.Add(panelBackground);
        }
    }

    public class FeedbackInfoPanel : roundPanel {
        public FeedbackInfoPanel(int r, Color s, Color e) : base(r, s, e) {
            PictureBox FeedbackRockt = new PictureBox() {
                Image = AForge.Imaging.Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Images\\FeedBack Background.png"),
                BackColor = Color.Transparent,
                BackgroundImageLayout = ImageLayout.None,
            };
            FeedbackRockt.SetBounds(0,0,300,300);
            this.Controls.Add(FeedbackRockt);
        }
    }

    public class DetailsInfoPanel : roundPanel {
        public DetailsInfoPanel(int r, Color s, Color e) : base(r, s, e) {
            
        }
    }
}