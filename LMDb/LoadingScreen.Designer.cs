namespace LMDb
{
    partial class LoadingScreen
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
            this.tlpCenteringTable = new System.Windows.Forms.TableLayoutPanel();
            this.mpsLoading = new MetroFramework.Controls.MetroProgressSpinner();
            this.mlblSubText = new MetroFramework.Controls.MetroLabel();
            this.mlblText = new MetroFramework.Controls.MetroLabel();
            this.tlpCenteringTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpCenteringTable
            // 
            this.tlpCenteringTable.BackColor = System.Drawing.Color.Transparent;
            this.tlpCenteringTable.ColumnCount = 3;
            this.tlpCenteringTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCenteringTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpCenteringTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCenteringTable.Controls.Add(this.mpsLoading, 1, 1);
            this.tlpCenteringTable.Controls.Add(this.mlblSubText, 0, 4);
            this.tlpCenteringTable.Controls.Add(this.mlblText, 0, 3);
            this.tlpCenteringTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCenteringTable.Location = new System.Drawing.Point(0, 0);
            this.tlpCenteringTable.Name = "tlpCenteringTable";
            this.tlpCenteringTable.RowCount = 6;
            this.tlpCenteringTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCenteringTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpCenteringTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpCenteringTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCenteringTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpCenteringTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCenteringTable.Size = new System.Drawing.Size(256, 256);
            this.tlpCenteringTable.TabIndex = 0;
            // 
            // mpsLoading
            // 
            this.mpsLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mpsLoading.Location = new System.Drawing.Point(96, 70);
            this.mpsLoading.Margin = new System.Windows.Forms.Padding(0);
            this.mpsLoading.Maximum = 100;
            this.mpsLoading.Name = "mpsLoading";
            this.mpsLoading.Size = new System.Drawing.Size(64, 64);
            this.mpsLoading.TabIndex = 0;
            // 
            // mlblSubText
            // 
            this.tlpCenteringTable.SetColumnSpan(this.mlblSubText, 3);
            this.mlblSubText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlblSubText.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlblSubText.Location = new System.Drawing.Point(0, 170);
            this.mlblSubText.Margin = new System.Windows.Forms.Padding(0);
            this.mlblSubText.Name = "mlblSubText";
            this.mlblSubText.Size = new System.Drawing.Size(256, 15);
            this.mlblSubText.TabIndex = 2;
            this.mlblSubText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlblText
            // 
            this.tlpCenteringTable.SetColumnSpan(this.mlblText, 3);
            this.mlblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlblText.Location = new System.Drawing.Point(0, 150);
            this.mlblText.Margin = new System.Windows.Forms.Padding(0);
            this.mlblText.Name = "mlblText";
            this.mlblText.Size = new System.Drawing.Size(256, 20);
            this.mlblText.TabIndex = 1;
            this.mlblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tlpCenteringTable);
            this.Name = "LoadingScreen";
            this.Size = new System.Drawing.Size(256, 256);
            this.tlpCenteringTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCenteringTable;
        private MetroFramework.Controls.MetroProgressSpinner mpsLoading;
        private MetroFramework.Controls.MetroLabel mlblText;
        private MetroFramework.Controls.MetroLabel mlblSubText;
    }
}
