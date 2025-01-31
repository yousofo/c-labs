namespace day4.form
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
            button1 = new Button();
            num2 = new TextBox();
            num1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(291, 318);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(318, 32);
            button1.TabIndex = 2;
            button1.Text = "display";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // num2
            // 
            num2.HideSelection = false;
            num2.Location = new Point(291, 115);
            num2.Margin = new Padding(3, 4, 3, 4);
            num2.Name = "num2";
            num2.Size = new Size(318, 27);
            num2.TabIndex = 1;
            num2.Text = "0";
            num2.UseSystemPasswordChar = true;
            num2.TextChanged += num2_TextChanged;
            // 
            // num1
            // 
            num1.Location = new Point(291, 80);
            num1.Margin = new Padding(3, 4, 3, 4);
            num1.Name = "num1";
            num1.Size = new Size(318, 27);
            num1.TabIndex = 0;
            num1.Text = "0";
            num1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(449, 166);
            button2.Name = "button2";
            button2.Size = new Size(83, 31);
            button2.TabIndex = 3;
            button2.Text = "*";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(291, 166);
            button3.Name = "button3";
            button3.Size = new Size(70, 31);
            button3.TabIndex = 4;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(538, 166);
            button4.Name = "button4";
            button4.Size = new Size(71, 31);
            button4.TabIndex = 5;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(372, 166);
            button5.Name = "button5";
            button5.Size = new Size(71, 31);
            button5.TabIndex = 6;
            button5.Text = "-";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(291, 213);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(318, 27);
            textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AccessibleDescription = "";
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(num2);
            Controls.Add(num1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox num2;
        private TextBox num1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox1;
    }
}
