
namespace EjercicioDeClase_1
{
    partial class Contraseña
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
            this.bt_Aceptar = new System.Windows.Forms.Button();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.lb_pswd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Aceptar
            // 
            this.bt_Aceptar.Location = new System.Drawing.Point(232, 142);
            this.bt_Aceptar.Name = "bt_Aceptar";
            this.bt_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.bt_Aceptar.TabIndex = 0;
            this.bt_Aceptar.Text = "Aceptar";
            this.bt_Aceptar.UseVisualStyleBackColor = true;
            this.bt_Aceptar.Click += new System.EventHandler(this.bt_Aceptar_Click);
            // 
            // tb_pwd
            // 
            this.tb_pwd.Location = new System.Drawing.Point(149, 114);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.Size = new System.Drawing.Size(254, 22);
            this.tb_pwd.TabIndex = 1;
            // 
            // lb_pswd
            // 
            this.lb_pswd.AutoSize = true;
            this.lb_pswd.Location = new System.Drawing.Point(146, 94);
            this.lb_pswd.Name = "lb_pswd";
            this.lb_pswd.Size = new System.Drawing.Size(85, 17);
            this.lb_pswd.TabIndex = 2;
            this.lb_pswd.Text = "Contraseña:";
            // 
            // Contraseña
            // 
            this.AcceptButton = this.bt_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 330);
            this.Controls.Add(this.lb_pswd);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.bt_Aceptar);
            this.Name = "Contraseña";
            this.Text = "Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Aceptar;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.Label lb_pswd;
    }
}