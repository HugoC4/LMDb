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
            this.tlSettings = new System.Windows.Forms.TableLayoutPanel();
            this.mpSettingsCategories = new MetroFramework.Controls.MetroPanel();
            this.tlSettingsCategories = new System.Windows.Forms.TableLayoutPanel();
            this.mllGeneral = new MetroFramework.Controls.MetroLink();
            this.mllFiles = new MetroFramework.Controls.MetroLink();
            this.mllAppearance = new MetroFramework.Controls.MetroLink();
            this.mlCategories = new MetroFramework.Controls.MetroLabel();
            this.vcSettings = new LMDb.ViewControl();
            this.mtpSettingsGeneral = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtpSettingsFiles = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtpSettingsAppearance = new MetroFramework.Controls.MetroTabPage();
            this.mbChangeImage = new MetroFramework.Controls.MetroButton();
            this.pbProfileSettings = new System.Windows.Forms.PictureBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mcStyle = new MetroFramework.Controls.MetroComboBox();
            this.mlStyle = new MetroFramework.Controls.MetroLabel();
            this.mcTheme = new MetroFramework.Controls.MetroComboBox();
            this.mlTheme = new MetroFramework.Controls.MetroLabel();
            this.resizeTimer = new System.Windows.Forms.Timer(this.components);
            this.scanningBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.mtcMainTabs.SuspendLayout();
            this.mtHome.SuspendLayout();
            this.vcHome.SuspendLayout();
            this.vcpLoadingScreen.SuspendLayout();
            this.vcpOverview.SuspendLayout();
            this.mtSettings.SuspendLayout();
            this.tlSettings.SuspendLayout();
            this.mpSettingsCategories.SuspendLayout();
            this.tlSettingsCategories.SuspendLayout();
            this.vcSettings.SuspendLayout();
            this.mtpSettingsGeneral.SuspendLayout();
            this.mtpSettingsFiles.SuspendLayout();
            this.mtpSettingsAppearance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // mtcMainTabs
            // 
            this.mtcMainTabs.Controls.Add(this.mtHome);
            this.mtcMainTabs.Controls.Add(this.mtSettings);
            resources.ApplyResources(this.mtcMainTabs, "mtcMainTabs");
            this.mtcMainTabs.Name = "mtcMainTabs";
            this.mtcMainTabs.SelectedIndex = 1;
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
            resources.ApplyResources(this.vcHome, "vcHome");
            this.vcHome.Controls.Add(this.vcpLoadingScreen);
            this.vcHome.Controls.Add(this.vcpOverview);
            this.vcHome.Multiline = true;
            this.vcHome.Name = "vcHome";
            this.vcHome.SelectedIndex = 1;
            this.vcHome.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
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
            this.ldHome.SubText = "";
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
            this.mtSettings.Controls.Add(this.tlSettings);
            this.mtSettings.HorizontalScrollbarBarColor = true;
            resources.ApplyResources(this.mtSettings, "mtSettings");
            this.mtSettings.Name = "mtSettings";
            this.mtSettings.VerticalScrollbarBarColor = true;
            // 
            // tlSettings
            // 
            resources.ApplyResources(this.tlSettings, "tlSettings");
            this.tlSettings.BackColor = System.Drawing.Color.Transparent;
            this.tlSettings.Controls.Add(this.mpSettingsCategories, 0, 0);
            this.tlSettings.Controls.Add(this.vcSettings, 1, 0);
            this.tlSettings.Name = "tlSettings";
            // 
            // mpSettingsCategories
            // 
            resources.ApplyResources(this.mpSettingsCategories, "mpSettingsCategories");
            this.mpSettingsCategories.Controls.Add(this.tlSettingsCategories);
            this.mpSettingsCategories.Controls.Add(this.mlCategories);
            this.mpSettingsCategories.HorizontalScrollbar = true;
            this.mpSettingsCategories.HorizontalScrollbarBarColor = true;
            this.mpSettingsCategories.HorizontalScrollbarHighlightOnWheel = false;
            this.mpSettingsCategories.HorizontalScrollbarSize = 10;
            this.mpSettingsCategories.Name = "mpSettingsCategories";
            this.mpSettingsCategories.VerticalScrollbar = true;
            this.mpSettingsCategories.VerticalScrollbarBarColor = true;
            this.mpSettingsCategories.VerticalScrollbarHighlightOnWheel = false;
            this.mpSettingsCategories.VerticalScrollbarSize = 10;
            // 
            // tlSettingsCategories
            // 
            resources.ApplyResources(this.tlSettingsCategories, "tlSettingsCategories");
            this.tlSettingsCategories.Controls.Add(this.mllGeneral, 0, 0);
            this.tlSettingsCategories.Controls.Add(this.mllFiles, 0, 2);
            this.tlSettingsCategories.Controls.Add(this.mllAppearance, 0, 1);
            this.tlSettingsCategories.Name = "tlSettingsCategories";
            // 
            // mllGeneral
            // 
            resources.ApplyResources(this.mllGeneral, "mllGeneral");
            this.mllGeneral.Name = "mllGeneral";
            this.mllGeneral.Tag = "0";
            this.mllGeneral.Click += new System.EventHandler(this.NavigationClicked);
            // 
            // mllFiles
            // 
            resources.ApplyResources(this.mllFiles, "mllFiles");
            this.mllFiles.Name = "mllFiles";
            this.mllFiles.Tag = "1";
            this.mllFiles.Click += new System.EventHandler(this.NavigationClicked);
            // 
            // mllAppearance
            // 
            resources.ApplyResources(this.mllAppearance, "mllAppearance");
            this.mllAppearance.Name = "mllAppearance";
            this.mllAppearance.Tag = "2";
            this.mllAppearance.Click += new System.EventHandler(this.NavigationClicked);
            // 
            // mlCategories
            // 
            resources.ApplyResources(this.mlCategories, "mlCategories");
            this.mlCategories.Name = "mlCategories";
            // 
            // vcSettings
            // 
            resources.ApplyResources(this.vcSettings, "vcSettings");
            this.vcSettings.Controls.Add(this.mtpSettingsGeneral);
            this.vcSettings.Controls.Add(this.mtpSettingsFiles);
            this.vcSettings.Controls.Add(this.mtpSettingsAppearance);
            this.vcSettings.Name = "vcSettings";
            this.vcSettings.SelectedIndex = 2;
            this.vcSettings.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // mtpSettingsGeneral
            // 
            this.mtpSettingsGeneral.Controls.Add(this.metroLabel1);
            this.mtpSettingsGeneral.HorizontalScrollbarBarColor = true;
            resources.ApplyResources(this.mtpSettingsGeneral, "mtpSettingsGeneral");
            this.mtpSettingsGeneral.Name = "mtpSettingsGeneral";
            this.mtpSettingsGeneral.VerticalScrollbarBarColor = true;
            // 
            // metroLabel1
            // 
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.Name = "metroLabel1";
            // 
            // mtpSettingsFiles
            // 
            this.mtpSettingsFiles.Controls.Add(this.metroLabel2);
            this.mtpSettingsFiles.HorizontalScrollbarBarColor = true;
            resources.ApplyResources(this.mtpSettingsFiles, "mtpSettingsFiles");
            this.mtpSettingsFiles.Name = "mtpSettingsFiles";
            this.mtpSettingsFiles.VerticalScrollbarBarColor = true;
            // 
            // metroLabel2
            // 
            resources.ApplyResources(this.metroLabel2, "metroLabel2");
            this.metroLabel2.Name = "metroLabel2";
            // 
            // mtpSettingsAppearance
            // 
            this.mtpSettingsAppearance.Controls.Add(this.mbChangeImage);
            this.mtpSettingsAppearance.Controls.Add(this.pbProfileSettings);
            this.mtpSettingsAppearance.Controls.Add(this.metroLabel3);
            this.mtpSettingsAppearance.Controls.Add(this.mcStyle);
            this.mtpSettingsAppearance.Controls.Add(this.mlStyle);
            this.mtpSettingsAppearance.Controls.Add(this.mcTheme);
            this.mtpSettingsAppearance.Controls.Add(this.mlTheme);
            this.mtpSettingsAppearance.HorizontalScrollbarBarColor = true;
            resources.ApplyResources(this.mtpSettingsAppearance, "mtpSettingsAppearance");
            this.mtpSettingsAppearance.Name = "mtpSettingsAppearance";
            this.mtpSettingsAppearance.VerticalScrollbarBarColor = true;
            // 
            // mbChangeImage
            // 
            resources.ApplyResources(this.mbChangeImage, "mbChangeImage");
            this.mbChangeImage.Name = "mbChangeImage";
            this.mbChangeImage.Click += new System.EventHandler(this.mbChangeImage_Click);
            // 
            // pbProfileSettings
            // 
            this.pbProfileSettings.Image = global::LMDb.Properties.Resources.user_placeholder;
            resources.ApplyResources(this.pbProfileSettings, "pbProfileSettings");
            this.pbProfileSettings.Name = "pbProfileSettings";
            this.pbProfileSettings.TabStop = false;
            // 
            // metroLabel3
            // 
            resources.ApplyResources(this.metroLabel3, "metroLabel3");
            this.metroLabel3.Name = "metroLabel3";
            // 
            // mcStyle
            // 
            this.mcStyle.FormattingEnabled = true;
            resources.ApplyResources(this.mcStyle, "mcStyle");
            this.mcStyle.Name = "mcStyle";
            this.mcStyle.SelectedIndexChanged += new System.EventHandler(this.mcStyle_SelectedIndexChanged);
            // 
            // mlStyle
            // 
            resources.ApplyResources(this.mlStyle, "mlStyle");
            this.mlStyle.Name = "mlStyle";
            // 
            // mcTheme
            // 
            this.mcTheme.FormattingEnabled = true;
            resources.ApplyResources(this.mcTheme, "mcTheme");
            this.mcTheme.Name = "mcTheme";
            this.mcTheme.SelectedIndexChanged += new System.EventHandler(this.mcTheme_SelectedIndexChanged);
            // 
            // mlTheme
            // 
            resources.ApplyResources(this.mlTheme, "mlTheme");
            this.mlTheme.Name = "mlTheme";
            // 
            // resizeTimer
            // 
            this.resizeTimer.Interval = 200;
            this.resizeTimer.Tick += new System.EventHandler(this.resizeTimer_Tick);
            // 
            // scanningBackgroundWorker
            // 
            this.scanningBackgroundWorker.WorkerReportsProgress = true;
            this.scanningBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.scanningBackgroundWorker_DoWork);
            this.scanningBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.scanningBackgroundWorker_ProgressChanged);
            // 
            // pbProfile
            // 
            resources.ApplyResources(this.pbProfile, "pbProfile");
            this.pbProfile.Image = global::LMDb.Properties.Resources.user_placeholder;
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.TabStop = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbProfile);
            this.Controls.Add(this.mtcMainTabs);
            this.Name = "MainForm";
            this.mtcMainTabs.ResumeLayout(false);
            this.mtHome.ResumeLayout(false);
            this.vcHome.ResumeLayout(false);
            this.vcpLoadingScreen.ResumeLayout(false);
            this.vcpOverview.ResumeLayout(false);
            this.mtSettings.ResumeLayout(false);
            this.tlSettings.ResumeLayout(false);
            this.mpSettingsCategories.ResumeLayout(false);
            this.tlSettingsCategories.ResumeLayout(false);
            this.tlSettingsCategories.PerformLayout();
            this.vcSettings.ResumeLayout(false);
            this.mtpSettingsGeneral.ResumeLayout(false);
            this.mtpSettingsGeneral.PerformLayout();
            this.mtpSettingsFiles.ResumeLayout(false);
            this.mtpSettingsFiles.PerformLayout();
            this.mtpSettingsAppearance.ResumeLayout(false);
            this.mtpSettingsAppearance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
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
        private System.ComponentModel.BackgroundWorker scanningBackgroundWorker;
        private TableLayoutPanel tlSettings;
        private MetroFramework.Controls.MetroPanel mpSettingsCategories;
        private MetroFramework.Controls.MetroLabel mlCategories;
        private TableLayoutPanel tlSettingsCategories;
        private MetroFramework.Controls.MetroLink mllGeneral;
        private ViewControl vcSettings;
        private MetroFramework.Controls.MetroTabPage mtpSettingsGeneral;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage mtpSettingsFiles;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLink mllFiles;
        private MetroFramework.Controls.MetroLink mllAppearance;
        private MetroFramework.Controls.MetroTabPage mtpSettingsAppearance;
        private MetroFramework.Controls.MetroLabel mlTheme;
        private MetroFramework.Controls.MetroComboBox mcTheme;
        private MetroFramework.Controls.MetroComboBox mcStyle;
        private MetroFramework.Controls.MetroLabel mlStyle;
        private PictureBox pbProfile;
        private MetroFramework.Controls.MetroButton mbChangeImage;
        private PictureBox pbProfileSettings;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}