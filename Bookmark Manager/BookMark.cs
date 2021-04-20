using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bookmark_Manager
{
	class BookMark
	{
        public string Naam { get; set; }
        public string URL { get; set; }
        public void OpenSite() // does not work
        {
           // Process.Start("chrome.exe", URL);  //Voeg bovenaan using System.Diagnostics; toe
        }
        public void WriteTXTStreamWriter()
        {
            using (StreamWriter streamWriter = new StreamWriter($@"D:\{Naam}.txt"))
            {
                streamWriter.WriteLine(URL);
            }
        }
    }
}
