using System.Drawing;
using System.Windows.Forms;

namespace Enviroment {
    public class SignupTab : roundPanel{
        PictureBox BackToLogin;
        public SignupTab(int r, Color s, Color e) : base(r,s,e) {
            BackToLogin = new PictureBox {
                Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\StudentViewPort\\Images & Icons\\Icons\\Back To.png"),
            };
            BackToLogin.SetBounds(20,20,40,40);
            this.Controls.Add(BackToLogin);
            
            Label BackToLoginLabel = new Label();
            BackToLoginLabel.Text = "Back to Login";
            BackToLoginLabel.SetBounds(70,27,160,25);
            BackToLoginLabel.ForeColor = Color.White;
            BackToLoginLabel.Font = new Font("Century Gothic", 16, FontStyle.Regular);
            this.Controls.Add(BackToLoginLabel);
            
        }
    }
}