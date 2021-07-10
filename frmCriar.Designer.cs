
namespace LanValley
{
    partial class frmCriar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCriar));
            this.txt_insertUser = new System.Windows.Forms.TextBox();
            this.txt_insertPass = new System.Windows.Forms.TextBox();
            this.lbl_insertUser = new System.Windows.Forms.Label();
            this.lbl_insertPass = new System.Windows.Forms.Label();
            this.btn_viewPassword = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lbl_insertName = new System.Windows.Forms.Label();
            this.txt_insertName = new System.Windows.Forms.TextBox();
            this.ts_Menu = new System.Windows.Forms.ToolStrip();
            this.tsb_Back = new System.Windows.Forms.ToolStripButton();
            this.tsb_Exit = new System.Windows.Forms.ToolStripButton();
            this.btn_Criar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.ts_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Criar)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_insertUser
            // 
            this.txt_insertUser.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_insertUser.ForeColor = System.Drawing.Color.Red;
            this.txt_insertUser.Location = new System.Drawing.Point(60, 406);
            this.txt_insertUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_insertUser.Name = "txt_insertUser";
            this.txt_insertUser.Size = new System.Drawing.Size(833, 27);
            this.txt_insertUser.TabIndex = 2;
            this.txt_insertUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_insertPass
            // 
            this.txt_insertPass.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_insertPass.ForeColor = System.Drawing.Color.Red;
            this.txt_insertPass.Location = new System.Drawing.Point(60, 571);
            this.txt_insertPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_insertPass.Name = "txt_insertPass";
            this.txt_insertPass.Size = new System.Drawing.Size(833, 27);
            this.txt_insertPass.TabIndex = 3;
            this.txt_insertPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_insertPass.UseSystemPasswordChar = true;
            // 
            // lbl_insertUser
            // 
            this.lbl_insertUser.AutoSize = true;
            this.lbl_insertUser.BackColor = System.Drawing.Color.Transparent;
            this.lbl_insertUser.Font = new System.Drawing.Font("ROG Fonts", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_insertUser.Location = new System.Drawing.Point(299, 375);
            this.lbl_insertUser.Name = "lbl_insertUser";
            this.lbl_insertUser.Size = new System.Drawing.Size(415, 29);
            this.lbl_insertUser.TabIndex = 3;
            this.lbl_insertUser.Text = "Introduza o Username:";
            // 
            // lbl_insertPass
            // 
            this.lbl_insertPass.AutoSize = true;
            this.lbl_insertPass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_insertPass.Font = new System.Drawing.Font("ROG Fonts", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_insertPass.Location = new System.Drawing.Point(299, 530);
            this.lbl_insertPass.Name = "lbl_insertPass";
            this.lbl_insertPass.Size = new System.Drawing.Size(417, 29);
            this.lbl_insertPass.TabIndex = 4;
            this.lbl_insertPass.Text = "Introduza a Password:";
            // 
            // btn_viewPassword
            // 
            this.btn_viewPassword.BackColor = System.Drawing.Color.Transparent;
            this.btn_viewPassword.BackgroundImage = global::LanValley.Properties.Resources.viewpass;
            this.btn_viewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_viewPassword.FlatAppearance.BorderSize = 0;
            this.btn_viewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewPassword.Location = new System.Drawing.Point(896, 566);
            this.btn_viewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_viewPassword.Name = "btn_viewPassword";
            this.btn_viewPassword.Size = new System.Drawing.Size(43, 32);
            this.btn_viewPassword.TabIndex = 4;
            this.btn_viewPassword.UseVisualStyleBackColor = false;
            this.btn_viewPassword.Click += new System.EventHandler(this.btn_viewPassword_Click);
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
            // lbl_insertName
            // 
            this.lbl_insertName.AutoSize = true;
            this.lbl_insertName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_insertName.Font = new System.Drawing.Font("ROG Fonts", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_insertName.Location = new System.Drawing.Point(341, 224);
            this.lbl_insertName.Name = "lbl_insertName";
            this.lbl_insertName.Size = new System.Drawing.Size(329, 29);
            this.lbl_insertName.TabIndex = 8;
            this.lbl_insertName.Text = "Introduza o Nome:";
            // 
            // txt_insertName
            // 
            this.txt_insertName.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_insertName.ForeColor = System.Drawing.Color.Red;
            this.txt_insertName.Location = new System.Drawing.Point(60, 255);
            this.txt_insertName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_insertName.Name = "txt_insertName";
            this.txt_insertName.Size = new System.Drawing.Size(833, 27);
            this.txt_insertName.TabIndex = 1;
            this.txt_insertName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ts_Menu
            // 
            this.ts_Menu.AutoSize = false;
            this.ts_Menu.BackColor = System.Drawing.Color.Transparent;
            this.ts_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ts_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Back,
            this.tsb_Exit});
            this.ts_Menu.Location = new System.Drawing.Point(0, 100);
            this.ts_Menu.Name = "ts_Menu";
            this.ts_Menu.Size = new System.Drawing.Size(1000, 55);
            this.ts_Menu.TabIndex = 9;
            this.ts_Menu.Text = "Menu";
            // 
            // tsb_Back
            // 
            this.tsb_Back.AutoSize = false;
            this.tsb_Back.BackgroundImage = global::LanValley.Properties.Resources.back;
            this.tsb_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsb_Back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Back.Name = "tsb_Back";
            this.tsb_Back.Size = new System.Drawing.Size(40, 40);
            this.tsb_Back.Text = "Voltar";
            this.tsb_Back.Click += new System.EventHandler(this.tsb_Back_Click);
            // 
            // tsb_Exit
            // 
            this.tsb_Exit.AutoSize = false;
            this.tsb_Exit.BackColor = System.Drawing.Color.Transparent;
            this.tsb_Exit.BackgroundImage = global::LanValley.Properties.Resources.exit;
            this.tsb_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsb_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Exit.Name = "tsb_Exit";
            this.tsb_Exit.Size = new System.Drawing.Size(40, 40);
            this.tsb_Exit.Text = "Sair";
            this.tsb_Exit.Click += new System.EventHandler(this.tsb_Exit_Click);
            // 
            // btn_Criar
            // 
            this.btn_Criar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Criar.Image = global::LanValley.Properties.Resources.submit;
            this.btn_Criar.Location = new System.Drawing.Point(356, 695);
            this.btn_Criar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Criar.Name = "btn_Criar";
            this.btn_Criar.Size = new System.Drawing.Size(288, 84);
            this.btn_Criar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Criar.TabIndex = 10;
            this.btn_Criar.TabStop = false;
            this.btn_Criar.Click += new System.EventHandler(this.btn_Criar_Click);
            // 
            // frmCriar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.btn_Criar);
            this.Controls.Add(this.ts_Menu);
            this.Controls.Add(this.lbl_insertName);
            this.Controls.Add(this.txt_insertName);
            this.Controls.Add(this.btn_viewPassword);
            this.Controls.Add(this.lbl_insertPass);
            this.Controls.Add(this.lbl_insertUser);
            this.Controls.Add(this.txt_insertPass);
            this.Controls.Add(this.txt_insertUser);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCriar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Conta";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ts_Menu.ResumeLayout(false);
            this.ts_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Criar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox txt_insertUser;
        private System.Windows.Forms.TextBox txt_insertPass;
        private System.Windows.Forms.Label lbl_insertUser;
        private System.Windows.Forms.Label lbl_insertPass;
        private System.Windows.Forms.Button btn_viewPassword;
        private System.Windows.Forms.Label lbl_insertName;
        private System.Windows.Forms.TextBox txt_insertName;
        private System.Windows.Forms.ToolStrip ts_Menu;
        private System.Windows.Forms.ToolStripButton tsb_Back;
        private System.Windows.Forms.ToolStripButton tsb_Exit;
        private System.Windows.Forms.PictureBox btn_Criar;
    }
}