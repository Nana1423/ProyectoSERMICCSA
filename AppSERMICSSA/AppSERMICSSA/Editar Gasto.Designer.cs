namespace AppSERMICSSA
{
    partial class Editar_Gasto
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
            PictureBox pictureBox1;
            label1 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.warning;
            pictureBox1.Image = Properties.Resources.warning;
            pictureBox1.Location = new Point(347, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(307, 20);
            label1.Name = "label1";
            label1.Size = new Size(168, 34);
            label1.TabIndex = 1;
            label1.Text = "Editar Gasto";
            // 
            // button1
            // 
            button1.Location = new Point(29, 20);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(29, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(267, 247);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gasto ZZZZZZ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(77, 76, 76);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(6, 159);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(242, 82);
            textBox4.TabIndex = 12;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(77, 76, 76);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(107, 104);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(141, 26);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(77, 76, 76);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(107, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(141, 26);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(77, 76, 76);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(107, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 26);
            textBox1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(6, 108);
            label5.Name = "label5";
            label5.Size = new Size(63, 18);
            label5.TabIndex = 9;
            label5.Text = "Subtotal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 138);
            label4.Name = "label4";
            label4.Size = new Size(87, 18);
            label4.TabIndex = 8;
            label4.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 68);
            label2.Name = "label2";
            label2.Size = new Size(80, 18);
            label2.TabIndex = 7;
            label2.Text = "Referencia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 29);
            label3.Name = "label3";
            label3.Size = new Size(61, 18);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(304, 191);
            label6.Name = "label6";
            label6.Size = new Size(191, 54);
            label6.TabIndex = 7;
            label6.Text = "Consulta con un supervisor\r\n de SERMICSSA antes de \r\neditar un gasto.";
            label6.TextAlign = ContentAlignment.TopCenter;
            label6.Click += label6_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(323, 261);
            button2.Name = "button2";
            button2.Size = new Size(152, 42);
            button2.TabIndex = 8;
            button2.Text = "Aceptar";
            button2.UseVisualStyleBackColor = false;
            // 
            // Editar_Gasto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 18, 35);
            ClientSize = new Size(503, 332);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Editar_Gasto";
            Text = "Editar_Gasto";
            Load += Editar_Gasto_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label6;
        private Button button2;
    }
}