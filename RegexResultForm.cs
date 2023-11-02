using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _200601038_odev1_1
{
    public partial class RegexResultForm : Form
    {
        public RegexResultForm(string fileName, string pattern, string[] matcheds)
        {
            InitializeComponent();
            this.lblRegex.Text = pattern;
            this.gbRegex.Text = fileName;
            this.rtBoxResults.ReadOnly = true;
            this.addResults(matcheds);
        }
        private void RegexResultForm_Load(object sender, EventArgs e)
        {

        }

        private void addResults(string[] matcheds)
        {
            for (int i = 0; i < matcheds.Length; i += 1)
                rtBoxResults.AppendText((i + 1) + "- " + matcheds[i] + "\n");
        }

        private void RegexResultForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
