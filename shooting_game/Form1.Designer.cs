namespace shooting_game
{
    partial class Game_Interface
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pointatstomach = new System.Windows.Forms.RadioButton();
            this.pointathead = new System.Windows.Forms.RadioButton();
            this.loadbullet = new System.Windows.Forms.Button();
            this.spinchamber = new System.Windows.Forms.Button();
            this.playagain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firebutton = new System.Windows.Forms.Button();
            this.gunpicturebox = new System.Windows.Forms.PictureBox();
            this.manpicturebox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunpicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manpicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pointatstomach);
            this.groupBox1.Controls.Add(this.pointathead);
            this.groupBox1.Location = new System.Drawing.Point(531, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 139);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // pointatstomach
            // 
            this.pointatstomach.AutoSize = true;
            this.pointatstomach.Location = new System.Drawing.Point(7, 49);
            this.pointatstomach.Name = "pointatstomach";
            this.pointatstomach.Size = new System.Drawing.Size(137, 21);
            this.pointatstomach.TabIndex = 1;
            this.pointatstomach.TabStop = true;
            this.pointatstomach.Text = "Point At Stomach";
            this.pointatstomach.UseVisualStyleBackColor = true;
            // 
            // pointathead
            // 
            this.pointathead.AutoSize = true;
            this.pointathead.Location = new System.Drawing.Point(7, 22);
            this.pointathead.Name = "pointathead";
            this.pointathead.Size = new System.Drawing.Size(116, 21);
            this.pointathead.TabIndex = 0;
            this.pointathead.TabStop = true;
            this.pointathead.Text = "Point At Head";
            this.pointathead.UseVisualStyleBackColor = true;
            // 
            // loadbullet
            // 
            this.loadbullet.Location = new System.Drawing.Point(601, 200);
            this.loadbullet.Name = "loadbullet";
            this.loadbullet.Size = new System.Drawing.Size(162, 29);
            this.loadbullet.TabIndex = 3;
            this.loadbullet.Text = "Load Bullet";
            this.loadbullet.UseVisualStyleBackColor = true;
            this.loadbullet.Click += new System.EventHandler(this.button1_Click);
            // 
            // spinchamber
            // 
            this.spinchamber.Location = new System.Drawing.Point(601, 235);
            this.spinchamber.Name = "spinchamber";
            this.spinchamber.Size = new System.Drawing.Size(162, 29);
            this.spinchamber.TabIndex = 4;
            this.spinchamber.Text = "Spin Chamber";
            this.spinchamber.UseVisualStyleBackColor = true;
            this.spinchamber.Click += new System.EventHandler(this.button2_Click);
            // 
            // playagain
            // 
            this.playagain.Location = new System.Drawing.Point(601, 270);
            this.playagain.Name = "playagain";
            this.playagain.Size = new System.Drawing.Size(162, 29);
            this.playagain.TabIndex = 5;
            this.playagain.Text = "Play Again";
            this.playagain.UseVisualStyleBackColor = true;
            this.playagain.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(86, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 46);
            this.label2.TabIndex = 7;
            // 
            // firebutton
            // 
            this.firebutton.Enabled = false;
            this.firebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firebutton.Location = new System.Drawing.Point(110, 340);
            this.firebutton.Name = "firebutton";
            this.firebutton.Size = new System.Drawing.Size(426, 53);
            this.firebutton.TabIndex = 8;
            this.firebutton.Text = "Fire";
            this.firebutton.UseVisualStyleBackColor = true;
            this.firebutton.Click += new System.EventHandler(this.button4_Click);
            // 
            // gunpicturebox
            // 
            this.gunpicturebox.Location = new System.Drawing.Point(234, 91);
            this.gunpicturebox.Name = "gunpicturebox";
            this.gunpicturebox.Size = new System.Drawing.Size(211, 130);
            this.gunpicturebox.TabIndex = 9;
            this.gunpicturebox.TabStop = false;
            // 
            // manpicturebox
            // 
            this.manpicturebox.Location = new System.Drawing.Point(12, 42);
            this.manpicturebox.Name = "manpicturebox";
            this.manpicturebox.Size = new System.Drawing.Size(226, 202);
            this.manpicturebox.TabIndex = 0;
            this.manpicturebox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(179, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Game_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(896, 554);
            this.Controls.Add(this.gunpicturebox);
            this.Controls.Add(this.firebutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playagain);
            this.Controls.Add(this.spinchamber);
            this.Controls.Add(this.loadbullet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.manpicturebox);
            this.Name = "Game_Interface";
            this.Text = "Shooting Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunpicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manpicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox manpicturebox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton pointatstomach;
        private System.Windows.Forms.RadioButton pointathead;
        private System.Windows.Forms.Button loadbullet;
        private System.Windows.Forms.Button spinchamber;
        private System.Windows.Forms.Button playagain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button firebutton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox gunpicturebox;
    }
}

