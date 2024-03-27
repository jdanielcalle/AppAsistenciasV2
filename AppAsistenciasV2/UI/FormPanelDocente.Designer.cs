namespace AppAsistenciasV2
{
    partial class FormPanelDocente
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
            this.btnCursos = new MaterialSkin.Controls.MaterialButton();
            this.btnVerCursos = new MaterialSkin.Controls.MaterialButton();
            this.btnEstudiantes = new MaterialSkin.Controls.MaterialButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
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
            this.panelCentral.TabIndex = 3;
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.Gainsboro;
            this.panelLateral.Controls.Add(this.btnSalir);
            this.panelLateral.Controls.Add(this.btnEstudiantes);
            this.panelLateral.Controls.Add(this.pbFotoLogin);
            this.panelLateral.Controls.Add(this.btnCursos);
            this.panelLateral.Controls.Add(this.btnVerCursos);
            this.panelLateral.Location = new System.Drawing.Point(-1, 64);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(196, 436);
            this.panelLateral.TabIndex = 2;
            // 
            // btnCursos
            // 
            this.btnCursos.AutoSize = false;
            this.btnCursos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCursos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCursos.Depth = 0;
            this.btnCursos.HighEmphasis = true;
            this.btnCursos.Icon = null;
            this.btnCursos.Location = new System.Drawing.Point(17, 206);
            this.btnCursos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCursos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCursos.Size = new System.Drawing.Size(160, 36);
            this.btnCursos.TabIndex = 1;
            this.btnCursos.Text = "CURSOS";
            this.btnCursos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCursos.UseAccentColor = false;
            this.btnCursos.UseVisualStyleBackColor = true;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // btnVerCursos
            // 
            this.btnVerCursos.AutoSize = false;
            this.btnVerCursos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerCursos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVerCursos.Depth = 0;
            this.btnVerCursos.HighEmphasis = true;
            this.btnVerCursos.Icon = null;
            this.btnVerCursos.Location = new System.Drawing.Point(17, 158);
            this.btnVerCursos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVerCursos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerCursos.Name = "btnVerCursos";
            this.btnVerCursos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVerCursos.Size = new System.Drawing.Size(160, 36);
            this.btnVerCursos.TabIndex = 0;
            this.btnVerCursos.Text = "VER CURSOS";
            this.btnVerCursos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVerCursos.UseAccentColor = false;
            this.btnVerCursos.UseVisualStyleBackColor = true;
            this.btnVerCursos.Click += new System.EventHandler(this.btnVerCursos_Click);
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.AutoSize = false;
            this.btnEstudiantes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEstudiantes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEstudiantes.Depth = 0;
            this.btnEstudiantes.HighEmphasis = true;
            this.btnEstudiantes.Icon = null;
            this.btnEstudiantes.Location = new System.Drawing.Point(17, 254);
            this.btnEstudiantes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEstudiantes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEstudiantes.Size = new System.Drawing.Size(160, 36);
            this.btnEstudiantes.TabIndex = 3;
            this.btnEstudiantes.Text = "ESTUDIANTES";
            this.btnEstudiantes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEstudiantes.UseAccentColor = false;
            this.btnEstudiantes.UseVisualStyleBackColor = true;
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
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
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            // FormPanelDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelLateral);
            this.Name = "FormPanelDocente";
            this.Text = "Panel de gestión del docente";
            this.panelLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.PictureBox pbFotoLogin;
        private MaterialSkin.Controls.MaterialButton btnCursos;
        private MaterialSkin.Controls.MaterialButton btnVerCursos;
        private MaterialSkin.Controls.MaterialButton btnEstudiantes;
        private MaterialSkin.Controls.MaterialButton btnSalir;
    }
}