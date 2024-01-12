namespace server
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
            textBox1 = new TextBox();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("うずらフォント", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(189, 20);
            label1.TabIndex = 0;
            label1.Text = "サーバーダウン通知";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 19);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(185, 40);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "設定";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 69);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(238, 331);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(175, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "最小化";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 450);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }
        

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private RichTextBox richTextBox1;
        private Button button2;
    }
}
