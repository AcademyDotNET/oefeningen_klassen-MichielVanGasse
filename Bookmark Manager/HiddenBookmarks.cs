using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmark_Manager
{
	class HiddenBookmarks : BookMark
	{
		public override void OpenSite()
		{
			Process.Start(@"c:\Program Files (x86)\Google\Chrome\Application\chrome.exe","-incognito "+URL);
		}
	}
}
