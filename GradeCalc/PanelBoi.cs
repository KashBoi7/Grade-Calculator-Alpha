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
    public partial class PanelBoi : UserControl
    {
  
        public PanelBoi(int x)
        {
            InitializeComponent();
            
       /*      textBox1=new TextBox();
             textBox2 = new TextBox();
             tex0);*/
            // Initialize the Panel control.
            this.Location = new Point(77, x * 58);
            this.Size = new Size(252, 58);
        /*    textBox1.Text = "";
            textBox1.Size = new Size(117, 30);
            textBox1.Anchor = AnchorStyles.None;*/


            // Add the Panel control to the form.
            // Add the Label and TextBox controls to the Panel.

         /*   this.Controls.Add(textBox1);
            this.Controls.Add(textBox2);

            this.Controls.Add(textBox3)*/;
        }

        private void PanelBoi_Load(object sender, EventArgs e)
        {

        }
       

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {


                if (e.Handled = !char.IsDigit(e.KeyChar))
                {

                }
            }
        }



        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {


                if (e.Handled = !char.IsDigit(e.KeyChar))
                {

                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
