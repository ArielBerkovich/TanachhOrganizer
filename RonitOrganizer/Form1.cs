using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RonitOrganizer
{
    public partial class Form1 : Form
    {
        Random rnd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rnd = new Random();
            init_panel();
        }

        private void init_panel()
        {
            initAll();
        }

        private void initAll()
        {
            string[] dirs = Directory.GetDirectories(Constants.MeterialsBaseFolder, "*", SearchOption.TopDirectoryOnly);
            foreach (String dir in dirs)
            {
               new MaterialPanel(panel1, dir);
            }
        }

        private void initByFilter(String text)
        {
            string[] dirs = Directory.GetDirectories(Constants.MeterialsBaseFolder, "*", SearchOption.TopDirectoryOnly);
            foreach (String dir in dirs)
            {
                if(dir.Contains(text))
                new MaterialPanel(panel1, dir);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


       
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Genesis.BackColor = Color.SlateGray;
            Shmot.BackColor = Color.SlateGray;
            Vaikra.BackColor = Color.SlateGray;
            button2.BackColor = Color.Yellow;
            initAll();
        }

        private void Genesis_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Genesis.BackColor = Color.Yellow;
            Shmot.BackColor = Color.SlateGray;
            Vaikra.BackColor = Color.SlateGray;
            button2.BackColor = Color.SlateGray;
            initByFilter("בראשית");
        }
        private void Shmot_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Genesis.BackColor = Color.SlateGray;
            Shmot.BackColor = Color.Yellow;
            Vaikra.BackColor = Color.SlateGray;
            button2.BackColor = Color.SlateGray;
            initByFilter("שמות");
        }

        private void Vaikra_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Genesis.BackColor = Color.SlateGray;
            Shmot.BackColor = Color.SlateGray;
            Vaikra.BackColor = Color.Yellow;
            button2.BackColor = Color.SlateGray;
            initByFilter("ויקרא");
        }
    }
}
