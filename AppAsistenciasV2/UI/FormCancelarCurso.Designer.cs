namespace AppAsistenciasV2
{
    partial class FormCancelarCurso
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
            this.cbCurso = new MaterialSkin.Controls.MaterialComboBox();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // cbCurso
            // 
            this.cbCurso.AutoResize = false;
            this.cbCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbCurso.Depth = 0;
            this.cbCurso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbCurso.DropDownHeight = 174;
            this.cbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurso.DropDownWidth = 121;
            this.cbCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Hint = "Selecciona un curso a cancelar";
            this.cbCurso.IntegralHeight = false;
            this.cbCurso.ItemHeight = 43;
            this.cbCurso.Location = new System.Drawing.Point(12, 131);
            this.cbCurso.MaxDropDownItems = 4;
            this.cbCurso.MouseState = MaterialSkin.MouseState.OUT;
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(384, 49);
            this.cbCurso.StartIndex = 0;
            this.cbCurso.TabIndex = 1;
            this.cbCurso.SelectedIndexChanged += new System.EventHandler(this.cbCurso_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = false;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(12, 200);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(384, 41);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "CANCELAR CURSO";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormCancelarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 436);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cbCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCancelarCurso";
            this.Text = "FormCancelarCurso";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cbCurso;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
    }
}