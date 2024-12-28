using System.Drawing;
using System.Windows.Forms;

namespace Enviroment.AdministrativeViewPort
{
    public partial class ClassFrame : Form
    {
        private ClassSchedulaing c = new ClassSchedulaing();
        public ClassFrame() {
            InitializeComponent();
            Size = new Size(1300,600);
            c.SetBounds(0,0,1150,400);
            Controls.Add(c);
        }
    }
}