
namespace LanValley
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txt_User = new System.Windows.Forms.TextBox();
            this.lbl_User = new System.Windows.Forms.Label();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lnk_lblCriar = new System.Windows.Forms.LinkLabel();
            this.lnk_lblSuporte = new System.Windows.Forms.LinkLabel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btn_Login = new System.Windows.Forms.PictureBox();
            this.btn_Sair = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sair)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_User
            // 
            this.txt_User.BackColor = System.Drawing.Color.White;
            this.txt_User.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.ForeColor = System.Drawing.Color.Red;
            this.txt_User.Location = new System.Drawing.Point(73, 178);
            this.txt_User.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(800, 27);
            this.txt_User.TabIndex = 0;
            this.txt_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.BackColor = System.Drawing.Color.Transparent;
            this.lbl_User.Font = new System.Drawing.Font("ROG Fonts", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.Location = new System.Drawing.Point(400, 148);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(186, 29);
            this.lbl_User.TabIndex = 1;
            this.lbl_User.Text = "Username";
            // 
            // txt_Pass
            // 
            this.txt_Pass.BackColor = System.Drawing.Color.White;
            this.txt_Pass.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.ForeColor = System.Drawing.Color.Red;
            this.txt_Pass.Location = new System.Drawing.Point(73, 338);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(800, 27);
            this.txt_Pass.TabIndex = 2;
            this.txt_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Pass.UseSystemPasswordChar = true;
            this.txt_Pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Pass_KeyPress);
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Pass.Font = new System.Drawing.Font("ROG Fonts", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pass.Location = new System.Drawing.Point(403, 306);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(188, 29);
            this.lbl_Pass.TabIndex = 3;
            this.lbl_Pass.Text = "Password";
            // 
            // lnk_lblCriar
            // 
            this.lnk_lblCriar.AutoSize = true;
            this.lnk_lblCriar.BackColor = System.Drawing.Color.Transparent;
            this.lnk_lblCriar.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_lblCriar.LinkColor = System.Drawing.SystemColors.ControlText;
            this.lnk_lblCriar.Location = new System.Drawing.Point(406, 697);
            this.lnk_lblCriar.Name = "lnk_lblCriar";
            this.lnk_lblCriar.Size = new System.Drawing.Size(189, 24);
            this.lnk_lblCriar.TabIndex = 8;
            this.lnk_lblCriar.TabStop = true;
            this.lnk_lblCriar.Text = "Criar Conta";
            this.lnk_lblCriar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_lblCriar_LinkClicked);
            // 
            // lnk_lblSuporte
            // 
            this.lnk_lblSuporte.AutoSize = true;
            this.lnk_lblSuporte.BackColor = System.Drawing.Color.Transparent;
            this.lnk_lblSuporte.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_lblSuporte.LinkColor = System.Drawing.SystemColors.ControlText;
            this.lnk_lblSuporte.Location = new System.Drawing.Point(346, 741);
            this.lnk_lblSuporte.Name = "lnk_lblSuporte";
            this.lnk_lblSuporte.Size = new System.Drawing.Size(309, 24);
            this.lnk_lblSuporte.TabIndex = 9;
            this.lnk_lblSuporte.TabStop = true;
            this.lnk_lblSuporte.Text = "Contactar Suporte";
            this.lnk_lblSuporte.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_lblSuporte_LinkClicked);
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
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            // 
            // btn_Login
            // 
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.Image = global::LanValley.Properties.Resources.login;
            this.btn_Login.Location = new System.Drawing.Point(655, 446);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(220, 121);
            this.btn_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Login.TabIndex = 10;
            this.btn_Login.TabStop = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sair.Image = global::LanValley.Properties.Resources.exit;
            this.btn_Sair.Location = new System.Drawing.Point(73, 446);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(220, 121);
            this.btn_Sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Sair.TabIndex = 11;
            this.btn_Sair.TabStop = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lnk_lblSuporte);
            this.Controls.Add(this.lnk_lblCriar);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.txt_User);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.LinkLabel lnk_lblCriar;
        private System.Windows.Forms.LinkLabel lnk_lblSuporte;
        private System.Windows.Forms.PictureBox btn_Login;
        private System.Windows.Forms.PictureBox btn_Sair;
    }
}

