using System;
using System.Collections.Generic;
namespace SettingsDemo.Models
{
    public class SiteSettings
    {
		public int NumberOfItemsToShow { get; set; }
		public string Title { get; set; }

		public List<string> Topics { get; set; }
    }
}
