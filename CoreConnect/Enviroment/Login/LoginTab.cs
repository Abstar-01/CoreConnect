using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Enviroment
{
    public class LoginTab : roundPanel {
        private TextBox usernameField = new TextBox();
        private TextBox passwordField = new TextBox();
        
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
            usernameField.SetBounds(80,20,250,50);
            usernameField.Text = "Username";
            usernameField.Font = new Font("arial",16, FontStyle.Bold);
            usernameField.BorderStyle = BorderStyle.None;
            usernameField.BackColor = Color.Azure;
            usernameField.Enter += (sender, args) => {
                usernameField.Text = "";
            };
            usernameField.Leave += (sender, args) => {
                if (usernameField.Text.Length == 0) {
                    usernameField.Text = "Username";
                }
            };
            userbackground.Controls.Add(usernameField);
            
            
            // Password Background
            roundPanel passwordbackground = new roundPanel(74, Color.Azure, Color.Azure);
            passwordbackground.SetBounds(100,300,400,74);
            
            // Password Background
            roundPanel passwordLog = new roundPanel(70, Color.Transparent, Color.Transparent);
            passwordLog.SetBounds(2,2,70,70);
            passwordLog.BackColor = Color.Transparent;
            passwordLog.BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\Secure.png");
            passwordbackground.Controls.Add(passwordLog);
            
            //PasswordField
            passwordField.SetBounds(85,24,250,50);
            passwordField.Text = "Password";
            passwordField.Font = new Font("arial",16, FontStyle.Bold);
            passwordField.BorderStyle = BorderStyle.None;
            passwordField.BackColor = Color.Azure;
            passwordField.Enter += (sender, args) => {
                passwordField.PasswordChar = '*';
                if (passwordField.Text == "Password") {
                    passwordField.Text = "";
                }
            };
            passwordField.Leave += (sender, args) => {
                if (passwordField.Text.Length == 0) {
                    passwordField.PasswordChar = '\0';
                    passwordField.Text = "Password";
                }
            };
            passwordbackground.Controls.Add(passwordField);
            
            //siginBackground
            roundPanel signBackground = new roundPanel(54, Color.Azure, Color.Azure);
            signBackground.SetBounds(160,390,250,54);
            this.Controls.Add(signBackground);
            
            
            this.Controls.Add(passwordbackground);
        }
    }
}