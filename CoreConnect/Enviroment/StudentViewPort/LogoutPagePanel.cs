using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Enviroment.StudentViewPort {
    
    public class LogoutPagePanel : roundPanel {
        private StudentMainPanel studentPanel;
        int count = 5;
        Timer timer;
        Label CounterTitle = new Label();
        public LogoutPagePanel(int r, Color s, Color e, StudentMainPanel mainpanel) : base(r, s, e) {
            this.DoubleBuffered = true;
            studentPanel = mainpanel;

            Label LogoutTitle = new Label();
            LogoutTitle.Text = "Logout";
            LogoutTitle.Font = new Font("Arial Rounded MT Bold", 50, FontStyle.Regular);
            LogoutTitle.SetBounds(455,25,300,100);
            LogoutTitle.ForeColor = Color.White;
            Controls.Add(LogoutTitle);
            
            PictureBox GoodbyeTitle = new PictureBox();
            GoodbyeTitle.Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Images\\GoodBye.gif");
            GoodbyeTitle.SetBounds(215,100,800,402);
            Controls.Add(GoodbyeTitle);

            CounterTitle.Text = "5";
            CounterTitle.SetBounds(600, 525, 35,35);
            CounterTitle.Font = new Font("Arial Rounded MT Bold", 25, FontStyle.Regular);
            CounterTitle.ForeColor = Color.FromArgb(93, 255, 255, 255);
            Controls.Add(CounterTitle);

            timer = new Timer {
                Interval = 1500
            };
            timer.Tick += CountDown;
            
            Cancel c = new Cancel(50, Color.FromArgb(40, 255, 255, 255), Color.FromArgb(40, 255, 255, 255));
            c.SetBounds(515,570, 200, 50);
            c.title.Click += (sender, args) => {
                CancelingLogout();
            };
            c.Click += (sender, args) => {
                CancelingLogout();
            };
            Controls.Add(c);
        }

        public void CancelingLogout() {
            timer.Stop();
            count = 5;
            CounterTitle.Text = "5";
            studentPanel.PageRemoval();
            studentPanel.Controls.Add(studentPanel.Home);
        }

        public void CountDown(Object obj, EventArgs e) {
            count--;
            if (count == 0){
                timer.Stop();
                Application.Exit();
            }else {
                CounterTitle.Text = count.ToString();
                CounterTitle.Invalidate();
            }
        }

        public void starting(){
            timer.Start();    
        }
    }

    public class Cancel : roundPanel {
        internal Label title = new Label();
        
        public Cancel(int r, Color s, Color e) : base(r, s, e) {
            this.DoubleBuffered = true;
            
            title.Text = "Cancel";
            title.SetBounds(50,8,120,50);
            title.ForeColor = Color.FromArgb(170, 240, 255, 255);
            title.Font = new Font("Arial Rounded MT Bold", 20, FontStyle.Regular);
            title.MouseEnter += (sender, args) => {
                start = Color.FromArgb(100, 255, 255, 255);
                start = Color.FromArgb(100, 255, 255, 255);
                Invalidate();
            };
            
            title.MouseLeave += (sender, args) => {
                start = Color.FromArgb(40, 255, 255, 255);
                end = Color.FromArgb(40, 255, 255, 255);
                Invalidate();
            };
            Controls.Add(title);
            
            this.MouseEnter += (sender, args) => {
                start = Color.FromArgb(100, 255, 255, 255);
                start = Color.FromArgb(100, 255, 255, 255);
                Invalidate();
            };
            
            this.MouseLeave += (sender, args) => {
                start = Color.FromArgb(40, 255, 255, 255);
                end = Color.FromArgb(40, 255, 255, 255);
                Invalidate();
            };
        }
    }
}