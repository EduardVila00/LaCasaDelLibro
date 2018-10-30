namespace View {
    partial class Calendari {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tornarAlMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortirDelProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttondesabilitar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvDiesNoHabils = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonHabilitar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiesNoHabils)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tornarAlMenuToolStripMenuItem,
            this.sortirDelProgramaToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // tornarAlMenuToolStripMenuItem
            // 
            this.tornarAlMenuToolStripMenuItem.Name = "tornarAlMenuToolStripMenuItem";
            this.tornarAlMenuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tornarAlMenuToolStripMenuItem.Text = "Tornar al menu";
            // 
            // sortirDelProgramaToolStripMenuItem
            // 
            this.sortirDelProgramaToolStripMenuItem.Name = "sortirDelProgramaToolStripMenuItem";
            this.sortirDelProgramaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sortirDelProgramaToolStripMenuItem.Text = "Sortir del programa";
            // 
            // buttondesabilitar
            // 
            this.buttondesabilitar.Location = new System.Drawing.Point(411, 117);
            this.buttondesabilitar.Name = "buttondesabilitar";
            this.buttondesabilitar.Size = new System.Drawing.Size(75, 44);
            this.buttondesabilitar.TabIndex = 2;
            this.buttondesabilitar.Text = "Deshabilitar dia";
            this.buttondesabilitar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(540, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dgvDiesNoHabils
            // 
            this.dgvDiesNoHabils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiesNoHabils.Location = new System.Drawing.Point(29, 117);
            this.dgvDiesNoHabils.Name = "dgvDiesNoHabils";
            this.dgvDiesNoHabils.Size = new System.Drawing.Size(295, 187);
            this.dgvDiesNoHabils.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dies no habils";
            // 
            // buttonHabilitar
            // 
            this.buttonHabilitar.Location = new System.Drawing.Point(122, 331);
            this.buttonHabilitar.Name = "buttonHabilitar";
            this.buttonHabilitar.Size = new System.Drawing.Size(75, 23);
            this.buttonHabilitar.TabIndex = 6;
            this.buttonHabilitar.Text = "Habilitar dia";
            this.buttonHabilitar.UseVisualStyleBackColor = true;
            // 
            // Calendari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHabilitar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDiesNoHabils);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttondesabilitar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Calendari";
            this.Text = "Calendari";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiesNoHabils)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem tornarAlMenuToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem sortirDelProgramaToolStripMenuItem;
        public System.Windows.Forms.Button buttondesabilitar;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.DataGridView dgvDiesNoHabils;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button buttonHabilitar;
    }
}