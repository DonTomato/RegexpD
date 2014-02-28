using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegexpD
{
    public class RegexAnalyzer
    {
        public List<string> Analyze(string input, string pattern, bool ignoreCase)
        {
            List<string> result = new List<string>();

			// test 1 111

            try
            {
                RegexOptions options = ignoreCase ? RegexOptions.IgnoreCase : RegexOptions.None;

                bool isMatch = Regex.IsMatch(input, pattern, options);

                result.Add(String.Format("IsMatch: {0}", isMatch));
                result.Add(String.Empty);
                result.Add(String.Empty);

                MatchCollection collection = Regex.Matches(input, pattern, options);

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }
    }
}
