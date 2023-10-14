using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14._1_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileContent = File.ReadAllText($@"{textBox1.Text}");

            List<int> res = new List<int>();
            foreach (string line in fileContent.Split('\n'))
            {
                res.Add(int.Parse(line));
            }

            // Remove all Negative number
            res.RemoveAll(x => x < 0);
            res = res.FindAll(x => x >= 1 && x <= 10);

            listBox1.DataSource = res;
        }
    }
}
