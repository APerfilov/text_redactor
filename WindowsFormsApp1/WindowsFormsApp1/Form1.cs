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
        string filename = "";
        string fname;
        bool filechanged;
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

        private void toolStripMenuItem2_Click(object sender, EventArgs e, string FileName)
        {
            //Если переменная с именем файла пустая
            //то вызываем диалог сохранения файла
            if (FileName == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog1.FileName;
                }
            }
            try
            {
                using (StreamWriter sw = new StreamWriter(FileName))
                {
                    sw.Write(richTextBox2.Text);
                }
                fname = FileName;
                filechanged = false;
            }
            catch
            {
                MessageBox.Show("Ошибка: Невозможно сохранить файл.");
            }
        }


        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string line = null;
            string text;

            openFileDialog2.InitialDirectory = "c:\\"; // путь дерриктории по умолчанию
            openFileDialog2.Filter = "Файл блокнота (*.txt)|*.txt|All files (*.*)|*.*"; //фильтр отображаемых файлов 
            openFileDialog2.FilterIndex = 1;//приоритетность фильтра
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
            }
        }
    }
}



