namespace AdoNetCore
{
    partial class Form01PrimerAdo
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
            btnConectar = new Button();
            btnDesconectar = new Button();
            btnLeerDatos = new Button();
            lblResultado = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lstApellidos = new ListBox();
            lstColumnas = new ListBox();
            lstTiposDato = new ListBox();
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(38, 47);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(124, 39);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnDesconectar
            // 
            btnDesconectar.Location = new Point(38, 112);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(124, 39);
            btnDesconectar.TabIndex = 1;
            btnDesconectar.Text = "Desconectar";
            btnDesconectar.UseVisualStyleBackColor = true;
            btnDesconectar.Click += btnDesconectar_Click;
            // 
            // btnLeerDatos
            // 
            btnLeerDatos.Location = new Point(38, 180);
            btnLeerDatos.Name = "btnLeerDatos";
            btnLeerDatos.Size = new Size(124, 39);
            btnLeerDatos.TabIndex = 2;
            btnLeerDatos.Text = "Leer datos";
            btnLeerDatos.UseVisualStyleBackColor = true;
            btnLeerDatos.Click += btnLeerDatos_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(38, 400);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(92, 20);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "lblResultado";
            lblResultado.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 28);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 4;
            label2.Text = "Apellidos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(435, 28);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 5;
            label3.Text = "Columnas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(631, 28);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 6;
            label4.Text = "Tipos Dato";
            // 
            // lstApellidos
            // 
            lstApellidos.FormattingEnabled = true;
            lstApellidos.Location = new Point(244, 62);
            lstApellidos.Name = "lstApellidos";
            lstApellidos.Size = new Size(149, 304);
            lstApellidos.TabIndex = 7;
            // 
            // lstColumnas
            // 
            lstColumnas.FormattingEnabled = true;
            lstColumnas.Location = new Point(435, 62);
            lstColumnas.Name = "lstColumnas";
            lstColumnas.Size = new Size(149, 304);
            lstColumnas.TabIndex = 8;
            // 
            // lstTiposDato
            // 
            lstTiposDato.FormattingEnabled = true;
            lstTiposDato.Location = new Point(631, 62);
            lstTiposDato.Name = "lstTiposDato";
            lstTiposDato.Size = new Size(149, 304);
            lstTiposDato.TabIndex = 9;
            // 
            // Form01PrimerAdo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 450);
            Controls.Add(lstTiposDato);
            Controls.Add(lstColumnas);
            Controls.Add(lstApellidos);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblResultado);
            Controls.Add(btnLeerDatos);
            Controls.Add(btnDesconectar);
            Controls.Add(btnConectar);
            Name = "Form01PrimerAdo";
            Text = "Form01PrimerAdo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConectar;
        private Button btnDesconectar;
        private Button btnLeerDatos;
        private Label lblResultado;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox lstApellidos;
        private ListBox lstColumnas;
        private ListBox lstTiposDato;
    }
}