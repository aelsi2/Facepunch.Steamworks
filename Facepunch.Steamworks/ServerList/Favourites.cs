﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Steamworks.ServerList
{
	public class Favourites : Base
	{
		internal override void LaunchQuery( IntPtr filters, uint filterCount )
		{
			request = Internal.RequestFavoritesServerList( AppId.Value, filters, filterCount, IntPtr.Zero );
		}
	}
}
