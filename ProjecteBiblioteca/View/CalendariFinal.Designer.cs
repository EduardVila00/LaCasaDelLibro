namespace View {
    partial class CalendariFinal {
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDes = new System.Windows.Forms.Button();
            this.buttonHabilitar = new System.Windows.Forms.Button();
            this.dateTimePickerDes = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHab = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(225, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(349, 420);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonDes
            // 
            this.buttonDes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonDes.FlatAppearance.BorderSize = 0;
            this.buttonDes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDes.ForeColor = System.Drawing.Color.White;
            this.buttonDes.Location = new System.Drawing.Point(36, 80);
            this.buttonDes.Name = "buttonDes";
            this.buttonDes.Size = new System.Drawing.Size(142, 41);
            this.buttonDes.TabIndex = 1;
            this.buttonDes.Text = "Deshabilitar dia";
            this.buttonDes.UseVisualStyleBackColor = false;
            // 
            // buttonHabilitar
            // 
            this.buttonHabilitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonHabilitar.FlatAppearance.BorderSize = 0;
            this.buttonHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHabilitar.ForeColor = System.Drawing.Color.White;
            this.buttonHabilitar.Location = new System.Drawing.Point(620, 80);
            this.buttonHabilitar.Name = "buttonHabilitar";
            this.buttonHabilitar.Size = new System.Drawing.Size(142, 41);
            this.buttonHabilitar.TabIndex = 2;
            this.buttonHabilitar.Text = "Habilitar dia";
            this.buttonHabilitar.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerDes
            // 
            this.dateTimePickerDes.Location = new System.Drawing.Point(19, 28);
            this.dateTimePickerDes.Name = "dateTimePickerDes";
            this.dateTimePickerDes.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDes.TabIndex = 4;
            // 
            // dateTimePickerHab
            // 
            this.dateTimePickerHab.Enabled = false;
            this.dateTimePickerHab.Location = new System.Drawing.Point(590, 28);
            this.dateTimePickerHab.Name = "dateTimePickerHab";
            this.dateTimePickerHab.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerHab.TabIndex = 5;
            // 
            // CalendariFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePickerHab);
            this.Controls.Add(this.dateTimePickerDes);
            this.Controls.Add(this.buttonHabilitar);
            this.Controls.Add(this.buttonDes);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CalendariFinal";
            this.Size = new System.Drawing.Size(803, 426);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button buttonHabilitar;
        public System.Windows.Forms.Button buttonDes;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DateTimePicker dateTimePickerDes;
        public System.Windows.Forms.DateTimePicker dateTimePickerHab;
    }
}
