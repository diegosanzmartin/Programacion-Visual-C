
namespace P1
{
    partial class RelojAnalogico
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
            this.SuspendLayout();
            // 
            // RelojAnalogico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.Name = "RelojAnalogico";
            this.ShowInTaskbar = false;
            this.Text = "Reloj Analógico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RelojAnalogico_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RelojAnalogico_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RelojAnalogico_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RelojAnalogico_MouseMove);
            this.Resize += new System.EventHandler(this.RelojAnalogico_Resize);
            this.ResumeLayout(false);

        }

        #endregion
    }
}