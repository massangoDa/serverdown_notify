namespace server
{
    partial class Form2
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
            label1 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("うずらフォント", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(95, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Ping送信";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 45);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(120, 16);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "192.168.0.1～255";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(138, 45);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(120, 16);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "192.168.1.1～255";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(65, 12);
            label2.TabIndex = 3;
            label2.Text = "カスタムIP";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 19);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 117);
            label4.Name = "label4";
            label4.Size = new Size(89, 12);
            label4.TabIndex = 7;
            label4.Text = "(192.168.〇.）";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(13, 213);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(245, 225);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("うずらフォント", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(67, 191);
            label6.Name = "label6";
            label6.Size = new Size(149, 19);
            label6.TabIndex = 10;
            label6.Text = "Pingが通ったIP";
            // 
            // button1
            // 
            button1.Location = new Point(183, 154);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Ping";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_ClickAsync;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 450);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label4;
        private RichTextBox richTextBox1;
        private Label label6;
        private Button button1;
        private string PingIP;
    }
}