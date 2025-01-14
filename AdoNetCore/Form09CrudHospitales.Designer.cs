namespace AdoNetCore
{
    partial class Form09CrudHospitales
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
            btnEliminar = new Button();
            btnModificar = new Button();
            btnInsertar = new Button();
            txtDireccion = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            lstHospitales = new ListBox();
            label1 = new Label();
            label5 = new Label();
            txtTelefono = new TextBox();
            label6 = new Label();
            txtNumCama = new TextBox();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = Color.Red;
            btnEliminar.Location = new Point(619, 372);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(217, 44);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(619, 311);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(217, 44);
            btnModificar.TabIndex = 20;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(619, 249);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(217, 45);
            btnInsertar.TabIndex = 19;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(477, 204);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(217, 27);
            txtDireccion.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(477, 181);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 17;
            label4.Text = "Direccion";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(477, 132);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(217, 27);
            txtNombre.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(477, 109);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 15;
            label3.Text = "Nombre";
            // 
            // txtId
            // 
            txtId.Location = new Point(477, 58);
            txtId.Name = "txtId";
            txtId.Size = new Size(126, 27);
            txtId.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(477, 35);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 13;
            label2.Text = "Id";
            // 
            // lstHospitales
            // 
            lstHospitales.FormattingEnabled = true;
            lstHospitales.Location = new Point(38, 70);
            lstHospitales.Name = "lstHospitales";
            lstHospitales.Size = new Size(393, 324);
            lstHospitales.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 35);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 11;
            label1.Text = "Hospitales";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(756, 35);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 22;
            label5.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(756, 58);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(217, 27);
            txtTelefono.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(756, 109);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 24;
            label6.Text = "Numero cama";
            // 
            // txtNumCama
            // 
            txtNumCama.Location = new Point(756, 132);
            txtNumCama.Name = "txtNumCama";
            txtNumCama.Size = new Size(217, 27);
            txtNumCama.TabIndex = 25;
            // 
            // Form09CrudHospitales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 450);
            Controls.Add(txtNumCama);
            Controls.Add(label6);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(txtDireccion);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(lstHospitales);
            Controls.Add(label1);
            Name = "Form09CrudHospitales";
            Text = "Form09CrudHospitales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnModificar;
        private Button btnInsertar;
        private TextBox txtDireccion;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtId;
        private Label label2;
        private ListBox lstHospitales;
        private Label label1;
        private Label label5;
        private TextBox txtTelefono;
        private Label label6;
        private TextBox txtNumCama;
    }
}