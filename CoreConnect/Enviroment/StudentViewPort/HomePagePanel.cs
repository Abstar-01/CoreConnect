using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Enviroment.StudentViewPort
{
    public class HomePagePanel : roundPanel {
        public HomePagePanel(int r, Color s, Color e) : base(r, s, e) {
            this.DoubleBuffered = true;
            this.VerticalScroll.Enabled = true;

            roundPanel dot = new roundPanel(50,Color.White, Color.White);
            dot.SetBounds(75,40,50,50);
            Controls.Add(dot);
            
            roundPanel Line = new roundPanel(50,Color.White, Color.White);
            Line.SetBounds(440,40,710,50);
            Controls.Add(Line);
            
            Label label = new Label();
            label.Text = "Home";
            label.SetBounds(130,10,400,90);
            label.Font = new Font("arial", 70, FontStyle.Bold);
            label.ForeColor = Color.FromArgb(170, 255, 255, 255);
            Controls.Add(label);

            schoolLogo logo = new schoolLogo(50, Color.FromArgb(185, 203, 165),Color.FromArgb(202, 219, 183));
            logo.SetBounds(60,120,1100, 200);
            Controls.Add(logo);
        }
    }

    public class schoolLogo : roundPanel {
        roundPanel ProgressBar = new roundPanel(50,Color.White, Color.White);
        roundPanel Progress = new roundPanel(23, Color.FromArgb(79, 0, 116, 16),Color.FromArgb(76, 0, 116, 16));
        roundPanel OnGoingProgress = new roundPanel(23, Color.FromArgb(228, 115, 192, 136),Color.FromArgb(255, 57, 125, 84));
        public schoolLogo(int r, Color s, Color e) : base(r, s, e) {
            this.DoubleBuffered = true;
            
            
            // Progress 
            ProgressBar.SetBounds(20,20, 460, 160);
            Label ProgressBarLabel = new Label();
            ProgressBarLabel.Text = "School Progress";
            ProgressBarLabel.ForeColor = Color.FromArgb(255, 115, 192, 136);
            ProgressBarLabel.Font = new Font("Arial Rounded MT Bold", 12,FontStyle.Bold);
            ProgressBarLabel.SetBounds(48,42,250,20);
            ProgressBar.Controls.Add(ProgressBarLabel);
            
            Label PercentageProgress = new Label();
            PercentageProgress.Text = "100% completed";
            PercentageProgress.ForeColor = Color.FromArgb(255, 168, 224, 183);
            PercentageProgress.SetBounds(40,60,300,30);
            PercentageProgress.BackColor = Color.Transparent;
            PercentageProgress.Font = new Font("Arial Rounded MT Bold", 20,FontStyle.Bold);
            ProgressBar.Controls.Add(PercentageProgress);

            PictureBox Finished = new PictureBox {
                Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Icons\\Finish Flag.png"),
                Size = new Size(25,25)
            };
            Finished.SetBounds(390,65,25,25);
            ProgressBar.Controls.Add(Finished);
            
            Progress.SetBounds(40,100, 380, 23);
            OnGoingProgress.SetBounds(0,0,23,23);
            Progress.Controls.Add(OnGoingProgress);
            ProgressBar.Controls.Add (Progress);
            Controls.Add(ProgressBar);
            
        }

        public void progress(string start, string end, string current){
            
        }
    }
}