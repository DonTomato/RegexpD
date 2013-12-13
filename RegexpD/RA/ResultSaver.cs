using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RegexpD.RA
{
    public class ResultSaver
    {
        private DateTime Created = DateTime.Now;

        public void Save(string text, string pattern, List<string> list)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Archive");

            var archieveDir = new DirectoryInfo(path);
            if (!archieveDir.Exists)
                archieveDir.Create();

            var sessionDir = new DirectoryInfo(Path.Combine(path, Created.ToString("yyyy-MM-dd HH.mm.ss")));
            if (!sessionDir.Exists)
                sessionDir.Create();

            var result =
                "Text:" +
                "\r\n--------------------------------------------------------------------------------------------\r\n" +
                text +
                "\r\n--------------------------------------------------------------------------------------------" +
                "\r\n\r\n\r\n" +
                "Pattern: " + pattern +
                "\r\n\r\n\r\n" +
                "Results:" +
                "\r\n--------------------------------------------------------------------------------------------" +
                list.Aggregate("", (acc, x) => acc + "\r\n" + x);

            string fileName = Path.Combine(sessionDir.FullName, 
                String.Format("{0}.log", DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss")));

            File.WriteAllText(fileName, result);
        }
    }
}
