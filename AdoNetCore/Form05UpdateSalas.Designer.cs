namespace AdoNetCore
{
    partial class Form05UpdateSalas
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
            lstSalas = new ListBox();
            txtNuevaSala = new TextBox();
            btnModificarSalas = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 38);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 0;
            label1.Text = "Salas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(444, 38);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 1;
            label2.Text = "Nueva sala";
            // 
            // lstSalas
            // 
            lstSalas.FormattingEnabled = true;
            lstSalas.Location = new Point(50, 80);
            lstSalas.Name = "lstSalas";
            lstSalas.Size = new Size(295, 344);
            lstSalas.TabIndex = 2;
            // 
            // txtNuevaSala
            // 
            txtNuevaSala.Location = new Point(444, 80);
            txtNuevaSala.Name = "txtNuevaSala";
            txtNuevaSala.Size = new Size(266, 27);
            txtNuevaSala.TabIndex = 3;
            // 
            // btnModificarSalas
            // 
            btnModificarSalas.Location = new Point(444, 130);
            btnModificarSalas.Name = "btnModificarSalas";
            btnModificarSalas.Size = new Size(266, 72);
            btnModificarSalas.TabIndex = 4;
            btnModificarSalas.Text = "Modificar salas";
            btnModificarSalas.UseVisualStyleBackColor = true;
            btnModificarSalas.Click += btnModificarSalas_Click;
            // 
            // Form05UpdateSalas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificarSalas);
            Controls.Add(txtNuevaSala);
            Controls.Add(lstSalas);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form05UpdateSalas";
            Text = "Form05UpdateSalas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lstSalas;
        private TextBox txtNuevaSala;
        private Button btnModificarSalas;
    }
}