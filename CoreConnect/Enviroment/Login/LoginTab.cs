using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Enviroment
{
    public class LoginTab : roundPanel {
        private TextBox usernameField = new TextBox();
        private TextBox IdentificationField = new TextBox();
        private TextBox passwordField = new TextBox();
        private bool viewing = false, remb = false;
        
        public LoginTab(int r, Color s, Color e) : base (r,s,e) {
            // UserName Background
            roundPanel userbackground = new roundPanel(66, Color.Azure, Color.Azure);
            userbackground.SetBounds(100,40,400,66);
            
            //UserNamee Logo
            roundPanel userlogo = new roundPanel(70, Color.Transparent, Color.Transparent);
            userlogo.SetBounds(3,4,60,60);
            userlogo.BackColor = Color.Transparent;
            userlogo.BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\Male User.png");
            userlogo.BackgroundImageLayout = ImageLayout.None;
            userbackground.Controls.Add(userlogo);
            this.Controls.Add(userbackground);
            this.Focus();
            
            //UserNameField
            usernameField.SetBounds(80,25,250,50);
            usernameField.Text = "Username";
            usernameField.Font = new Font("Arial Rounded MT Bold",16, FontStyle.Regular);
            usernameField.BorderStyle = BorderStyle.None;
            usernameField.BackColor = Color.Azure;
            usernameField.ForeColor = Color.FromArgb(110, 110, 110);
            usernameField.Enter += (sender, args) => {
                if (usernameField.Text == "Username") {
                    usernameField.Text = "";
                }
            };
            usernameField.Leave += (sender, args) => {
                if (usernameField.Text.Length == 0) {
                    usernameField.Text = "Username";
                }
            };
            userbackground.Controls.Add(usernameField);
            
            // Identification Background
            roundPanel IDbackground = new roundPanel(66, Color.Azure, Color.Azure);
            IDbackground.SetBounds(100,120,400,66);
            
            // Identification Background
            roundPanel IDlogo1 = new roundPanel(47, Color.Transparent, Color.Transparent);
            IDlogo1.SetBounds(10,10,47,47);
            IDlogo1.BackColor = Color.Transparent;
            IDlogo1.BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\Identification Documents.png");
            IDlogo1.BackgroundImageLayout = ImageLayout.Center;
            IDbackground.Controls.Add(IDlogo1);
            Controls.Add(IDbackground);
            
            roundPanel IDlogo2 = new roundPanel(60, Color.Transparent, Color.Transparent);
            IDlogo2.SetBounds(3,4,60,60);
            IDlogo2.BackColor = Color.Transparent;
            IDlogo2.BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\Circle.png");
            IDlogo2.BackgroundImageLayout = ImageLayout.None;
            IDbackground.Controls.Add(IDlogo2);
            Controls.Add(IDbackground);
            
            //Identification Field Section
            IdentificationField.SetBounds(75,21,250,50);
            IdentificationField.Text = "Identification";
            IdentificationField.Font = new Font("Arial Rounded MT Bold",16, FontStyle.Regular);
            IdentificationField.BorderStyle = BorderStyle.None;
            IdentificationField.BackColor = Color.Azure;
            IdentificationField.ForeColor = Color.FromArgb(110, 110, 110);
            IdentificationField.Enter += (sender, args) => {
                if (IdentificationField.Text == "Identification") {
                    IdentificationField.Text = "";
                }
            };
            IdentificationField.Leave += (sender, args) => {
                if (IdentificationField.Text.Length == 0) {
                    IdentificationField.Text = "Identification";
                }
            };
            IDbackground.Controls.Add(IdentificationField);
            
            
            // Password Background
            roundPanel passwordbackground = new roundPanel(66, Color.Azure, Color.Azure);
            passwordbackground.SetBounds(100,200,400,66);
            
            // Password Background
            roundPanel passwordLog = new roundPanel(60, Color.Transparent, Color.Transparent);
            passwordLog.SetBounds(3,4,60,60);
            passwordLog.BackColor = Color.Transparent;
            passwordLog.BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\Secure.png");
            passwordLog.BackgroundImageLayout = ImageLayout.None;
            passwordbackground.Controls.Add(passwordLog);
            
            //PasswordField
            passwordField.SetBounds(75,21,250,50);
            passwordField.Text = "Password";
            passwordField.Font = new Font("Arial Rounded MT Bold",15, FontStyle.Regular);
            passwordField.BorderStyle = BorderStyle.None;
            passwordField.BackColor = Color.Azure;
            passwordField.ForeColor = Color.FromArgb(110, 110, 110);
            passwordField.Enter += (sender, args) => {
                if (!viewing) {
                    passwordField.PasswordChar = '*';
                }
                if (passwordField.Text == "Password") {
                    passwordField.Text = "";
                }
            };
            passwordField.Leave += (sender, args) => {
                if (viewing) {
                    passwordField.PasswordChar = '\0';
                }
                if (passwordField.Text.Length == 0) {
                    passwordField.PasswordChar = '\0';
                    passwordField.Text = "Password";
                }
            };
            passwordbackground.Controls.Add(passwordField);
            
            //Reveal Eye Button
            PictureBox View = new PictureBox {
                Size = new Size(30,30),
                Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\Hide.png"),
                SizeMode = PictureBoxSizeMode.Normal,
            };
            View.SetBounds(350,23,30,30);
            View.Click += (sender, args) => {
                viewing = !viewing;
                if (viewing) {
                    View.Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\Eye.png");
                    passwordField.PasswordChar = '\0';
                    View.Invalidate();
                }else {
                    View.Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\Hide.png");
                    if (passwordField.Text != "Password") {
                        passwordField.PasswordChar = '*';
                    }
                    View.Invalidate();
                }
            };
            passwordbackground.Controls.Add(View);
            
            //Remember Sction
            PictureBox check = new PictureBox {
                Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\CheckCircle.png"),
                Size = new Size(25,25),
            };
            check.SetBounds(140,270,25,25);
            check.Click += (sender, args) => {
                remb = !remb;
                if (remb) {
                    check.Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\Checkmark.png");
                    check.Invalidate();
                }else {
                    check.Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\CheckCircle.png");
                    check.Invalidate();
                }
            }; 
            Controls.Add(check);
            
            // SiginBackground
            roundPanel signBackground = new roundPanel(54, Color.FromArgb(110, 255, 255, 255), Color.FromArgb(124, 255, 255, 255));
            signBackground.SetBounds(175,300,250,60);
            signBackground.MouseEnter += (sender, args) => {
                signBackground.start = Color.White;
                signBackground.end = Color.White;
                signBackground.Invalidate();
            };
            
            signBackground.MouseLeave += (sender, args) => {
                signBackground.start = Color.FromArgb(110, 255, 255, 255);
                signBackground.end = Color.FromArgb(110, 255, 255, 255);
                signBackground.Invalidate();
            };
            this.Controls.Add(signBackground);
            
            
            this.Controls.Add(passwordbackground);
        }
    }
}