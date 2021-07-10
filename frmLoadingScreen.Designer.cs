
namespace LanValley
{
    partial class frmLoadingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoadingScreen));
            this.loadingTimer = new System.Windows.Forms.Timer(this.components);
            this.loadingBar = new CircularProgressBar.CircularProgressBar();
            this.lbl_Percentage = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // loadingTimer
            // 
            this.loadingTimer.Enabled = true;
            this.loadingTimer.Tick += new System.EventHandler(this.loadingTimer_Tick);
            // 
            // loadingBar
            // 
            this.loadingBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.loadingBar.AnimationSpeed = 500;
            this.loadingBar.BackColor = System.Drawing.Color.Transparent;
            this.loadingBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.loadingBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadingBar.InnerColor = System.Drawing.Color.Transparent;
            this.loadingBar.InnerMargin = 2;
            this.loadingBar.InnerWidth = -1;
            this.loadingBar.Location = new System.Drawing.Point(364, 427);
            this.loadingBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadingBar.MarqueeAnimationSpeed = 2000;
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.OuterColor = System.Drawing.Color.Black;
            this.loadingBar.OuterMargin = -25;
            this.loadingBar.OuterWidth = 26;
            this.loadingBar.ProgressColor = System.Drawing.Color.Red;
            this.loadingBar.ProgressWidth = 25;
            this.loadingBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.loadingBar.Size = new System.Drawing.Size(283, 266);
            this.loadingBar.StartAngle = 270;
            this.loadingBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.loadingBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.loadingBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.loadingBar.SubscriptText = ".23";
            this.loadingBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.loadingBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.loadingBar.SuperscriptText = "°C";
            this.loadingBar.TabIndex = 1;
            this.loadingBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.loadingBar.UseWaitCursor = true;
            this.loadingBar.Value = 68;
            // 
            // lbl_Percentage
            // 
            this.lbl_Percentage.AutoSize = true;
            this.lbl_Percentage.Font = new System.Drawing.Font("ROG Fonts", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Percentage.Location = new System.Drawing.Point(487, 550);
            this.lbl_Percentage.Name = "lbl_Percentage";
            this.lbl_Percentage.Size = new System.Drawing.Size(41, 23);
            this.lbl_Percentage.TabIndex = 2;
            this.lbl_Percentage.Text = "0%";
            this.lbl_Percentage.UseWaitCursor = true;
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::LanValley.Properties.Resources.LAN_Valley__Transparent;
            this.logo.Location = new System.Drawing.Point(12, 294);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(976, 87);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            this.logo.UseWaitCursor = true;
            // 
            // frmLoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.lbl_Percentage);
            this.Controls.Add(this.loadingBar);
            this.Controls.Add(this.logo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading...";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.frmLoadingScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer loadingTimer;
        private CircularProgressBar.CircularProgressBar loadingBar;
        private System.Windows.Forms.Label lbl_Percentage;
        private System.Windows.Forms.PictureBox logo;
    }
}