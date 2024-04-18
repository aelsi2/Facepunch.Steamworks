﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;

namespace Steamworks
{
	internal static class Platform
    {
		public const string LibraryName = "steam_api";

#if PLATFORM_WIN
		public const int StructPlatformPackSize = 8;
#elif PLATFORM_UNIX
		public const int StructPlatformPackSize = 4;
#else
		public const int StructPlatformPackSize = 4;
#endif

		public const CallingConvention CC = CallingConvention.Cdecl;
		public const int StructPackSize = 4;
	}
}
