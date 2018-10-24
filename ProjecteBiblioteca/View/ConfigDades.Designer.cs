namespace View {
    partial class ConfigDades {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgvLlibres = new System.Windows.Forms.DataGridView();
            this.dgvCopies = new System.Windows.Forms.DataGridView();
            this.dgvAutors = new System.Windows.Forms.DataGridView();
            this.labelAutors = new System.Windows.Forms.Label();
            this.labelLlibres = new System.Windows.Forms.Label();
            this.labelCopies = new System.Windows.Forms.Label();
            this.buttonAfegirAutor = new System.Windows.Forms.Button();
            this.buttonEliminarAutor = new System.Windows.Forms.Button();
            this.buttonModificarAutor = new System.Windows.Forms.Button();
            this.buttonModificarLlibre = new System.Windows.Forms.Button();
            this.buttonEliminarLlibre = new System.Windows.Forms.Button();
            this.buttonAfegirLlibre = new System.Windows.Forms.Button();
            this.buttonModificarCopia = new System.Windows.Forms.Button();
            this.buttonEliminarCopia = new System.Windows.Forms.Button();
            this.buttonAfegirCopia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLlibres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLlibres
            // 
            this.dgvLlibres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLlibres.Location = new System.Drawing.Point(334, 29);
            this.dgvLlibres.Name = "dgvLlibres";
            this.dgvLlibres.Size = new System.Drawing.Size(240, 262);
            this.dgvLlibres.TabIndex = 0;
            // 
            // dgvCopies
            // 
            this.dgvCopies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCopies.Location = new System.Drawing.Point(630, 29);
            this.dgvCopies.Name = "dgvCopies";
            this.dgvCopies.Size = new System.Drawing.Size(240, 262);
            this.dgvCopies.TabIndex = 1;
            // 
            // dgvAutors
            // 
            this.dgvAutors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutors.Location = new System.Drawing.Point(38, 29);
            this.dgvAutors.Name = "dgvAutors";
            this.dgvAutors.Size = new System.Drawing.Size(240, 262);
            this.dgvAutors.TabIndex = 2;
            // 
            // labelAutors
            // 
            this.labelAutors.AutoSize = true;
            this.labelAutors.Location = new System.Drawing.Point(35, 9);
            this.labelAutors.Name = "labelAutors";
            this.labelAutors.Size = new System.Drawing.Size(37, 13);
            this.labelAutors.TabIndex = 3;
            this.labelAutors.Text = "Autors";
            // 
            // labelLlibres
            // 
            this.labelLlibres.AutoSize = true;
            this.labelLlibres.Location = new System.Drawing.Point(331, 9);
            this.labelLlibres.Name = "labelLlibres";
            this.labelLlibres.Size = new System.Drawing.Size(37, 13);
            this.labelLlibres.TabIndex = 4;
            this.labelLlibres.Text = "Llibres";
            // 
            // labelCopies
            // 
            this.labelCopies.AutoSize = true;
            this.labelCopies.Location = new System.Drawing.Point(627, 9);
            this.labelCopies.Name = "labelCopies";
            this.labelCopies.Size = new System.Drawing.Size(39, 13);
            this.labelCopies.TabIndex = 5;
            this.labelCopies.Text = "Copies";
            // 
            // buttonAfegirAutor
            // 
            this.buttonAfegirAutor.Location = new System.Drawing.Point(38, 322);
            this.buttonAfegirAutor.Name = "buttonAfegirAutor";
            this.buttonAfegirAutor.Size = new System.Drawing.Size(75, 23);
            this.buttonAfegirAutor.TabIndex = 6;
            this.buttonAfegirAutor.Text = "Afegir";
            this.buttonAfegirAutor.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarAutor
            // 
            this.buttonEliminarAutor.Location = new System.Drawing.Point(203, 322);
            this.buttonEliminarAutor.Name = "buttonEliminarAutor";
            this.buttonEliminarAutor.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarAutor.TabIndex = 7;
            this.buttonEliminarAutor.Text = "Eliminar";
            this.buttonEliminarAutor.UseVisualStyleBackColor = true;
            // 
            // buttonModificarAutor
            // 
            this.buttonModificarAutor.Location = new System.Drawing.Point(119, 322);
            this.buttonModificarAutor.Name = "buttonModificarAutor";
            this.buttonModificarAutor.Size = new System.Drawing.Size(78, 23);
            this.buttonModificarAutor.TabIndex = 8;
            this.buttonModificarAutor.Text = "Modificar";
            this.buttonModificarAutor.UseVisualStyleBackColor = true;
            this.buttonModificarAutor.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonModificarLlibre
            // 
            this.buttonModificarLlibre.Location = new System.Drawing.Point(415, 322);
            this.buttonModificarLlibre.Name = "buttonModificarLlibre";
            this.buttonModificarLlibre.Size = new System.Drawing.Size(78, 23);
            this.buttonModificarLlibre.TabIndex = 11;
            this.buttonModificarLlibre.Text = "Modificar";
            this.buttonModificarLlibre.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarLlibre
            // 
            this.buttonEliminarLlibre.Location = new System.Drawing.Point(499, 322);
            this.buttonEliminarLlibre.Name = "buttonEliminarLlibre";
            this.buttonEliminarLlibre.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarLlibre.TabIndex = 10;
            this.buttonEliminarLlibre.Text = "Eliminar";
            this.buttonEliminarLlibre.UseVisualStyleBackColor = true;
            // 
            // buttonAfegirLlibre
            // 
            this.buttonAfegirLlibre.Location = new System.Drawing.Point(334, 322);
            this.buttonAfegirLlibre.Name = "buttonAfegirLlibre";
            this.buttonAfegirLlibre.Size = new System.Drawing.Size(75, 23);
            this.buttonAfegirLlibre.TabIndex = 9;
            this.buttonAfegirLlibre.Text = "Afegir";
            this.buttonAfegirLlibre.UseVisualStyleBackColor = true;
            this.buttonAfegirLlibre.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // buttonModificarCopia
            // 
            this.buttonModificarCopia.Location = new System.Drawing.Point(711, 322);
            this.buttonModificarCopia.Name = "buttonModificarCopia";
            this.buttonModificarCopia.Size = new System.Drawing.Size(78, 23);
            this.buttonModificarCopia.TabIndex = 14;
            this.buttonModificarCopia.Text = "Modificar";
            this.buttonModificarCopia.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarCopia
            // 
            this.buttonEliminarCopia.Location = new System.Drawing.Point(795, 322);
            this.buttonEliminarCopia.Name = "buttonEliminarCopia";
            this.buttonEliminarCopia.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarCopia.TabIndex = 13;
            this.buttonEliminarCopia.Text = "Eliminar";
            this.buttonEliminarCopia.UseVisualStyleBackColor = true;
            // 
            // buttonAfegirCopia
            // 
            this.buttonAfegirCopia.Location = new System.Drawing.Point(630, 322);
            this.buttonAfegirCopia.Name = "buttonAfegirCopia";
            this.buttonAfegirCopia.Size = new System.Drawing.Size(75, 23);
            this.buttonAfegirCopia.TabIndex = 12;
            this.buttonAfegirCopia.Text = "Afegir";
            this.buttonAfegirCopia.UseVisualStyleBackColor = true;
            // 
            // ConfigDades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.buttonModificarCopia);
            this.Controls.Add(this.buttonEliminarCopia);
            this.Controls.Add(this.buttonAfegirCopia);
            this.Controls.Add(this.buttonModificarLlibre);
            this.Controls.Add(this.buttonEliminarLlibre);
            this.Controls.Add(this.buttonAfegirLlibre);
            this.Controls.Add(this.buttonModificarAutor);
            this.Controls.Add(this.buttonEliminarAutor);
            this.Controls.Add(this.buttonAfegirAutor);
            this.Controls.Add(this.labelCopies);
            this.Controls.Add(this.labelLlibres);
            this.Controls.Add(this.labelAutors);
            this.Controls.Add(this.dgvAutors);
            this.Controls.Add(this.dgvCopies);
            this.Controls.Add(this.dgvLlibres);
            this.Name = "ConfigDades";
            this.Text = "ConfigDades";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLlibres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAutors;
        private System.Windows.Forms.Label labelLlibres;
        private System.Windows.Forms.Label labelCopies;
        public System.Windows.Forms.DataGridView dgvLlibres;
        public System.Windows.Forms.DataGridView dgvCopies;
        public System.Windows.Forms.DataGridView dgvAutors;
        public System.Windows.Forms.Button buttonAfegirAutor;
        public System.Windows.Forms.Button buttonEliminarAutor;
        public System.Windows.Forms.Button buttonModificarAutor;
        public System.Windows.Forms.Button buttonModificarLlibre;
        public System.Windows.Forms.Button buttonEliminarLlibre;
        public System.Windows.Forms.Button buttonAfegirLlibre;
        public System.Windows.Forms.Button buttonModificarCopia;
        public System.Windows.Forms.Button buttonEliminarCopia;
        public System.Windows.Forms.Button buttonAfegirCopia;
    }
}