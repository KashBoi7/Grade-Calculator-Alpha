using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCalc
{
    public partial class UserControl1 : UserControl
    {
        public int NumOfPanels = 4;
        public float FinalGrade = 0;
        public List<TextBox> Grade = new List<TextBox>();
        public List<TextBox> Weight = new List<TextBox>();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
