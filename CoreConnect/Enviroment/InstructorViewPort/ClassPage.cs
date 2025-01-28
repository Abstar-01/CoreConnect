using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net.Mime;
using System.Windows.Forms;

namespace Enviroment.InstructorViewPort {
    
    public class ClassPage : roundPanel {

        PictureBox ChatPanelButton, AttendancePanelButton, CourseMaterialPanelButton, NotificationButton, CourseDetailsButton;
        
        ChatPanel chatPanel;
        AttendancePanel attendancePanel;
        CourseMaterialPanel courseMaterialPanel;
        NotificationPanel notificationPanel;
        CourseDetailsPanel courseDetailsPanel;
        
        string Unfilled = "C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Icons\\Circle.png";
        string Filled = "C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Icons\\Filled Circle.png";
        
        public ClassPage(int r, Color s, Color e) : base(r,s,e) {
            this.Hide();
            
              //////////////////
             // CHAT SECTION //
            //////////////////
            
            // chat Panel 
            chatPanel = new ChatPanel(50, Color.Blue, Color.Aqua);
            chatPanel.SetBounds(5,5,1250,650);
            chatPanel.Hide();
            this.Controls.Add(chatPanel);
            
            // chat button
            ChatPanelButton = new PictureBox();
            ButtonFormat(ChatPanelButton, 1280,150,Filled);
            ChatPanelButton.Click += (sender, args) => {
                HideAll();
                chatPanel.Show();
                ChatPanelButton.Image = Image.FromFile(Filled);
            };
              
              ////////////////////////
             // ATTENDANCE SECTION //
            ////////////////////////

            // Attendance Panel
            attendancePanel = new AttendancePanel(50,Color.Transparent, Color.Transparent);
            attendancePanel.SetBounds(5,5,1250,650);
            this.Controls.Add(attendancePanel);
            
            // Attendance Button
            AttendancePanelButton = new PictureBox();
            ButtonFormat(AttendancePanelButton, 1280,240,Unfilled);
            AttendancePanelButton.Click += (sender, args) => {
                HideAll();
                attendancePanel.Show();
                AttendancePanelButton.Image = Image.FromFile(Filled);
            };
            
              /////////////////////////////
             // COURSE MATERIAL SECTION //
            /////////////////////////////
            
            // Course Material Panel
            courseMaterialPanel = new CourseMaterialPanel(50,Color.Transparent, Color.Transparent);
            courseMaterialPanel.SetBounds(5,5,1250,650);
            this.Controls.Add(courseMaterialPanel);
            
            // Course Material Button
            CourseMaterialPanelButton = new PictureBox();
            ButtonFormat(CourseMaterialPanelButton, 1280,330,Unfilled);
            CourseMaterialPanelButton.Click += (sender, args) => {
                HideAll();
                courseMaterialPanel.Show();
                CourseMaterialPanelButton.Image = Image.FromFile(Filled);
            };
            
              //////////////////////////
             // NOTIFICATION SECTION //
            //////////////////////////
            
            // Notification Panel
            notificationPanel = new NotificationPanel(50,Color.Transparent, Color.Transparent);
            notificationPanel.SetBounds(5,5,1250,650);
            notificationPanel.Show();
            this.Controls.Add(notificationPanel);
            
            // Notification Button
            NotificationButton = new PictureBox();
            ButtonFormat(NotificationButton, 1280,420,Unfilled);
            NotificationButton.Click += (sender, args) => {
                HideAll();
                notificationPanel.Show();
                NotificationButton.Image = Image.FromFile(Filled);
            };
            
              //////////////////////////
             // COURSE DETAIL SECTION //
            //////////////////////////
            
            // Course Detail Panel
            courseDetailsPanel = new CourseDetailsPanel(50,Color.Blue, Color.Aqua);
            courseDetailsPanel.SetBounds(5,5,1250,650);
            this.Controls.Add(courseDetailsPanel);
            
            // Course Detail Button
            CourseDetailsButton = new PictureBox();
            ButtonFormat(CourseDetailsButton, 1280,510,Unfilled);
            CourseDetailsButton.Click += (sender, args) => {
                HideAll();
                courseDetailsPanel.Show();
                CourseDetailsButton.Image = Image.FromFile(Filled);
            };
            
            // Line
            roundPanel line = new roundPanel(1,Color.White, Color.White);
            line.SetBounds(1292,175, 1, 350);
            this.Controls.Add(line);
        }
        
        public void ButtonFormat(PictureBox pb, int x, int y, string path) {
            pb.SetBounds(x,y,25,25);
            pb.BackColor = Color.Transparent;
            pb.Image = Bitmap.FromFile(path);
            pb.BackgroundImageLayout = ImageLayout.None;
            this.Controls.Add(pb);
        }

        public void HideAll() {
            chatPanel.Hide();
            ChatPanelButton.Image = Image.FromFile(Unfilled);
            
            attendancePanel.Hide();
            AttendancePanelButton.Image = Image.FromFile(Unfilled);
            
            courseMaterialPanel.Hide();
            CourseMaterialPanelButton.Image = Image.FromFile(Unfilled);
            
            notificationPanel.Hide();
            NotificationButton.Image = Image.FromFile(Unfilled);
            
            courseDetailsPanel.Hide();
            CourseDetailsButton.Image = Image.FromFile(Unfilled);
        }
    }

    public class ChatPanel : roundPanel {
        public ChatPanel(int r, Color s, Color e) : base(r, s, e) {
            this.Hide();
            
            Label label = new Label();
            label.SetBounds(0,0,250,250);
            label.Font = new Font("Arial", 10, FontStyle.Bold);
            label.Text = "Chat Panel";
            this.Controls.Add(label);
        }
    }

    public class AttendancePanel : roundPanel {
        
        // Search Box 
        TextBox SearchBox = new TextBox();
        
        Label SeasonSearch = new Label();
        Label StudentSearch = new Label();
        Label AbsenceSearch = new Label();
        
        public AttendancePanel(int r, Color s, Color e) : base(r, s, e) {
            this.Hide();
            
            Label label = new Label();
            label.SetBounds(30,5,330,50);
            label.Font = new Font("Arial", 40, FontStyle.Bold);
            label.Text = "Attendance";
            label.ForeColor = Color.White;
            this.Controls.Add(label);

            VerticalLine(360,15,1,45);
            TitleFormat(SeasonSearch, "Batch Search", 370,22,180,25);
            
            VerticalLine(550,15,1,45);
            TitleFormat(StudentSearch, "Student Search", 560,22,190,25);
            
            VerticalLine(760,15,1,45);
            TitleFormat(AbsenceSearch, "Absence Search", 770,22,210,25);
            
            VerticalLine(980,15,1,45);
            
            roundPanel SearchBar = new roundPanel(50, Color.White, Color.White);
            SearchBar.SetBounds(30, 70, 350, 50);

            SearchBox.SetBounds(20,10,280,40);
            SearchBox.Text = "Search";
            SearchBox.Font = new Font("Arial", 18, FontStyle.Bold);
            SearchBox.BorderStyle = BorderStyle.None;
            SearchBox.BackColor = Color.White;
            SearchBox.ForeColor = Color.LightGray;

            SearchBox.Enter += (sender, args) => {
                if (SearchBox.Text == "Search") {
                    SearchBox.Text = "";
                }
            };

            SearchBox.Leave += (sender, args) => {
                if (SearchBox.Text == "") {
                    SearchBox.Text = "Search";
                }
            };
            
            SearchBar.Controls.Add(SearchBox);
            
            PictureBox SearchIconImage = new PictureBox() {
                Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Icons\\Search.png"),
                BackgroundImageLayout =  ImageLayout.None
            };
            SearchIconImage.SetBounds(300,7,36,36);
            SearchBar.Controls.Add(SearchIconImage);
            this.Controls.Add(SearchBar);
            
            
            AttendancePanelHolder at = new AttendancePanelHolder(50, Color.White, Color.White);
            at.SetBounds(30,130,1200,450);
            this.Controls.Add(at);
            
            Label Warning = new Label();
            Warning.SetBounds(35,605,900,450);
            Warning.Font = new Font("Arial", 17, FontStyle.Regular);
            Warning.ForeColor = Color.LightGray;
            Warning.Text = "Notice : Changes are permanent and cannot be undone. Proceed cautiously.";
            this.Controls.Add(Warning);
            
            roundPanel SubmitButton = new roundPanel(50,Color.White, Color.White);
            SubmitButton.SetBounds(970,590,250,50);
            this.Controls.Add(SubmitButton);
        }

        public void TitleFormat(Label label, string s, int x, int y, int length, int width) {
            label.Text = s;
            label.SetBounds(x,y,length,width);
            label.Font = new Font("Arial", 19, FontStyle.Regular);
            label.ForeColor = Color.LightGray;
            this.Controls.Add(label);
        }

        public void VerticalLine(int x, int y, int length, int width) {
            roundPanel line = new roundPanel(1, Color.FromArgb(128, 255, 255, 255), Color.FromArgb(128, 255, 255, 255));
            line.SetBounds(x,y,length,width);
            this.Controls.Add(line);
        }

        public class AttendancePanelHolder : roundPanel {
            
            public AttendancePanelHolder(int r, Color s, Color e) : base(r, s, e) {
                this.AutoScroll = true;
            }
            
        }

        public class RowFormat : roundPanel {
            public RowFormat(int r, Color s, Color e) : base(r, s, e) {
                
            }
        } 
    }

    public class CourseMaterialPanel : roundPanel {
        
        TextBox SearchBox = new TextBox();
        
        public CourseMaterialPanel(int r, Color s, Color e) : base(r, s, e) {
            this.Hide();
            
            Label label = new Label();
            label.SetBounds(10,20,498,220);
            label.Font = new Font("Folklore", 65, FontStyle.Bold);
            label.ForeColor = Color.White;
            label.Text = "Course Material";
            this.Controls.Add(label);
            
            PictureBox BooksLogo = new PictureBox() {
                Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Images\\Books.png"),
                BackgroundImageLayout = ImageLayout.None
            };
            BooksLogo.SetBounds(460,-20,230,250);
            this.Controls.Add(BooksLogo);
            
            
            // Search Bar
            roundPanel SearchBar = new roundPanel(50, Color.White, Color.White);
            SearchBar.SetBounds(30,240, 350,50);
            
            SearchBox.SetBounds(20,10,280,40);
            SearchBox.Text = "Search";
            SearchBox.Font = new Font("Arial", 18, FontStyle.Bold);
            SearchBox.BorderStyle = BorderStyle.None;
            SearchBox.BackColor = Color.White;
            SearchBox.ForeColor = Color.LightGray;

            SearchBox.Enter += (sender, args) => {
                if (SearchBox.Text == "Search") {
                    SearchBox.Text = "";
                }
            };

            SearchBox.Leave += (sender, args) => {
                if (SearchBox.Text == "") {
                    SearchBox.Text = "Search";
                }
            };
            
            SearchBar.Controls.Add(SearchBox);
            
            PictureBox SearchIconImage = new PictureBox() {
                Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Icons\\Search.png"),
                BackgroundImageLayout =  ImageLayout.None
            };
            SearchIconImage.SetBounds(300,7,36,36);
            SearchBar.Controls.Add(SearchIconImage);
            
            this.Controls.Add(SearchBar);
            
            // Collection Panel
            // This Panel is a panel that houses all the resource material in regards to a specific instructor
            roundPanel Collection = new roundPanel(50, Color.White, Color.White);
            Collection.SetBounds(30,310,640,310);
            this.Controls.Add(Collection);
            
            
            // Information Detail Panel 
            // This panel displays all th information about selected resource material
            roundPanel InformationDetails = new roundPanel(20,Color.White, Color.White);

            PictureBox BookInfoIcon = new PictureBox() {
                Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Icons\\Document.png"),
                BackgroundImageLayout = ImageLayout.None
            };
            BookInfoIcon.SetBounds(40,40,150,150);
            InformationDetails.Controls.Add(BookInfoIcon);
            
            
            Line(InformationDetails,40,200,400,1, Color.FromArgb(131, 52, 52, 52));
            
            Label TypeLabel = new Label();
            TextFormat(InformationDetails,TypeLabel, "Type", 40,210,150,30);
            
            Label SizeLabel = new Label();
            TextFormat(InformationDetails,SizeLabel, "File Size", 40,270,200,30);
            
            Label CreatedLabel = new Label();
            TextFormat(InformationDetails,CreatedLabel, "Created", 40,330,150,30);
            
            Label LastModifiedLabel = new Label();
            TextFormat(InformationDetails,LastModifiedLabel, "Last Date of Modification", 40,390,300,30);
            
            
            roundPanel DownloadButton = new roundPanel(15,Color.FromArgb(94, 181, 215), Color.FromArgb(132, 237, 237));
            DownloadButton.SetBounds(20,510,450,50);
            
              /////////////////
             // View Button //
            /////////////////
            
            PictureBox ViewIcon = new PictureBox() {
                BackgroundImageLayout = ImageLayout.None
            };
            ViewIcon.SetBounds(0, 0, 224,50);
            ViewIcon.Paint += (sender, args) => {
                Image image1 = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Icons\\View.png");
                
                args.Graphics.DrawImage(image1, 20,11,image1.Width,image1.Height);
            };
            
            Label ViewLabel = new Label();
            ViewLabel.SetBounds(60,16,100,40);
            ViewLabel.Text = "View";
            ViewLabel.ForeColor = Color.White;
            ViewLabel.Font = new Font("arial", 16, FontStyle.Regular);
            DownloadButton.Controls.Add(ViewLabel);
            
            DownloadButton.Controls.Add(ViewIcon);
            
            Line(DownloadButton,225,5,1,40, Color.White);
            
              /////////////////////
             // Download Button //
            /////////////////////
            
            PictureBox DownloadIcon = new PictureBox() {
                BackgroundImageLayout = ImageLayout.None
            };
            DownloadIcon.SetBounds(226, 0, 224,50);
            DownloadIcon.Paint += (sender, args) => {
                Image image2 = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Icons\\Download.png");
                
                args.Graphics.DrawImage(image2, 20,13,image2.Width,image2.Height);
            };
            
            Label DownloadLabel = new Label();
            DownloadLabel.SetBounds(60,16,110,40);
            DownloadLabel.Text = "Download";
            DownloadLabel.ForeColor = Color.White;
            DownloadLabel.Font = new Font("arial", 16, FontStyle.Regular);
            DownloadIcon.Controls.Add(DownloadLabel);
            
            DownloadButton.Controls.Add(DownloadIcon);
            
            InformationDetails.Controls.Add(DownloadButton);
            InformationDetails.SetBounds(700,50, 500, 570);
            this.Controls.Add(InformationDetails);
        }

        public void TextFormat(roundPanel panel,Label label,string s, int x, int y, int length, int width) {
            label.Text = s;
            label.SetBounds(x,y,length,width);
            label.Font = new Font("Arial", 18, FontStyle.Regular);
            panel.Controls.Add(label);
        }

        public void Line(roundPanel panel,int x, int y, int length, int width, Color color) {
            roundPanel Line = new roundPanel(1,color, color);
            Line.SetBounds(x,y,length,width);
            panel.Controls.Add(Line);
        }
    }

    public class NotificationPanel : roundPanel {
        public NotificationPanel(int r, Color s, Color e) : base(r, s, e) {
            this.Hide();
            
            roundPanel Background = new roundPanel(50,Color.White, Color.White);
            Background.SetBounds(10,10,350,630);
            this.Controls.Add(Background);

            PictureBox InboxIcon = new PictureBox() {
                Image = Image.FromFile("C:\\Users\\user\\Desktop\\CoreConnect\\CoreConnectSRC\\CoreConnect\\Enviroment\\InstructorViewPort\\Image & Icon\\Images\\Inbox Logo.png"),
                BackgroundImageLayout = ImageLayout.None
            };
            InboxIcon.SetBounds(17,-50,300,300);
            Background.Controls.Add(InboxIcon);
            
            
            Label label = new Label();
            label.SetBounds(19,220,300,150);
            label.Font = new Font( "Folklore", 60, FontStyle.Bold);
            label.Text = "Inbox";
            InboxIcon.Controls.Add(label);
            
            Line(Background, 30,270,280,1,Color.Black); 
            Label RecivedMailLabel = new Label();
            TextFormat(Background, RecivedMailLabel, "Mail", 40, 285, 150, 25);
            
            Line(Background, 30,320,280,1,Color.Black);
            Label SendMailLabel = new Label();
            TextFormat(Background, SendMailLabel, "Send", 40, 335, 150, 25);
            
            Line(Background, 30,370,280,1,Color.Black);
            Label AssignmentMailLabel = new Label();
            TextFormat(Background, AssignmentMailLabel, "Assignment Notification", 40, 385, 150, 25);
            
            Line(Background, 30,420,280,1,Color.Black);
            Label DeletedMailLabel = new Label();
            TextFormat(Background, DeletedMailLabel, "Deleted Mail", 40, 435, 150, 25);
            
            
            roundPanel Message = new roundPanel(50,Color.White, Color.White);
            Message.SetBounds(380, 10, 860, 630);
            this.Controls.Add(Message);
            
        }
        
        public void Line(roundPanel panel,int x, int y, int length, int width, Color color) {
            roundPanel Line = new roundPanel(1,color, color);
            Line.SetBounds(x,y,length,width);
            panel.Controls.Add(Line);
        }
        
        public void TextFormat(roundPanel panel,Label label,string s, int x, int y, int length, int width) {
            label.Text = s;
            label.SetBounds(x,y,length,width);
            label.Font = new Font("Arial", 18, FontStyle.Regular);
            panel.Controls.Add(label);
        }
    }

    public class CourseDetailsPanel : roundPanel {
        public CourseDetailsPanel(int r, Color s, Color e) : base(r, s, e) {
            this.Hide();
            
            Label label = new Label();
            label.SetBounds(0,0,250,250);
            label.Font = new Font("Arial", 10, FontStyle.Bold);
            label.Text = "Course Detail Panel";
            this.Controls.Add(label);
        }
    }
}