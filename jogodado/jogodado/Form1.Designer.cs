namespace jogodado
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
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(104, 43);
            label1.Name = "label1";
            label1.Size = new Size(159, 46);
            label1.TabIndex = 0;
            label1.Text = "PLAYER 1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(541, 43);
            label2.Name = "label2";
            label2.Size = new Size(159, 46);
            label2.TabIndex = 1;
            label2.Text = "PLAYER 2";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(104, 128);
            button1.Name = "button1";
            button1.Size = new Size(159, 60);
            button1.TabIndex = 2;
            button1.Text = "JOGAR DADO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(541, 128);
            button2.Name = "button2";
            button2.Size = new Size(159, 60);
            button2.TabIndex = 3;
            button2.Text = "JOGAR DADO";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(84, 226);
            label3.Name = "label3";
            label3.Size = new Size(200, 28);
            label3.TabIndex = 4;
            label3.Text = "NÚMERO SORTEADO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(522, 226);
            label5.Name = "label5";
            label5.Size = new Size(200, 28);
            label5.TabIndex = 6;
            label5.Text = "NÚMERO SORTEADO";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(104, 313);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 34);
            textBox1.TabIndex = 8;
            textBox1.Text = "🎲 ";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(541, 313);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 34);
            textBox2.TabIndex = 9;
            textBox2.Text = "🎲 ";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(163, 269);
            label4.Name = "label4";
            label4.Size = new Size(39, 28);
            label4.TabIndex = 10;
            label4.Text = "🎲";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(599, 269);
            label6.Name = "label6";
            label6.Size = new Size(39, 28);
            label6.TabIndex = 11;
            label6.Text = "🎲";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "z";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label6;
    }
}
