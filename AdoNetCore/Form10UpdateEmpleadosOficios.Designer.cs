namespace AdoNetCore
{
    partial class Form10UpdateEmpleadosOficios
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
            lstOficios = new ListBox();
            label2 = new Label();
            lstEmpleados = new ListBox();
            label3 = new Label();
            txtIncremento = new TextBox();
            btnIncrementarSalarios = new Button();
            lblSumaSalarial = new Label();
            lblMediaSalarial = new Label();
            lblMaximoSalario = new Label();
            label4 = new Label();
            txtOficio = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 31);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Oficios";
            // 
            // lstOficios
            // 
            lstOficios.FormattingEnabled = true;
            lstOficios.Location = new Point(31, 54);
            lstOficios.Name = "lstOficios";
            lstOficios.Size = new Size(240, 204);
            lstOficios.TabIndex = 1;
            lstOficios.SelectedIndexChanged += lstOficios_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 31);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 2;
            label2.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(319, 54);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(240, 284);
            lstEmpleados.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(613, 107);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 4;
            label3.Text = "Incremento";
            label3.Click += label3_Click;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(613, 130);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(158, 27);
            txtIncremento.TabIndex = 5;
            // 
            // btnIncrementarSalarios
            // 
            btnIncrementarSalarios.Location = new Point(613, 192);
            btnIncrementarSalarios.Name = "btnIncrementarSalarios";
            btnIncrementarSalarios.Size = new Size(158, 66);
            btnIncrementarSalarios.TabIndex = 6;
            btnIncrementarSalarios.Text = "Incrementar salarios";
            btnIncrementarSalarios.UseVisualStyleBackColor = true;
            btnIncrementarSalarios.Click += btnIncrementarSalarios_Click;
            // 
            // lblSumaSalarial
            // 
            lblSumaSalarial.AutoSize = true;
            lblSumaSalarial.Location = new Point(31, 302);
            lblSumaSalarial.Name = "lblSumaSalarial";
            lblSumaSalarial.Size = new Size(112, 20);
            lblSumaSalarial.TabIndex = 7;
            lblSumaSalarial.Text = "lblSumaSalarial";
            lblSumaSalarial.Click += lblSumaSalarial_Click;
            // 
            // lblMediaSalarial
            // 
            lblMediaSalarial.AutoSize = true;
            lblMediaSalarial.Location = new Point(31, 342);
            lblMediaSalarial.Name = "lblMediaSalarial";
            lblMediaSalarial.Size = new Size(117, 20);
            lblMediaSalarial.TabIndex = 8;
            lblMediaSalarial.Text = "lblMediaSalarial";
            lblMediaSalarial.Click += lblMediaSalarial_Click;
            // 
            // lblMaximoSalario
            // 
            lblMaximoSalario.AutoSize = true;
            lblMaximoSalario.Location = new Point(31, 384);
            lblMaximoSalario.Name = "lblMaximoSalario";
            lblMaximoSalario.Size = new Size(126, 20);
            lblMaximoSalario.TabIndex = 9;
            lblMaximoSalario.Text = "lblMaximoSalario";
            lblMaximoSalario.Click += lblMaximoSalario_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(613, 31);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 10;
            label4.Text = "Oficio";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(613, 54);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(158, 27);
            txtOficio.TabIndex = 11;
            txtOficio.TextChanged += txtOficio_TextChanged;
            // 
            // Form10UpdateEmpleadosOficios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtOficio);
            Controls.Add(label4);
            Controls.Add(lblMaximoSalario);
            Controls.Add(lblMediaSalarial);
            Controls.Add(lblSumaSalarial);
            Controls.Add(btnIncrementarSalarios);
            Controls.Add(txtIncremento);
            Controls.Add(label3);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(lstOficios);
            Controls.Add(label1);
            Name = "Form10UpdateEmpleadosOficios";
            Text = "Form10UpdateEmpleadosOficios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstOficios;
        private Label label2;
        private ListBox lstEmpleados;
        private Label label3;
        private TextBox txtIncremento;
        private Button btnIncrementarSalarios;
        private Label lblSumaSalarial;
        private Label lblMediaSalarial;
        private Label lblMaximoSalario;
        private Label label4;
        private TextBox txtOficio;
    }
}