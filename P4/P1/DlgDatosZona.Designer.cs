
namespace P1
{
    partial class DlgDatosZona
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ct_Nombre = new System.Windows.Forms.TextBox();
            this.bt_Aceptar = new System.Windows.Forms.Button();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.bt_Positivo = new System.Windows.Forms.RadioButton();
            this.bt_Negativo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.ct_Diferencia = new P1.EditHora();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Diferencia horaria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // ct_Nombre
            // 
            this.ct_Nombre.Location = new System.Drawing.Point(107, 36);
            this.ct_Nombre.Name = "ct_Nombre";
            this.ct_Nombre.Size = new System.Drawing.Size(244, 26);
            this.ct_Nombre.TabIndex = 2;
            // 
            // bt_Aceptar
            // 
            this.bt_Aceptar.Location = new System.Drawing.Point(399, 31);
            this.bt_Aceptar.Name = "bt_Aceptar";
            this.bt_Aceptar.Size = new System.Drawing.Size(88, 37);
            this.bt_Aceptar.TabIndex = 5;
            this.bt_Aceptar.Text = "Aceptar";
            this.bt_Aceptar.UseVisualStyleBackColor = true;
            this.bt_Aceptar.Click += new System.EventHandler(this.bt_Aceptar_Click);
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancelar.Location = new System.Drawing.Point(399, 74);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(88, 37);
            this.bt_Cancelar.TabIndex = 6;
            this.bt_Cancelar.Text = "Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = true;
            // 
            // bt_Positivo
            // 
            this.bt_Positivo.AutoSize = true;
            this.bt_Positivo.Checked = true;
            this.bt_Positivo.Location = new System.Drawing.Point(399, 127);
            this.bt_Positivo.Name = "bt_Positivo";
            this.bt_Positivo.Size = new System.Drawing.Size(88, 24);
            this.bt_Positivo.TabIndex = 7;
            this.bt_Positivo.TabStop = true;
            this.bt_Positivo.Text = "Positivo";
            this.bt_Positivo.UseVisualStyleBackColor = true;
            // 
            // bt_Negativo
            // 
            this.bt_Negativo.AutoSize = true;
            this.bt_Negativo.Location = new System.Drawing.Point(399, 157);
            this.bt_Negativo.Name = "bt_Negativo";
            this.bt_Negativo.Size = new System.Drawing.Size(96, 24);
            this.bt_Negativo.TabIndex = 8;
            this.bt_Negativo.Text = "Negativo";
            this.bt_Negativo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Signo:";
            // 
            // ct_Diferencia
            // 
            this.ct_Diferencia.BeepOnError = true;
            this.ct_Diferencia.Hora = new System.DateTime(((long)(0)));
            this.ct_Diferencia.Location = new System.Drawing.Point(176, 79);
            this.ct_Diferencia.Mask = "90:00:99";
            this.ct_Diferencia.Name = "ct_Diferencia";
            this.ct_Diferencia.PromptChar = '-';
            this.ct_Diferencia.Size = new System.Drawing.Size(175, 26);
            this.ct_Diferencia.TabIndex = 3;
            this.ct_Diferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ct_Diferencia.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // DlgDatosZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 208);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_Negativo);
            this.Controls.Add(this.bt_Positivo);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.bt_Aceptar);
            this.Controls.Add(this.ct_Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ct_Diferencia);
            this.Name = "DlgDatosZona";
            this.Text = "DlgDatosZona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EditHora ct_Diferencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ct_Nombre;
        private System.Windows.Forms.Button bt_Aceptar;
        private System.Windows.Forms.Button bt_Cancelar;
        private System.Windows.Forms.RadioButton bt_Positivo;
        private System.Windows.Forms.RadioButton bt_Negativo;
        private System.Windows.Forms.Label label3;
    }
}