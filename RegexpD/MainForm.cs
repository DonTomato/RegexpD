﻿using RegexpD.RA;
using System;
using System.Collections.Generic;
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
        private RegexAnalyzer _analyzer = new RegexAnalyzer();

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

                result = _analyzer.Analyze(teInput.Text, tePattern.Text, cheIgnoreCase.Checked);

				teResult.Lines = result.ToArray();

                _saver.Save(teInput.Text, tePattern.Text, result); 
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void btAnalyze_Click(object sender, EventArgs e)
        {
            Analyze();
        }
	}
}
