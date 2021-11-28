
namespace WindowsFormsApp
{
    partial class ElementoLista
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imgAvenger = new System.Windows.Forms.PictureBox();
            this.etAliasNomEdad = new System.Windows.Forms.Label();
            this.etAlias = new System.Windows.Forms.Label();
            this.etNombre = new System.Windows.Forms.Label();
            this.etCumple = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ttElementoLista = new System.Windows.Forms.ToolTip(this.components);
            this.avengerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgAvenger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avengerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imgAvenger
            // 
            this.imgAvenger.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.avengerBindingSource, "Imagen", true));
            this.imgAvenger.Location = new System.Drawing.Point(31, 30);
            this.imgAvenger.Name = "imgAvenger";
            this.imgAvenger.Size = new System.Drawing.Size(172, 227);
            this.imgAvenger.TabIndex = 0;
            this.imgAvenger.TabStop = false;
            // 
            // etAliasNomEdad
            // 
            this.etAliasNomEdad.AutoSize = true;
            this.etAliasNomEdad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avengerBindingSource, "NombreAprellidosEdad", true));
            this.etAliasNomEdad.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etAliasNomEdad.Location = new System.Drawing.Point(249, 30);
            this.etAliasNomEdad.Name = "etAliasNomEdad";
            this.etAliasNomEdad.Size = new System.Drawing.Size(240, 29);
            this.etAliasNomEdad.TabIndex = 1;
            this.etAliasNomEdad.Text = "Alias, Nombre (Edad)";
            // 
            // etAlias
            // 
            this.etAlias.AutoSize = true;
            this.etAlias.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etAlias.Location = new System.Drawing.Point(250, 86);
            this.etAlias.Name = "etAlias";
            this.etAlias.Size = new System.Drawing.Size(65, 24);
            this.etAlias.TabIndex = 2;
            this.etAlias.Text = "Alias: ";
            // 
            // etNombre
            // 
            this.etNombre.AutoSize = true;
            this.etNombre.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etNombre.Location = new System.Drawing.Point(250, 131);
            this.etNombre.Name = "etNombre";
            this.etNombre.Size = new System.Drawing.Size(93, 24);
            this.etNombre.TabIndex = 3;
            this.etNombre.Text = "Nombre: ";
            // 
            // etCumple
            // 
            this.etCumple.AutoSize = true;
            this.etCumple.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etCumple.Location = new System.Drawing.Point(250, 175);
            this.etCumple.Name = "etCumple";
            this.etCumple.Size = new System.Drawing.Size(203, 24);
            this.etCumple.TabIndex = 4;
            this.etCumple.Text = "Fecha de Nacimiento:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avengerBindingSource, "Alias", true));
            this.textBox1.Location = new System.Drawing.Point(353, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 26);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avengerBindingSource, "Nombre", true));
            this.textBox2.Location = new System.Drawing.Point(353, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 26);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avengerBindingSource, "Cumple", true));
            this.textBox3.Location = new System.Drawing.Point(254, 216);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(287, 26);
            this.textBox3.TabIndex = 7;
            // 
            // avengerBindingSource
            // 
            this.avengerBindingSource.DataSource = typeof(BDAvengers.CAvengerBO);
            // 
            // ElementoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.etCumple);
            this.Controls.Add(this.etNombre);
            this.Controls.Add(this.etAlias);
            this.Controls.Add(this.etAliasNomEdad);
            this.Controls.Add(this.imgAvenger);
            this.Name = "ElementoLista";
            this.Size = new System.Drawing.Size(703, 287);
            ((System.ComponentModel.ISupportInitialize)(this.imgAvenger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avengerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgAvenger;
        private System.Windows.Forms.Label etAliasNomEdad;
        private System.Windows.Forms.Label etAlias;
        private System.Windows.Forms.Label etNombre;
        private System.Windows.Forms.Label etCumple;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ToolTip ttElementoLista;
        private System.Windows.Forms.BindingSource avengerBindingSource;
    }
}
