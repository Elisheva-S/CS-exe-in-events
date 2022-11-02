using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events_Example
{
    public partial class Form1 : Form
    {
        public string name;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddToListenersList addToListenersList = new AddToListenersList();
            addToListenersList.Add(name);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }
        public void Check(String name)
        {
            if (name == "Miri" || name == "Sari")
            {
                MessageBox.Show("You Can't enter to my app!!");
            }
            else
            {
                MessageBox.Show("Welcome to " + name);
            }
        }
    }
}
