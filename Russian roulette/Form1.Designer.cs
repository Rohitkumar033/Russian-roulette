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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_spin = new System.Windows.Forms.Button();
            this.btn_shoot = new System.Windows.Forms.Button();
            this.btn_shootaway = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btn_playagain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(207, 103);
            this.btn_load.Margin = new System.Windows.Forms.Padding(4);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(100, 47);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "load";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.Btn_load_Click);
            // 
            // btn_spin
            // 
            this.btn_spin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_spin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_spin.Location = new System.Drawing.Point(207, 171);
            this.btn_spin.Margin = new System.Windows.Forms.Padding(4);
            this.btn_spin.Name = "btn_spin";
            this.btn_spin.Size = new System.Drawing.Size(100, 46);
            this.btn_spin.TabIndex = 1;
            this.btn_spin.Text = "spin";
            this.btn_spin.UseVisualStyleBackColor = false;
            this.btn_spin.Click += new System.EventHandler(this.Btn_spin_Click);
            // 
            // btn_shoot
            // 
            this.btn_shoot.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_shoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shoot.Location = new System.Drawing.Point(207, 238);
            this.btn_shoot.Margin = new System.Windows.Forms.Padding(4);
            this.btn_shoot.Name = "btn_shoot";
            this.btn_shoot.Size = new System.Drawing.Size(100, 47);
            this.btn_shoot.TabIndex = 2;
            this.btn_shoot.Text = "shoot";
            this.btn_shoot.UseVisualStyleBackColor = false;
            this.btn_shoot.Click += new System.EventHandler(this.Btn_shoot_Click);
            // 
            // btn_shootaway
            // 
            this.btn_shootaway.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_shootaway.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shootaway.Location = new System.Drawing.Point(207, 309);
            this.btn_shootaway.Margin = new System.Windows.Forms.Padding(4);
            this.btn_shootaway.Name = "btn_shootaway";
            this.btn_shootaway.Size = new System.Drawing.Size(100, 62);
            this.btn_shootaway.TabIndex = 3;
            this.btn_shootaway.Text = "shootaway";
            this.btn_shootaway.UseVisualStyleBackColor = false;
            this.btn_shootaway.Click += new System.EventHandler(this.Btn_shootaway_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(456, 103);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(457, 266);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // btn_playagain
            // 
            this.btn_playagain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_playagain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playagain.ForeColor = System.Drawing.Color.Orange;
            this.btn_playagain.Location = new System.Drawing.Point(344, 401);
            this.btn_playagain.Margin = new System.Windows.Forms.Padding(4);
            this.btn_playagain.Name = "btn_playagain";
            this.btn_playagain.Size = new System.Drawing.Size(163, 52);
            this.btn_playagain.TabIndex = 5;
            this.btn_playagain.Text = "playagain";
            this.btn_playagain.UseVisualStyleBackColor = false;
            this.btn_playagain.Click += new System.EventHandler(this.Btn_playagain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_playagain);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btn_shootaway);
            this.Controls.Add(this.btn_shoot);
            this.Controls.Add(this.btn_spin);
            this.Controls.Add(this.btn_load);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_spin;
        private System.Windows.Forms.Button btn_shoot;
        private System.Windows.Forms.Button btn_shootaway;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btn_playagain;
    }
}

