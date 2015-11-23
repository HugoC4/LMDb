using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace LMDb.Controls
{
    public class ViewControl : MetroTabControl
    {
        private const int TCM_ADJUSTRECT = 0x1328;
        
        private List<int> l = new List<int>();

        public ViewControl()
        {
            if (!DesignMode)
            {
                SetDefaults();
            }
        }

        private void SetDefaults()
        {
            Appearance = TabAppearance.FlatButtons;
            ItemSize = new Size(0, 1);
            SizeMode = TabSizeMode.Fixed;
        }

        protected override void WndProc(ref Message m)
        {
            // Hide the tab headers at run-time
            if (!DesignMode && m.Msg == TCM_ADJUSTRECT && !DesignMode)
            {
                m.Result = (IntPtr)1;
                return;
            }

            // call the base class implementation
            base.WndProc(ref m);
        }
    }
}
