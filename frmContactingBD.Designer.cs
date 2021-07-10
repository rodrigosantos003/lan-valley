
namespace LanValley
{
    partial class frmContactingBD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContactingBD));
            this.lbl_ContactingBD = new System.Windows.Forms.Label();
            this.contactingBar = new CircularProgressBar.CircularProgressBar();
            this.contactingTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_ContactingBD
            // 
            this.lbl_ContactingBD.AutoSize = true;
            this.lbl_ContactingBD.Font = new System.Drawing.Font("ROG Fonts", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ContactingBD.Location = new System.Drawing.Point(57, 27);
            this.lbl_ContactingBD.Name = "lbl_ContactingBD";
            this.lbl_ContactingBD.Size = new System.Drawing.Size(398, 34);
            this.lbl_ContactingBD.TabIndex = 2;
            this.lbl_ContactingBD.Text = "A Contactar a BD...";
            // 
            // contactingBar
            // 
            this.contactingBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.contactingBar.AnimationSpeed = 500;
            this.contactingBar.BackColor = System.Drawing.Color.Transparent;
            this.contactingBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.contactingBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contactingBar.InnerColor = System.Drawing.Color.Transparent;
            this.contactingBar.InnerMargin = 2;
            this.contactingBar.InnerWidth = -1;
            this.contactingBar.Location = new System.Drawing.Point(159, 142);
            this.contactingBar.MarqueeAnimationSpeed = 2000;
            this.contactingBar.Name = "contactingBar";
            this.contactingBar.OuterColor = System.Drawing.Color.Black;
            this.contactingBar.OuterMargin = -25;
            this.contactingBar.OuterWidth = 26;
            this.contactingBar.ProgressColor = System.Drawing.Color.Red;
            this.contactingBar.ProgressWidth = 25;
            this.contactingBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.contactingBar.Size = new System.Drawing.Size(182, 168);
            this.contactingBar.StartAngle = 270;
            this.contactingBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.contactingBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.contactingBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.contactingBar.SubscriptText = ".23";
            this.contactingBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.contactingBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.contactingBar.SuperscriptText = "°C";
            this.contactingBar.TabIndex = 3;
            this.contactingBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.contactingBar.UseWaitCursor = true;
            this.contactingBar.Value = 68;
            // 
            // contactingTimer
            // 
            this.contactingTimer.Enabled = true;
            this.contactingTimer.Interval = 30;
            this.contactingTimer.Tick += new System.EventHandler(this.contactingTimer_Tick);
            // 
            // frmContactingBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.contactingBar);
            this.Controls.Add(this.lbl_ContactingBD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmContactingBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmContactingBD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_ContactingBD;
        private CircularProgressBar.CircularProgressBar contactingBar;
        private System.Windows.Forms.Timer contactingTimer;
    }
}