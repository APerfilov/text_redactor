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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void новыйФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Modified = true;
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
            
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            openFileDialog2.InitialDirectory = "c:\\"; // путь дерриктории по умолчанию
            openFileDialog2.Filter = "Файл блокнота (*.txt)|*.txt|All files (*.*)|*.*"; //фильтр отображаемых файлов 
            openFileDialog2.FilterIndex = 1;//приоритетность фильтра
            openFileDialog2.RestoreDirectory = true; //возвращает ранее выбранный каталог
            if (openFileDialog2.ShowDialog() == DialogResult.OK) //показывает диалог открытия окна
            {
                string filename = openFileDialog2.FileName; //FileName - имя открываемого файла
                string text = File.ReadAllText(filename); // Содержимое файла
            }
            richTextBox2.Text = Text;
        }
    }
}
