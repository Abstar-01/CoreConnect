using System;
using System.Drawing;
using System.Windows.Forms;
using Enviroment.StudentViewPort;

namespace Enviroment.InstructorViewPort {
    
    public class LogoutPage : roundPanel{
        
        Label logoutTitle = new Label();
        Label Counter = new Label();
        private int count = 5;
        internal Timer time;
        private InstructorPanel form;
        
        public LogoutPage(int r, Color s, Color e, InstructorPanel f) : base(r,s,e) {
            this.form = f;
            this.Hide();
            
            logoutTitle.Text = "Logging out ...";
            logoutTitle.Font = new Font("Barber Outline", 120, FontStyle.Bold);
            logoutTitle.ForeColor = Color.FromArgb(207, 216, 220);
            logoutTitle.SetBounds(50,50,1000,400);
            this.Controls.Add(logoutTitle);

            Label Farwell = new Label();
            Farwell.Text = "Logout Sqeuence:";
            Farwell.Font = new Font("Californian FB", 25, FontStyle.Bold);
            Farwell.ForeColor = Color.White;
            Farwell.SetBounds(100,450,1000,40);
            Farwell.BackColor = Color.Transparent;
            this.Controls.Add(Farwell);

            roundPanel Line = new roundPanel(1,Color.White,Color.White);
            Line.SetBounds(100,450,1000,1);
            
            
            roundPanel CounterBackground = new roundPanel(60,Color.FromArgb(128, 207, 216, 220),Color.FromArgb(128, 236, 239, 241));
            CounterBackground.SetBounds(100,550,60,60);
            
            Counter.Text = count.ToString();
            Counter.Font = new Font("Impact", 25, FontStyle.Regular);
            Counter.SetBounds(15,11,40,40);
            Counter.ForeColor = Color.White;
            Counter.BackColor = Color.Transparent;
            CounterBackground.Controls.Add(Counter);
            
            this.Controls.Add(CounterBackground);
            
            time = new Timer() {
                Interval = 1000
            };
            time.Tick += CountDown;

            roundPanel cancelBackground = new roundPanel(60,Color.FromArgb(128, 207, 216, 220),Color.FromArgb(128, 236, 239, 241));
            cancelBackground.BackColor = Color.Transparent;
            cancelBackground.SetBounds(180,550,250,60);
            cancelBackground.Click += CancelButtonClicked;
            this.Controls.Add(cancelBackground);
            
            Label CancelLabel = new Label();
            CancelLabel.Text = "Cancel";
            CancelLabel.Font = new Font("Arial Rounded Border", 20, FontStyle.Bold);
            CancelLabel.ForeColor = Color.White;
            CancelLabel.BackColor = Color.Transparent;
            CancelLabel.SetBounds(70,15,110,35);
            CancelLabel.Click += CancelButtonClicked;
            cancelBackground.Controls.Add(CancelLabel);
            
            

        }

        public void CancelButtonClicked(object sender, EventArgs e) {
            count = 5;
            Counter.Text = count.ToString();
            time.Stop();
            form.home.Show();
            this.Hide();
            
        } 

        public void CountDown(Object obj, EventArgs e) {
            count--;
            if (count > 0) {
                Counter.Text = count.ToString();
                Counter.Invalidate();
            }else {
                time.Stop();
                LoginFrame frame = new LoginFrame();
                form.Hide();
                frame.Show();
                form.f.Hide();
            }
        }
    }
}