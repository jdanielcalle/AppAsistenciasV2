namespace AppAsistenciasV2
{
    partial class FormEditarEstudiante
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
            this.cbNombre = new MaterialSkin.Controls.MaterialComboBox();
            this.btnEditarEstudiante = new MaterialSkin.Controls.MaterialButton();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtContrasena = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtIdentificacion = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbTipoID = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
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
            this.cbNombre.Location = new System.Drawing.Point(12, 18);
            this.cbNombre.MaxDropDownItems = 4;
            this.cbNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(384, 49);
            this.cbNombre.StartIndex = 0;
            this.cbNombre.TabIndex = 12;
            this.cbNombre.SelectedIndexChanged += new System.EventHandler(this.cbNombre_SelectedIndexChanged);
            // 
            // btnEditarEstudiante
            // 
            this.btnEditarEstudiante.AutoSize = false;
            this.btnEditarEstudiante.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarEstudiante.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditarEstudiante.Depth = 0;
            this.btnEditarEstudiante.HighEmphasis = true;
            this.btnEditarEstudiante.Icon = null;
            this.btnEditarEstudiante.Location = new System.Drawing.Point(12, 303);
            this.btnEditarEstudiante.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditarEstudiante.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarEstudiante.Name = "btnEditarEstudiante";
            this.btnEditarEstudiante.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditarEstudiante.Size = new System.Drawing.Size(383, 36);
            this.btnEditarEstudiante.TabIndex = 11;
            this.btnEditarEstudiante.Text = "EDITAR ESTUDIANTE";
            this.btnEditarEstudiante.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditarEstudiante.UseAccentColor = false;
            this.btnEditarEstudiante.UseVisualStyleBackColor = true;
            this.btnEditarEstudiante.Click += new System.EventHandler(this.btnEditarEstudiante_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.HideSelection = true;
            this.txtEmail.Hint = "Ingrese el correo electrónico";
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(12, 235);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PrefixSuffixText = null;
            this.txtEmail.ReadOnly = false;
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(384, 48);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.TabStop = false;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtContrasena
            // 
            this.txtContrasena.AnimateReadOnly = false;
            this.txtContrasena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtContrasena.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtContrasena.Depth = 0;
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContrasena.HideSelection = true;
            this.txtContrasena.Hint = "Ingrese la contraseña";
            this.txtContrasena.LeadingIcon = null;
            this.txtContrasena.Location = new System.Drawing.Point(12, 181);
            this.txtContrasena.MaxLength = 32767;
            this.txtContrasena.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '\0';
            this.txtContrasena.PrefixSuffixText = null;
            this.txtContrasena.ReadOnly = false;
            this.txtContrasena.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContrasena.SelectedText = "";
            this.txtContrasena.SelectionLength = 0;
            this.txtContrasena.SelectionStart = 0;
            this.txtContrasena.ShortcutsEnabled = true;
            this.txtContrasena.Size = new System.Drawing.Size(384, 48);
            this.txtContrasena.TabIndex = 9;
            this.txtContrasena.TabStop = false;
            this.txtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContrasena.TrailingIcon = null;
            this.txtContrasena.UseSystemPasswordChar = false;
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
            this.txtIdentificacion.Location = new System.Drawing.Point(12, 127);
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
            this.txtIdentificacion.TabIndex = 8;
            this.txtIdentificacion.TabStop = false;
            this.txtIdentificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdentificacion.TrailingIcon = null;
            this.txtIdentificacion.UseSystemPasswordChar = false;
            // 
            // cbTipoID
            // 
            this.cbTipoID.AutoResize = false;
            this.cbTipoID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbTipoID.Depth = 0;
            this.cbTipoID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbTipoID.DropDownHeight = 174;
            this.cbTipoID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoID.DropDownWidth = 121;
            this.cbTipoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbTipoID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTipoID.FormattingEnabled = true;
            this.cbTipoID.Hint = "Selecciona un tipo de identificación";
            this.cbTipoID.IntegralHeight = false;
            this.cbTipoID.ItemHeight = 43;
            this.cbTipoID.Location = new System.Drawing.Point(12, 72);
            this.cbTipoID.MaxDropDownItems = 4;
            this.cbTipoID.MouseState = MaterialSkin.MouseState.OUT;
            this.cbTipoID.Name = "cbTipoID";
            this.cbTipoID.Size = new System.Drawing.Size(384, 49);
            this.cbTipoID.StartIndex = 0;
            this.cbTipoID.TabIndex = 7;
            // 
            // FormEditarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 357);
            this.Controls.Add(this.cbNombre);
            this.Controls.Add(this.btnEditarEstudiante);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.cbTipoID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditarEstudiante";
            this.Text = "FormEditarEstudiante";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cbNombre;
        private MaterialSkin.Controls.MaterialButton btnEditarEstudiante;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmail;
        private MaterialSkin.Controls.MaterialTextBox2 txtContrasena;
        private MaterialSkin.Controls.MaterialTextBox2 txtIdentificacion;
        private MaterialSkin.Controls.MaterialComboBox cbTipoID;
    }
}