using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLibrary
{
    public class FileFunctions
    {
        public static string GetFilePathFromBaseDirectory(string fileName)
        {
            string parentDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppContext.BaseDirectory).ToString()).ToString()).ToString();
            //Console.WriteLine(Path.Combine(parentDirectory, fileName));
            return Path.Combine(parentDirectory, fileName);
        }
    }
}
