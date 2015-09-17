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

namespace LMDb
{
    public partial class PosterCard : UserControl
    {
        private string _text;

        public override string Text
        {
            get { return _text; }
            set
            {
                lblInfo.Text = value;
                _text = value;
            }
        }


        public PosterCard()
        {
            InitializeComponent();
        }
    }
}
