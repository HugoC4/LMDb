using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMDb
{
    class ProgressState
    {
        public int Value { get; set; } = 0;
        public string Text { get; set; } = String.Empty;
        public string SubText { get; set; } = String.Empty;

        public ProgressState IncrementValue(int value = 1)
        {
            Value += value;
            return this;
        }

        public ProgressState SetValue(int value)
        {
            Value = value;
            return this;
        }

        public ProgressState ResetValue()
        {
            Value = 0;
            return this;
        }

        public ProgressState SetText(string text)
        {
            Text = text;
            return this;
        }

        public ProgressState SetSubText(string subText)
        {
            SubText = subText;
            return this;
        }

        public ProgressState EmptyText()
        {
            Text = String.Empty;
            return this;
        }

        public ProgressState EmptySubText()
        {
            SubText = String.Empty;
            return this;
        }
    }
}
