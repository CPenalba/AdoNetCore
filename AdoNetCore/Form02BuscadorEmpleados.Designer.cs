namespace AdoNetCore
{
    partial class Form02BuscadorEmpleados
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
            txtSalario = new TextBox();
            btnBuscarEmpleados = new Button();
            lstEmpleados = new ListBox();
            label2 = new Label();
            label3 = new Label();
            txtOficio = new TextBox();
            btnBuscarPorOficio = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 47);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 0;
            label1.Text = "Introduzca salario";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(59, 79);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(241, 27);
            txtSalario.TabIndex = 1;
            // 
            // btnBuscarEmpleados
            // 
            btnBuscarEmpleados.Location = new Point(59, 125);
            btnBuscarEmpleados.Name = "btnBuscarEmpleados";
            btnBuscarEmpleados.Size = new Size(241, 49);
            btnBuscarEmpleados.TabIndex = 2;
            btnBuscarEmpleados.Text = "Buscar empleados";
            btnBuscarEmpleados.UseVisualStyleBackColor = true;
            btnBuscarEmpleados.Click += btnBuscarEmpleados_Click;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(59, 255);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(602, 144);
            lstEmpleados.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 218);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 4;
            label2.Text = "Empleados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(420, 47);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 5;
            label3.Text = "Introduzca oficio";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(420, 79);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(241, 27);
            txtOficio.TabIndex = 6;
            // 
            // btnBuscarPorOficio
            // 
            btnBuscarPorOficio.Location = new Point(420, 125);
            btnBuscarPorOficio.Name = "btnBuscarPorOficio";
            btnBuscarPorOficio.Size = new Size(241, 48);
            btnBuscarPorOficio.TabIndex = 7;
            btnBuscarPorOficio.Text = "Buscar por oficio";
            btnBuscarPorOficio.UseVisualStyleBackColor = true;
            btnBuscarPorOficio.Click += btnBuscarPorOficio_Click;
            // 
            // Form02BuscadorEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscarPorOficio);
            Controls.Add(txtOficio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstEmpleados);
            Controls.Add(btnBuscarEmpleados);
            Controls.Add(txtSalario);
            Controls.Add(label1);
            Name = "Form02BuscadorEmpleados";
            Text = "Form02BuscadorEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSalario;
        private Button btnBuscarEmpleados;
        private ListBox lstEmpleados;
        private Label label2;
        private Label label3;
        private TextBox txtOficio;
        private Button btnBuscarPorOficio;
    }
}