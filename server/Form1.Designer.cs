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
            checkBox1 = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            button3 = new Button();
            label4 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("うずらフォント", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 9);
            label1.Name = "label1";
            label1.Size = new Size(189, 20);
            label1.TabIndex = 0;
            label1.Text = "サーバーダウン通知";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 19);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(185, 51);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "決定";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 183);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(248, 217);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(185, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "最小化";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 99);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(72, 16);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "1分に1回";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Font = new Font("うずらフォント", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(119, 21);
            label2.TabIndex = 0;
            label2.Text = "pingの送信頻度";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("うずらフォント", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(257, 11);
            label3.TabIndex = 7;
            label3.Text = "カスタム頻度を指定(秒数を入力してください)";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 19);
            textBox2.TabIndex = 8;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // button3
            // 
            button3.Location = new Point(118, 132);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "決定";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 38);
            label4.Name = "label4";
            label4.Size = new Size(101, 12);
            label4.TabIndex = 10;
            label4.Text = "ipまたはドメイン";
            // 
            // button4
            // 
            button4.Location = new Point(12, 415);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 11;
            button4.Text = "その他";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 450);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(checkBox1);
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
        private CheckBox checkBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Button button3;
        private Label label4;
        private Button button4;
    }
}
