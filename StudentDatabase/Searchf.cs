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
    public partial class Searchf : Form
    {
        public Searchf()
        {
            InitializeComponent();
        }

        private void Searchf_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                button1.Enabled=true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int j = 0;
            dataGridView1.Rows.Clear();

            if (comboBox1.SelectedIndex == 0)
            {
                j = 0;
                for (int i = 0; i < Form1.myDb.Count; i++)
                {

                    if (textBox1.Text == Form1.myDb[i].studentNo)
                    {
                        showInGrid(i, j);
                        j++;
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                j = 0;
                for (int i = 0; i < Form1.myDb.Count; i++)
                {

                    if (textBox1.Text == Form1.myDb[i].name)
                    {
                        showInGrid(i, j);
                        j++;
                    }
                }

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                j = 0;
                for (int i = 0; i < Form1.myDb.Count; i++)
                {

                    if (textBox1.Text == Form1.myDb[i].surname)
                    {
                        showInGrid(i, j);
                        j++;
                    }
                }
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
    }
}
