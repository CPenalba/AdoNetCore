namespace AdoNetCore
{
    partial class Form06UpdateSalasClases
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
            btnModificarSalas = new Button();
            txtNuevaSala = new TextBox();
            lstSalas = new ListBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnModificarSalas
            // 
            btnModificarSalas.Location = new Point(464, 124);
            btnModificarSalas.Name = "btnModificarSalas";
            btnModificarSalas.Size = new Size(266, 72);
            btnModificarSalas.TabIndex = 9;
            btnModificarSalas.Text = "Modificar salas";
            btnModificarSalas.UseVisualStyleBackColor = true;
            btnModificarSalas.Click += btnModificarSalas_Click;
            // 
            // txtNuevaSala
            // 
            txtNuevaSala.Location = new Point(464, 74);
            txtNuevaSala.Name = "txtNuevaSala";
            txtNuevaSala.Size = new Size(266, 27);
            txtNuevaSala.TabIndex = 8;
            // 
            // lstSalas
            // 
            lstSalas.FormattingEnabled = true;
            lstSalas.Location = new Point(70, 74);
            lstSalas.Name = "lstSalas";
            lstSalas.Size = new Size(295, 344);
            lstSalas.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(464, 32);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 6;
            label2.Text = "Nueva sala";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 32);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 5;
            label1.Text = "Salas";
            // 
            // Form06UpdateSalasClases
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificarSalas);
            Controls.Add(txtNuevaSala);
            Controls.Add(lstSalas);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form06UpdateSalasClases";
            Text = "Form06UpdateSalasClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificarSalas;
        private TextBox txtNuevaSala;
        private ListBox lstSalas;
        private Label label2;
        private Label label1;
    }
}