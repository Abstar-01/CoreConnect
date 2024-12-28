using System.Drawing;
using System.Windows.Forms;

namespace Enviroment.StudentViewPort {
    
    public class ProfilePagePanel : roundPanel {
        public ProfilePagePanel(int r, Color s, Color e) : base(r, s, e) {
            this.DoubleBuffered = true;
            Label label = new Label();
            label.Text = "Profile Page";
            label.SetBounds(0,0,450,200);
            label.Font = new Font("arial", 50, FontStyle.Bold);
            Controls.Add(label);
            
            
            
            
            
            
        }
    }
}