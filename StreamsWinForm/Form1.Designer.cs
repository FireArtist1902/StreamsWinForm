namespace StreamsWinForm
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
            MinNumsTB = new TextBox();
            MaxTB = new TextBox();
            SubmitNumBtn = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            Task2Btn = new Button();
            SuspendLayout();
            // 
            // MinNumsTB
            // 
            MinNumsTB.Location = new Point(12, 35);
            MinNumsTB.Name = "MinNumsTB";
            MinNumsTB.PlaceholderText = "min";
            MinNumsTB.Size = new Size(125, 27);
            MinNumsTB.TabIndex = 0;
            // 
            // MaxTB
            // 
            MaxTB.Location = new Point(12, 77);
            MaxTB.Name = "MaxTB";
            MaxTB.PlaceholderText = "Max";
            MaxTB.Size = new Size(125, 27);
            MaxTB.TabIndex = 1;
            // 
            // SubmitNumBtn
            // 
            SubmitNumBtn.Location = new Point(12, 120);
            SubmitNumBtn.Name = "SubmitNumBtn";
            SubmitNumBtn.Size = new Size(94, 29);
            SubmitNumBtn.TabIndex = 2;
            SubmitNumBtn.Text = "Submit";
            SubmitNumBtn.UseVisualStyleBackColor = true;
            SubmitNumBtn.Click += SubmitNumBtn_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(143, 35);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(222, 114);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 170);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 4;
            label1.Text = "Прості числа";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(371, 128);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 7;
            label2.Text = "Числа до 10000";
            // 
            // Task2Btn
            // 
            Task2Btn.Location = new Point(371, 78);
            Task2Btn.Name = "Task2Btn";
            Task2Btn.Size = new Size(94, 29);
            Task2Btn.TabIndex = 6;
            Task2Btn.Text = "Task2";
            Task2Btn.UseVisualStyleBackColor = true;
            Task2Btn.Click += Task2Btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(Task2Btn);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(SubmitNumBtn);
            Controls.Add(MaxTB);
            Controls.Add(MinNumsTB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MinNumsTB;
        private TextBox MaxTB;
        private Button SubmitNumBtn;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Button Task2Btn;
    }
}