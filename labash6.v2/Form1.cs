using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labash6.v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Пример использования меню";
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MIClose.Checked == true)
            {
                e.Cancel = MessageBox.Show("Закрыть форму?", "Закрытие формы", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes;
            }
        }

        private void увеличитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 3;
        }

        private void уменьшитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Value -= 3;
            
        }

        private void progressBar1Value3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 3;
        }

        private void уменьшитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            progressBar1.Value -= 3;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form2 temp = new Form2();
            temp.ShowDialog();

        }

        private void модальнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 temp = new Form3();
            temp.Show(this);
        }

        private void формыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
