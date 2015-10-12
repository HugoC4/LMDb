using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Drawing;

namespace LMDb.Controls
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
            this.Poster = new System.Windows.Forms.PictureBox();
            this.mpInfo = new MetroFramework.Controls.MetroPanel();
            this.tlpInfo = new System.Windows.Forms.TableLayoutPanel();
            this.mlTitle = new MetroFramework.Controls.MetroLabel();
            this.mlGenres = new MetroFramework.Controls.MetroLabel();
            this.mlRating = new MetroFramework.Controls.MetroLabel();
            this.mlSynopsis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Poster)).BeginInit();
            this.mpInfo.SuspendLayout();
            this.tlpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Poster
            // 
            this.Poster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Poster.Image = global::LMDb.Properties.Resources.a1;
            this.Poster.Location = new System.Drawing.Point(0, 0);
            this.Poster.Margin = new System.Windows.Forms.Padding(4);
            this.Poster.Name = "Poster";
            this.Poster.Size = new System.Drawing.Size(373, 614);
            this.Poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Poster.TabIndex = 0;
            this.Poster.TabStop = false;
            this.Poster.MouseEnter += new System.EventHandler(this.Poster_MouseEnter);
            this.Poster.MouseLeave += new System.EventHandler(this.Poster_MouseLeave);
            // 
            // mpInfo
            // 
            this.mpInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpInfo.Controls.Add(this.tlpInfo);
            this.mpInfo.HorizontalScrollbarBarColor = true;
            this.mpInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.mpInfo.HorizontalScrollbarSize = 15;
            this.mpInfo.Location = new System.Drawing.Point(23, 406);
            this.mpInfo.Margin = new System.Windows.Forms.Padding(7);
            this.mpInfo.Name = "mpInfo";
            this.mpInfo.Size = new System.Drawing.Size(328, 185);
            this.mpInfo.TabIndex = 1;
            this.mpInfo.VerticalScrollbarBarColor = true;
            this.mpInfo.VerticalScrollbarHighlightOnWheel = false;
            this.mpInfo.VerticalScrollbarSize = 13;
            this.mpInfo.Visible = false;
            // 
            // tlpInfo
            // 
            this.tlpInfo.BackColor = System.Drawing.Color.Transparent;
            this.tlpInfo.ColumnCount = 1;
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInfo.Controls.Add(this.mlTitle, 0, 0);
            this.tlpInfo.Controls.Add(this.mlGenres, 0, 2);
            this.tlpInfo.Controls.Add(this.mlRating, 0, 3);
            this.tlpInfo.Controls.Add(this.mlSynopsis, 0, 1);
            this.tlpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInfo.Location = new System.Drawing.Point(0, 0);
            this.tlpInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tlpInfo.Name = "tlpInfo";
            this.tlpInfo.RowCount = 5;
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpInfo.Size = new System.Drawing.Size(328, 185);
            this.tlpInfo.TabIndex = 2;
            // 
            // mlTitle
            // 
            this.mlTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlTitle.Location = new System.Drawing.Point(4, 0);
            this.mlTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlTitle.Name = "mlTitle";
            this.mlTitle.Size = new System.Drawing.Size(320, 30);
            this.mlTitle.TabIndex = 0;
            this.mlTitle.Text = "Title";
            this.mlTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlGenres
            // 
            this.mlGenres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlGenres.Location = new System.Drawing.Point(4, 140);
            this.mlGenres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlGenres.Name = "mlGenres";
            this.mlGenres.Size = new System.Drawing.Size(320, 20);
            this.mlGenres.TabIndex = 2;
            this.mlGenres.Text = "Genres: ";
            this.mlGenres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlRating
            // 
            this.mlRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlRating.Location = new System.Drawing.Point(4, 160);
            this.mlRating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlRating.Name = "mlRating";
            this.mlRating.Size = new System.Drawing.Size(320, 20);
            this.mlRating.TabIndex = 3;
            this.mlRating.Text = "Rating";
            this.mlRating.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlSynopsis
            // 
            this.mlSynopsis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlSynopsis.Enabled = false;
            this.mlSynopsis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlSynopsis.Location = new System.Drawing.Point(4, 30);
            this.mlSynopsis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlSynopsis.Name = "mlSynopsis";
            this.mlSynopsis.Size = new System.Drawing.Size(320, 110);
            this.mlSynopsis.TabIndex = 4;
            this.mlSynopsis.Text = "Synopsis";
            // 
            // PosterCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.mpInfo);
            this.Controls.Add(this.Poster);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "PosterCard";
            this.Size = new System.Drawing.Size(373, 614);
            this.MouseEnter += new System.EventHandler(this.PosterCard_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.PosterCard_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PosterCard_MouseMove);
            this.Resize += new System.EventHandler(this.PosterCard_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Poster)).EndInit();
            this.mpInfo.ResumeLayout(false);
            this.tlpInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Poster;
        private MetroFramework.Controls.MetroPanel mpInfo;
        private System.Windows.Forms.TableLayoutPanel tlpInfo;
        private MetroFramework.Controls.MetroLabel mlTitle;
        private MetroFramework.Controls.MetroLabel mlGenres;
        private MetroFramework.Controls.MetroLabel mlRating;
        private Label mlSynopsis;
    }
}
