namespace View {
    partial class GenerarPrestec {
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
            this.dgvLlibres = new System.Windows.Forms.DataGridView();
            this.dgvUsuaris = new System.Windows.Forms.DataGridView();
            this.buttonGenerarPrestec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLlibres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuaris)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLlibres
            // 
            this.dgvLlibres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLlibres.Location = new System.Drawing.Point(404, 3);
            this.dgvLlibres.MultiSelect = false;
            this.dgvLlibres.Name = "dgvLlibres";
            this.dgvLlibres.ReadOnly = true;
            this.dgvLlibres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLlibres.Size = new System.Drawing.Size(396, 272);
            this.dgvLlibres.TabIndex = 10;
            // 
            // dgvUsuaris
            // 
            this.dgvUsuaris.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuaris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuaris.Location = new System.Drawing.Point(3, 3);
            this.dgvUsuaris.MultiSelect = false;
            this.dgvUsuaris.Name = "dgvUsuaris";
            this.dgvUsuaris.ReadOnly = true;
            this.dgvUsuaris.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuaris.Size = new System.Drawing.Size(396, 272);
            this.dgvUsuaris.TabIndex = 9;
            // 
            // buttonGenerarPrestec
            // 
            this.buttonGenerarPrestec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonGenerarPrestec.FlatAppearance.BorderSize = 0;
            this.buttonGenerarPrestec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerarPrestec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerarPrestec.ForeColor = System.Drawing.Color.White;
            this.buttonGenerarPrestec.Location = new System.Drawing.Point(331, 335);
            this.buttonGenerarPrestec.Name = "buttonGenerarPrestec";
            this.buttonGenerarPrestec.Size = new System.Drawing.Size(142, 41);
            this.buttonGenerarPrestec.TabIndex = 11;
            this.buttonGenerarPrestec.Text = "Generar prestec";
            this.buttonGenerarPrestec.UseVisualStyleBackColor = false;
            // 
            // GenerarPrestec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonGenerarPrestec);
            this.Controls.Add(this.dgvLlibres);
            this.Controls.Add(this.dgvUsuaris);
            this.Name = "GenerarPrestec";
            this.Size = new System.Drawing.Size(803, 426);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLlibres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuaris)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvLlibres;
        public System.Windows.Forms.DataGridView dgvUsuaris;
        public System.Windows.Forms.Button buttonGenerarPrestec;
    }
}
