using System;
using System.Drawing;
using MonoMac.Foundation;
using MonoMac.AppKit;
using MonoMac.ObjCRuntime;

namespace URLFriendly2
{
	public partial class AppDelegate : NSApplicationDelegate
	{
		static readonly string[] pboardTypes = { "NSStringPboardType" };
		MainWindowController mainWindowController;

		public override void FinishedLaunching (NSObject notification)
		{
			mainWindowController = new MainWindowController ();
			mainWindowController.Window.MakeKeyAndOrderFront (this);

		}

		partial void Decode (NSObject sender)
		{
			Decode();
		}

		partial void Encode (NSObject sender)
		{
			Encode ();
		}

		partial void MainMenuDecode (NSObject sender)
		{
			Decode ();
		}

		partial void MainMenuEncode (NSObject sender)
		{
			Encode ();
		}

		partial void MenuAbout (NSObject sender)
		{
			AboutPanel.MakeKeyAndOrderFront(this);

		}


		void Decode ()
		{
			var result = URLFriendly2.URLHandler2.Decode (NSPasteboard.GeneralPasteboard.GetStringForType(pboardTypes[0]));
			NSPasteboard.GeneralPasteboard.DeclareTypes(pboardTypes, null);
			NSPasteboard.GeneralPasteboard.SetStringForType(result, pboardTypes[0]);
			Console.WriteLine ("Successfully copied to clipboard {0}", result);
		}

		void Encode ()
		{
			var result = URLFriendly2.URLHandler2.Encode (NSPasteboard.GeneralPasteboard.GetStringForType(pboardTypes[0]));
			NSPasteboard.GeneralPasteboard.DeclareTypes(pboardTypes, null);
			NSPasteboard.GeneralPasteboard.SetStringForType(result, pboardTypes[0]);
			Console.WriteLine ("Successfully copied to clipboard {0}", result);
		}
	}
}

