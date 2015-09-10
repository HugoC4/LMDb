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
            set { metroLabel1.Text = value; base.Text = value; }
        }

        private string _subText { get; set; }

        public string SubText
        {
            get { return _subText; }
            set { _subText = value;}
        }

        public int Value
        {
            get { return metroProgressSpinner1.Value; }
            set
            {
                value = value > this.metroProgressSpinner1.Maximum ? metroProgressSpinner1.Maximum : value;
                value = value < this.metroProgressSpinner1.Minimum ? metroProgressSpinner1.Minimum : value;
                metroProgressSpinner1.Value = value;
            }
        }

        public bool Spinning
        {
            get { return metroProgressSpinner1.Spinning; }
            set { metroProgressSpinner1.Spinning = value; }
        }

        public LoadingScreen()
        {
            InitializeComponent();
            subTextUpdateTime.Start();
        }

        private void subTextUpdateTime_Tick(object sender, EventArgs e)
        {
            if (metroLabel2.Text != _subText)
                metroLabel2.Text = _subText;
        }
    }
}
