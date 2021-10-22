
namespace P1
{
    partial class DlgEliminarZona
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
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.bt_Aceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_Zonas = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ct_Signo = new System.Windows.Forms.TextBox();
            this.ct_Diferencia = new P1.EditHora();
            this.SuspendLayout();
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancelar.Location = new System.Drawing.Point(333, 76);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(88, 37);
            this.bt_Cancelar.TabIndex = 12;
            this.bt_Cancelar.Text = "Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = true;
            // 
            // bt_Aceptar
            // 
            this.bt_Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Aceptar.Location = new System.Drawing.Point(333, 33);
            this.bt_Aceptar.Name = "bt_Aceptar";
            this.bt_Aceptar.Size = new System.Drawing.Size(88, 37);
            this.bt_Aceptar.TabIndex = 11;
            this.bt_Aceptar.Text = "Aceptar";
            this.bt_Aceptar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Diferencia horaria:";
            // 
            // lst_Zonas
            // 
            this.lst_Zonas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_Zonas.FormattingEnabled = true;
            this.lst_Zonas.ItemHeight = 20;
            this.lst_Zonas.Location = new System.Drawing.Point(35, 56);
            this.lst_Zonas.Name = "lst_Zonas";
            this.lst_Zonas.Size = new System.Drawing.Size(266, 124);
            this.lst_Zonas.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Signo:";
            // 
            // ct_Signo
            // 
            this.ct_Signo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ct_Signo.Location = new System.Drawing.Point(91, 225);
            this.ct_Signo.Name = "ct_Signo";
            this.ct_Signo.ReadOnly = true;
            this.ct_Signo.Size = new System.Drawing.Size(210, 26);
            this.ct_Signo.TabIndex = 15;
            this.ct_Signo.TabStop = false;
            // 
            // ct_Diferencia
            // 
            this.ct_Diferencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ct_Diferencia.BeepOnError = true;
            this.ct_Diferencia.Hora = new System.DateTime(((long)(0)));
            this.ct_Diferencia.Location = new System.Drawing.Point(175, 191);
            this.ct_Diferencia.Mask = "90:00:99";
            this.ct_Diferencia.Name = "ct_Diferencia";
            this.ct_Diferencia.PromptChar = '-';
            this.ct_Diferencia.ReadOnly = true;
            this.ct_Diferencia.Size = new System.Drawing.Size(126, 26);
            this.ct_Diferencia.TabIndex = 10;
            this.ct_Diferencia.TabStop = false;
            this.ct_Diferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ct_Diferencia.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // DlgEliminarZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 303);
            this.Controls.Add(this.ct_Signo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lst_Zonas);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.bt_Aceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ct_Diferencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DlgEliminarZona";
            this.Text = "Eliminar zona horaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Cancelar;
        private System.Windows.Forms.Button bt_Aceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private EditHora ct_Diferencia;
        private System.Windows.Forms.ListBox lst_Zonas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ct_Signo;
    }
}