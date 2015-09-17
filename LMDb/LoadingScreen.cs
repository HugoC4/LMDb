using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMDb
{
    public partial class LoadingScreen : UserControl
    {

        public override string Text
        {
            get { return base.Text; }
            set { mlblText.Text = value; base.Text = value; }
        }

        public string SubText
        {
            get { return mlblSubText.Text; }
            set { mlblSubText.Text = value;}
        }

        public int Value
        {
            get { return mpsLoading.Value; }
            set
            {
                value = value > this.mpsLoading.Maximum ? mpsLoading.Maximum : value;
                value = value < this.mpsLoading.Minimum ? mpsLoading.Minimum : value;
                mpsLoading.Value = value;
            }
        }

        public bool Spinning
        {
            get { return mpsLoading.Spinning; }
            set { mpsLoading.Spinning = value; }
        }

        public LoadingScreen()
        {
            InitializeComponent();
        }
    }
}
