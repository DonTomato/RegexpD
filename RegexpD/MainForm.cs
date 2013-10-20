using RegexpD.RA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegexpD
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

        private ResultSaver _saver = new ResultSaver();

		private void tePattern_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				Analyze();
				e.Handled = true;
			}
		}

		public void Analyze()
		{
			try
			{
				List<string> result = new List<string>();

				bool isMatch = Regex.IsMatch(teInput.Text, tePattern.Text, cheIgnoreCase.Checked ? RegexOptions.IgnoreCase : RegexOptions.None);

				result.Add(String.Format("IsMatch: {0}", isMatch));
				result.Add(String.Empty);
				result.Add(String.Empty);

				MatchCollection collection = Regex.Matches(teInput.Text, tePattern.Text, cheIgnoreCase.Checked ? RegexOptions.IgnoreCase : RegexOptions.None);

				for (int i = 0; i < collection.Count; i++)
				{
					var m = collection[i];

					result.Add(String.Format("#{0}:\tValue: '{1}'", i, m.Value));
					for (int k = 1; k < m.Groups.Count; k++)
					{
						var g = m.Groups[k];
						result.Add(String.Format("\t\t G#{0}:\tValue: '{1}'", k, g.Value));
					}
					result.Add(String.Empty);
					result.Add(String.Empty);
				}

				teResult.Lines = result.ToArray();

                _saver.Save(teInput.Text, tePattern.Text, result);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
