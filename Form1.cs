using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Playerbox_TextChanged(object sender, EventArgs e)
        {
           
        }
       // public string name=string.Empty;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Playerbox.Text == "" || string.IsNullOrEmpty(Playerbox.Text))
            {
                MessageBox.Show("Please Enter Your Name.");
            }
            else if (!(Playerbox.Text == "" )|| (!string.IsNullOrEmpty(Playerbox.Text)))
            {
                if (Playerbox.Text.Length <=20)
                {

                    Class1.name= Playerbox.Text;
                    

                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Name must be 20 or less than 20 char");
                }

                
            }
        }

       
    }
}
