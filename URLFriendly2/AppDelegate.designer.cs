// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoMac.Foundation;
using System.CodeDom.Compiler;

namespace URLFriendly2
{
	[Register ("AppDelegate")]
	partial class AppDelegate
	{
		[Outlet]
		MonoMac.AppKit.NSPanel AboutPanel { get; set; }

		[Outlet]
		MonoMac.AppKit.NSMenu DockMenuOutlet { get; set; }

		[Action ("Decode:")]
		partial void Decode (MonoMac.Foundation.NSObject sender);

		[Action ("Encode:")]
		partial void Encode (MonoMac.Foundation.NSObject sender);

		[Action ("MainMenuDecode:")]
		partial void MainMenuDecode (MonoMac.Foundation.NSObject sender);

		[Action ("MainMenuEncode:")]
		partial void MainMenuEncode (MonoMac.Foundation.NSObject sender);

		[Action ("MenuAbout:")]
		partial void MenuAbout (MonoMac.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (DockMenuOutlet != null) {
				DockMenuOutlet.Dispose ();
				DockMenuOutlet = null;
			}

			if (AboutPanel != null) {
				AboutPanel.Dispose ();
				AboutPanel = null;
			}
		}
	}
}
