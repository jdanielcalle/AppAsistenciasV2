namespace AppAsistenciasV2
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLateral = new System.Windows.Forms.Panel();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.btnDocente = new MaterialSkin.Controls.MaterialButton();
            this.btnEstudiante = new MaterialSkin.Controls.MaterialButton();
            this.pbFotoLogin = new System.Windows.Forms.PictureBox();
            this.panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.Gainsboro;
            this.panelLateral.Controls.Add(this.pbFotoLogin);
            this.panelLateral.Controls.Add(this.btnEstudiante);
            this.panelLateral.Controls.Add(this.btnDocente);
            this.panelLateral.Location = new System.Drawing.Point(-1, 64);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(196, 436);
            this.panelLateral.TabIndex = 0;
            // 
            // panelCentral
            // 
            this.panelCentral.Location = new System.Drawing.Point(194, 64);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(408, 436);
            this.panelCentral.TabIndex = 1;
            // 
            // btnDocente
            // 
            this.btnDocente.AutoSize = false;
            this.btnDocente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDocente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDocente.Depth = 0;
            this.btnDocente.HighEmphasis = true;
            this.btnDocente.Icon = null;
            this.btnDocente.Location = new System.Drawing.Point(17, 158);
            this.btnDocente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDocente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDocente.Name = "btnDocente";
            this.btnDocente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDocente.Size = new System.Drawing.Size(160, 36);
            this.btnDocente.TabIndex = 0;
            this.btnDocente.Text = "DOCENTE";
            this.btnDocente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDocente.UseAccentColor = false;
            this.btnDocente.UseVisualStyleBackColor = true;
            this.btnDocente.Click += new System.EventHandler(this.btnDocente_Click);
            // 
            // btnEstudiante
            // 
            this.btnEstudiante.AutoSize = false;
            this.btnEstudiante.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEstudiante.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEstudiante.Depth = 0;
            this.btnEstudiante.HighEmphasis = true;
            this.btnEstudiante.Icon = null;
            this.btnEstudiante.Location = new System.Drawing.Point(17, 206);
            this.btnEstudiante.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEstudiante.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEstudiante.Name = "btnEstudiante";
            this.btnEstudiante.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEstudiante.Size = new System.Drawing.Size(160, 36);
            this.btnEstudiante.TabIndex = 1;
            this.btnEstudiante.Text = "ESTUDIANTE";
            this.btnEstudiante.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEstudiante.UseAccentColor = false;
            this.btnEstudiante.UseVisualStyleBackColor = true;
            this.btnEstudiante.Click += new System.EventHandler(this.btnEstudiante_Click);
            // 
            // pbFotoLogin
            // 
            this.pbFotoLogin.BackColor = System.Drawing.Color.Transparent;
            this.pbFotoLogin.Image = global::AppAsistenciasV2.Properties.Resources.imgLogin1;
            this.pbFotoLogin.Location = new System.Drawing.Point(50, 32);
            this.pbFotoLogin.Name = "pbFotoLogin";
            this.pbFotoLogin.Size = new System.Drawing.Size(100, 100);
            this.pbFotoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoLogin.TabIndex = 2;
            this.pbFotoLogin.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelLateral);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso al sistema";
            this.panelLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.PictureBox pbFotoLogin;
        private MaterialSkin.Controls.MaterialButton btnEstudiante;
        private MaterialSkin.Controls.MaterialButton btnDocente;
    }
}

