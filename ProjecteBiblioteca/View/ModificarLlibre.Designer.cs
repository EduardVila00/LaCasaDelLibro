﻿namespace View {
    partial class ModificarLlibre {
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
            this.buttonModificar = new System.Windows.Forms.Button();
            this.textBoxIsbn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEditorial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumPagines = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIdioma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAfegirAutors = new System.Windows.Forms.Button();
            this.dgvAutors = new System.Windows.Forms.DataGridView();
            this.checkBoxSwitchAutors = new System.Windows.Forms.CheckBox();
            this.buttonEliminarAutors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutors)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonModificar.FlatAppearance.BorderSize = 0;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.ForeColor = System.Drawing.Color.White;
            this.buttonModificar.Location = new System.Drawing.Point(343, 345);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(142, 41);
            this.buttonModificar.TabIndex = 9;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            // 
            // textBoxIsbn
            // 
            this.textBoxIsbn.Enabled = false;
            this.textBoxIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIsbn.Location = new System.Drawing.Point(34, 69);
            this.textBoxIsbn.Name = "textBoxIsbn";
            this.textBoxIsbn.Size = new System.Drawing.Size(194, 26);
            this.textBoxIsbn.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "ISBN";
            // 
            // textBoxTitol
            // 
            this.textBoxTitol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitol.Location = new System.Drawing.Point(36, 135);
            this.textBoxTitol.Name = "textBoxTitol";
            this.textBoxTitol.Size = new System.Drawing.Size(194, 26);
            this.textBoxTitol.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Titol";
            // 
            // textBoxEditorial
            // 
            this.textBoxEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditorial.Location = new System.Drawing.Point(38, 260);
            this.textBoxEditorial.Name = "textBoxEditorial";
            this.textBoxEditorial.Size = new System.Drawing.Size(194, 26);
            this.textBoxEditorial.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Editorial";
            // 
            // textBoxNumPagines
            // 
            this.textBoxNumPagines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumPagines.Location = new System.Drawing.Point(39, 201);
            this.textBoxNumPagines.Name = "textBoxNumPagines";
            this.textBoxNumPagines.Size = new System.Drawing.Size(194, 26);
            this.textBoxNumPagines.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Numero de pagines";
            // 
            // textBoxIdioma
            // 
            this.textBoxIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdioma.Location = new System.Drawing.Point(38, 326);
            this.textBoxIdioma.Name = "textBoxIdioma";
            this.textBoxIdioma.Size = new System.Drawing.Size(195, 26);
            this.textBoxIdioma.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Idioma";
            // 
            // buttonAfegirAutors
            // 
            this.buttonAfegirAutors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonAfegirAutors.FlatAppearance.BorderSize = 0;
            this.buttonAfegirAutors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAfegirAutors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfegirAutors.ForeColor = System.Drawing.Color.White;
            this.buttonAfegirAutors.Location = new System.Drawing.Point(648, 292);
            this.buttonAfegirAutors.Name = "buttonAfegirAutors";
            this.buttonAfegirAutors.Size = new System.Drawing.Size(142, 41);
            this.buttonAfegirAutors.TabIndex = 19;
            this.buttonAfegirAutors.Text = "Afegir";
            this.buttonAfegirAutors.UseVisualStyleBackColor = false;
            // 
            // dgvAutors
            // 
            this.dgvAutors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutors.Location = new System.Drawing.Point(367, 25);
            this.dgvAutors.MultiSelect = false;
            this.dgvAutors.Name = "dgvAutors";
            this.dgvAutors.ReadOnly = true;
            this.dgvAutors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutors.Size = new System.Drawing.Size(423, 261);
            this.dgvAutors.TabIndex = 18;
            // 
            // checkBoxSwitchAutors
            // 
            this.checkBoxSwitchAutors.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxSwitchAutors.AutoSize = true;
            this.checkBoxSwitchAutors.Location = new System.Drawing.Point(570, 0);
            this.checkBoxSwitchAutors.Name = "checkBoxSwitchAutors";
            this.checkBoxSwitchAutors.Size = new System.Drawing.Size(49, 23);
            this.checkBoxSwitchAutors.TabIndex = 20;
            this.checkBoxSwitchAutors.Text = "Switch";
            this.checkBoxSwitchAutors.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarAutors
            // 
            this.buttonEliminarAutors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonEliminarAutors.FlatAppearance.BorderSize = 0;
            this.buttonEliminarAutors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarAutors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarAutors.ForeColor = System.Drawing.Color.White;
            this.buttonEliminarAutors.Location = new System.Drawing.Point(648, 292);
            this.buttonEliminarAutors.Name = "buttonEliminarAutors";
            this.buttonEliminarAutors.Size = new System.Drawing.Size(142, 41);
            this.buttonEliminarAutors.TabIndex = 21;
            this.buttonEliminarAutors.Text = "Eliminar";
            this.buttonEliminarAutors.UseVisualStyleBackColor = false;
            // 
            // ModificarLlibre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAfegirAutors);
            this.Controls.Add(this.buttonEliminarAutors);
            this.Controls.Add(this.checkBoxSwitchAutors);
            this.Controls.Add(this.dgvAutors);
            this.Controls.Add(this.textBoxIdioma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxEditorial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNumPagines);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTitol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.textBoxIsbn);
            this.Controls.Add(this.label1);
            this.Name = "ModificarLlibre";
            this.Size = new System.Drawing.Size(803, 426);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxIdioma;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxEditorial;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxNumPagines;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxTitol;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button buttonModificar;
        public System.Windows.Forms.TextBox textBoxIsbn;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button buttonAfegirAutors;
        public System.Windows.Forms.DataGridView dgvAutors;
        public System.Windows.Forms.CheckBox checkBoxSwitchAutors;
        public System.Windows.Forms.Button buttonEliminarAutors;
    }
}
