namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtN = new TextBox();
            checkNum = new CheckBox();
            checkSum = new CheckBox();
            listBox = new ListBox();
            label2 = new Label();
            txtNum = new TextBox();
            txtSum = new TextBox();
            bt1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 40);
            label1.Name = "label1";
            label1.Size = new Size(173, 15);
            label1.TabIndex = 0;
            label1.Text = "Введити натуральное число N";
            label1.Click += label1_Click;
            // 
            // txtN
            // 
            txtN.Location = new Point(26, 74);
            txtN.Name = "txtN";
            txtN.Size = new Size(100, 23);
            txtN.TabIndex = 1;
            txtN.TextChanged += txtN_TextChanged;
            // 
            // checkNum
            // 
            checkNum.AutoSize = true;
            checkNum.Location = new Point(235, 142);
            checkNum.Name = "checkNum";
            checkNum.Size = new Size(127, 19);
            checkNum.TabIndex = 2;
            checkNum.Text = "Количество чисел";
            checkNum.UseVisualStyleBackColor = true;
            checkNum.CheckedChanged += checkNum_CheckedChanged;
            // 
            // checkSum
            // 
            checkSum.AutoSize = true;
            checkSum.Location = new Point(404, 142);
            checkSum.Name = "checkSum";
            checkSum.Size = new Size(100, 19);
            checkSum.TabIndex = 3;
            checkSum.Text = "Сумма чисел";
            checkSum.UseVisualStyleBackColor = true;
            checkSum.CheckedChanged += checkSum_CheckedChanged;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(26, 142);
            listBox.Name = "listBox";
            listBox.Size = new Size(158, 184);
            listBox.TabIndex = 4;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 355);
            label2.Name = "label2";
            label2.Size = new Size(144, 15);
            label2.TabIndex = 5;
            label2.Text = "Список чисел Фибоначи";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(235, 179);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(100, 23);
            txtNum.TabIndex = 6;
            txtNum.TextChanged += txtNum_TextChanged;
            // 
            // txtSum
            // 
            txtSum.Location = new Point(404, 179);
            txtSum.Name = "txtSum";
            txtSum.Size = new Size(100, 23);
            txtSum.TabIndex = 7;
            txtSum.TextChanged += txtSum_TextChanged;
            // 
            // bt1
            // 
            bt1.Location = new Point(297, 254);
            bt1.Name = "bt1";
            bt1.Size = new Size(146, 23);
            bt1.TabIndex = 8;
            bt1.Text = "Вычеслить";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(527, 450);
            Controls.Add(bt1);
            Controls.Add(txtSum);
            Controls.Add(txtNum);
            Controls.Add(label2);
            Controls.Add(listBox);
            Controls.Add(checkSum);
            Controls.Add(checkNum);
            Controls.Add(txtN);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtN;
        private CheckBox checkNum;
        private CheckBox checkSum;
        private ListBox listBox;
        private Label label2;
        private TextBox txtNum;
        private TextBox txtSum;
        private Button bt1;
    }
}
