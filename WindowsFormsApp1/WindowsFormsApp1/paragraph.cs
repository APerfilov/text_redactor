using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class paragraph : Form
    {
        public paragraph()
        {
            InitializeComponent();
            Form1 frm = new (Form1)this.Owner();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            int right;
            int left;
            right = Decimal.ToInt16(Right_otst.Value);
            left = Decimal.ToInt16(Left_otst.Value);
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
