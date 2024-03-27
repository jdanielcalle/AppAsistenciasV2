namespace AppAsistenciasV2
{
    partial class FormVerCursos
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
            this.cbEstudiantes = new MaterialSkin.Controls.MaterialComboBox();
            this.dvgEstudiantes = new System.Windows.Forms.DataGridView();
            this.btnReportar = new MaterialSkin.Controls.MaterialButton();
            this.btnRegistrar = new MaterialSkin.Controls.MaterialButton();
            this.btnGenerar = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEstudiantes
            // 
            this.cbEstudiantes.AutoResize = false;
            this.cbEstudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbEstudiantes.Depth = 0;
            this.cbEstudiantes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbEstudiantes.DropDownHeight = 174;
            this.cbEstudiantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstudiantes.DropDownWidth = 121;
            this.cbEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbEstudiantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbEstudiantes.FormattingEnabled = true;
            this.cbEstudiantes.Hint = "Selecciona un curso";
            this.cbEstudiantes.IntegralHeight = false;
            this.cbEstudiantes.ItemHeight = 43;
            this.cbEstudiantes.Location = new System.Drawing.Point(22, 47);
            this.cbEstudiantes.MaxDropDownItems = 4;
            this.cbEstudiantes.MouseState = MaterialSkin.MouseState.OUT;
            this.cbEstudiantes.Name = "cbEstudiantes";
            this.cbEstudiantes.Size = new System.Drawing.Size(361, 49);
            this.cbEstudiantes.StartIndex = 0;
            this.cbEstudiantes.TabIndex = 0;
            this.cbEstudiantes.SelectedIndexChanged += new System.EventHandler(this.cbEstudiantes_SelectedIndexChanged);
            // 
            // dvgEstudiantes
            // 
            this.dvgEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgEstudiantes.Location = new System.Drawing.Point(22, 115);
            this.dvgEstudiantes.Name = "dvgEstudiantes";
            this.dvgEstudiantes.Size = new System.Drawing.Size(361, 125);
            this.dvgEstudiantes.TabIndex = 1;
            // 
            // btnReportar
            // 
            this.btnReportar.AutoSize = false;
            this.btnReportar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReportar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReportar.Depth = 0;
            this.btnReportar.HighEmphasis = true;
            this.btnReportar.Icon = null;
            this.btnReportar.Location = new System.Drawing.Point(22, 260);
            this.btnReportar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReportar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReportar.Name = "btnReportar";
            this.btnReportar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReportar.Size = new System.Drawing.Size(361, 36);
            this.btnReportar.TabIndex = 2;
            this.btnReportar.Text = "REPORTAR ASISTENCIA";
            this.btnReportar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReportar.UseAccentColor = false;
            this.btnReportar.UseVisualStyleBackColor = true;
            this.btnReportar.Click += new System.EventHandler(this.btnReportar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AutoSize = false;
            this.btnRegistrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegistrar.Depth = 0;
            this.btnRegistrar.HighEmphasis = true;
            this.btnRegistrar.Icon = null;
            this.btnRegistrar.Location = new System.Drawing.Point(22, 308);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegistrar.Size = new System.Drawing.Size(361, 36);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "REGISTRAR ASISTENCIA";
            this.btnRegistrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegistrar.UseAccentColor = false;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.AutoSize = false;
            this.btnGenerar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGenerar.Depth = 0;
            this.btnGenerar.HighEmphasis = true;
            this.btnGenerar.Icon = null;
            this.btnGenerar.Location = new System.Drawing.Point(22, 356);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGenerar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGenerar.Size = new System.Drawing.Size(361, 36);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "GENERAR ALERTA";
            this.btnGenerar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGenerar.UseAccentColor = false;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // FormVerCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 436);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnReportar);
            this.Controls.Add(this.dvgEstudiantes);
            this.Controls.Add(this.cbEstudiantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVerCursos";
            this.Text = "FormVerCursos";
            ((System.ComponentModel.ISupportInitialize)(this.dvgEstudiantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cbEstudiantes;
        private System.Windows.Forms.DataGridView dvgEstudiantes;
        private MaterialSkin.Controls.MaterialButton btnReportar;
        private MaterialSkin.Controls.MaterialButton btnRegistrar;
        private MaterialSkin.Controls.MaterialButton btnGenerar;
    }
}