using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RegexpD.RA
{
    public class ResultSaver
    {
        public void Save(List<string> list)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Archieve");

            var archieveDir = new DirectoryInfo(path);
            if (!archieveDir.Exists)
                archieveDir.Create();
        }
    }
}
