using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace StudentDatabase
{
    
    
    public partial class Form1 : Form
    {
        public static List<Student> myDb = new List<Student>();
        public static string filepath = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addf ad = new Addf();
            ad.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Showf sh = new Showf();
            sh.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Searchf se = new Searchf();
            se.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Editf ed = new Editf();
            ed.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select your Student DB file";
            ofd.Filter = "Student DB|*.dat";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                load(ofd);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static void load(OpenFileDialog ofd)
        {
            // Delete list data
            myDb = null;

            // Read data from XML
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));

            using (FileStream fs = File.OpenRead(ofd.FileName))
            {
                myDb = (List<Student>)serializer.Deserialize(fs);
            }
            filepath = ofd.FileName;   
        }
        public static void load()
        {
            // Delete list data
            myDb = null;

            // Read data from XML
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));

            using (FileStream fs = File.OpenRead(filepath))
            {
                myDb = (List<Student>)serializer.Deserialize(fs);
            } 
        }

        public static void create(SaveFileDialog sfd)
        {
            myDb = new List<Student>();
            using (Stream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
                serializer.Serialize(fs, myDb);
            }
            filepath = sfd.FileName;
        }

        public static void create()
        {
            using (Stream fs = new FileStream(filepath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
                serializer.Serialize(fs, myDb);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save your Student DB file";
            sfd.Filter = "Student DB|*.dat";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                create(sfd);
            }
                     
        }
    }
}
