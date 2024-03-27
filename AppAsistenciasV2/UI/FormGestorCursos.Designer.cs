namespace AppAsistenciasV2
{
    partial class FormGestorCursos
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
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.txtNombreAgregar = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialButton();
            this.txtNombreEliminar = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbCodigoEliminar = new MaterialSkin.Controls.MaterialComboBox();
            this.btnEditar = new MaterialSkin.Controls.MaterialButton();
            this.txtNombreEditar = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbCodigoEditar = new MaterialSkin.Controls.MaterialComboBox();
            this.txtCodigoAgregar = new MaterialSkin.Controls.MaterialTextBox2();
            this.SuspendLayout();
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(12, 146);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(384, 1);
            this.materialDivider1.TabIndex = 0;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(12, 295);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(384, 1);
            this.materialDivider2.TabIndex = 1;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // txtNombreAgregar
            // 
            this.txtNombreAgregar.AnimateReadOnly = false;
            this.txtNombreAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombreAgregar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreAgregar.Depth = 0;
            this.txtNombreAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreAgregar.HideSelection = true;
            this.txtNombreAgregar.Hint = "Nombre del curso";
            this.txtNombreAgregar.LeadingIcon = null;
            this.txtNombreAgregar.Location = new System.Drawing.Point(12, 75);
            this.txtNombreAgregar.MaxLength = 32767;
            this.txtNombreAgregar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreAgregar.Name = "txtNombreAgregar";
            this.txtNombreAgregar.PasswordChar = '\0';
            this.txtNombreAgregar.PrefixSuffixText = null;
            this.txtNombreAgregar.ReadOnly = false;
            this.txtNombreAgregar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombreAgregar.SelectedText = "";
            this.txtNombreAgregar.SelectionLength = 0;
            this.txtNombreAgregar.SelectionStart = 0;
            this.txtNombreAgregar.ShortcutsEnabled = true;
            this.txtNombreAgregar.Size = new System.Drawing.Size(228, 48);
            this.txtNombreAgregar.TabIndex = 3;
            this.txtNombreAgregar.TabStop = false;
            this.txtNombreAgregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreAgregar.TrailingIcon = null;
            this.txtNombreAgregar.UseSystemPasswordChar = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = false;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(257, 46);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar.Size = new System.Drawing.Size(139, 56);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = false;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = false;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.HighEmphasis = true;
            this.btnEliminar.Icon = null;
            this.btnEliminar.Location = new System.Drawing.Point(257, 341);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminar.Size = new System.Drawing.Size(139, 56);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminar.UseAccentColor = false;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtNombreEliminar
            // 
            this.txtNombreEliminar.AnimateReadOnly = false;
            this.txtNombreEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombreEliminar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreEliminar.Depth = 0;
            this.txtNombreEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreEliminar.HideSelection = true;
            this.txtNombreEliminar.Hint = "Nombre del curso";
            this.txtNombreEliminar.LeadingIcon = null;
            this.txtNombreEliminar.Location = new System.Drawing.Point(12, 370);
            this.txtNombreEliminar.MaxLength = 32767;
            this.txtNombreEliminar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreEliminar.Name = "txtNombreEliminar";
            this.txtNombreEliminar.PasswordChar = '\0';
            this.txtNombreEliminar.PrefixSuffixText = null;
            this.txtNombreEliminar.ReadOnly = false;
            this.txtNombreEliminar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombreEliminar.SelectedText = "";
            this.txtNombreEliminar.SelectionLength = 0;
            this.txtNombreEliminar.SelectionStart = 0;
            this.txtNombreEliminar.ShortcutsEnabled = true;
            this.txtNombreEliminar.Size = new System.Drawing.Size(228, 48);
            this.txtNombreEliminar.TabIndex = 6;
            this.txtNombreEliminar.TabStop = false;
            this.txtNombreEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreEliminar.TrailingIcon = null;
            this.txtNombreEliminar.UseSystemPasswordChar = false;
            // 
            // cbCodigoEliminar
            // 
            this.cbCodigoEliminar.AutoResize = false;
            this.cbCodigoEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbCodigoEliminar.Depth = 0;
            this.cbCodigoEliminar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbCodigoEliminar.DropDownHeight = 174;
            this.cbCodigoEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodigoEliminar.DropDownWidth = 121;
            this.cbCodigoEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbCodigoEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbCodigoEliminar.FormattingEnabled = true;
            this.cbCodigoEliminar.Hint = "Selecciona el código";
            this.cbCodigoEliminar.IntegralHeight = false;
            this.cbCodigoEliminar.ItemHeight = 43;
            this.cbCodigoEliminar.Location = new System.Drawing.Point(12, 315);
            this.cbCodigoEliminar.MaxDropDownItems = 4;
            this.cbCodigoEliminar.MouseState = MaterialSkin.MouseState.OUT;
            this.cbCodigoEliminar.Name = "cbCodigoEliminar";
            this.cbCodigoEliminar.Size = new System.Drawing.Size(228, 49);
            this.cbCodigoEliminar.StartIndex = 0;
            this.cbCodigoEliminar.TabIndex = 5;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSize = false;
            this.btnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditar.Depth = 0;
            this.btnEditar.HighEmphasis = true;
            this.btnEditar.Icon = null;
            this.btnEditar.Location = new System.Drawing.Point(257, 195);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditar.Size = new System.Drawing.Size(139, 56);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditar.UseAccentColor = false;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtNombreEditar
            // 
            this.txtNombreEditar.AnimateReadOnly = false;
            this.txtNombreEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombreEditar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreEditar.Depth = 0;
            this.txtNombreEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreEditar.HideSelection = true;
            this.txtNombreEditar.Hint = "Nombre del curso";
            this.txtNombreEditar.LeadingIcon = null;
            this.txtNombreEditar.Location = new System.Drawing.Point(12, 224);
            this.txtNombreEditar.MaxLength = 32767;
            this.txtNombreEditar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreEditar.Name = "txtNombreEditar";
            this.txtNombreEditar.PasswordChar = '\0';
            this.txtNombreEditar.PrefixSuffixText = null;
            this.txtNombreEditar.ReadOnly = false;
            this.txtNombreEditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombreEditar.SelectedText = "";
            this.txtNombreEditar.SelectionLength = 0;
            this.txtNombreEditar.SelectionStart = 0;
            this.txtNombreEditar.ShortcutsEnabled = true;
            this.txtNombreEditar.Size = new System.Drawing.Size(228, 48);
            this.txtNombreEditar.TabIndex = 9;
            this.txtNombreEditar.TabStop = false;
            this.txtNombreEditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreEditar.TrailingIcon = null;
            this.txtNombreEditar.UseSystemPasswordChar = false;
            // 
            // cbCodigoEditar
            // 
            this.cbCodigoEditar.AutoResize = false;
            this.cbCodigoEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbCodigoEditar.Depth = 0;
            this.cbCodigoEditar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbCodigoEditar.DropDownHeight = 174;
            this.cbCodigoEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodigoEditar.DropDownWidth = 121;
            this.cbCodigoEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbCodigoEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbCodigoEditar.FormattingEnabled = true;
            this.cbCodigoEditar.Hint = "Selecciona el código";
            this.cbCodigoEditar.IntegralHeight = false;
            this.cbCodigoEditar.ItemHeight = 43;
            this.cbCodigoEditar.Location = new System.Drawing.Point(12, 169);
            this.cbCodigoEditar.MaxDropDownItems = 4;
            this.cbCodigoEditar.MouseState = MaterialSkin.MouseState.OUT;
            this.cbCodigoEditar.Name = "cbCodigoEditar";
            this.cbCodigoEditar.Size = new System.Drawing.Size(228, 49);
            this.cbCodigoEditar.StartIndex = 0;
            this.cbCodigoEditar.TabIndex = 8;
            // 
            // txtCodigoAgregar
            // 
            this.txtCodigoAgregar.AnimateReadOnly = false;
            this.txtCodigoAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCodigoAgregar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigoAgregar.Depth = 0;
            this.txtCodigoAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigoAgregar.HideSelection = true;
            this.txtCodigoAgregar.Hint = "Código del curso";
            this.txtCodigoAgregar.LeadingIcon = null;
            this.txtCodigoAgregar.Location = new System.Drawing.Point(12, 21);
            this.txtCodigoAgregar.MaxLength = 32767;
            this.txtCodigoAgregar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigoAgregar.Name = "txtCodigoAgregar";
            this.txtCodigoAgregar.PasswordChar = '\0';
            this.txtCodigoAgregar.PrefixSuffixText = null;
            this.txtCodigoAgregar.ReadOnly = false;
            this.txtCodigoAgregar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCodigoAgregar.SelectedText = "";
            this.txtCodigoAgregar.SelectionLength = 0;
            this.txtCodigoAgregar.SelectionStart = 0;
            this.txtCodigoAgregar.ShortcutsEnabled = true;
            this.txtCodigoAgregar.Size = new System.Drawing.Size(228, 48);
            this.txtCodigoAgregar.TabIndex = 11;
            this.txtCodigoAgregar.TabStop = false;
            this.txtCodigoAgregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigoAgregar.TrailingIcon = null;
            this.txtCodigoAgregar.UseSystemPasswordChar = false;
            // 
            // FormGestorCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 436);
            this.Controls.Add(this.txtCodigoAgregar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtNombreEditar);
            this.Controls.Add(this.cbCodigoEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtNombreEliminar);
            this.Controls.Add(this.cbCodigoEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombreAgregar);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialDivider1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestorCursos";
            this.Text = "FormGestorCursos";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombreAgregar;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombreEliminar;
        private MaterialSkin.Controls.MaterialComboBox cbCodigoEliminar;
        private MaterialSkin.Controls.MaterialButton btnEditar;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombreEditar;
        private MaterialSkin.Controls.MaterialComboBox cbCodigoEditar;
        private MaterialSkin.Controls.MaterialTextBox2 txtCodigoAgregar;
    }
}