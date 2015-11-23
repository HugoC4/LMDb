using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMDb.Db;
using LMDb.Properties;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Drawing;

namespace LMDb.Controls
{
    public partial class PosterCard : UserControl
    {
        public EventHandler CustomClick { get; set; }
        public Image Image
        {
            get { return Poster.Image; }
            set { Poster.Image.Dispose(); Poster.Image = value;}
        }

        public string Title
        {
            get { return mlTitle.Text; }
            set { mlTitle.Text = value; }
        }

        public string Synopsis
        {
            get { return mlSynopsis.Text; }
            set { mlSynopsis.Text = value; }
        }

        public string Genres
        {
            get { return mlGenres.Text; }
            set { mlGenres.Text = value; }
        }

        public string Rating
        {
            get { return mlRating.Text; }
            set { mlRating.Text = value; }
        }

        public Movie Movie { get; set; }

        public PosterCard()
        {
            InitializeComponent();
            mlSynopsis.Font = MetroFonts.Label(MetroLabelSize.Medium, MetroLabelWeight.Light);
            mlSynopsis.ForeColor = MetroPaint.ForeColor.Label.Normal(MetroStyleManager.Default.Theme);
            Poster.Click += (sender, e) => CustomClick.Invoke(this, e);
            mlGenres.Click += (sender, e) => CustomClick.Invoke(this, e);
            mlSynopsis.Click += (sender, e) => CustomClick.Invoke(this, e);
            mlRating.Click += (sender, e) => CustomClick.Invoke(this, e);
            mpInfo.Click += (sender, e) => CustomClick.Invoke(this, e);
            tlpInfo.Click += (sender, e) => CustomClick.Invoke(this, e);
            mlTitle.Click += (sender, e) => CustomClick.Invoke(this, e);
        }

        private void PosterCard_Resize(object sender, EventArgs e)
        {
            mpInfo.Height = (int) Math.Round(Height*(23F/56F));
            mpInfo.Width = Width - 30;
            mpInfo.Location = new Point(15, Height - mpInfo.Height - 15);
        }

        private void Poster_MouseEnter(object sender, EventArgs e)
        {
            mpInfo.Visible = true;
        }

        private void Poster_MouseLeave(object sender, EventArgs e)
        {
            if (ClientRectangle.Contains(PointToClient(MousePosition))) return;

            mpInfo.Visible = false;
            OnMouseLeave(e);
            
        }
        
    }
}
