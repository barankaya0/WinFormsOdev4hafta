namespace WinFormsOdev3hafta
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button5 = new Button();
            groupBox2 = new GroupBox();
            button4 = new Button();
            listBox2 = new ListBox();
            richTextBox1 = new RichTextBox();
            comboBox1 = new ComboBox();
            button3 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            textBox3 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(102, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 40);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 3;
            label1.Text = "Ad-Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 98);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 4;
            label2.Text = "Numara:";
            // 
            // button1
            // 
            button1.Location = new Point(115, 166);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightSalmon;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(276, 237);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri Ekleme";
            // 
            // button5
            // 
            button5.Location = new Point(85, 438);
            button5.Name = "button5";
            button5.Size = new Size(136, 29);
            button5.TabIndex = 7;
            button5.Text = "Şikayet Ara";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightSalmon;
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(listBox2);
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(listBox1);
            groupBox2.Location = new Point(319, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(481, 547);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bilgiler";
            // 
            // button4
            // 
            button4.Location = new Point(283, 208);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 6;
            button4.Text = "Sil";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(26, 432);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(443, 104);
            listBox2.TabIndex = 5;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(26, 257);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(443, 120);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(26, 398);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(193, 397);
            button3.Name = "button3";
            button3.Size = new Size(134, 29);
            button3.TabIndex = 2;
            button3.Text = "Şikayet Ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(107, 208);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Aktar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(107, 40);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(270, 144);
            listBox1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(85, 375);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(136, 27);
            textBox3.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 574);
            Controls.Add(textBox3);
            Controls.Add(button5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Şikayet Formu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
        private ComboBox comboBox1;
        private RichTextBox richTextBox1;
        private ListBox listBox2;
        private Button button4;
        private Button button5;
        private TextBox textBox3;
    }
}