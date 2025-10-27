namespace Laboratorio14
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            lblBuscar = new Label();
            lblNombre = new Label();
            lblId = new Label();
            lblPrecio = new Label();
            lblStock = new Label();
            txtNombre = new TextBox();
            txtId = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            btnSalir = new Button();
            txtBuscarId = new TextBox();
            tsbNuevo = new PictureBox();
            tsbGuardar = new PictureBox();
            tsbCancelar = new PictureBox();
            tsbEliminar = new PictureBox();
            tsbBuscar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)tsbNuevo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbGuardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbCancelar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbBuscar).BeginInit();
            SuspendLayout();
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 12F);
            lblBuscar.Location = new Point(209, 13);
            lblBuscar.Margin = new Padding(4, 0, 4, 0);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(158, 32);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar por Id:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F);
            lblNombre.Location = new Point(257, 140);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(85, 28);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 10F);
            lblId.Location = new Point(33, 140);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(29, 28);
            lblId.TabIndex = 2;
            lblId.Text = "Id";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 10F);
            lblPrecio.Location = new Point(33, 238);
            lblPrecio.Margin = new Padding(4, 0, 4, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(66, 28);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 10F);
            lblStock.Location = new Point(257, 252);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(60, 28);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(257, 170);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(681, 31);
            txtNombre.TabIndex = 5;
            // 
            // txtId
            // 
            txtId.Location = new Point(33, 170);
            txtId.Margin = new Padding(4, 5, 4, 5);
            txtId.Name = "txtId";
            txtId.Size = new Size(141, 31);
            txtId.TabIndex = 6;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(33, 272);
            txtPrecio.Margin = new Padding(4, 5, 4, 5);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(141, 31);
            txtPrecio.TabIndex = 7;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(257, 282);
            txtStock.Margin = new Padding(4, 5, 4, 5);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(141, 31);
            txtStock.TabIndex = 8;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(68, 324);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(129, 50);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtBuscarId
            // 
            txtBuscarId.Location = new Point(366, 13);
            txtBuscarId.Margin = new Padding(4, 5, 4, 5);
            txtBuscarId.Name = "txtBuscarId";
            txtBuscarId.Size = new Size(167, 31);
            txtBuscarId.TabIndex = 10;
            // 
            // tsbNuevo
            // 
            tsbNuevo.BackgroundImage = (Image)resources.GetObject("tsbNuevo.BackgroundImage");
            tsbNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            tsbNuevo.InitialImage = null;
            tsbNuevo.Location = new Point(31, 10);
            tsbNuevo.Margin = new Padding(4, 5, 4, 5);
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(49, 42);
            tsbNuevo.TabIndex = 11;
            tsbNuevo.TabStop = false;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbGuardar
            // 
            tsbGuardar.BackColor = SystemColors.ControlLight;
            tsbGuardar.BackgroundImage = (Image)resources.GetObject("tsbGuardar.BackgroundImage");
            tsbGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            tsbGuardar.Location = new Point(89, 9);
            tsbGuardar.Margin = new Padding(4, 5, 4, 5);
            tsbGuardar.Name = "tsbGuardar";
            tsbGuardar.Size = new Size(36, 42);
            tsbGuardar.TabIndex = 12;
            tsbGuardar.TabStop = false;
            tsbGuardar.Click += tsbGuardar_Click;
            // 
            // tsbCancelar
            // 
            tsbCancelar.BackgroundImage = (Image)resources.GetObject("tsbCancelar.BackgroundImage");
            tsbCancelar.BackgroundImageLayout = ImageLayout.Zoom;
            tsbCancelar.Location = new Point(134, 10);
            tsbCancelar.Margin = new Padding(4, 5, 4, 5);
            tsbCancelar.Name = "tsbCancelar";
            tsbCancelar.Size = new Size(36, 42);
            tsbCancelar.TabIndex = 13;
            tsbCancelar.TabStop = false;
            tsbCancelar.Click += tsbCancelar_Click;
            // 
            // tsbEliminar
            // 
            tsbEliminar.BackgroundImage = (Image)resources.GetObject("tsbEliminar.BackgroundImage");
            tsbEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            tsbEliminar.Location = new Point(179, 10);
            tsbEliminar.Margin = new Padding(4, 5, 4, 5);
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(36, 42);
            tsbEliminar.TabIndex = 14;
            tsbEliminar.TabStop = false;
            tsbEliminar.Click += tsbEliminar_Click;
            // 
            // tsbBuscar
            // 
            tsbBuscar.BackgroundImage = (Image)resources.GetObject("tsbBuscar.BackgroundImage");
            tsbBuscar.BackgroundImageLayout = ImageLayout.Zoom;
            tsbBuscar.Location = new Point(533, 11);
            tsbBuscar.Margin = new Padding(4, 5, 4, 5);
            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Size = new Size(36, 42);
            tsbBuscar.TabIndex = 15;
            tsbBuscar.TabStop = false;
            tsbBuscar.Click += tsbBuscar_Click;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 467);
            Controls.Add(tsbBuscar);
            Controls.Add(tsbEliminar);
            Controls.Add(tsbCancelar);
            Controls.Add(tsbGuardar);
            Controls.Add(tsbNuevo);
            Controls.Add(txtBuscarId);
            Controls.Add(btnSalir);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtId);
            Controls.Add(txtNombre);
            Controls.Add(lblStock);
            Controls.Add(lblPrecio);
            Controls.Add(lblId);
            Controls.Add(lblNombre);
            Controls.Add(lblBuscar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmProductos";
            Text = "Productos";
            Load += frmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)tsbNuevo).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbGuardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbCancelar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbEliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbBuscar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBuscar;
        private Label lblNombre;
        private Label lblId;
        private Label lblPrecio;
        private Label lblStock;
        private TextBox txtNombre;
        private TextBox txtId;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Button btnSalir;
        private TextBox txtBuscarId;
        private PictureBox tsbNuevo;
        private PictureBox tsbGuardar;
        private PictureBox tsbCancelar;
        private PictureBox tsbEliminar;
        private PictureBox tsbBuscar;
    }
}