using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMDb.Properties;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Drawing;

namespace LMDb.Controls
{
    public partial class PosterCard : UserControl
    {
        public Image Image
        {
            get { return Poster.Image; }
            set { Poster.Image = value;}
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

        public PosterCard()
        {
            InitializeComponent();
            mlSynopsis.Font = MetroFonts.Label(MetroLabelSize.Medium, MetroLabelWeight.Light);
            mlSynopsis.ForeColor = MetroPaint.ForeColor.Label.Normal(MetroStyleManager.Default.Theme);
        }

        private void PosterCard_Resize(object sender, EventArgs e)
        {
            mpInfo.Height = (int) Math.Round(Height*(23F/56F));
            mpInfo.Width = Width - 30;
            mpInfo.Location = new Point(15, Height - mpInfo.Height - 15);
        }

        private void PosterCard_MouseEnter(object sender, EventArgs e)
        {
            mpInfo.Visible = true;
        }

        private void PosterCard_MouseLeave(object sender, EventArgs e)
        {
            mpInfo.Visible = false;
        }

        private void PosterCard_MouseMove(object sender, MouseEventArgs e)
        {
            mpInfo.Visible = true;
        }

        private void Poster_MouseEnter(object sender, EventArgs e)
        {
            mpInfo.Visible = true;
        }

        private void Poster_MouseLeave(object sender, EventArgs e)
        {
            mpInfo.Visible = false;
        }
    }
}
