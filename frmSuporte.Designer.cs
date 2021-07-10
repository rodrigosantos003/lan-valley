
namespace LanValley
{
    partial class frmSuporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuporte));
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Facebook = new System.Windows.Forms.Button();
            this.btn_Instagram = new System.Windows.Forms.Button();
            this.btn_Email = new System.Windows.Forms.Button();
            this.btn_Site = new System.Windows.Forms.Button();
            this.ts_Menu = new System.Windows.Forms.ToolStrip();
            this.tsb_Back = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.ts_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Image = global::LanValley.Properties.Resources.LAN_Valley__Transparent;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(1000, 100);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Precisa de Ajuda?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Facebook);
            this.groupBox1.Controls.Add(this.btn_Instagram);
            this.groupBox1.Controls.Add(this.btn_Email);
            this.groupBox1.Controls.Add(this.btn_Site);
            this.groupBox1.Font = new System.Drawing.Font("ROG Fonts", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 225);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(976, 562);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contacte o Programador";
            // 
            // btn_Facebook
            // 
            this.btn_Facebook.BackColor = System.Drawing.Color.Transparent;
            this.btn_Facebook.BackgroundImage = global::LanValley.Properties.Resources.facebook;
            this.btn_Facebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Facebook.FlatAppearance.BorderSize = 0;
            this.btn_Facebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Facebook.Location = new System.Drawing.Point(593, 302);
            this.btn_Facebook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Facebook.Name = "btn_Facebook";
            this.btn_Facebook.Size = new System.Drawing.Size(131, 100);
            this.btn_Facebook.TabIndex = 3;
            this.btn_Facebook.UseVisualStyleBackColor = false;
            this.btn_Facebook.Click += new System.EventHandler(this.button_Click);
            // 
            // btn_Instagram
            // 
            this.btn_Instagram.BackColor = System.Drawing.Color.Transparent;
            this.btn_Instagram.BackgroundImage = global::LanValley.Properties.Resources.instagram;
            this.btn_Instagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Instagram.FlatAppearance.BorderSize = 0;
            this.btn_Instagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Instagram.Location = new System.Drawing.Point(224, 302);
            this.btn_Instagram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Instagram.Name = "btn_Instagram";
            this.btn_Instagram.Size = new System.Drawing.Size(131, 100);
            this.btn_Instagram.TabIndex = 2;
            this.btn_Instagram.UseVisualStyleBackColor = false;
            this.btn_Instagram.Click += new System.EventHandler(this.button_Click);
            // 
            // btn_Email
            // 
            this.btn_Email.BackColor = System.Drawing.Color.Transparent;
            this.btn_Email.BackgroundImage = global::LanValley.Properties.Resources.email;
            this.btn_Email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Email.FlatAppearance.BorderSize = 0;
            this.btn_Email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Email.Location = new System.Drawing.Point(593, 142);
            this.btn_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Email.Name = "btn_Email";
            this.btn_Email.Size = new System.Drawing.Size(131, 100);
            this.btn_Email.TabIndex = 1;
            this.btn_Email.UseVisualStyleBackColor = false;
            this.btn_Email.Click += new System.EventHandler(this.button_Click);
            // 
            // btn_Site
            // 
            this.btn_Site.BackColor = System.Drawing.Color.Transparent;
            this.btn_Site.BackgroundImage = global::LanValley.Properties.Resources.site;
            this.btn_Site.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Site.FlatAppearance.BorderSize = 0;
            this.btn_Site.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Site.Location = new System.Drawing.Point(224, 142);
            this.btn_Site.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Site.Name = "btn_Site";
            this.btn_Site.Size = new System.Drawing.Size(131, 100);
            this.btn_Site.TabIndex = 0;
            this.btn_Site.UseVisualStyleBackColor = false;
            this.btn_Site.Click += new System.EventHandler(this.button_Click);
            // 
            // ts_Menu
            // 
            this.ts_Menu.BackColor = System.Drawing.Color.Transparent;
            this.ts_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ts_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Back});
            this.ts_Menu.Location = new System.Drawing.Point(0, 100);
            this.ts_Menu.Name = "ts_Menu";
            this.ts_Menu.Size = new System.Drawing.Size(1000, 43);
            this.ts_Menu.TabIndex = 3;
            this.ts_Menu.Text = "Menu";
            // 
            // tsb_Back
            // 
            this.tsb_Back.AutoSize = false;
            this.tsb_Back.BackColor = System.Drawing.Color.Transparent;
            this.tsb_Back.BackgroundImage = global::LanValley.Properties.Resources.back;
            this.tsb_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsb_Back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Back.Name = "tsb_Back";
            this.tsb_Back.Size = new System.Drawing.Size(40, 40);
            this.tsb_Back.Text = "Voltar";
            this.tsb_Back.Click += new System.EventHandler(this.tsb_Back_Click);
            // 
            // frmSuporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.ts_Menu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSuporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suporte";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ts_Menu.ResumeLayout(false);
            this.ts_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Facebook;
        private System.Windows.Forms.Button btn_Instagram;
        private System.Windows.Forms.Button btn_Email;
        private System.Windows.Forms.Button btn_Site;
        private System.Windows.Forms.ToolStrip ts_Menu;
        private System.Windows.Forms.ToolStripButton tsb_Back;
    }
}