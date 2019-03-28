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
    public partial class Editf : Form
    {
        public Editf()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int j = 0;
            dataGridView1.Rows.Clear();
                j = 0;
                for (int i = 0; i < Form1.myDb.Count; i++)
                {

                    if (textBox1.Text == Form1.myDb[i].studentNo)
                        showInGrid(i, i);
                }
           
        }
        public void showInGrid(int i, int j)
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[j].Cells[0].Value = Convert.ToString(Form1.myDb[i].studentNo);
            dataGridView1.Rows[j].Cells[1].Value = Convert.ToString(Form1.myDb[i].name);
            dataGridView1.Rows[j].Cells[2].Value = Convert.ToString(Form1.myDb[i].surname);
            dataGridView1.Rows[j].Cells[3].Value = Convert.ToString(Form1.myDb[i].dept);
            dataGridView1.Rows[j].Cells[4].Value = Convert.ToString(Form1.myDb[i].sex);
            dataGridView1.Rows[j].Cells[5].Value = Convert.ToString(Form1.myDb[i].placeOfBirth);
            dataGridView1.Rows[j].Cells[6].Value = Convert.ToString(Form1.myDb[i].age);
            dataGridView1.Rows[j].Cells[7].Value = Convert.ToString(Form1.myDb[i].phone);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           



        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.myDb.Count; i++)
            {

                if (dataGridView1.Rows[0].Cells[0].Value.ToString() == Form1.myDb[i].studentNo)
                {
                    Form1.myDb[i].name = dataGridView1.Rows[0].Cells[1].Value.ToString();
                    Form1.myDb[i].surname = dataGridView1.Rows[0].Cells[2].Value.ToString();
                    Form1.myDb[i].dept = dataGridView1.Rows[0].Cells[3].Value.ToString();
                    Form1.myDb[i].sex = dataGridView1.Rows[0].Cells[4].Value.ToString();
                    Form1.myDb[i].placeOfBirth = dataGridView1.Rows[0].Cells[5].Value.ToString();
                    Form1.myDb[i].age = dataGridView1.Rows[0].Cells[6].Value.ToString();
                    Form1.myDb[i].phone = dataGridView1.Rows[0].Cells[7].Value.ToString();
                }
            }
            Form1.create();
        }
    }
}
