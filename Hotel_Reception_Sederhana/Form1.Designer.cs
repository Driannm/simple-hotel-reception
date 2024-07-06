namespace Hotel_Reception_Sederhana
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
            this.nama = new TextBox();
            pss = new TextBox();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(68, 96);
            label1.Name = "label1";
            label1.Size = new Size(96, 42);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            // 
            // nama
            // 
            this.nama.Location = new Point(248, 104);
            this.nama.Name = "nama";
            this.nama.Size = new Size(268, 25);
            this.nama.TabIndex = 2;
            // 
            // pss
            // 
            pss.Location = new Point(248, 175);
            pss.Name = "pss";
            pss.PasswordChar = '*';
            pss.Size = new Size(268, 25);
            pss.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(248, 260);
            button1.Name = "button1";
            button1.Size = new Size(97, 34);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(68, 169);
            label2.Name = "label2";
            label2.Size = new Size(142, 42);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // button2
            // 
            button2.Location = new Point(419, 260);
            button2.Name = "button2";
            button2.Size = new Size(97, 34);
            button2.TabIndex = 7;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(603, 402);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(pss);
            Controls.Add(this.nama);
            Controls.Add(label1);
            Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Halaman Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox pss;
        private Button button1;
        private Label label2;
        private Button button2;
    }
}