namespace View {
    partial class Prestec {
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
            this.buttonGenerarPrestec = new System.Windows.Forms.Button();
            this.buttonFinalitzarPrestec = new System.Windows.Forms.Button();
            this.dgvPrestecs = new System.Windows.Forms.DataGridView();
            this.dgvUsuaris = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestecs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuaris)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGenerarPrestec
            // 
            this.buttonGenerarPrestec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonGenerarPrestec.FlatAppearance.BorderSize = 0;
            this.buttonGenerarPrestec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerarPrestec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerarPrestec.ForeColor = System.Drawing.Color.White;
            this.buttonGenerarPrestec.Location = new System.Drawing.Point(92, 362);
            this.buttonGenerarPrestec.Name = "buttonGenerarPrestec";
            this.buttonGenerarPrestec.Size = new System.Drawing.Size(142, 41);
            this.buttonGenerarPrestec.TabIndex = 1;
            this.buttonGenerarPrestec.Text = "Generar prestec";
            this.buttonGenerarPrestec.UseVisualStyleBackColor = false;
            // 
            // buttonFinalitzarPrestec
            // 
            this.buttonFinalitzarPrestec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonFinalitzarPrestec.FlatAppearance.BorderSize = 0;
            this.buttonFinalitzarPrestec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinalitzarPrestec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinalitzarPrestec.ForeColor = System.Drawing.Color.White;
            this.buttonFinalitzarPrestec.Location = new System.Drawing.Point(341, 362);
            this.buttonFinalitzarPrestec.Name = "buttonFinalitzarPrestec";
            this.buttonFinalitzarPrestec.Size = new System.Drawing.Size(142, 41);
            this.buttonFinalitzarPrestec.TabIndex = 3;
            this.buttonFinalitzarPrestec.Text = "Finalitzar prestec";
            this.buttonFinalitzarPrestec.UseVisualStyleBackColor = false;
            // 
            // dgvPrestecs
            // 
            this.dgvPrestecs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestecs.Location = new System.Drawing.Point(404, 3);
            this.dgvPrestecs.MultiSelect = false;
            this.dgvPrestecs.Name = "dgvPrestecs";
            this.dgvPrestecs.ReadOnly = true;
            this.dgvPrestecs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestecs.Size = new System.Drawing.Size(396, 272);
            this.dgvPrestecs.TabIndex = 8;
            // 
            // dgvUsuaris
            // 
            this.dgvUsuaris.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuaris.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsuaris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuaris.Location = new System.Drawing.Point(3, 3);
            this.dgvUsuaris.MultiSelect = false;
            this.dgvUsuaris.Name = "dgvUsuaris";
            this.dgvUsuaris.ReadOnly = true;
            this.dgvUsuaris.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuaris.Size = new System.Drawing.Size(396, 272);
            this.dgvUsuaris.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(631, 307);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 25);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // Prestec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dgvPrestecs);
            this.Controls.Add(this.dgvUsuaris);
            this.Controls.Add(this.buttonFinalitzarPrestec);
            this.Controls.Add(this.buttonGenerarPrestec);
            this.Name = "Prestec";
            this.Size = new System.Drawing.Size(803, 426);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestecs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuaris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonFinalitzarPrestec;
        public System.Windows.Forms.Button buttonGenerarPrestec;
        public System.Windows.Forms.DataGridView dgvPrestecs;
        public System.Windows.Forms.DataGridView dgvUsuaris;
        public System.Windows.Forms.CheckBox checkBox1;
    }
}
