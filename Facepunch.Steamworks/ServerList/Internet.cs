using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Steamworks.ServerList
{
	public class Internet : Base
	{
		internal override void LaunchQuery( IntPtr filters, uint filterCount )
		{
			request = Internal.RequestInternetServerList( AppId.Value, filters, filterCount, IntPtr.Zero );
		}
	}
}
