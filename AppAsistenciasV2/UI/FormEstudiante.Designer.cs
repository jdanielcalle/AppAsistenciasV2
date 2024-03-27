namespace AppAsistenciasV2
{
    partial class FormEstudiante
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
            this.txtCedula = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblEncabezado = new MaterialSkin.Controls.MaterialLabel();
            this.btnAcceder = new MaterialSkin.Controls.MaterialButton();
            this.swVerContrasena = new MaterialSkin.Controls.MaterialSwitch();
            this.txtContrasena = new MaterialSkin.Controls.MaterialTextBox2();
            this.SuspendLayout();
            // 
            // txtCedula
            // 
            this.txtCedula.AnimateReadOnly = false;
            this.txtCedula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCedula.Depth = 0;
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCedula.HideSelection = true;
            this.txtCedula.Hint = "Ingrese su identificación";
            this.txtCedula.LeadingIcon = null;
            this.txtCedula.Location = new System.Drawing.Point(70, 120);
            this.txtCedula.MaxLength = 32767;
            this.txtCedula.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.PasswordChar = '\0';
            this.txtCedula.PrefixSuffixText = null;
            this.txtCedula.ReadOnly = false;
            this.txtCedula.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCedula.SelectedText = "";
            this.txtCedula.SelectionLength = 0;
            this.txtCedula.SelectionStart = 0;
            this.txtCedula.ShortcutsEnabled = true;
            this.txtCedula.Size = new System.Drawing.Size(250, 48);
            this.txtCedula.TabIndex = 10;
            this.txtCedula.TabStop = false;
            this.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCedula.TrailingIcon = null;
            this.txtCedula.UseSystemPasswordChar = false;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.Depth = 0;
            this.lblEncabezado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEncabezado.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEncabezado.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEncabezado.Location = new System.Drawing.Point(111, 77);
            this.lblEncabezado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(167, 23);
            this.lblEncabezado.TabIndex = 9;
            this.lblEncabezado.Text = "LOGIN ESTUDIANTE";
            this.lblEncabezado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAcceder
            // 
            this.btnAcceder.AutoSize = false;
            this.btnAcceder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAcceder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAcceder.Depth = 0;
            this.btnAcceder.HighEmphasis = true;
            this.btnAcceder.Icon = null;
            this.btnAcceder.Location = new System.Drawing.Point(70, 298);
            this.btnAcceder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAcceder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAcceder.Size = new System.Drawing.Size(250, 41);
            this.btnAcceder.TabIndex = 8;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAcceder.UseAccentColor = false;
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // swVerContrasena
            // 
            this.swVerContrasena.AutoSize = true;
            this.swVerContrasena.Depth = 0;
            this.swVerContrasena.Location = new System.Drawing.Point(70, 242);
            this.swVerContrasena.Margin = new System.Windows.Forms.Padding(0);
            this.swVerContrasena.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swVerContrasena.MouseState = MaterialSkin.MouseState.HOVER;
            this.swVerContrasena.Name = "swVerContrasena";
            this.swVerContrasena.Ripple = true;
            this.swVerContrasena.Size = new System.Drawing.Size(164, 37);
            this.swVerContrasena.TabIndex = 7;
            this.swVerContrasena.Text = "Ver contraseña";
            this.swVerContrasena.UseVisualStyleBackColor = true;
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
            this.txtContrasena.Location = new System.Drawing.Point(70, 174);
            this.txtContrasena.MaxLength = 32767;
            this.txtContrasena.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '●';
            this.txtContrasena.PrefixSuffixText = null;
            this.txtContrasena.ReadOnly = false;
            this.txtContrasena.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContrasena.SelectedText = "";
            this.txtContrasena.SelectionLength = 0;
            this.txtContrasena.SelectionStart = 0;
            this.txtContrasena.ShortcutsEnabled = true;
            this.txtContrasena.Size = new System.Drawing.Size(250, 48);
            this.txtContrasena.TabIndex = 6;
            this.txtContrasena.TabStop = false;
            this.txtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContrasena.TrailingIcon = null;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // FormEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 397);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.swVerContrasena);
            this.Controls.Add(this.txtContrasena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEstudiante";
            this.Text = "FormEstudiante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtCedula;
        private MaterialSkin.Controls.MaterialLabel lblEncabezado;
        private MaterialSkin.Controls.MaterialButton btnAcceder;
        private MaterialSkin.Controls.MaterialSwitch swVerContrasena;
        private MaterialSkin.Controls.MaterialTextBox2 txtContrasena;
    }
}