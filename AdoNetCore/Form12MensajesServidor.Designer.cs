namespace AdoNetCore
{
    partial class Form12MensajesServidor
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNumero = new TextBox();
            txtNombre = new TextBox();
            txtLocalidad = new TextBox();
            label4 = new Label();
            btnInsertar = new Button();
            lstDepartamentos = new ListBox();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 40);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 133);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 218);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Localidad";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(57, 63);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(149, 27);
            txtNumero.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(57, 156);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(210, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(57, 241);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(210, 27);
            txtLocalidad.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(345, 40);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 6;
            label4.Text = "Departamentos";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(57, 300);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(210, 38);
            btnInsertar.TabIndex = 7;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(345, 63);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(432, 304);
            lstDepartamentos.TabIndex = 8;
            lstDepartamentos.SelectedIndexChanged += lstDepartamentos_SelectedIndexChanged;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(57, 388);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(81, 20);
            lblMensaje.TabIndex = 9;
            lblMensaje.Text = "lblMensaje";
            // 
            // Form12MensajesServidor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMensaje);
            Controls.Add(lstDepartamentos);
            Controls.Add(btnInsertar);
            Controls.Add(label4);
            Controls.Add(txtLocalidad);
            Controls.Add(txtNombre);
            Controls.Add(txtNumero);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form12MensajesServidor";
            Text = "Form12MensajesServidor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNumero;
        private TextBox txtNombre;
        private TextBox txtLocalidad;
        private Label label4;
        private Button btnInsertar;
        private ListBox lstDepartamentos;
        private Label lblMensaje;
    }
}