namespace task1_c
{
    partial class Form1
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
            this.count = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReverse = new System.Windows.Forms.TextBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(227, 344);
            this.count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(203, 22);
            this.count.TabIndex = 12;
            this.count.Text = "Number of customers is:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(40, 98);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(119, 28);
            this.txtName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter customer\'s name";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(440, 98);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(157, 246);
            this.listBox1.TabIndex = 9;
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_remove.Location = new System.Drawing.Point(241, 201);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(97, 46);
            this.btn_remove.TabIndex = 8;
            this.btn_remove.Text = "Remove Customer";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_add.Location = new System.Drawing.Point(241, 107);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(97, 46);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add Customer";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "0 Customer details reversed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Enter customer\'s age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(40, 192);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(119, 28);
            this.txtAge.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Enter number to reverse";
            // 
            // txtReverse
            // 
            this.txtReverse.Location = new System.Drawing.Point(40, 297);
            this.txtReverse.Margin = new System.Windows.Forms.Padding(2);
            this.txtReverse.Name = "txtReverse";
            this.txtReverse.Size = new System.Drawing.Size(119, 28);
            this.txtReverse.TabIndex = 17;
            // 
            // btnReverse
            // 
            this.btnReverse.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnReverse.Location = new System.Drawing.Point(55, 337);
            this.btnReverse.Margin = new System.Windows.Forms.Padding(2);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(82, 46);
            this.btnReverse.TabIndex = 19;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = false;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(685, 474);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.txtReverse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.count);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label count;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReverse;
        private System.Windows.Forms.Button btnReverse;
    }
}

