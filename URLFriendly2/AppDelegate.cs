using System;
using System.Drawing;
using MonoMac.Foundation;
using MonoMac.AppKit;
using MonoMac.ObjCRuntime;

namespace URLFriendly2
{
	public partial class AppDelegate : NSApplicationDelegate
	{
		static string[] pboardTypes = { "NSStringPboardType" };
		MainWindowController mainWindowController;

		public AppDelegate ()
		{
		}

		public override void FinishedLaunching (NSObject notification)
		{
			mainWindowController = new MainWindowController ();
			mainWindowController.Window.MakeKeyAndOrderFront (this);
		}

		public override bool OpenFile (NSApplication sender, string filename)
		{
			throw new System.NotImplementedException ();
		}

		partial void Decode (NSObject sender)
		{
			var result = URLFriendly.URLHandler.Decode (NSPasteboard.GeneralPasteboard.GetStringForType(pboardTypes[0]));
			NSPasteboard.GeneralPasteboard.DeclareTypes(pboardTypes, null);
			NSPasteboard.GeneralPasteboard.SetStringForType(result, pboardTypes[0]);
			Console.WriteLine ("Successfully copied to clipboard {0}", result);
		}

		partial void Encode (NSObject sender)
		{
			var result = URLFriendly.URLHandler.Encode (NSPasteboard.GeneralPasteboard.GetStringForType(pboardTypes[0]));
			NSPasteboard.GeneralPasteboard.DeclareTypes(pboardTypes, null);
			NSPasteboard.GeneralPasteboard.SetStringForType(result, pboardTypes[0]);
			Console.WriteLine ("Successfully copied to clipboard {0}", result);
		}

	}
}

