using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Summerland.Ping
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var wc = new WebClient())
			{
				var url = new Uri("http://www.breaks-in-summerland-tenerife.co.uk/?notrack=1");
				var data = wc.DownloadData(url);

				url = new Uri("http://www.breaks-in-summerland-tenerife.co.uk/more-info/?notrack=1");
				data = wc.DownloadData(url);

				url = new Uri("http://www.breaks-in-summerland-tenerife.co.uk/more-info/location/?notrack=1");
				data = wc.DownloadData(url);

				url = new Uri("http://www.breaks-in-summerland-tenerife.co.uk/Pictures/?notrack=1");
				data = wc.DownloadData(url);

				url = new Uri("http://www.breaks-in-summerland-tenerife.co.uk/Availability/?notrack=1");
				data = wc.DownloadData(url);

				url = new Uri("http://www.breaks-in-summerland-tenerife.co.uk/Availability/2014/?notrack=1");
				data = wc.DownloadData(url);

				url = new Uri("http://www.breaks-in-summerland-tenerife.co.uk/more-info/contact-us/?notrack=1");
				data = wc.DownloadData(url);
			}

			Console.Write("Done");
		}
	}
}
