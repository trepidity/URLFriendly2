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
	[Register ("MainWindowController")]
	partial class MainWindowController
	{
		[Outlet]
		MonoMac.AppKit.NSButton DecodeButton { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton EncodeButton { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField MsgOutlet { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField ResultsOutlet { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField UserInputOutlet { get; set; }

		[Action ("ButtonDecode:")]
		partial void ButtonDecode (MonoMac.Foundation.NSObject sender);

		[Action ("ButtonEncode:")]
		partial void ButtonEncode (MonoMac.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (DecodeButton != null) {
				DecodeButton.Dispose ();
				DecodeButton = null;
			}

			if (EncodeButton != null) {
				EncodeButton.Dispose ();
				EncodeButton = null;
			}

			if (ResultsOutlet != null) {
				ResultsOutlet.Dispose ();
				ResultsOutlet = null;
			}

			if (UserInputOutlet != null) {
				UserInputOutlet.Dispose ();
				UserInputOutlet = null;
			}

			if (MsgOutlet != null) {
				MsgOutlet.Dispose ();
				MsgOutlet = null;
			}
		}
	}

	[Register ("MainWindow")]
	partial class MainWindow
	{
		[Action ("ButtonDecode:")]
		partial void ButtonDecode (MonoMac.Foundation.NSObject sender);

		[Action ("ButtonEncode:")]
		partial void ButtonEncode (MonoMac.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
		}
	}
}
