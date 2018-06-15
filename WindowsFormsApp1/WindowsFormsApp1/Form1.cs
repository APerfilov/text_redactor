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
        //StreamReader sr;
        string filename;
        string fname;
        bool filechanged;
        string new_name_file;
        int size;
        string font;
        public Form1()
        {
            InitializeComponent();
            richTextBox2.SelectionIndent = 35;
            richTextBox2.BulletIndent = 30;
          

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

        private void toolStripMenuItem2_Click(object sender, EventArgs e, string filename)
        {
           
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
                       
           
                richTextBox2.Clear();
                openFileDialog2.DefaultExt = "*.rtf| *,txt";
                openFileDialog2.Filter = "RTF Files|*.rtf| Файлы блокнота| *.txt";
                if (openFileDialog2.ShowDialog() == DialogResult.OK && openFileDialog2.FileName.Length > 0)
                {
                    richTextBox2.LoadFile(openFileDialog2.FileName);
                }
            
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = ""; //очистка экрана
            new_name_file = ""; // имя файла должно быть пустым
           
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "*.rtf|*.txt"; //Форматы текста в подписи по умолчанию
            
            saveFileDialog1.Filter = "RTF Files|*.rtf| TXT Files|*.txt"; // расширения текста
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length>0)
            {
                new_name_file = saveFileDialog1.FileName; // путь и имя файла
                richTextBox2.SaveFile(saveFileDialog1.FileName,RichTextBoxStreamType.RichText); //сохранение из ричтекст

            }
            filechanged = true;// файл сохранён и может быть перезаписан
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (filechanged == true) // сохранение уже открытого файла
            {
                richTextBox2.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText); //сохранение из ричтекст
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Bold_Click(object sender, EventArgs e)
        {

        }

        private void Font_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void шрифтToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBox2.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
               richTextBox2.SelectionFont = fontDialog1.Font; // изменения выделенного участка текста
              
              
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox2.SelectionColor = colorDialog1.Color;
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void абзацToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.SelectionFont
        }
    }
    
}
