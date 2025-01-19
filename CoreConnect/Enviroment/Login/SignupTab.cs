using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Enviroment {
    public class SignupTab : roundPanel{
        internal PictureBox BackToLogin;
        internal TextBox FirstName, LastName, SID, Box1, Box2, Box3, Box4, Box5, Box6;
        internal roundPanel Authentication = new roundPanel(1,Color.Transparent,Color.Transparent);
        internal roundPanel SetDetails = new roundPanel(1,Color.Transparent,Color.Transparent);
        
        // USERS INFORMATION STORAGE
        private TextBox Username, Password, ConfirmPassword;
        private bool passVisability = false;
        
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
            
            // AUTHENTICATION PANEL 
            Authentication.BackColor = Color.Transparent;
            Authentication.SetBounds(50,70,500,400);
            
            Label AuthenticationLabel = new Label();
            AuthenticationLabel.Text = "Authentication";
            AuthenticationLabel.Font = new Font("SimSun", 28, FontStyle.Regular);
            AuthenticationLabel.ForeColor = Color.White;
            AuthenticationLabel.SetBounds(10,10,290,40);
            AuthenticationLabel.BackColor = Color.Transparent;
            Authentication.Controls.Add(AuthenticationLabel);
            
            roundPanel line  = new roundPanel(1, Color.Transparent, Color.Transparent);
            line.BackColor = Color.White;
            line.SetBounds(15,57, 310,1);
            Authentication.Controls.Add(line);
            
            FirstName = new TextBox();
            FieldableFormate(Authentication, FirstName, "First Name", 15,85,165,30, 190,80,250,50);
            
            LastName = new TextBox();
            FieldableFormate(Authentication, LastName, "Last Name",13,150,170,30,190,145,250,50);
            
            SID = new TextBox();
            FieldableFormate(Authentication, SID, "Student ID",15,215,170,30, 190,210,250,50);
            
            Label PassCodeLabel = new Label();
            PassCodeLabel.Text = "PassCode";
            PassCodeLabel.Font = new Font("Century Gothic", 25, FontStyle.Regular);
            PassCodeLabel.SetBounds(150,275, 190, 40);
            PassCodeLabel.BackColor = Color.Transparent;
            PassCodeLabel.ForeColor = Color.White;
            Authentication.Controls.Add(PassCodeLabel);
            
            roundPanel PassCodeline  = new roundPanel(1, Color.Transparent, Color.Transparent);
            PassCodeline.BackColor = Color.White;
            PassCodeline.SetBounds(127,318, 210,1);
            Authentication.Controls.Add(PassCodeline);
            
            // Pass Code Boxes
            Box1 = new TextBox();
            Box2 = new TextBox();
            Box3 = new TextBox();
            Box4 = new TextBox();
            Box5 = new TextBox();
            Box6 = new TextBox();
            
            // Digit 1
            BoxFormate(Authentication, Box1, Box2, Box1, 60, 330);
            // Digit 2
            BoxFormate(Authentication, Box2, Box3, Box1,120,330);
            // Digit 3
            BoxFormate(Authentication, Box3, Box4,Box2,180, 330);
            // Digit 4
            BoxFormate(Authentication, Box4,Box5,Box3, 240,330);
            // Digit 5
            BoxFormate(Authentication, Box5,Box6,Box4,300, 330);
            // Digit 6
            BoxFormate(Authentication, Box6,Box6,Box5 ,360,330);
            
            Controls.Add(Authentication);
            
            // USER NAME & PASSWORD PANEL
            SetDetails.BackColor = Color.Transparent;
            SetDetails.SetBounds(50,70,500,400);
            SetDetails.Hide();
            
            Label DetailsLabel = new Label();
            DetailsLabel.Text = "User Information";
            DetailsLabel.Font = new Font("SimSun", 28, FontStyle.Regular);
            DetailsLabel.ForeColor = Color.White;
            DetailsLabel.SetBounds(10,10,350,40);
            DetailsLabel.BackColor = Color.Transparent;
            SetDetails.Controls.Add(DetailsLabel);
            
            roundPanel line2  = new roundPanel(1, Color.Transparent, Color.Transparent);
            line2.BackColor = Color.White;
            line2.SetBounds(15,57, 350,1);
            SetDetails.Controls.Add(line2);
            
            Username = new TextBox();
            FieldableFormate(SetDetails, Username, "Username", 42,105,165,30, 210,100,270,50);
            
            Password = new TextBox();
            PassFieldableFormate(SetDetails, Password, "Password","Password",47,170,160,30,210,165,270,50);
            
            ConfirmPassword = new TextBox();
            PassFieldableFormate(SetDetails, ConfirmPassword, "Confirmation","Password",0,235,210,30, 210,230,270,50);
            
            roundPanel SubmitPanel  = new roundPanel(25,Color.FromArgb(115, 255, 255, 255), Color.FromArgb(115, 255, 255, 255));
            Label SubmitLabel = new Label();
            
            SubmitPanel.SetBounds(150, 330, 200,60);
            SubmitPanel.Click += (sender, args) => {

            };

            SubmitPanel.MouseEnter += (sender, args) => {
                SubmitLabel.ForeColor = Color.Gray;
                SubmitPanel.start = Color.White;
                SubmitPanel.end = Color.White;
            };

            SubmitPanel.MouseLeave += (sender, args) => {
                SubmitLabel.ForeColor = Color.White;
                SubmitPanel.start = Color.FromArgb(115, 255, 255, 255);
                SubmitPanel.end = Color.FromArgb(115, 255, 255, 255);
            };
            
            SubmitLabel.Text = "Submit";
            SubmitLabel.SetBounds(53,14,140,50);
            SubmitLabel.Font = new Font("Arial rounded border", 20, FontStyle.Regular);
            SubmitLabel.ForeColor = Color.White;
            SubmitPanel.Controls.Add(SubmitLabel);
            
            SubmitLabel.Click += (sender, args) => {

            };
            
            SubmitLabel.MouseEnter += (sender, args) => {
                SubmitLabel.ForeColor = Color.Gray;
                SubmitPanel.start = Color.White;
                SubmitPanel.end = Color.White;
            };
            
            SubmitLabel.MouseLeave += (sender, args) => {
                SubmitLabel.ForeColor = Color.White;
                SubmitPanel.start = Color.FromArgb(115, 255, 255, 255);
                SubmitPanel.end = Color.FromArgb(115, 255, 255, 255);
            };
            
            SetDetails.Controls.Add(SubmitPanel);
            
            
            
            this.Controls.Add(SetDetails);
        }

        public void FieldableFormate(Panel panel,TextBox box, string  s, int LabelX, int LabelY, int LabelWidth, int LabelHeight, int PanelX, int PaneelY, int PanelWidth, int PanelHeight) {
            Label label = new Label();
            label.Text = s + " :";
            label.Font = new Font("Century Gothic", 20, FontStyle.Regular);
            label.ForeColor = Color.White;
            label.SetBounds(LabelX,LabelY,LabelWidth,LabelHeight);
            panel.Controls.Add(label);
            
            roundPanel Background = new roundPanel(50, Color.Transparent, Color.Transparent);
            Background.BackColor = Color.White;
            Background.SetBounds(PanelX,PaneelY,PanelWidth,PanelHeight);
            
            box.Text = s;
            box.SetBounds(25,12,210,80);
            box.BackColor = Color.White;
            box.ForeColor = Color.FromArgb(186, 196, 170);
            box.BorderStyle = BorderStyle.None;
            box.Font = new Font("", 16, FontStyle.Regular);

            box.Enter += (sender, args) => {
                if (box.Text == s) {
                    box.Text = "";
                }
            };
            box.Leave += (sender, args) => {
                if (box.Text == "") {
                    box.Text = s;
                }
            };
            
            Background.Controls.Add(box);
            panel.Controls.Add(Background);
        }

        public void PassFieldableFormate(Panel panel,TextBox box, string  s, string ts, int LabelX, int LabelY, int LabelWidth, int LabelHeight, int PanelX, int PaneelY, int PanelWidth, int PanelHeight) {
            Label label = new Label();
            label.Text = s + " :";
            label.Font = new Font("Century Gothic", 20, FontStyle.Regular);
            label.ForeColor = Color.White;
            label.SetBounds(LabelX,LabelY,LabelWidth,LabelHeight);
            panel.Controls.Add(label);
            
            roundPanel Background = new roundPanel(50, Color.Transparent, Color.Transparent);
            Background.BackColor = Color.White;
            Background.SetBounds(PanelX,PaneelY,PanelWidth,PanelHeight);

            PictureBox View = new PictureBox {
                Size = new Size(30,30),
                Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\Hide.png"),
                SizeMode = PictureBoxSizeMode.Normal,
            };
            View.SetBounds(230,14,30,30);
            View.Click += (sender, args) => {
                passVisability = !passVisability;
                if (passVisability) {
                    View.Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\Eye.png");
                    box.PasswordChar = '\0';
                    View.Invalidate();
                }else {
                    View.Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\Hide.png");
                    if (box.Text != "Password") {
                        box.PasswordChar = '*';
                    }
                    View.Invalidate();
                }
            };
            Background.Controls.Add(View);
            
            box.Text = ts;
            box.SetBounds(25,12,190,80);
            box.BackColor = Color.White;
            box.ForeColor = Color.FromArgb(186, 196, 170);
            box.BorderStyle = BorderStyle.None;
            box.Font = new Font("", 16, FontStyle.Regular);

            box.Enter += (sender, args) => {
                if (!passVisability) {
                    box.PasswordChar = '*';
                }
                if (box.Text == "Password") {
                    box.Text = "";
                }
            };
            box.Leave += (sender, args) => {
                if (passVisability) {
                    box.PasswordChar = '\0';
                }
                if (box.Text.Length == 0) {
                    box.PasswordChar = '\0';
                    box.Text = "Password";
                }
            };
            
            Background.Controls.Add(box);
            panel.Controls.Add(Background);
        }
        
        public void BoxFormate(Panel panel, TextBox Box , TextBox NextBox, TextBox PriorBox,int X, int Y) {
            roundPanel BoxBackground = new roundPanel(15, Color.White, Color.White);
            BoxBackground.SetBounds(X,Y, 50,60);
            
            Box.SetBounds(5,15,40,60);
            Box.BorderStyle = BorderStyle.None;
            Box.BackColor = Color.White;
            Box.ForeColor = Color.FromArgb(136, 145, 121);
            Box.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular);
            Box.TextAlign = HorizontalAlignment.Center;
            Box.MaxLength = 1;
            Box.KeyPress += (sender, args) => {
                if (!char.IsDigit(args.KeyChar) && !char.IsControl(args.KeyChar)) {
                    args.Handled = true; 
                }else if(char.IsDigit(args.KeyChar)){
                    NextBox.Focus();
                }
            };
            Box.KeyDown += (sender, args) => {
                if (args.KeyCode == Keys.Back && string.IsNullOrEmpty(Box.Text)) {
                    PriorBox.Focus();
                }
            };  
            BoxBackground.Controls.Add(Box);
            panel.Controls.Add(BoxBackground);
        }
    }
}