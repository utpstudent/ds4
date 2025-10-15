namespace laboratorio12_3
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
            lblLadoA = new Label();
            lblLadoB = new Label();
            lblLadoC = new Label();
            txtBoxLadoA = new TextBox();
            txtBoxLadoB = new TextBox();
            txtBoxLadoC = new TextBox();
            btnSemiperimetro = new Button();
            btnArea = new Button();
            btnLimpiarCampos = new Button();
            btnSalir = new Button();
            lblCalcularPerimetro = new Label();
            lblAreaTriangulo = new Label();
            txtBoxSemiperimetro = new TextBox();
            TxtBoxAreaTriangulo = new TextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(148, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(521, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Programa que calcula semiperimetro y area total de un triangulo";
            // 
            // lblLadoA
            // 
            lblLadoA.AutoSize = true;
            lblLadoA.Location = new Point(137, 72);
            lblLadoA.Name = "lblLadoA";
            lblLadoA.Size = new Size(232, 25);
            lblLadoA.TabIndex = 1;
            lblLadoA.Text = "Ingresa Longitud del lado A";
            lblLadoA.Click += lblLadoA_Click;
            // 
            // lblLadoB
            // 
            lblLadoB.AutoSize = true;
            lblLadoB.Location = new Point(139, 119);
            lblLadoB.Name = "lblLadoB";
            lblLadoB.Size = new Size(230, 25);
            lblLadoB.TabIndex = 2;
            lblLadoB.Text = "Ingrese Longitud del lado B";
            lblLadoB.Click += lblLadoB_Click;
            // 
            // lblLadoC
            // 
            lblLadoC.AutoSize = true;
            lblLadoC.Location = new Point(139, 169);
            lblLadoC.Name = "lblLadoC";
            lblLadoC.Size = new Size(231, 25);
            lblLadoC.TabIndex = 3;
            lblLadoC.Text = "Ingrese Longitud del lado C";
            lblLadoC.Click += label3_Click;
            // 
            // txtBoxLadoA
            // 
            txtBoxLadoA.Location = new Point(407, 66);
            txtBoxLadoA.Name = "txtBoxLadoA";
            txtBoxLadoA.Size = new Size(80, 31);
            txtBoxLadoA.TabIndex = 4;
            // 
            // txtBoxLadoB
            // 
            txtBoxLadoB.Location = new Point(407, 119);
            txtBoxLadoB.Name = "txtBoxLadoB";
            txtBoxLadoB.Size = new Size(80, 31);
            txtBoxLadoB.TabIndex = 5;
            // 
            // txtBoxLadoC
            // 
            txtBoxLadoC.Location = new Point(407, 169);
            txtBoxLadoC.Name = "txtBoxLadoC";
            txtBoxLadoC.Size = new Size(80, 31);
            txtBoxLadoC.TabIndex = 6;
            // 
            // btnSemiperimetro
            // 
            btnSemiperimetro.Location = new Point(103, 231);
            btnSemiperimetro.Name = "btnSemiperimetro";
            btnSemiperimetro.Size = new Size(146, 34);
            btnSemiperimetro.TabIndex = 7;
            btnSemiperimetro.Text = "Semiperimetro";
            btnSemiperimetro.UseVisualStyleBackColor = true;
            btnSemiperimetro.Click += btnSemiperimetro_Click;
            // 
            // btnArea
            // 
            btnArea.Location = new Point(274, 231);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(112, 34);
            btnArea.TabIndex = 8;
            btnArea.Text = "Area";
            btnArea.UseVisualStyleBackColor = true;
            btnArea.Click += btnArea_Click;
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.Location = new Point(416, 231);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(168, 34);
            btnLimpiarCampos.TabIndex = 9;
            btnLimpiarCampos.Text = "Limpiar Campos";
            btnLimpiarCampos.UseVisualStyleBackColor = true;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(618, 231);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblCalcularPerimetro
            // 
            lblCalcularPerimetro.AutoSize = true;
            lblCalcularPerimetro.Location = new Point(177, 312);
            lblCalcularPerimetro.Name = "lblCalcularPerimetro";
            lblCalcularPerimetro.Size = new Size(195, 25);
            lblCalcularPerimetro.TabIndex = 11;
            lblCalcularPerimetro.Text = "Calcular Semiperimetro";
            // 
            // lblAreaTriangulo
            // 
            lblAreaTriangulo.AutoSize = true;
            lblAreaTriangulo.Location = new Point(177, 371);
            lblAreaTriangulo.Name = "lblAreaTriangulo";
            lblAreaTriangulo.Size = new Size(154, 25);
            lblAreaTriangulo.TabIndex = 12;
            lblAreaTriangulo.Text = "Area del Triangulo";
            lblAreaTriangulo.Click += label1_Click;
            // 
            // txtBoxSemiperimetro
            // 
            txtBoxSemiperimetro.Location = new Point(460, 312);
            txtBoxSemiperimetro.Name = "txtBoxSemiperimetro";
            txtBoxSemiperimetro.Size = new Size(150, 31);
            txtBoxSemiperimetro.TabIndex = 13;
            txtBoxSemiperimetro.TextChanged += txtBoxCalcularPerimetro_TextChanged;
            // 
            // TxtBoxAreaTriangulo
            // 
            TxtBoxAreaTriangulo.Location = new Point(460, 365);
            TxtBoxAreaTriangulo.Name = "TxtBoxAreaTriangulo";
            TxtBoxAreaTriangulo.Size = new Size(150, 31);
            TxtBoxAreaTriangulo.TabIndex = 14;
            TxtBoxAreaTriangulo.TextChanged += TxtBoxAreaTriangulo_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtBoxAreaTriangulo);
            Controls.Add(txtBoxSemiperimetro);
            Controls.Add(lblAreaTriangulo);
            Controls.Add(lblCalcularPerimetro);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiarCampos);
            Controls.Add(btnArea);
            Controls.Add(btnSemiperimetro);
            Controls.Add(txtBoxLadoC);
            Controls.Add(txtBoxLadoB);
            Controls.Add(txtBoxLadoA);
            Controls.Add(lblLadoC);
            Controls.Add(lblLadoB);
            Controls.Add(lblLadoA);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblLadoA;
        private Label lblLadoB;
        private Label lblLadoC;
        private TextBox txtBoxLadoA;
        private TextBox txtBoxLadoB;
        private TextBox txtBoxLadoC;
        private Button btnSemiperimetro;
        private Button btnArea;
        private Button btnLimpiarCampos;
        private Button btnSalir;
        private Label lblCalcularPerimetro;
        private Label lblAreaTriangulo;
        private TextBox txtBoxSemiperimetro;
        private TextBox TxtBoxAreaTriangulo;
    }
}
