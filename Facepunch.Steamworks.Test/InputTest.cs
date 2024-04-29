using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Steamworks.Data;

namespace Steamworks
{
    [TestClass]
	[DeploymentItem( TestAssets.Win64Lib )]
	[DeploymentItem( TestAssets.Win32Lib )]
	[DeploymentItem( TestAssets.ControllerConfig )]
    public class InputTest
	{
		[TestMethod]
        public void ControllerList()
        {
			foreach ( var controller in SteamInput.Controllers )
			{
				Console.Write( $"Controller: {controller}" );

				var dstate = controller.GetDigitalState( "fire" );
				var astate = controller.GetAnalogState( "Move" );
			}
		}
	}

}
