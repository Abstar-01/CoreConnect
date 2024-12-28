using System.Drawing;
using System.Windows.Forms;

namespace Enviroment.InstructorViewPort
{
    public partial class Attendence : Form
    {
        public Attendence() {
            InitializeComponent();
            Size = new Size(1000, 500);
            AttendencePanel at = new AttendencePanel();
            at.Dock = DockStyle.Fill;
            Controls.Add(at);
        }
    }
}