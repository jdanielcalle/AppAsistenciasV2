namespace AppAsistenciasV2
{
    partial class FormPanelEstudiante
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
            this.panelCentral = new System.Windows.Forms.Panel();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnVerAsistencia = new MaterialSkin.Controls.MaterialButton();
            this.pbFotoLogin = new System.Windows.Forms.PictureBox();
            this.panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCentral
            // 
            this.panelCentral.Location = new System.Drawing.Point(194, 64);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(408, 436);
            this.panelCentral.TabIndex = 5;
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.Gainsboro;
            this.panelLateral.Controls.Add(this.btnSalir);
            this.panelLateral.Controls.Add(this.pbFotoLogin);
            this.panelLateral.Controls.Add(this.btnCancelar);
            this.panelLateral.Controls.Add(this.btnVerAsistencia);
            this.panelLateral.Location = new System.Drawing.Point(-1, 64);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(196, 436);
            this.panelLateral.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = false;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(17, 367);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(160, 36);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalir.UseAccentColor = false;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = false;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(17, 206);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(160, 36);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "CANCELAR CURSO";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnVerAsistencia
            // 
            this.btnVerAsistencia.AutoSize = false;
            this.btnVerAsistencia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerAsistencia.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVerAsistencia.Depth = 0;
            this.btnVerAsistencia.HighEmphasis = true;
            this.btnVerAsistencia.Icon = null;
            this.btnVerAsistencia.Location = new System.Drawing.Point(17, 158);
            this.btnVerAsistencia.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVerAsistencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerAsistencia.Name = "btnVerAsistencia";
            this.btnVerAsistencia.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVerAsistencia.Size = new System.Drawing.Size(160, 36);
            this.btnVerAsistencia.TabIndex = 0;
            this.btnVerAsistencia.Text = "VER ASISTENCIA";
            this.btnVerAsistencia.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVerAsistencia.UseAccentColor = false;
            this.btnVerAsistencia.UseVisualStyleBackColor = true;
            this.btnVerAsistencia.Click += new System.EventHandler(this.btnVerAsistencia_Click_1);
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
            // FormPanelEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelLateral);
            this.Name = "FormPanelEstudiante";
            this.Text = "Panel del estudiante";
            this.panelLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Panel panelLateral;
        private MaterialSkin.Controls.MaterialButton btnSalir;
        private System.Windows.Forms.PictureBox pbFotoLogin;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnVerAsistencia;
    }
}