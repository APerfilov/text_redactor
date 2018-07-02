namespace WindowsFormsApp1
{
    partial class paragraph
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Left_otst = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Right_otst = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Аlignment = new System.Windows.Forms.ComboBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Left_otst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Right_otst)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Right_otst);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Left_otst);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отступы";
            // 
            // Left_otst
            // 
            this.Left_otst.Location = new System.Drawing.Point(115, 19);
            this.Left_otst.Name = "Left_otst";
            this.Left_otst.Size = new System.Drawing.Size(46, 20);
            this.Left_otst.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "От левого края:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Right_otst
            // 
            this.Right_otst.Location = new System.Drawing.Point(115, 45);
            this.Right_otst.Name = "Right_otst";
            this.Right_otst.Size = new System.Drawing.Size(46, 20);
            this.Right_otst.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "От правого края:";
            // 
            // Аlignment
            // 
            this.Аlignment.FormattingEnabled = true;
            this.Аlignment.Items.AddRange(new object[] {
            "По центру",
            "По правому краю",
            "По левому краю"});
            this.Аlignment.Location = new System.Drawing.Point(207, 21);
            this.Аlignment.Name = "Аlignment";
            this.Аlignment.Size = new System.Drawing.Size(121, 21);
            this.Аlignment.TabIndex = 1;
            // 
            // OK
            // 
            this.OK.ForeColor = System.Drawing.Color.Black;
            this.OK.Location = new System.Drawing.Point(172, 103);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(253, 103);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // paragraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 140);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Аlignment);
            this.Controls.Add(this.groupBox1);
            this.Name = "paragraph";
            this.Text = "paragraph";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Left_otst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Right_otst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown Right_otst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Left_otst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Аlignment;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
    }
}