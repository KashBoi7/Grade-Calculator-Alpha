using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GradeCalc
{
    

    public partial class Form1 : Form
    {
        public int NumOfPanels = 4;
        public List<TextBox> Grade = new List<TextBox>();
        public List<TextBox> Weight=new List<TextBox> ();
        
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
            CreateMyPanel(1);
            CreateMyPanel(2);
            CreateMyPanel(3);
            CreateMyPanel(4);
            Console.WriteLine(Weight.Count);



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

            
            NumOfPanels++;
            CreateMyPanel(NumOfPanels);

            


        }
       
        public void CreateMyPanel(int x)
{
            PanelBoi panel = new PanelBoi(x);
            panel2.Controls.Add(panel);
            Grade.Add(panel.textBox5);
            Weight.Add(panel.textBox6);



        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

   


        }
}