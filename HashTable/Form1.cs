using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            csHashTable objHT = new csHashTable();
            string[] arInput = tbInput.Text.Split(' ');
            for (int i = 0; i < arInput.Length; i++)
            {
                objHT[i.ToString()] = arInput[i];
                tbOutput.Text += objHT[i.ToString()] + ": " + arInput[i] + "\r\n";
            }

            
        }
    }
}
