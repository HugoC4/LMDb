using System.Windows.Forms;

namespace LMDb
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mtcMainTabs = new MetroFramework.Controls.MetroTabControl();
            this.mtHome = new MetroFramework.Controls.MetroTabPage();
            this.vcHome = new LMDb.ViewControl();
            this.vcpLoadingScreen = new MetroFramework.Controls.MetroTabPage();
            this.ldHome = new LMDb.LoadingScreen();
            this.vcpOverview = new MetroFramework.Controls.MetroTabPage();
            this.tlOverview = new System.Windows.Forms.TableLayoutPanel();
            this.mtSettings = new MetroFramework.Controls.MetroTabPage();
            this.resizeTimer = new System.Windows.Forms.Timer(this.components);
            this.mtcMainTabs.SuspendLayout();
            this.mtHome.SuspendLayout();
            this.vcHome.SuspendLayout();
            this.vcpLoadingScreen.SuspendLayout();
            this.vcpOverview.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtcMainTabs
            // 
            this.mtcMainTabs.Controls.Add(this.mtHome);
            this.mtcMainTabs.Controls.Add(this.mtSettings);
            resources.ApplyResources(this.mtcMainTabs, "mtcMainTabs");
            this.mtcMainTabs.Name = "mtcMainTabs";
            this.mtcMainTabs.SelectedIndex = 0;
            // 
            // mtHome
            // 
            resources.ApplyResources(this.mtHome, "mtHome");
            this.mtHome.Controls.Add(this.vcHome);
            this.mtHome.HorizontalScrollbar = true;
            this.mtHome.HorizontalScrollbarBarColor = true;
            this.mtHome.Name = "mtHome";
            this.mtHome.VerticalScrollbar = true;
            this.mtHome.VerticalScrollbarBarColor = true;
            // 
            // vcHome
            // 
            this.vcHome.Controls.Add(this.vcpLoadingScreen);
            this.vcHome.Controls.Add(this.vcpOverview);
            resources.ApplyResources(this.vcHome, "vcHome");
            this.vcHome.Multiline = true;
            this.vcHome.Name = "vcHome";
            this.vcHome.SelectedIndex = 0;
            // 
            // vcpLoadingScreen
            // 
            this.vcpLoadingScreen.Controls.Add(this.ldHome);
            this.vcpLoadingScreen.HorizontalScrollbarBarColor = true;
            resources.ApplyResources(this.vcpLoadingScreen, "vcpLoadingScreen");
            this.vcpLoadingScreen.Name = "vcpLoadingScreen";
            this.vcpLoadingScreen.VerticalScrollbarBarColor = true;
            // 
            // ldHome
            // 
            this.ldHome.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ldHome, "ldHome");
            this.ldHome.Name = "ldHome";
            this.ldHome.Spinning = true;
            this.ldHome.SubText = null;
            this.ldHome.Value = 0;
            // 
            // vcpOverview
            // 
            resources.ApplyResources(this.vcpOverview, "vcpOverview");
            this.vcpOverview.Controls.Add(this.tlOverview);
            this.vcpOverview.HorizontalScrollbar = true;
            this.vcpOverview.HorizontalScrollbarBarColor = true;
            this.vcpOverview.Name = "vcpOverview";
            this.vcpOverview.VerticalScrollbar = true;
            this.vcpOverview.VerticalScrollbarBarColor = true;
            // 
            // tlOverview
            // 
            this.tlOverview.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tlOverview, "tlOverview");
            this.tlOverview.Name = "tlOverview";
            // 
            // mtSettings
            // 
            this.mtSettings.HorizontalScrollbarBarColor = true;
            resources.ApplyResources(this.mtSettings, "mtSettings");
            this.mtSettings.Name = "mtSettings";
            this.mtSettings.VerticalScrollbarBarColor = true;
            // 
            // resizeTimer
            // 
            this.resizeTimer.Interval = 200;
            this.resizeTimer.Tick += new System.EventHandler(this.resizeTimer_Tick);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtcMainTabs);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.mtcMainTabs.ResumeLayout(false);
            this.mtHome.ResumeLayout(false);
            this.vcHome.ResumeLayout(false);
            this.vcpLoadingScreen.ResumeLayout(false);
            this.vcpOverview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtcMainTabs;
        private MetroFramework.Controls.MetroTabPage mtSettings;
        private MetroFramework.Controls.MetroTabPage mtHome;
        private TableLayoutPanel tlOverview;
        private Timer resizeTimer;
        private LoadingScreen ldHome;
        private ViewControl vcHome;
        private MetroFramework.Controls.MetroTabPage vcpLoadingScreen;
        private MetroFramework.Controls.MetroTabPage vcpOverview;
    }
}