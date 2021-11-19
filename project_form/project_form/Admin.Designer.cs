namespace project_form
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonlogout = new System.Windows.Forms.Button();
            this.buttonmanage = new System.Windows.Forms.Button();
            this.buttonaccount = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonexit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.buttonlogout);
            this.panel1.Controls.Add(this.buttonmanage);
            this.panel1.Controls.Add(this.buttonaccount);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 553);
            this.panel1.TabIndex = 0;
            // 
            // buttonlogout
            // 
            this.buttonlogout.FlatAppearance.BorderSize = 0;
            this.buttonlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogout.ForeColor = System.Drawing.Color.White;
            this.buttonlogout.Image = global::project_form.Properties.Resources.logout1;
            this.buttonlogout.Location = new System.Drawing.Point(0, 503);
            this.buttonlogout.Name = "buttonlogout";
            this.buttonlogout.Size = new System.Drawing.Size(182, 47);
            this.buttonlogout.TabIndex = 4;
            this.buttonlogout.Text = "Log out";
            this.buttonlogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonlogout.UseVisualStyleBackColor = true;
            this.buttonlogout.Click += new System.EventHandler(this.button2_Click);
            this.buttonlogout.MouseEnter += new System.EventHandler(this.buttonlogout_MouseEnter);
            this.buttonlogout.MouseLeave += new System.EventHandler(this.buttonlogout_MouseLeave);
            // 
            // buttonmanage
            // 
            this.buttonmanage.FlatAppearance.BorderSize = 0;
            this.buttonmanage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmanage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmanage.ForeColor = System.Drawing.Color.White;
            this.buttonmanage.Image = ((System.Drawing.Image)(resources.GetObject("buttonmanage.Image")));
            this.buttonmanage.Location = new System.Drawing.Point(0, 228);
            this.buttonmanage.Name = "buttonmanage";
            this.buttonmanage.Size = new System.Drawing.Size(182, 47);
            this.buttonmanage.TabIndex = 3;
            this.buttonmanage.Text = "Nhân viên";
            this.buttonmanage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonmanage.UseVisualStyleBackColor = true;
            this.buttonmanage.Click += new System.EventHandler(this.button1_Click);
            this.buttonmanage.MouseEnter += new System.EventHandler(this.buttonmanage_MouseEnter);
            this.buttonmanage.MouseLeave += new System.EventHandler(this.buttonmanage_MouseLeave);
            // 
            // buttonaccount
            // 
            this.buttonaccount.FlatAppearance.BorderSize = 0;
            this.buttonaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonaccount.ForeColor = System.Drawing.Color.White;
            this.buttonaccount.Image = global::project_form.Properties.Resources.account1;
            this.buttonaccount.Location = new System.Drawing.Point(2, 175);
            this.buttonaccount.Name = "buttonaccount";
            this.buttonaccount.Size = new System.Drawing.Size(177, 47);
            this.buttonaccount.TabIndex = 2;
            this.buttonaccount.Text = "Account";
            this.buttonaccount.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonaccount.UseVisualStyleBackColor = true;
            this.buttonaccount.Click += new System.EventHandler(this.buttonhome_Click);
            this.buttonaccount.MouseEnter += new System.EventHandler(this.buttonhome_MouseEnter);
            this.buttonaccount.MouseLeave += new System.EventHandler(this.buttonhome_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 166);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::project_form.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(186, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 46);
            this.label2.TabIndex = 7;
            this.label2.Text = "Manage";
            // 
            // buttonexit
            // 
            this.buttonexit.BackColor = System.Drawing.Color.Black;
            this.buttonexit.FlatAppearance.BorderSize = 2;
            this.buttonexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexit.ForeColor = System.Drawing.Color.White;
            this.buttonexit.Location = new System.Drawing.Point(960, 0);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(32, 28);
            this.buttonexit.TabIndex = 8;
            this.buttonexit.Text = "X";
            this.buttonexit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonexit.UseVisualStyleBackColor = false;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            this.buttonexit.MouseEnter += new System.EventHandler(this.buttonexit_MouseEnter);
            this.buttonexit.MouseLeave += new System.EventHandler(this.buttonexit_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(183, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(809, 509);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.buttonexit);
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(992, 28);
            this.panel4.TabIndex = 0;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::project_form.Properties.Resources.minimize4;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(922, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 28);
            this.button3.TabIndex = 16;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(993, 590);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonmanage;
        private System.Windows.Forms.Button buttonaccount;
        private System.Windows.Forms.Button buttonlogout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;

    }
}