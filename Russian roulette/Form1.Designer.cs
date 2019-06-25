namespace Russian_roulette
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_spin = new System.Windows.Forms.Button();
            this.btn_shoot = new System.Windows.Forms.Button();
            this.btn_shootaway = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_load.Location = new System.Drawing.Point(155, 84);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 38);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "load";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.Btn_load_Click);
            // 
            // btn_spin
            // 
            this.btn_spin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_spin.Location = new System.Drawing.Point(155, 139);
            this.btn_spin.Name = "btn_spin";
            this.btn_spin.Size = new System.Drawing.Size(75, 37);
            this.btn_spin.TabIndex = 1;
            this.btn_spin.Text = "spin";
            this.btn_spin.UseVisualStyleBackColor = false;
            // 
            // btn_shoot
            // 
            this.btn_shoot.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_shoot.Location = new System.Drawing.Point(155, 193);
            this.btn_shoot.Name = "btn_shoot";
            this.btn_shoot.Size = new System.Drawing.Size(75, 38);
            this.btn_shoot.TabIndex = 2;
            this.btn_shoot.Text = "shoot";
            this.btn_shoot.UseVisualStyleBackColor = false;
            // 
            // btn_shootaway
            // 
            this.btn_shootaway.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_shootaway.Location = new System.Drawing.Point(155, 251);
            this.btn_shootaway.Name = "btn_shootaway";
            this.btn_shootaway.Size = new System.Drawing.Size(75, 38);
            this.btn_shootaway.TabIndex = 3;
            this.btn_shootaway.Text = "shootaway";
            this.btn_shootaway.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Russian_roulette.Properties.Resources.bann;
            this.pictureBox1.Location = new System.Drawing.Point(528, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 177);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Russian_roulette.Properties.Resources.goli222;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_shootaway);
            this.Controls.Add(this.btn_shoot);
            this.Controls.Add(this.btn_spin);
            this.Controls.Add(this.btn_load);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_spin;
        private System.Windows.Forms.Button btn_shoot;
        private System.Windows.Forms.Button btn_shootaway;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

