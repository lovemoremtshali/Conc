namespace Conc
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
            add_word_btn = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            remove1 = new RadioButton();
            remove2 = new RadioButton();
            conc = new Button();
            labelout = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(278, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // add_word_btn
            // 
            add_word_btn.Location = new Point(288, 97);
            add_word_btn.Name = "add_word_btn";
            add_word_btn.Size = new Size(75, 23);
            add_word_btn.TabIndex = 1;
            add_word_btn.Text = "Add Word";
            add_word_btn.UseVisualStyleBackColor = true;
            add_word_btn.Click += add_word_btn_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(144, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(382, 164);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 3;
            // 
            // remove1
            // 
            remove1.AutoSize = true;
            remove1.Location = new Point(146, 211);
            remove1.Name = "remove1";
            remove1.Size = new Size(71, 19);
            remove1.TabIndex = 4;
            remove1.TabStop = true;
            remove1.Text = "remove1";
            remove1.UseVisualStyleBackColor = true;
            remove1.CheckedChanged += remove1_CheckedChanged;
            // 
            // remove2
            // 
            remove2.AutoSize = true;
            remove2.Location = new Point(382, 208);
            remove2.Name = "remove2";
            remove2.Size = new Size(71, 19);
            remove2.TabIndex = 5;
            remove2.TabStop = true;
            remove2.Text = "remove2";
            remove2.UseVisualStyleBackColor = true;
            remove2.CheckedChanged += remove2_CheckedChanged;
            // 
            // conc
            // 
            conc.Location = new Point(294, 257);
            conc.Name = "conc";
            conc.Size = new Size(99, 23);
            conc.TabIndex = 6;
            conc.Text = "concatenate";
            conc.UseVisualStyleBackColor = true;
            conc.Click += conc_Click;
            // 
            // labelout
            // 
            labelout.AutoSize = true;
            labelout.BackColor = SystemColors.ActiveCaption;
            labelout.Location = new Point(164, 310);
            labelout.MinimumSize = new Size(350, 50);
            labelout.Name = "labelout";
            labelout.Size = new Size(350, 50);
            labelout.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelout);
            Controls.Add(conc);
            Controls.Add(remove2);
            Controls.Add(remove1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(add_word_btn);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button add_word_btn;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private RadioButton remove1;
        private RadioButton remove2;
        private Button conc;
        private Label labelout;
    }
}