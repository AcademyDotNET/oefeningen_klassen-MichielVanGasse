using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Bookmark_Manager
{
	class BookMark
	{
        public string Naam { get; set; }
        public string URL { get; set; }
        public virtual void OpenSite()
        {
            Process.Start(@"c:\Program Files (x86)\Google\Chrome\Application\chrome.exe", URL);
        }
        public override string ToString()
		{
            return $"{Naam} {URL}";
		}
    }
}
