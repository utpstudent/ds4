namespace laboratorio13
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
            btnConexion = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnConexion
            // 
            btnConexion.Location = new Point(291, 40);
            btnConexion.Name = "btnConexion";
            btnConexion.Size = new Size(193, 65);
            btnConexion.TabIndex = 0;
            btnConexion.Text = "Conectar y desconectar SQL Server";
            btnConexion.UseVisualStyleBackColor = true;
            btnConexion.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(221, 135);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(322, 229);
            listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(btnConexion);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnConexion;
        private ListBox listBox1;
    }
}
