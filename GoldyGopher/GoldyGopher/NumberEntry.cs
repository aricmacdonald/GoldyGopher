using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GoldyGopher
{
    public partial class NumberEntry : Form

    {
        private int startNum = 0;
        private int endNum = 0;

        public NumberEntry()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            startNum = Convert.ToInt32(numStartValue.Value);
            endNum = Convert.ToInt32(numEndValue.Value);

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                listView1.Items.Clear();

                for (int i = startNum; i <= endNum; i++)
                {
                    if (i % 3 == 0 && i % 7 == 0)
                    {
                        listView1.Items.Add("Goldy Gopher");
                    }
                    else if (i % 3 == 0)
                    {
                        listView1.Items.Add("Goldy");
                    }
                    else if (i % 7 == 0)
                    {
                        listView1.Items.Add("Gopher");
                    }
                    else
                    {
                        listView1.Items.Add(i.ToString());
                    }
                }
            }
        }

        private void numEndValue_Validating(object sender, CancelEventArgs e)
        {
            startNum = Convert.ToInt32(numStartValue.Value);
            endNum = Convert.ToInt32(numEndValue.Value);

            if (endNum < startNum)
            {
                e.Cancel = true;
                numEndValue.Focus();
                errorProviderEndingValue.SetError(numEndValue, "The ending value cannot be smaller than the starting value.");
            }
            else
            {
                e.Cancel = false;
                errorProviderEndingValue.SetError(numEndValue, "");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = false;
            base.OnFormClosing(e);
        }
    }
}
