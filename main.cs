using System;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string str = "Clone() Test";
                string clonedString = null;
                clonedString = (String)str.Clone();
                MessageBox.Show (clonedString);
            }
        }
    }
}