namespace AppAsistenciasV2
{
    partial class FormAgregarEstudiante
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
            this.btnAgregarEstudiante = new MaterialSkin.Controls.MaterialButton();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtContrasena = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtIdentificacion = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbTipoID = new MaterialSkin.Controls.MaterialComboBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.SuspendLayout();
            // 
            // btnAgregarEstudiante
            // 
            this.btnAgregarEstudiante.AutoSize = false;
            this.btnAgregarEstudiante.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarEstudiante.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarEstudiante.Depth = 0;
            this.btnAgregarEstudiante.HighEmphasis = true;
            this.btnAgregarEstudiante.Icon = null;
            this.btnAgregarEstudiante.Location = new System.Drawing.Point(12, 303);
            this.btnAgregarEstudiante.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarEstudiante.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            this.btnAgregarEstudiante.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarEstudiante.Size = new System.Drawing.Size(383, 36);
            this.btnAgregarEstudiante.TabIndex = 11;
            this.btnAgregarEstudiante.Text = "AGREGAR ESTUDIANTE";
            this.btnAgregarEstudiante.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarEstudiante.UseAccentColor = false;
            this.btnAgregarEstudiante.UseVisualStyleBackColor = true;
            this.btnAgregarEstudiante.Click += new System.EventHandler(this.btnAgregarEstudiante_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.HideSelection = true;
            this.txtEmail.Hint = "Ingrese su correo electrónico";
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
            this.txtContrasena.Hint = "Ingrese su contraseña";
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
            this.txtIdentificacion.Hint = "Ingrese su identificación";
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
            this.cbTipoID.Hint = "Seleccione el tipo de identificación";
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
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.HideSelection = true;
            this.txtNombre.Hint = "Ingrese el nombre";
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(12, 18);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PrefixSuffixText = null;
            this.txtNombre.ReadOnly = false;
            this.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(384, 48);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.TabStop = false;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.TrailingIcon = null;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // FormAgregarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 357);
            this.Controls.Add(this.btnAgregarEstudiante);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.cbTipoID);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgregarEstudiante";
            this.Text = "FormAgregarEstudiante";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnAgregarEstudiante;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmail;
        private MaterialSkin.Controls.MaterialTextBox2 txtContrasena;
        private MaterialSkin.Controls.MaterialTextBox2 txtIdentificacion;
        private MaterialSkin.Controls.MaterialComboBox cbTipoID;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombre;
    }
}