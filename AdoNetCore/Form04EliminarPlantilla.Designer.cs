namespace AdoNetCore
{
    partial class Form04EliminarPlantilla
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
            txtIdEmpleado = new TextBox();
            btnEliminarPlantilla = new Button();
            label2 = new Label();
            lstPlantilla = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 45);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Id empleado";
            // 
            // txtIdEmpleado
            // 
            txtIdEmpleado.Location = new Point(48, 80);
            txtIdEmpleado.Name = "txtIdEmpleado";
            txtIdEmpleado.Size = new Size(207, 27);
            txtIdEmpleado.TabIndex = 1;
            // 
            // btnEliminarPlantilla
            // 
            btnEliminarPlantilla.Location = new Point(48, 130);
            btnEliminarPlantilla.Name = "btnEliminarPlantilla";
            btnEliminarPlantilla.Size = new Size(207, 51);
            btnEliminarPlantilla.TabIndex = 2;
            btnEliminarPlantilla.Text = "Eliminar plantilla";
            btnEliminarPlantilla.UseVisualStyleBackColor = true;
            btnEliminarPlantilla.Click += btnEliminarPlantilla_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(375, 45);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 3;
            label2.Text = "Plantilla";
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.Location = new Point(375, 80);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(277, 304);
            lstPlantilla.TabIndex = 4;
            // 
            // Form04EliminarPlantilla
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstPlantilla);
            Controls.Add(label2);
            Controls.Add(btnEliminarPlantilla);
            Controls.Add(txtIdEmpleado);
            Controls.Add(label1);
            Name = "Form04EliminarPlantilla";
            Text = "Form04EliminarPlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdEmpleado;
        private Button btnEliminarPlantilla;
        private Label label2;
        private ListBox lstPlantilla;
    }
}