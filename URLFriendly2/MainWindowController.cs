using System;
using System.Collections.Generic;
using System.Linq;
using MonoMac.Foundation;
using MonoMac.AppKit;

namespace URLFriendly2
{
	public partial class MainWindowController : NSWindowController
	{
		private static string[] pboardTypes = { "NSStringPboardType" };

		#region Constructors

		// Called when created from unmanaged code
		public MainWindowController (IntPtr handle) : base (handle)
		{
			Initialize ();
		}
		// Called when created directly from a XIB file
		[Export ("initWithCoder:")]
		public MainWindowController (NSCoder coder) : base (coder)
		{
			Initialize ();
		}
		// Call to load from the XIB/NIB file
		public MainWindowController () : base ("MainWindow")
		{
			Initialize ();
		}
		// Shared initialization code
		void Initialize ()
		{
		}

		#endregion

		//strongly typed window accessor
		public new MainWindow Window {
			get {
				return (MainWindow)base.Window;
			}
		}

		partial void ButtonDecode (NSObject sender)
		{
			var result = URLFriendly.URLHandler.Encode (UserInputOutlet.Cell.StringValue);
			Console.WriteLine ("Decoded {0}", result);
			ResultsOutlet.StringValue = result;
			NSPasteboard.GeneralPasteboard.DeclareTypes(pboardTypes, null);
			NSPasteboard.GeneralPasteboard.SetStringForType(result, pboardTypes[0]);
			MsgOutlet.StringValue = "Successfully copied to clipboard";
		}

		partial void ButtonEncode (NSObject sender)
		{
			var result = URLFriendly.URLHandler.Decode (UserInputOutlet.Cell.StringValue);
			Console.WriteLine ("Encoded {0}", result);
			ResultsOutlet.StringValue = result;
			NSPasteboard.GeneralPasteboard.DeclareTypes(pboardTypes, null);
			NSPasteboard.GeneralPasteboard.SetStringForType(result, pboardTypes[0]);
			MsgOutlet.StringValue = "Successfully copied to clipboard";
		}

	}
}

