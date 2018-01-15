using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFTool.usercontrols
{
    public partial class TimeSpanEditUserControl : UserControl
    {
        public event Action ValueChanged;
        public TimeSpanEditUserControl()
        {
            InitializeComponent();
            nudHour.ValueChanged += raiseValueChanged;
            nudMin.ValueChanged += raiseValueChanged;
            nudSec.ValueChanged += raiseValueChanged;
            nudMs.ValueChanged += raiseValueChanged;

            Value = new TimeSpan();
        }

        private void raiseValueChanged(object sender, EventArgs e)
        {
            if(ValueChanged != null)
            {
                ValueChanged();
            }
        }

        public TimeSpan Value
        {
            get
            {
                return new TimeSpan(0, (int)nudHour.Value, (int)nudMin.Value, (int)nudSec.Value, (int)nudMs.Value);
            }
            set
            {
                nudHour.Value = value.Hours;
                nudMin.Value = value.Minutes;
                nudSec.Value = value.Seconds;
                nudMs.Value = value.Milliseconds;
            }
        }
    }
}
