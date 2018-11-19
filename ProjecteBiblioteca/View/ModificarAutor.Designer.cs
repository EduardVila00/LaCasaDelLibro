namespace View {
    partial class ModificarAutor {
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxCognoms = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonAfegirLlibres = new System.Windows.Forms.Button();
            this.dgvLlibres = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLlibres)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(47, 97);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 26);
            this.textBoxNom.TabIndex = 1;
            // 
            // textBoxCognoms
            // 
            this.textBoxCognoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCognoms.Location = new System.Drawing.Point(46, 181);
            this.textBoxCognoms.Name = "textBoxCognoms";
            this.textBoxCognoms.Size = new System.Drawing.Size(161, 26);
            this.textBoxCognoms.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cognoms";
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonModificar.FlatAppearance.BorderSize = 0;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.ForeColor = System.Drawing.Color.White;
            this.buttonModificar.Location = new System.Drawing.Point(326, 345);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(142, 41);
            this.buttonModificar.TabIndex = 4;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            // 
            // buttonAfegirLlibres
            // 
            this.buttonAfegirLlibres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonAfegirLlibres.FlatAppearance.BorderSize = 0;
            this.buttonAfegirLlibres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAfegirLlibres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfegirLlibres.ForeColor = System.Drawing.Color.White;
            this.buttonAfegirLlibres.Location = new System.Drawing.Point(634, 295);
            this.buttonAfegirLlibres.Name = "buttonAfegirLlibres";
            this.buttonAfegirLlibres.Size = new System.Drawing.Size(142, 41);
            this.buttonAfegirLlibres.TabIndex = 8;
            this.buttonAfegirLlibres.Text = "Afegir";
            this.buttonAfegirLlibres.UseVisualStyleBackColor = false;
            // 
            // dgvLlibres
            // 
            this.dgvLlibres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLlibres.Location = new System.Drawing.Point(353, 28);
            this.dgvLlibres.MultiSelect = false;
            this.dgvLlibres.Name = "dgvLlibres";
            this.dgvLlibres.ReadOnly = true;
            this.dgvLlibres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLlibres.Size = new System.Drawing.Size(423, 261);
            this.dgvLlibres.TabIndex = 7;
            // 
            // ModificarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAfegirLlibres);
            this.Controls.Add(this.dgvLlibres);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.textBoxCognoms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.label1);
            this.Name = "ModificarAutor";
            this.Size = new System.Drawing.Size(803, 426);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLlibres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonModificar;
        public System.Windows.Forms.TextBox textBoxCognoms;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxNom;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button buttonAfegirLlibres;
        public System.Windows.Forms.DataGridView dgvLlibres;
    }
}
