﻿namespace AppAsistenciasV2
{
    partial class FormVerAsistencia
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
            this.cbVerCursos = new MaterialSkin.Controls.MaterialComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbVerCursos
            // 
            this.cbVerCursos.AutoResize = false;
            this.cbVerCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbVerCursos.Depth = 0;
            this.cbVerCursos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbVerCursos.DropDownHeight = 174;
            this.cbVerCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVerCursos.DropDownWidth = 121;
            this.cbVerCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbVerCursos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbVerCursos.FormattingEnabled = true;
            this.cbVerCursos.Hint = "Selecciona un curso a visualizar";
            this.cbVerCursos.IntegralHeight = false;
            this.cbVerCursos.ItemHeight = 43;
            this.cbVerCursos.Location = new System.Drawing.Point(12, 48);
            this.cbVerCursos.MaxDropDownItems = 4;
            this.cbVerCursos.MouseState = MaterialSkin.MouseState.OUT;
            this.cbVerCursos.Name = "cbVerCursos";
            this.cbVerCursos.Size = new System.Drawing.Size(384, 49);
            this.cbVerCursos.StartIndex = 0;
            this.cbVerCursos.TabIndex = 0;
            this.cbVerCursos.SelectedIndexChanged += new System.EventHandler(this.cbVerCursos_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(384, 210);
            this.dataGridView1.TabIndex = 1;
            // 
            // FormVerAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 436);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbVerCursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVerAsistencia";
            this.Text = "FormVerAsistencia";
            this.Load += new System.EventHandler(this.FormVerAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cbVerCursos;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}