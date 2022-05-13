using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GradeCalc
{
    

    public partial class Form1 : Form
    {
        public int NumOfPanels = 4;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Form1()
        {
            InitializeComponent();
          
           
        }
       
    

    private void Form1_Load(object sender, EventArgs e)
        {





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        

        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            for(int i = 0; i < n; i++)
            {

            }
            panel7.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Height = panel2.Height + 58;
            Panel panel1= new Panel() ;
            
            panel1.Location = new Point(77, 272);
            
            NumOfPanels++;
            CreateMyPanel(NumOfPanels);


        }
        public void CreateMyPanel(int x)
{
   Panel panel1 = new Panel();
   TextBox textBox1 = new TextBox();
          TextBox textBox2 = new TextBox();
        TextBox textBox3 = new TextBox();
            textBox2.Size = new Size(55, 30);
            textBox2.Location = new Point(126, 12);
            textBox3.Size = new Size(55, 30);
            textBox3.Location = new Point(187, 12);
            // Initialize the Panel control.
            panel1.Location = new Point(77,x*58);
   panel1.Size = new Size(252, 52);
   // Set the Borderstyle for the Panel to three-dimensional.
   
       

   // Initialize the Label and TextBox controls.

   textBox1.Location = new Point(3,12);
   textBox1.Text = "";
   textBox1.Size = new Size(117, 30);
    

   // Add the Panel control to the form.
   panel2.Controls.Add(panel1);
   // Add the Label and TextBox controls to the Panel.
   
   panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);

            panel1.Controls.Add(textBox3);

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}