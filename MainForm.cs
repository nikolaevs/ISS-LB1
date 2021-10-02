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


namespace ISS_LB1
{
    public partial class MainForm : Form
    {
        string MsgFile="";
        string KeyFile="";
        string CipherFile = "";
        public MainForm()
        {
            InitializeComponent();
        }

        //private void открытьТекстToolStripMenuItem_Click(object sender, EventArgs e)

        private void SaveFile_Click(object sender, EventArgs e)
        {
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            

        }

        private void openMsg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = File.OpenText(openFileDialog1.FileName))
                    textBox1.Text = sr.ReadToEnd();
                MsgFile = openFileDialog1.FileName;
            }

        }

        private void saveMsg_Click(object sender, EventArgs e)
        {

            if (MsgFile=="")
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
                    MsgFile = saveFileDialog1.FileName;
                }
            }
            else
            {
                System.IO.File.WriteAllText(MsgFile, textBox1.Text);
            }

        }

        private void saveMsgAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
                MsgFile = saveFileDialog1.FileName;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                saveMsg.Enabled = true;           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                saveKey.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
                saveCipher.Enabled = true;
        }

        private void openKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = File.OpenText(openFileDialog1.FileName))
                    textBox2.Text = sr.ReadToEnd();
                MsgFile = openFileDialog1.FileName;
            }
        }

        private void saveKey_Click(object sender, EventArgs e)
        {
            if (KeyFile == "")
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(saveFileDialog1.FileName, textBox2.Text);
                    KeyFile = saveFileDialog1.FileName;
                }
            }
            else
            {
                System.IO.File.WriteAllText(KeyFile, textBox2.Text);
            }
        }

        private void saveKeyAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, textBox2.Text);
                KeyFile = saveFileDialog1.FileName;
            }
        }

        private void сгенерироватьЗановоToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openCipher_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = File.OpenText(openFileDialog1.FileName))
                    textBox3.Text = sr.ReadToEnd();
                CipherFile = openFileDialog1.FileName;
            }
        }

        private void saveCipher_Click(object sender, EventArgs e)
        {
            if (CipherFile == "")
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(saveFileDialog1.FileName, textBox3.Text);
                    CipherFile = saveFileDialog1.FileName;
                }
            }
            else
            {
                System.IO.File.WriteAllText(CipherFile, textBox3.Text);
            }
        }

        private void saveCipherAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, textBox3.Text);
                CipherFile = saveFileDialog1.FileName;
            }
        }
    }
}
