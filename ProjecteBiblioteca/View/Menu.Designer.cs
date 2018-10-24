namespace View {
    partial class Menu {
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
            this.buttonDades = new System.Windows.Forms.Button();
            this.buttonSocis = new System.Windows.Forms.Button();
            this.buttonPrestecs = new System.Windows.Forms.Button();
            this.buttonCalendari = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDades
            // 
            this.buttonDades.Location = new System.Drawing.Point(197, 33);
            this.buttonDades.Name = "buttonDades";
            this.buttonDades.Size = new System.Drawing.Size(134, 71);
            this.buttonDades.TabIndex = 0;
            this.buttonDades.Text = "Administrar autors, llibres i copies";
            this.buttonDades.UseVisualStyleBackColor = true;
            // 
            // buttonSocis
            // 
            this.buttonSocis.Location = new System.Drawing.Point(197, 133);
            this.buttonSocis.Name = "buttonSocis";
            this.buttonSocis.Size = new System.Drawing.Size(134, 71);
            this.buttonSocis.TabIndex = 1;
            this.buttonSocis.Text = "Administrar socis";
            this.buttonSocis.UseVisualStyleBackColor = true;
            // 
            // buttonPrestecs
            // 
            this.buttonPrestecs.Location = new System.Drawing.Point(197, 234);
            this.buttonPrestecs.Name = "buttonPrestecs";
            this.buttonPrestecs.Size = new System.Drawing.Size(134, 71);
            this.buttonPrestecs.TabIndex = 2;
            this.buttonPrestecs.Text = "Administrar prestecs";
            this.buttonPrestecs.UseVisualStyleBackColor = true;
            // 
            // buttonCalendari
            // 
            this.buttonCalendari.Location = new System.Drawing.Point(197, 336);
            this.buttonCalendari.Name = "buttonCalendari";
            this.buttonCalendari.Size = new System.Drawing.Size(134, 71);
            this.buttonCalendari.TabIndex = 3;
            this.buttonCalendari.Text = "Calendari";
            this.buttonCalendari.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 467);
            this.Controls.Add(this.buttonCalendari);
            this.Controls.Add(this.buttonPrestecs);
            this.Controls.Add(this.buttonSocis);
            this.Controls.Add(this.buttonDades);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button buttonDades;
        public System.Windows.Forms.Button buttonSocis;
        public System.Windows.Forms.Button buttonPrestecs;
        public System.Windows.Forms.Button buttonCalendari;
    }
}