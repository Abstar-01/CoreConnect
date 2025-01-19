using System;
using System.Drawing;
using System.Windows.Forms;

namespace Enviroment.InstructorViewPort {
    public class InstructorPanel : roundPanel{
        private bool isDragging = false;
        
        
        public InstructorPanel(int r, Color s, Color e, Form form) : base(r,s,e) {
            BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Images\\Background Option 6.jpg");
            BackgroundImageLayout = ImageLayout.None;
            
            roundPanel panel = new roundPanel(50, Color.Transparent,Color.Transparent);
            panel.SetBounds(0,0,1500,1500);

            PictureBox Logo = new PictureBox {
                Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Icons\\image.png"),
                BackgroundImageLayout = ImageLayout.None,
            };
            Logo.SetBounds(15,15,85,85);
            panel.Controls.Add(Logo);
            
            Label TitlePart1 = new Label();
            TitlePart1.SetBounds(107,25,110,30);
            TitlePart1.Text = "Core";
            TitlePart1.Font = new Font("Felix Titling", 22, FontStyle.Bold);
            TitlePart1.ForeColor = Color.Black;
            panel.Controls.Add(TitlePart1);
            
            Label TitlePart2 = new Label();
            TitlePart2.SetBounds(107,53,200,35);
            TitlePart2.Text = "Connect";
            TitlePart2.Font = new Font("Felix Titling", 25, FontStyle.Bold);
            TitlePart2.ForeColor = Color.Black;
            panel.Controls.Add(TitlePart2);
            
            roundPanel TabBar = new roundPanel(50, Color.FromArgb(130, 113, 144, 94),Color.FromArgb(130, 113, 144, 94));
            TabBar.SetBounds(450,20,600,70);
            panel.Controls.Add(TabBar);
            
            // Closing & Minimizing Buttons
            // Closing 
            roundPanel ClosingPanel = new roundPanel(40, Color.Transparent, Color.Transparent);
            ClosingPanel.SetBounds(1435,10,39,39);
            ClosingPanel.BackColor = Color.Transparent;
            Label CloseButton = new Label();
            CloseButton.BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\Cancel.png");
            CloseButton.SetBounds(-1,0,40,40);

            CloseButton.Click += (sender, args) => {
                Application.Exit();
            }; 
            
            CloseButton.MouseEnter += (sender, args) => {
                ClosingPanel.start = Color.Red;
                ClosingPanel.start = Color.Red;
                ClosingPanel.Invalidate();
            };

            CloseButton.MouseLeave += (sender, args) => {
                ClosingPanel.start = Color.Transparent;
                ClosingPanel.start = Color.Transparent;
                ClosingPanel.BackColor = Color.Transparent;
                ClosingPanel.Invalidate();
            }; 
            
            ClosingPanel.Controls.Add(CloseButton);
            this.Controls.Add(ClosingPanel);
            
            
            // Minimization 
            roundPanel MinPanel = new roundPanel(40, Color.Transparent, Color.Transparent);
            MinPanel.SetBounds(1390,10,39,39);
            MinPanel.BackColor = Color.Transparent;
            Label MinButton = new Label();
            MinButton.BackgroundImage = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\Login\\Images & Icons\\Icons\\Minus.png");
            MinButton.SetBounds(0,0,40,40);

            MinButton.Click += (sender, args) => {
                form.WindowState = FormWindowState.Minimized;
            }; 
            
            MinButton.MouseEnter += (sender, args) => {
                MinPanel.start = Color.FromArgb(30, 91, 83);
                MinPanel.start = Color.FromArgb(184, 113, 144, 94);
                MinPanel.Invalidate();
            };

            MinButton.MouseLeave += (sender, args) => {
                MinPanel.start = Color.Transparent;
                MinPanel.start = Color.Transparent;
                MinPanel.BackColor = Color.Transparent;
                MinPanel.Invalidate();
            }; 
            
            MinPanel.Controls.Add(MinButton);
            this.Controls.Add(MinPanel);
            
            
            Controls.Add(panel);
        }
        
    }
}