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
    public partial class Showf : Form
    {
        public Showf()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int j = 0;
            dataGridView1.Rows.Clear();

            if (comboBox1.SelectedIndex == 1)
            {
                j = 0;
                for (int i = 0; i < Form1.myDb.Count; i++)
                {

                    if (comboBox2.Text == Form1.myDb[i].sex)
                    {
                        showInGrid(i,j);
                        j++;
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                j = 0;
                for (int i = 0; i < Form1.myDb.Count; i++)
                {

                    if (comboBox2.Text == Form1.myDb[i].dept)
                    {
                        showInGrid(i,j);
                        j++;
                    }
                }

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                j = 0;
                for (int i = 0; i < Form1.myDb.Count; i++)
                {
                    
                    if (textBox1.Text == Form1.myDb[i].age)
                    {
                        showInGrid(i,j);
                        j++;
                    }
                }
            }
            else
            {
                j = 0;
                for (int i = 0; i < Form1.myDb.Count; i++)
                {
                    showInGrid(i,i);

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Showf_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> sex = new List<string>();
            List<string> dept = new List<string>();
            button1.Enabled = true;
            if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Hide();
                comboBox2.Show();
                comboBox2.Items.Clear();
                for (int i =0; i<Form1.myDb.Count; i++)
                {
          
                    if(!sex.Contains(Form1.myDb[i].sex))
                    {
                        
                        sex.Add(Form1.myDb[i].sex);
                        comboBox2.Items.Add(Form1.myDb[i].sex);
                    }
                }
                
                
            } else if(comboBox1.SelectedIndex == 2)
            {
                textBox1.Hide();
                comboBox2.Show();
                comboBox2.Items.Clear();
                for (int i = 0; i < Form1.myDb.Count; i++)
                {

                    if (!dept.Contains(Form1.myDb[i].dept))
                    {
                        dept.Add(Form1.myDb[i].dept);
                        comboBox2.Items.Add(Form1.myDb[i].dept);
                    }
                }
                
            }
            else if(comboBox1.SelectedIndex == 3)
            {
                comboBox2.Hide();
                textBox1.Show();
            } else
            {
                comboBox2.Hide();
                textBox1.Hide();
            }



                
        }
    }
}
