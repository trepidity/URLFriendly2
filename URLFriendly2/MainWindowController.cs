using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using MonoMac.Foundation;
using MonoMac.AppKit;
using System.Text;

namespace URLFriendly2
{
	public partial class MainWindowController : NSWindowController
	{
		static readonly string[] pboardTypes = { "NSStringPboardType" };

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
			var result = URLFriendly2.URLHandler2.Encode (UserInputOutlet.Cell.StringValue);
			Console.WriteLine ("Decoded {0}", result);
			ResultsOutlet.StringValue = result;
			NSPasteboard.GeneralPasteboard.DeclareTypes(pboardTypes, null);
			NSPasteboard.GeneralPasteboard.SetStringForType(result, pboardTypes[0]);
			MsgOutlet.StringValue = "Successfully copied to clipboard";
		}

		partial void ButtonEncode (NSObject sender)
		{
			var result = URLFriendly2.URLHandler2.Decode (UserInputOutlet.Cell.StringValue);
			Console.WriteLine ("Encoded {0}", result);
			ResultsOutlet.StringValue = result;
			NSPasteboard.GeneralPasteboard.DeclareTypes(pboardTypes, null);
			NSPasteboard.GeneralPasteboard.SetStringForType(result, pboardTypes[0]);
			MsgOutlet.StringValue = "Successfully copied to clipboard";
		}

		partial void IdentityProvider_INPUT(NSObject sender)
		{
			var textField = (NSTextField)sender;
			Console.WriteLine (string.Format("Identity Provider URL {0}", textField.Cell.StringValue));
		}

		partial void GenerateUrlButton(NSObject sender)
		{
			// clear messages
			GenerateMessages.Cell.StringValue = "";

			var idpVal = IdentityProviderField.Cell.StringValue;
			var spID = ServiceProviderField.Cell.StringValue;
			var targetURL = TargetURLField.Cell.StringValue;
			var idpPort = IDPPortInput.Cell.StringValue;
			var idpProtocol = IdentityProvierProtocol.Cell.StringValue;

			// do we have a required IDP port
			if (String.IsNullOrEmpty(idpPort)) {
				Console.WriteLine ("missing required IDP port");
				GenerateMessages.Cell.StringValue = "Missing required IDP port";
				return;
			}

			if (string.IsNullOrEmpty(idpVal)) {
				Console.WriteLine ("Missing Identity Provider URL");
				GenerateMessages.Cell.StringValue = "Missing required IDP URL";
				return;
			}

			if (string.IsNullOrEmpty(spID)) {
				Console.WriteLine ("Missing Service Provider ID");
				GenerateMessages.Cell.StringValue = "Missing Service Provider ID.";
				return;
			}

			if (string.IsNullOrEmpty(targetURL)) {
				Console.WriteLine ("Missing target URL");
				GenerateMessages.Cell.StringValue = "Missing target URL.";
				return;
			}

			// do we have a required IDP port
			if (String.IsNullOrEmpty(idpProtocol)) {
				Console.WriteLine ("missing required IDP protocol");
				GenerateMessages.Cell.StringValue = "Missing required IDP protocol";
				return;
			}
				
			Console.WriteLine (string.Format("Identity Provider URL {0}", idpVal));

			if (SAML1.State == NSCellStateValue.On)
				Console.WriteLine ("SAML1 enabled");
			
			if (SAML2.State == NSCellStateValue.On)
				Console.WriteLine ("SAML2 enabled");

			var sb = new StringBuilder();
			sb.Append(idpProtocol.Replace("://",""));
			sb.Append("://");
			sb.Append(idpVal);
			if (Regex.IsMatch(idpVal, ":\\d{2,}") == false) {
				sb.Append(":");
				sb.Append(idpPort);
			}
			
			sb.Append("/nidp/");

			if (SAML1.State == NSCellStateValue.On)
				sb.Append("saml");
			else
				sb.Append("saml2");
			sb.Append("/");

			if (SPInitiated.State == NSCellStateValue.On)
				sb.Append("spsend");
			else
				sb.Append("idpsend");

			sb.Append("?SP=");
			sb.Append(spID);
			sb.Append("&target=");
			sb.Append(URLFriendly2.URLHandler2.Encode(targetURL));

			Console.WriteLine (string.Format("Generated URL = {0}", sb.ToString()));
			ResultsOutlet.StringValue = sb.ToString();
				
		}

	}
}

