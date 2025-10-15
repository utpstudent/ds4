namespace laboratorio12
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
            lblVelocidad = new Label();
            lblTiempo = new Label();
            txtBoxVelocidad = new TextBox();
            txtBoxSegundos = new TextBox();
            btnCalcularDistancia = new Button();
            btnLimpiarCampos = new Button();
            btnSalir = new Button();
            lblResultado = new Label();
            txtBoxResultado = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(216, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(434, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Programa que calcula la distancia recorrida en metros";
            lblTitulo.Click += label1_Click;
            // 
            // lblVelocidad
            // 
            lblVelocidad.AutoSize = true;
            lblVelocidad.Location = new Point(82, 118);
            lblVelocidad.Name = "lblVelocidad";
            lblVelocidad.Size = new Size(229, 25);
            lblVelocidad.TabIndex = 1;
            lblVelocidad.Text = "Ingrese la velocidad en m/s";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(82, 175);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(257, 25);
            lblTiempo.TabIndex = 2;
            lblTiempo.Text = "Ingrese el tiempo en segundos";
            lblTiempo.Click += label2_Click;
            // 
            // txtBoxVelocidad
            // 
            txtBoxVelocidad.Location = new Point(455, 118);
            txtBoxVelocidad.Name = "txtBoxVelocidad";
            txtBoxVelocidad.Size = new Size(195, 31);
            txtBoxVelocidad.TabIndex = 3;
            txtBoxVelocidad.TextChanged += txtBoxVelocidad_TextChanged;
            // 
            // txtBoxSegundos
            // 
            txtBoxSegundos.Location = new Point(455, 169);
            txtBoxSegundos.Name = "txtBoxSegundos";
            txtBoxSegundos.Size = new Size(195, 31);
            txtBoxSegundos.TabIndex = 4;
            txtBoxSegundos.TextChanged += txtBoxSegundos_TextChanged;
            // 
            // btnCalcularDistancia
            // 
            btnCalcularDistancia.Location = new Point(139, 239);
            btnCalcularDistancia.Name = "btnCalcularDistancia";
            btnCalcularDistancia.Size = new Size(112, 86);
            btnCalcularDistancia.TabIndex = 5;
            btnCalcularDistancia.Text = "Calcular Distancia Recorrida";
            btnCalcularDistancia.UseVisualStyleBackColor = true;
            btnCalcularDistancia.Click += button1_Click;
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.Location = new Point(313, 239);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(112, 86);
            btnLimpiarCampos.TabIndex = 6;
            btnLimpiarCampos.Text = "Limpiar Campos";
            btnLimpiarCampos.UseVisualStyleBackColor = true;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(493, 239);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 86);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(192, 385);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(94, 25);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "Resultado:";
            lblResultado.Click += label3_Click;
            // 
            // txtBoxResultado
            // 
            txtBoxResultado.Location = new Point(422, 382);
            txtBoxResultado.Name = "txtBoxResultado";
            txtBoxResultado.Size = new Size(150, 31);
            txtBoxResultado.TabIndex = 9;
            txtBoxResultado.TextChanged += txtBoxResultado_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(577, 385);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 10;
            label1.Text = "m";
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtBoxResultado);
            Controls.Add(lblResultado);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiarCampos);
            Controls.Add(btnCalcularDistancia);
            Controls.Add(txtBoxSegundos);
            Controls.Add(txtBoxVelocidad);
            Controls.Add(lblTiempo);
            Controls.Add(lblVelocidad);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblVelocidad;
        private Label lblTiempo;
        private TextBox txtBoxVelocidad;
        private TextBox txtBoxSegundos;
        private Button btnCalcularDistancia;
        private Button btnLimpiarCampos;
        private Button btnSalir;
        private Label lblResultado;
        private TextBox txtBoxResultado;
        private Label label1;
    }
}
