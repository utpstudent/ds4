namespace laboratorio12_2
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
            lblTitulo = new Label();
            lblNota1 = new Label();
            lblNota2 = new Label();
            label3 = new Label();
            txtBoxNota1 = new TextBox();
            txtBoxNota2 = new TextBox();
            txtBoxNota3 = new TextBox();
            btnPromedio = new Button();
            btnLimpiarCampos = new Button();
            btnSalir = new Button();
            lblNotaPromedio = new Label();
            txtBoxNotaPromedio = new TextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(395, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(134, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nota Promedio";
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Location = new Point(183, 71);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(106, 25);
            lblNota1.TabIndex = 1;
            lblNota1.Text = "NOTA No. 1";
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Location = new Point(183, 130);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(106, 25);
            lblNota2.TabIndex = 2;
            lblNota2.Text = "NOTA No. 2";
            lblNota2.Click += lblNota2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 198);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 3;
            label3.Text = "NOTA No. 3";
            // 
            // txtBoxNota1
            // 
            txtBoxNota1.Location = new Point(396, 68);
            txtBoxNota1.Name = "txtBoxNota1";
            txtBoxNota1.Size = new Size(179, 31);
            txtBoxNota1.TabIndex = 4;
            // 
            // txtBoxNota2
            // 
            txtBoxNota2.Location = new Point(396, 127);
            txtBoxNota2.Name = "txtBoxNota2";
            txtBoxNota2.Size = new Size(179, 31);
            txtBoxNota2.TabIndex = 5;
            txtBoxNota2.TextChanged += textBox2_TextChanged;
            // 
            // txtBoxNota3
            // 
            txtBoxNota3.Location = new Point(395, 198);
            txtBoxNota3.Name = "txtBoxNota3";
            txtBoxNota3.Size = new Size(179, 31);
            txtBoxNota3.TabIndex = 6;
            // 
            // btnPromedio
            // 
            btnPromedio.Location = new Point(165, 253);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(112, 71);
            btnPromedio.TabIndex = 7;
            btnPromedio.Text = "Calcular Promedio";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.Location = new Point(344, 253);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(112, 71);
            btnLimpiarCampos.TabIndex = 8;
            btnLimpiarCampos.Text = "Limpiar Campos";
            btnLimpiarCampos.UseVisualStyleBackColor = true;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(518, 253);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 71);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblNotaPromedio
            // 
            lblNotaPromedio.AutoSize = true;
            lblNotaPromedio.Location = new Point(219, 376);
            lblNotaPromedio.Name = "lblNotaPromedio";
            lblNotaPromedio.Size = new Size(134, 25);
            lblNotaPromedio.TabIndex = 10;
            lblNotaPromedio.Text = "Nota Promedio";
            lblNotaPromedio.Click += label4_Click;
            // 
            // txtBoxNotaPromedio
            // 
            txtBoxNotaPromedio.Location = new Point(396, 376);
            txtBoxNotaPromedio.Name = "txtBoxNotaPromedio";
            txtBoxNotaPromedio.Size = new Size(150, 31);
            txtBoxNotaPromedio.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBoxNotaPromedio);
            Controls.Add(lblNotaPromedio);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiarCampos);
            Controls.Add(btnPromedio);
            Controls.Add(txtBoxNota3);
            Controls.Add(txtBoxNota2);
            Controls.Add(txtBoxNota1);
            Controls.Add(label3);
            Controls.Add(lblNota2);
            Controls.Add(lblNota1);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNota1;
        private Label lblNota2;
        private Label label3;
        private TextBox txtBoxNota1;
        private TextBox txtBoxNota2;
        private TextBox txtBoxNota3;
        private Button btnPromedio;
        private Button btnLimpiarCampos;
        private Button btnSalir;
        private Label lblNotaPromedio;
        private TextBox txtBoxNotaPromedio;
    }
}
