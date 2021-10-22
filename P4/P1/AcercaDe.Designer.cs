
namespace P1
{
    partial class AcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDe));
            this.bt_Aceptar = new System.Windows.Forms.Button();
            this.labelAcercaDe = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelAcercaDe2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Aceptar
            // 
            this.bt_Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Aceptar.Location = new System.Drawing.Point(145, 164);
            this.bt_Aceptar.Name = "bt_Aceptar";
            this.bt_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.bt_Aceptar.TabIndex = 0;
            this.bt_Aceptar.Text = "Aceptar";
            this.bt_Aceptar.UseVisualStyleBackColor = true;
            // 
            // labelAcercaDe
            // 
            this.labelAcercaDe.AutoSize = true;
            this.labelAcercaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcercaDe.Location = new System.Drawing.Point(150, 126);
            this.labelAcercaDe.Name = "labelAcercaDe";
            this.labelAcercaDe.Size = new System.Drawing.Size(39, 13);
            this.labelAcercaDe.TabIndex = 1;
            this.labelAcercaDe.Text = "Texto";
            this.labelAcercaDe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(122, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelAcercaDe2
            // 
            this.labelAcercaDe2.AutoSize = true;
            this.labelAcercaDe2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcercaDe2.Location = new System.Drawing.Point(126, 140);
            this.labelAcercaDe2.Name = "labelAcercaDe2";
            this.labelAcercaDe2.Size = new System.Drawing.Size(46, 13);
            this.labelAcercaDe2.TabIndex = 3;
            this.labelAcercaDe2.Text = "Texto2";
            this.labelAcercaDe2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AcercaDe
            // 
            this.AcceptButton = this.bt_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 191);
            this.ControlBox = false;
            this.Controls.Add(this.labelAcercaDe2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelAcercaDe);
            this.Controls.Add(this.bt_Aceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AcercaDe";
            this.ShowIcon = false;
            this.Text = "Acerca De";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Aceptar;
        private System.Windows.Forms.Label labelAcercaDe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAcercaDe2;
    }
}