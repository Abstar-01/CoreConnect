using System.Drawing;
using System.Windows.Forms;
using Image = AForge.Imaging.Image;

namespace Enviroment.InstructorViewPort {
    
    public class ProfilePage : roundPanel {
        public ProfilePage(int r, Color s, Color e) : base(r,s,e) {
            this.Hide();
            
            Label AccountTitleLabel = new Label();
            AccountTitleLabel.Text = "Profile";
            AccountTitleLabel.SetBounds(100,25,250,75);
            AccountTitleLabel.Font = new Font("Berlin Sans FB Demi", 50, FontStyle.Regular);
            AccountTitleLabel.ForeColor = Color.White;
            this.Controls.Add(AccountTitleLabel);
            
            roundPanel ProfileBackground = new roundPanel(50, Color.FromArgb(61, 132, 167), Color.FromArgb(70, 205, 207));
            ProfileBackground.SetBounds(100,120,300,300);
            PictureBox Profile = new PictureBox() {
                Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Images\\Profile_Pic.png"),
                BackgroundImageLayout = ImageLayout.None
            };
            Profile.SetBounds(0,0,300,300);
            ProfileBackground.Controls.Add(Profile);
            this.Controls.Add(ProfileBackground);

            roundPanel personalInformationBackground = new roundPanel(50, Color.FromArgb(140, 137, 140, 167), Color.FromArgb(162, 172, 176, 174));
            personalInformationBackground.SetBounds(450,30,870,300);
            this.Controls.Add(personalInformationBackground);

        }
    }
}