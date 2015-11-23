using System.Windows.Forms;
using LMDb.Controls;

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
            this.vcHome = new LMDb.Controls.ViewControl();
            this.vcpLoadingScreen = new MetroFramework.Controls.MetroTabPage();
            this.ldHome = new LMDb.LoadingScreen();
            this.vcpOverview = new MetroFramework.Controls.MetroTabPage();
            this.tlOverview = new System.Windows.Forms.TableLayoutPanel();
            this.vcpDetails = new MetroFramework.Controls.MetroTabPage();
            this.tlpDetails = new System.Windows.Forms.TableLayoutPanel();
            this.pbDetails = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mlDetailSynopsis = new System.Windows.Forms.Label();
            this.mlDetailsTitle = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mlReleased = new MetroFramework.Controls.MetroLabel();
            this.mlRuntime = new MetroFramework.Controls.MetroLabel();
            this.mlImdbRating = new MetroFramework.Controls.MetroLabel();
            this.mlActors = new MetroFramework.Controls.MetroLabel();
            this.mlWriters = new MetroFramework.Controls.MetroLabel();
            this.mlDirectors = new MetroFramework.Controls.MetroLabel();
            this.mlWebsite = new MetroFramework.Controls.MetroLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mbBack = new MetroFramework.Controls.MetroButton();
            this.mbWatch = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.mcSubs = new MetroFramework.Controls.MetroComboBox();
            this.mcPaths = new MetroFramework.Controls.MetroComboBox();
            this.mtSettings = new MetroFramework.Controls.MetroTabPage();
            this.tlSettings = new System.Windows.Forms.TableLayoutPanel();
            this.mpSettingsCategories = new MetroFramework.Controls.MetroPanel();
            this.tlSettingsCategories = new System.Windows.Forms.TableLayoutPanel();
            this.mllGeneral = new MetroFramework.Controls.MetroLink();
            this.mllAppearance = new MetroFramework.Controls.MetroLink();
            this.mlCategories = new MetroFramework.Controls.MetroLabel();
            this.vcSettings = new LMDb.Controls.ViewControl();
            this.mtpSettingsGeneral = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtpSettingsAppearance = new MetroFramework.Controls.MetroTabPage();
            this.mrbPoster1080 = new MetroFramework.Controls.MetroRadioButton();
            this.mrbPoster720 = new MetroFramework.Controls.MetroRadioButton();
            this.mrbPoster480 = new MetroFramework.Controls.MetroRadioButton();
            this.mrbPosterDefault = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mcStyle = new MetroFramework.Controls.MetroComboBox();
            this.mlStyle = new MetroFramework.Controls.MetroLabel();
            this.mcTheme = new MetroFramework.Controls.MetroComboBox();
            this.mlTheme = new MetroFramework.Controls.MetroLabel();
            this.resizeTimer = new System.Windows.Forms.Timer(this.components);
            this.scanningBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.mtcMainTabs.SuspendLayout();
            this.mtHome.SuspendLayout();
            this.vcHome.SuspendLayout();
            this.vcpLoadingScreen.SuspendLayout();
            this.vcpOverview.SuspendLayout();
            this.vcpDetails.SuspendLayout();
            this.tlpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetails)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.mtSettings.SuspendLayout();
            this.tlSettings.SuspendLayout();
            this.mpSettingsCategories.SuspendLayout();
            this.tlSettingsCategories.SuspendLayout();
            this.vcSettings.SuspendLayout();
            this.mtpSettingsGeneral.SuspendLayout();
            this.mtpSettingsAppearance.SuspendLayout();
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
            this.vcHome.Controls.Add(this.vcpDetails);
            this.vcHome.Multiline = true;
            this.vcHome.Name = "vcHome";
            this.vcHome.SelectedIndex = 0;
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
            // vcpDetails
            // 
            this.vcpDetails.Controls.Add(this.tlpDetails);
            this.vcpDetails.HorizontalScrollbarBarColor = true;
            resources.ApplyResources(this.vcpDetails, "vcpDetails");
            this.vcpDetails.Name = "vcpDetails";
            this.vcpDetails.VerticalScrollbarBarColor = true;
            // 
            // tlpDetails
            // 
            this.tlpDetails.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tlpDetails, "tlpDetails");
            this.tlpDetails.Controls.Add(this.pbDetails, 1, 1);
            this.tlpDetails.Controls.Add(this.tableLayoutPanel1, 3, 1);
            this.tlpDetails.Name = "tlpDetails";
            // 
            // pbDetails
            // 
            resources.ApplyResources(this.pbDetails, "pbDetails");
            this.pbDetails.Name = "pbDetails";
            this.pbDetails.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.mlDetailSynopsis, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.mlDetailsTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // mlDetailSynopsis
            // 
            resources.ApplyResources(this.mlDetailSynopsis, "mlDetailSynopsis");
            this.mlDetailSynopsis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlDetailSynopsis.Name = "mlDetailSynopsis";
            // 
            // mlDetailsTitle
            // 
            resources.ApplyResources(this.mlDetailsTitle, "mlDetailsTitle");
            this.mlDetailsTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlDetailsTitle.Name = "mlDetailsTitle";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.mlReleased);
            this.panel1.Controls.Add(this.mlRuntime);
            this.panel1.Controls.Add(this.mlImdbRating);
            this.panel1.Controls.Add(this.mlActors);
            this.panel1.Controls.Add(this.mlWriters);
            this.panel1.Controls.Add(this.mlDirectors);
            this.panel1.Controls.Add(this.mlWebsite);
            this.panel1.Name = "panel1";
            // 
            // mlReleased
            // 
            resources.ApplyResources(this.mlReleased, "mlReleased");
            this.mlReleased.Name = "mlReleased";
            // 
            // mlRuntime
            // 
            resources.ApplyResources(this.mlRuntime, "mlRuntime");
            this.mlRuntime.Name = "mlRuntime";
            // 
            // mlImdbRating
            // 
            resources.ApplyResources(this.mlImdbRating, "mlImdbRating");
            this.mlImdbRating.Name = "mlImdbRating";
            // 
            // mlActors
            // 
            resources.ApplyResources(this.mlActors, "mlActors");
            this.mlActors.Name = "mlActors";
            // 
            // mlWriters
            // 
            resources.ApplyResources(this.mlWriters, "mlWriters");
            this.mlWriters.Name = "mlWriters";
            // 
            // mlDirectors
            // 
            resources.ApplyResources(this.mlDirectors, "mlDirectors");
            this.mlDirectors.Name = "mlDirectors";
            // 
            // mlWebsite
            // 
            resources.ApplyResources(this.mlWebsite, "mlWebsite");
            this.mlWebsite.Name = "mlWebsite";
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.mbBack);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mbWatch);
            // 
            // mbBack
            // 
            resources.ApplyResources(this.mbBack, "mbBack");
            this.mbBack.Name = "mbBack";
            this.mbBack.Click += new System.EventHandler(this.mbBack_Click);
            // 
            // mbWatch
            // 
            resources.ApplyResources(this.mbWatch, "mbWatch");
            this.mbWatch.Name = "mbWatch";
            this.mbWatch.Click += new System.EventHandler(this.mbWatch_Click_1);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.mcSubs, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.mcPaths, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // mcSubs
            // 
            resources.ApplyResources(this.mcSubs, "mcSubs");
            this.mcSubs.FormattingEnabled = true;
            this.mcSubs.Name = "mcSubs";
            // 
            // mcPaths
            // 
            resources.ApplyResources(this.mcPaths, "mcPaths");
            this.mcPaths.FormattingEnabled = true;
            this.mcPaths.Name = "mcPaths";
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
            // mllAppearance
            // 
            resources.ApplyResources(this.mllAppearance, "mllAppearance");
            this.mllAppearance.Name = "mllAppearance";
            this.mllAppearance.Tag = "1";
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
            this.vcSettings.Controls.Add(this.mtpSettingsAppearance);
            this.vcSettings.Name = "vcSettings";
            this.vcSettings.SelectedIndex = 0;
            this.vcSettings.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // mtpSettingsGeneral
            // 
            this.mtpSettingsGeneral.Controls.Add(this.metroLabel3);
            this.mtpSettingsGeneral.Controls.Add(this.metroLabel2);
            this.mtpSettingsGeneral.Controls.Add(this.metroTextBox1);
            this.mtpSettingsGeneral.Controls.Add(this.metroLabel1);
            this.mtpSettingsGeneral.HorizontalScrollbarBarColor = true;
            resources.ApplyResources(this.mtpSettingsGeneral, "mtpSettingsGeneral");
            this.mtpSettingsGeneral.Name = "mtpSettingsGeneral";
            this.mtpSettingsGeneral.VerticalScrollbarBarColor = true;
            // 
            // metroLabel3
            // 
            resources.ApplyResources(this.metroLabel3, "metroLabel3");
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Name = "metroLabel3";
            // 
            // metroLabel2
            // 
            resources.ApplyResources(this.metroLabel2, "metroLabel2");
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Name = "metroLabel2";
            // 
            // metroTextBox1
            // 
            resources.ApplyResources(this.metroTextBox1, "metroTextBox1");
            this.metroTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LMDb.Properties.Settings.Default, "SearchPaths", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Text = global::LMDb.Properties.Settings.Default.SearchPaths;
            this.metroTextBox1.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            // 
            // metroLabel1
            // 
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.Name = "metroLabel1";
            // 
            // mtpSettingsAppearance
            // 
            this.mtpSettingsAppearance.Controls.Add(this.mrbPoster1080);
            this.mtpSettingsAppearance.Controls.Add(this.mrbPoster720);
            this.mtpSettingsAppearance.Controls.Add(this.mrbPoster480);
            this.mtpSettingsAppearance.Controls.Add(this.mrbPosterDefault);
            this.mtpSettingsAppearance.Controls.Add(this.metroLabel4);
            this.mtpSettingsAppearance.Controls.Add(this.mcStyle);
            this.mtpSettingsAppearance.Controls.Add(this.mlStyle);
            this.mtpSettingsAppearance.Controls.Add(this.mcTheme);
            this.mtpSettingsAppearance.Controls.Add(this.mlTheme);
            this.mtpSettingsAppearance.HorizontalScrollbarBarColor = true;
            resources.ApplyResources(this.mtpSettingsAppearance, "mtpSettingsAppearance");
            this.mtpSettingsAppearance.Name = "mtpSettingsAppearance";
            this.mtpSettingsAppearance.VerticalScrollbarBarColor = true;
            // 
            // mrbPoster1080
            // 
            resources.ApplyResources(this.mrbPoster1080, "mrbPoster1080");
            this.mrbPoster1080.Name = "mrbPoster1080";
            this.mrbPoster1080.TabStop = true;
            this.mrbPoster1080.Tag = "1080";
            this.mrbPoster1080.UseVisualStyleBackColor = true;
            this.mrbPoster1080.CheckedChanged += new System.EventHandler(this.mrbPoster_CheckedChanged);
            // 
            // mrbPoster720
            // 
            resources.ApplyResources(this.mrbPoster720, "mrbPoster720");
            this.mrbPoster720.Name = "mrbPoster720";
            this.mrbPoster720.TabStop = true;
            this.mrbPoster720.Tag = "720";
            this.mrbPoster720.UseVisualStyleBackColor = true;
            this.mrbPoster720.CheckedChanged += new System.EventHandler(this.mrbPoster_CheckedChanged);
            // 
            // mrbPoster480
            // 
            resources.ApplyResources(this.mrbPoster480, "mrbPoster480");
            this.mrbPoster480.Name = "mrbPoster480";
            this.mrbPoster480.TabStop = true;
            this.mrbPoster480.Tag = "480";
            this.mrbPoster480.UseVisualStyleBackColor = true;
            this.mrbPoster480.CheckedChanged += new System.EventHandler(this.mrbPoster_CheckedChanged);
            // 
            // mrbPosterDefault
            // 
            resources.ApplyResources(this.mrbPosterDefault, "mrbPosterDefault");
            this.mrbPosterDefault.Name = "mrbPosterDefault";
            this.mrbPosterDefault.TabStop = true;
            this.mrbPosterDefault.Tag = "0";
            this.mrbPosterDefault.UseVisualStyleBackColor = true;
            this.mrbPosterDefault.CheckedChanged += new System.EventHandler(this.mrbPoster_CheckedChanged);
            // 
            // metroLabel4
            // 
            resources.ApplyResources(this.metroLabel4, "metroLabel4");
            this.metroLabel4.Name = "metroLabel4";
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
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtcMainTabs);
            this.Name = "MainForm";
            this.mtcMainTabs.ResumeLayout(false);
            this.mtHome.ResumeLayout(false);
            this.vcHome.ResumeLayout(false);
            this.vcpLoadingScreen.ResumeLayout(false);
            this.vcpOverview.ResumeLayout(false);
            this.vcpDetails.ResumeLayout(false);
            this.tlpDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDetails)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.mtSettings.ResumeLayout(false);
            this.tlSettings.ResumeLayout(false);
            this.mpSettingsCategories.ResumeLayout(false);
            this.tlSettingsCategories.ResumeLayout(false);
            this.tlSettingsCategories.PerformLayout();
            this.vcSettings.ResumeLayout(false);
            this.mtpSettingsGeneral.ResumeLayout(false);
            this.mtpSettingsGeneral.PerformLayout();
            this.mtpSettingsAppearance.ResumeLayout(false);
            this.mtpSettingsAppearance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtcMainTabs;
        private MetroFramework.Controls.MetroTabPage mtSettings;
        private MetroFramework.Controls.MetroTabPage mtHome;
        public TableLayoutPanel tlOverview;
        public Timer resizeTimer;
        public LoadingScreen ldHome;
        public ViewControl vcHome;
        private MetroFramework.Controls.MetroTabPage vcpLoadingScreen;
        private MetroFramework.Controls.MetroTabPage vcpOverview;
        public System.ComponentModel.BackgroundWorker scanningBackgroundWorker;
        private TableLayoutPanel tlSettings;
        private MetroFramework.Controls.MetroPanel mpSettingsCategories;
        private MetroFramework.Controls.MetroLabel mlCategories;
        private TableLayoutPanel tlSettingsCategories;
        private MetroFramework.Controls.MetroLink mllGeneral;
        private ViewControl vcSettings;
        private MetroFramework.Controls.MetroTabPage mtpSettingsGeneral;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink mllAppearance;
        private MetroFramework.Controls.MetroTabPage mtpSettingsAppearance;
        private MetroFramework.Controls.MetroLabel mlTheme;
        private MetroFramework.Controls.MetroComboBox mcTheme;
        private MetroFramework.Controls.MetroComboBox mcStyle;
        private MetroFramework.Controls.MetroLabel mlStyle;
        private MetroFramework.Controls.MetroRadioButton mrbPoster1080;
        private MetroFramework.Controls.MetroRadioButton mrbPoster720;
        private MetroFramework.Controls.MetroRadioButton mrbPoster480;
        private MetroFramework.Controls.MetroRadioButton mrbPosterDefault;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTabPage vcpDetails;
        private TableLayoutPanel tlpDetails;
        private PictureBox pbDetails;
        private TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel mlDetailsTitle;
        private Label mlDetailSynopsis;
        private FlowLayoutPanel panel1;
        private MetroFramework.Controls.MetroLabel mlRuntime;
        private MetroFramework.Controls.MetroLabel mlReleased;
        private MetroFramework.Controls.MetroLabel mlImdbRating;
        private MetroFramework.Controls.MetroLabel mlActors;
        private MetroFramework.Controls.MetroLabel mlWriters;
        private MetroFramework.Controls.MetroLabel mlDirectors;
        private MetroFramework.Controls.MetroLabel mlWebsite;
        private SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroButton mbBack;
        private MetroFramework.Controls.MetroButton mbWatch;
        private TableLayoutPanel tableLayoutPanel2;
        public MetroFramework.Controls.MetroComboBox mcSubs;
        private MetroFramework.Controls.MetroComboBox mcPaths;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
    }
}