﻿namespace View {
    partial class Copia {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonAfegir = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.dgvCopies = new System.Windows.Forms.DataGridView();
            this.dgvLlibres = new System.Windows.Forms.DataGridView();
            this.checkBoxDeshabilitats = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLlibres)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAfegir
            // 
            this.buttonAfegir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonAfegir.FlatAppearance.BorderSize = 0;
            this.buttonAfegir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAfegir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfegir.ForeColor = System.Drawing.Color.White;
            this.buttonAfegir.Location = new System.Drawing.Point(106, 362);
            this.buttonAfegir.Name = "buttonAfegir";
            this.buttonAfegir.Size = new System.Drawing.Size(142, 41);
            this.buttonAfegir.TabIndex = 1;
            this.buttonAfegir.Text = "Afegir";
            this.buttonAfegir.UseVisualStyleBackColor = false;
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonModificar.FlatAppearance.BorderSize = 0;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.ForeColor = System.Drawing.Color.White;
            this.buttonModificar.Location = new System.Drawing.Point(331, 362);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(142, 41);
            this.buttonModificar.TabIndex = 2;
            this.buttonModificar.Text = "Canviar disponibilitat";
            this.buttonModificar.UseVisualStyleBackColor = false;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Location = new System.Drawing.Point(556, 362);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(142, 41);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // dgvCopies
            // 
            this.dgvCopies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCopies.Location = new System.Drawing.Point(404, 3);
            this.dgvCopies.MultiSelect = false;
            this.dgvCopies.Name = "dgvCopies";
            this.dgvCopies.ReadOnly = true;
            this.dgvCopies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCopies.Size = new System.Drawing.Size(396, 272);
            this.dgvCopies.TabIndex = 6;
            // 
            // dgvLlibres
            // 
            this.dgvLlibres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvLlibres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLlibres.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLlibres.Location = new System.Drawing.Point(3, 3);
            this.dgvLlibres.MultiSelect = false;
            this.dgvLlibres.Name = "dgvLlibres";
            this.dgvLlibres.ReadOnly = true;
            this.dgvLlibres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLlibres.Size = new System.Drawing.Size(396, 272);
            this.dgvLlibres.TabIndex = 5;
            // 
            // checkBoxDeshabilitats
            // 
            this.checkBoxDeshabilitats.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxDeshabilitats.AutoSize = true;
            this.checkBoxDeshabilitats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.checkBoxDeshabilitats.FlatAppearance.BorderSize = 0;
            this.checkBoxDeshabilitats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxDeshabilitats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDeshabilitats.ForeColor = System.Drawing.Color.White;
            this.checkBoxDeshabilitats.Location = new System.Drawing.Point(646, 281);
            this.checkBoxDeshabilitats.Name = "checkBoxDeshabilitats";
            this.checkBoxDeshabilitats.Size = new System.Drawing.Size(154, 25);
            this.checkBoxDeshabilitats.TabIndex = 13;
            this.checkBoxDeshabilitats.Text = "Mostrar Deshabilitats";
            this.checkBoxDeshabilitats.UseVisualStyleBackColor = false;
            // 
            // Copia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxDeshabilitats);
            this.Controls.Add(this.dgvCopies);
            this.Controls.Add(this.dgvLlibres);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAfegir);
            this.Name = "Copia";
            this.Size = new System.Drawing.Size(803, 426);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLlibres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonEliminar;
        public System.Windows.Forms.Button buttonModificar;
        public System.Windows.Forms.Button buttonAfegir;
        public System.Windows.Forms.DataGridView dgvCopies;
        public System.Windows.Forms.DataGridView dgvLlibres;
        public System.Windows.Forms.CheckBox checkBoxDeshabilitats;
    }
}
