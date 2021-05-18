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
			try
			{
				Process.Start(@"c:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "-incognito " + URL);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception: Could find chrome.exe");
				Debug.WriteLine($"Message: { e.Message}");
				Debug.WriteLine($"Targetsite: {e.TargetSite}");
				Debug.WriteLine($"StackTrace: {e.StackTrace}");
			}
		}
		public override string ToString()
		{
			return base.ToString() + " ---HIDDEN---";

		}
	}
}
