﻿
namespace _1st_try
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
            label5 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            button3 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AccessibleRole = AccessibleRole.ButtonMenu;
            label5.AutoSize = true;
            label5.Location = new Point(310, 263);
            label5.Name = "label5";
            label5.Size = new Size(202, 20);
            label5.TabIndex = 9;
            label5.Text = "Your message will show here!";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26" });
            comboBox1.Location = new Point(91, 127);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += CB1_Rotor3;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26" });
            comboBox2.Location = new Point(310, 127);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(138, 28);
            comboBox2.TabIndex = 11;
            comboBox2.SelectedIndexChanged += CB2_Rotor2;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26" });
            comboBox3.Location = new Point(531, 127);
            comboBox3.Margin = new Padding(3, 4, 3, 4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(138, 28);
            comboBox3.TabIndex = 12;
            comboBox3.SelectedIndexChanged += CB3_Rotor1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 221);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 14;
            label1.Text = "Enter your text below!";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(90, 263);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(139, 152);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(713, 488);
            button1.Name = "button1";
            button1.Size = new Size(138, 37);
            button1.TabIndex = 18;
            button1.TabStop = false;
            button1.Text = "New Message";
            button1.UseVisualStyleBackColor = true;
            button1.Click += NewMessage;
            // 
            // button2
            // 
            button2.Location = new Point(90, 488);
            button2.Name = "button2";
            button2.Size = new Size(138, 37);
            button2.TabIndex = 19;
            button2.TabStop = false;
            button2.Text = "Decrypt";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Decryption;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(655, 40);
            label3.Name = "label3";
            label3.Size = new Size(17, 20);
            label3.TabIndex = 20;
            label3.Text = "  ";
            // 
            // button3
            // 
            button3.Location = new Point(91, 444);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(139, 37);
            button3.TabIndex = 21;
            button3.Text = "Encrypt";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Encryption;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 12);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(49, 24);
            radioButton1.TabIndex = 22;
            radioButton1.TabStop = true;
            radioButton1.Text = "EN";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 42);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(49, 24);
            radioButton2.TabIndex = 23;
            radioButton2.TabStop = true;
            radioButton2.Text = "BG";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 94);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 24;
            label2.Text = "Rotor 1";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(310, 94);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 25;
            label4.Text = "Rotor 2";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(531, 94);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 26;
            label6.Text = "Rotor 3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(914, 600);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label1;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private Label label3;
        private Button button3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label2;
        private Label label4;
        private Label label6;
    }
}
