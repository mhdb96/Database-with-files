using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDatabase
{
    public partial class Addf : Form
    {
        
        public Addf()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addf_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool exist=false;
            Student st = new Student();
            st.name = textBox1.Text;
            st.surname = textBox2.Text;
            st.studentNo = textBox3.Text;
            st.dept = textBox4.Text;
            st.sex = comboBox1.Text;
            st.placeOfBirth = textBox6.Text;
            st.age = textBox7.Text;
            st.phone = textBox9.Text;
            for (int i = 0; i < Form1.myDb.Count; i++)
            {
                if (st.studentNo == Form1.myDb[i].studentNo)
                {
                    MessageBox.Show("This number is already existed");
                    exist = true;
                }
            }
            if(!exist)
            {
                Form1.myDb.Add(st);
                Form1.create();
                this.Close();
            }         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
