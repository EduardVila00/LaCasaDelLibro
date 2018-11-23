namespace View {
    partial class Configuracio {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracio));
            this.buttonChangeColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonDefaultColor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.buttonChangeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonChangeColor.FlatAppearance.BorderSize = 0;
            this.buttonChangeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeColor.ForeColor = System.Drawing.Color.White;
            this.buttonChangeColor.Location = new System.Drawing.Point(331, 187);
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Size = new System.Drawing.Size(142, 41);
            this.buttonChangeColor.TabIndex = 2;
            this.buttonChangeColor.Text = "Cambiar Color";
            this.buttonChangeColor.UseVisualStyleBackColor = false;
            // 
            // buttonDefaultColor
            // 
            this.buttonDefaultColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonDefaultColor.FlatAppearance.BorderSize = 0;
            this.buttonDefaultColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDefaultColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDefaultColor.ForeColor = System.Drawing.Color.White;
            this.buttonDefaultColor.Location = new System.Drawing.Point(331, 248);
            this.buttonDefaultColor.Name = "buttonDefaultColor";
            this.buttonDefaultColor.Size = new System.Drawing.Size(142, 41);
            this.buttonDefaultColor.TabIndex = 3;
            this.buttonDefaultColor.Text = "Default";
            this.buttonDefaultColor.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(331, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Configuracio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDefaultColor);
            this.Controls.Add(this.buttonChangeColor);
            this.Name = "Configuracio";
            this.Size = new System.Drawing.Size(803, 426);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button buttonChangeColor;
        public System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.Button buttonDefaultColor;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}
