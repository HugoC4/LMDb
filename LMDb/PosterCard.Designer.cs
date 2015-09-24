namespace LMDb
{
    partial class PosterCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scPoster = new System.Windows.Forms.SplitContainer();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scPoster)).BeginInit();
            this.scPoster.Panel2.SuspendLayout();
            this.scPoster.SuspendLayout();
            this.SuspendLayout();
            // 
            // scPoster
            // 
            this.scPoster.BackColor = System.Drawing.Color.Transparent;
            this.scPoster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scPoster.Location = new System.Drawing.Point(0, 0);
            this.scPoster.Name = "scPoster";
            this.scPoster.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scPoster.Panel1
            // 
            this.scPoster.Panel1.BackColor = System.Drawing.Color.Transparent;
            // 
            // scPoster.Panel2
            // 
            this.scPoster.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.scPoster.Panel2.BackgroundImage = global::LMDb.Properties.Resources.mask;
            this.scPoster.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scPoster.Panel2.Controls.Add(this.lblInfo);
            this.scPoster.Size = new System.Drawing.Size(280, 420);
            this.scPoster.SplitterDistance = 222;
            this.scPoster.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfo.Location = new System.Drawing.Point(0, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.lblInfo.Size = new System.Drawing.Size(280, 194);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Info";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PosterCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::LMDb.Properties.Resources.a1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.scPoster);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PosterCard";
            this.Size = new System.Drawing.Size(280, 420);
            this.scPoster.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scPoster)).EndInit();
            this.scPoster.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scPoster;
        private System.Windows.Forms.Label lblInfo;
    }
}
