using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Enviroment
{
    public class LoginTab : roundPanel {
        private TextBox usernameField = new TextBox();
        private TextBox passwordField = new TextBox();
        private bool viewing = false, remb = false;
        
        public LoginTab(int r, Color s, Color e) : base (r,s,e) {
            // UserName Background
            roundPanel userbackground = new roundPanel(74, Color.Azure, Color.Azure);
            userbackground.SetBounds(100,200,400,74);
            
            //UserNamee Logo
            roundPanel userlogo = new roundPanel(70, Color.Transparent, Color.Transparent);
            userlogo.SetBounds(2,2,70,70);
            userlogo.BackColor = Color.Transparent;
            userlogo.BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\Male User.png");
            userbackground.Controls.Add(userlogo);
            this.Controls.Add(userbackground);
            this.Focus();
            
            //UserNameField
            usernameField.SetBounds(80,25,250,50);
            usernameField.Text = "Username";
            usernameField.Font = new Font("arial",16, FontStyle.Bold);
            usernameField.BorderStyle = BorderStyle.None;
            usernameField.BackColor = Color.Azure;
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
            
            
            // Password Background
            roundPanel passwordbackground = new roundPanel(74, Color.Azure, Color.Azure);
            passwordbackground.SetBounds(100,290,400,74);
            
            // Password Background
            roundPanel passwordLog = new roundPanel(70, Color.Transparent, Color.Transparent);
            passwordLog.SetBounds(2,2,70,70);
            passwordLog.BackColor = Color.Transparent;
            passwordLog.BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\Secure.png");
            passwordbackground.Controls.Add(passwordLog);
            
            //PasswordField
            passwordField.SetBounds(85,25,250,50);
            passwordField.Text = "Password";
            passwordField.Font = new Font("arial",16, FontStyle.Bold);
            passwordField.BorderStyle = BorderStyle.None;
            passwordField.BackColor = Color.Azure;
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
                Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\Circle.png"),
                Size = new Size(25,25),
            };
            check.SetBounds(140,370,25,25);
            check.Click += (sender, args) => {
                remb = !remb;
                if (remb) {
                    check.Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\Checkmark.png");
                    check.Invalidate();
                }else {
                    check.Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\Circle.png");
                    check.Invalidate();
                }
            }; 
            Controls.Add(check);
            
            // SiginBackground
            roundPanel signBackground = new roundPanel(54, Color.FromArgb(110, 255, 255, 255), Color.FromArgb(124, 255, 255, 255));
            signBackground.SetBounds(175,410,250,60);
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