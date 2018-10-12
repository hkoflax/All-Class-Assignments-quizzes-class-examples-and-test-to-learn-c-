using person;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<Person> listofCreatedPerson = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                Person aPerson = new Person(textBox1.Text);
                listofCreatedPerson.Add(aPerson);
                listBox1.DataSource = null;
                listBox1.DataSource = listofCreatedPerson;
                listBox1.DisplayMember = "Name";
                if(label3.Text!= "path")
                {
                    aPerson.Photo = label3.Text;
                }
                textBox1.Text = "";
                label3.Text = "path";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpeg |*.jpg";
            openFileDialog1.ShowDialog();
            label3.Text= openFileDialog1.FileName;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox1.ImageLocation = null;
            var result = listBox1.SelectedItem as Person;
            if (result.Photo!=null)
            {
                pictureBox1.ImageLocation = result.Photo; 
            }
        }
    }
}
