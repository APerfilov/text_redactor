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

        private void toolStripMenuItem2_Click(object sender, EventArgs e, string filename)
        {
           
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string line = null;
            string text;
            
            openFileDialog2.InitialDirectory = "c:\\"; // путь дерриктории по умолчанию
            openFileDialog2.Filter = "TXT-файл (*.txt)|*.txt|RTF-файл (*.rtf)|*.rtf"; //фильтр отображаемых файлов 
            openFileDialog2.FilterIndex = 2;//приоритетность фильтра
            //openFileDialog2.Filter = "RTF-файл (*.rtf)|*.rtf|All files (*.*)|*.*"; //фильтр отображаемых файлов 
            //openFileDialog2.FilterIndex = 1;//приоритетность фильтра
            openFileDialog2.RestoreDirectory = true; //возвращает ранее выбранный каталог
            if (openFileDialog2.ShowDialog() == DialogResult.OK) //показывает диалог открытия окна
            {
                richTextBox2.Clear();
                filename = Convert.ToString(openFileDialog2.FileName); //FileName - имя открываемого файла
                string inf = Convert.ToString(File.OpenText(filename)); // Содержимое файла
                StreamReader sr = File.OpenText(filename);

                line = sr.ReadLine();

                while (line != null)
                {
                    richTextBox2.AppendText(line);
                    richTextBox2.AppendText("\r\n");
                    line = sr.ReadLine();
                }
                sr.Close();
                filechanged = true;// файл сохранён и может быть перезаписан
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
                richTextBox2.SaveFile(saveFileDialog1.FileName,RichTextBoxStreamType.PlainText); //сохранение из ричтекст

            }
            filechanged = true;// файл сохранён и может быть перезаписан
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (filechanged == true) // сохранение уже открытого файла
            {
                richTextBox2.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText); //сохранение из ричтекст
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
