
namespace LanValley
{
    partial class frmUsers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.ts_Menu = new System.Windows.Forms.ToolStrip();
            this.tsb_Lock = new System.Windows.Forms.ToolStripButton();
            this.tsb_Exit = new System.Windows.Forms.ToolStripButton();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Text = new System.Windows.Forms.Label();
            this.lbl_Number = new System.Windows.Forms.Label();
            this.txt_Montante = new System.Windows.Forms.TextBox();
            this.timeCounter = new System.Windows.Forms.Timer(this.components);
            this.logo = new System.Windows.Forms.PictureBox();
            this.btn_Depositar = new System.Windows.Forms.PictureBox();
            this.btn_Jogar = new System.Windows.Forms.PictureBox();
            this.ts_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Depositar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Jogar)).BeginInit();
            this.SuspendLayout();
            // 
            // ts_Menu
            // 
            this.ts_Menu.AutoSize = false;
            this.ts_Menu.BackColor = System.Drawing.Color.Transparent;
            this.ts_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ts_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Lock,
            this.tsb_Exit});
            this.ts_Menu.Location = new System.Drawing.Point(0, 100);
            this.ts_Menu.Name = "ts_Menu";
            this.ts_Menu.Size = new System.Drawing.Size(1000, 55);
            this.ts_Menu.TabIndex = 2;
            this.ts_Menu.Text = "Menu";
            // 
            // tsb_Lock
            // 
            this.tsb_Lock.AutoSize = false;
            this.tsb_Lock.BackColor = System.Drawing.Color.Transparent;
            this.tsb_Lock.BackgroundImage = global::LanValley.Properties.Resources._lock;
            this.tsb_Lock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsb_Lock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Lock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Lock.Name = "tsb_Lock";
            this.tsb_Lock.Size = new System.Drawing.Size(40, 40);
            this.tsb_Lock.Text = "Bloquear";
            this.tsb_Lock.Click += new System.EventHandler(this.tsb_Lock_Click);
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
            // lbl_User
            // 
            this.lbl_User.BackColor = System.Drawing.Color.Transparent;
            this.lbl_User.Font = new System.Drawing.Font("ROG Fonts", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.Location = new System.Drawing.Point(29, 167);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(959, 34);
            this.lbl_User.TabIndex = 3;
            this.lbl_User.Text = "username";
            this.lbl_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Text
            // 
            this.lbl_Text.AutoSize = true;
            this.lbl_Text.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Text.Font = new System.Drawing.Font("ROG Fonts", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Text.Location = new System.Drawing.Point(24, 273);
            this.lbl_Text.Name = "lbl_Text";
            this.lbl_Text.Size = new System.Drawing.Size(355, 29);
            this.lbl_Text.TabIndex = 4;
            this.lbl_Text.Text = "Dinheiro Disponivel: ";
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Number.Font = new System.Drawing.Font("ROG Fonts", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Number.ForeColor = System.Drawing.Color.Red;
            this.lbl_Number.Location = new System.Drawing.Point(385, 273);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(34, 29);
            this.lbl_Number.TabIndex = 5;
            this.lbl_Number.Text = "0";
            // 
            // txt_Montante
            // 
            this.txt_Montante.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Montante.ForeColor = System.Drawing.Color.Red;
            this.txt_Montante.Location = new System.Drawing.Point(720, 273);
            this.txt_Montante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Montante.Name = "txt_Montante";
            this.txt_Montante.Size = new System.Drawing.Size(268, 27);
            this.txt_Montante.TabIndex = 6;
            this.txt_Montante.Text = "Montante";
            this.txt_Montante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Montante.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Montante_MouseClick);
            // 
            // timeCounter
            // 
            this.timeCounter.Interval = 60000;
            this.timeCounter.Tick += new System.EventHandler(this.timeCounter_Tick);
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
            // btn_Depositar
            // 
            this.btn_Depositar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Depositar.Image = global::LanValley.Properties.Resources.deposit;
            this.btn_Depositar.Location = new System.Drawing.Point(816, 306);
            this.btn_Depositar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Depositar.Name = "btn_Depositar";
            this.btn_Depositar.Size = new System.Drawing.Size(92, 70);
            this.btn_Depositar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Depositar.TabIndex = 8;
            this.btn_Depositar.TabStop = false;
            this.btn_Depositar.Click += new System.EventHandler(this.btn_Depositar_Click);
            // 
            // btn_Jogar
            // 
            this.btn_Jogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Jogar.Image = global::LanValley.Properties.Resources.game;
            this.btn_Jogar.Location = new System.Drawing.Point(349, 645);
            this.btn_Jogar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Jogar.Name = "btn_Jogar";
            this.btn_Jogar.Size = new System.Drawing.Size(300, 121);
            this.btn_Jogar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Jogar.TabIndex = 9;
            this.btn_Jogar.TabStop = false;
            this.btn_Jogar.Click += new System.EventHandler(this.btn_Jogar_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.btn_Jogar);
            this.Controls.Add(this.btn_Depositar);
            this.Controls.Add(this.txt_Montante);
            this.Controls.Add(this.lbl_Number);
            this.Controls.Add(this.lbl_Text);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.ts_Menu);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ecrã Principal";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmUsers_MouseClick);
            this.ts_Menu.ResumeLayout(false);
            this.ts_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Depositar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Jogar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.ToolStrip ts_Menu;
        private System.Windows.Forms.ToolStripButton tsb_Lock;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_Text;
        private System.Windows.Forms.Label lbl_Number;
        private System.Windows.Forms.TextBox txt_Montante;
        private System.Windows.Forms.ToolStripButton tsb_Exit;
        private System.Windows.Forms.Timer timeCounter;
        private System.Windows.Forms.PictureBox btn_Depositar;
        private System.Windows.Forms.PictureBox btn_Jogar;
    }
}