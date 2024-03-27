namespace AppAsistenciasV2
{
    partial class FormEliminarEstudiante
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
            this.btnEliminarEstudiante = new MaterialSkin.Controls.MaterialButton();
            this.txtIdentificacion = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbNombre = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // btnEliminarEstudiante
            // 
            this.btnEliminarEstudiante.AutoSize = false;
            this.btnEliminarEstudiante.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarEstudiante.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarEstudiante.Depth = 0;
            this.btnEliminarEstudiante.HighEmphasis = true;
            this.btnEliminarEstudiante.Icon = null;
            this.btnEliminarEstudiante.Location = new System.Drawing.Point(13, 197);
            this.btnEliminarEstudiante.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarEstudiante.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarEstudiante.Name = "btnEliminarEstudiante";
            this.btnEliminarEstudiante.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarEstudiante.Size = new System.Drawing.Size(383, 36);
            this.btnEliminarEstudiante.TabIndex = 5;
            this.btnEliminarEstudiante.Text = "ELIMINAR ESTUDIANTE";
            this.btnEliminarEstudiante.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarEstudiante.UseAccentColor = false;
            this.btnEliminarEstudiante.UseVisualStyleBackColor = true;
            this.btnEliminarEstudiante.Click += new System.EventHandler(this.btnEliminarEstudiante_Click);
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.AnimateReadOnly = false;
            this.txtIdentificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtIdentificacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIdentificacion.Depth = 0;
            this.txtIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdentificacion.HideSelection = true;
            this.txtIdentificacion.Hint = "Ingrese el número de identificación";
            this.txtIdentificacion.LeadingIcon = null;
            this.txtIdentificacion.Location = new System.Drawing.Point(12, 130);
            this.txtIdentificacion.MaxLength = 32767;
            this.txtIdentificacion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.PasswordChar = '\0';
            this.txtIdentificacion.PrefixSuffixText = null;
            this.txtIdentificacion.ReadOnly = false;
            this.txtIdentificacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIdentificacion.SelectedText = "";
            this.txtIdentificacion.SelectionLength = 0;
            this.txtIdentificacion.SelectionStart = 0;
            this.txtIdentificacion.ShortcutsEnabled = true;
            this.txtIdentificacion.Size = new System.Drawing.Size(384, 48);
            this.txtIdentificacion.TabIndex = 2;
            this.txtIdentificacion.TabStop = false;
            this.txtIdentificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdentificacion.TrailingIcon = null;
            this.txtIdentificacion.UseSystemPasswordChar = false;
            // 
            // cbNombre
            // 
            this.cbNombre.AutoResize = false;
            this.cbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbNombre.Depth = 0;
            this.cbNombre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbNombre.DropDownHeight = 174;
            this.cbNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNombre.DropDownWidth = 121;
            this.cbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbNombre.FormattingEnabled = true;
            this.cbNombre.Hint = "Selecciona un estudiante";
            this.cbNombre.IntegralHeight = false;
            this.cbNombre.ItemHeight = 43;
            this.cbNombre.Location = new System.Drawing.Point(12, 66);
            this.cbNombre.MaxDropDownItems = 4;
            this.cbNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(384, 49);
            this.cbNombre.StartIndex = 0;
            this.cbNombre.TabIndex = 6;
            this.cbNombre.SelectedIndexChanged += new System.EventHandler(this.cbNombre_SelectedIndexChanged);
            // 
            // FormEliminarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 357);
            this.Controls.Add(this.cbNombre);
            this.Controls.Add(this.btnEliminarEstudiante);
            this.Controls.Add(this.txtIdentificacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEliminarEstudiante";
            this.Text = "FormEliminarEstudiante";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnEliminarEstudiante;
        private MaterialSkin.Controls.MaterialTextBox2 txtIdentificacion;
        private MaterialSkin.Controls.MaterialComboBox cbNombre;
    }
}