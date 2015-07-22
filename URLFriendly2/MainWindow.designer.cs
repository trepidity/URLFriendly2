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
		MonoMac.AppKit.NSTextField EncodeDecodeTextFieldMethod { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField GenerateMessages { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField IdentityProviderField { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField IdentityProvierProtocol { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButtonCell IDPInitiated { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField IDPPortInput { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField MsgOutlet { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField ResultsOutlet { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButtonCell SAML1 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButtonCell SAML2 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField ServiceProviderField { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButtonCell SPInitiated { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField TargetURLField { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField UserInputOutlet { get; set; }

		[Action ("ButtonDecode:")]
		partial void ButtonDecode (MonoMac.Foundation.NSObject sender);

		[Action ("ButtonEncode:")]
		partial void ButtonEncode (MonoMac.Foundation.NSObject sender);

		[Action ("EncodeDecodeInput:")]
		partial void EncodeDecodeInput (MonoMac.Foundation.NSObject sender);

		[Action ("GenerateUrlButton:")]
		partial void GenerateUrlButton (MonoMac.Foundation.NSObject sender);

		[Action ("IdentityProvider_INPUT:")]
		partial void IdentityProvider_INPUT (MonoMac.Foundation.NSObject sender);

		[Action ("InitiatedFederationType:")]
		partial void InitiatedFederationType (MonoMac.Foundation.NSObject sender);

		[Action ("SAML_TYPE_RADIO:")]
		partial void SAML_TYPE_RADIO (MonoMac.Foundation.NSObject sender);

		[Action ("ServiceProviderInput:")]
		partial void ServiceProviderInput (MonoMac.Foundation.NSObject sender);

		[Action ("TargetURL:")]
		partial void TargetURL (MonoMac.Foundation.NSObject sender);

		[Action ("UserInput:")]
		partial void UserInput (MonoMac.Foundation.NSObject sender);

		[Action ("UserInputDecodeEncode:")]
		partial void UserInputDecodeEncode (MonoMac.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (EncodeDecodeTextFieldMethod != null) {
				EncodeDecodeTextFieldMethod.Dispose ();
				EncodeDecodeTextFieldMethod = null;
			}

			if (DecodeButton != null) {
				DecodeButton.Dispose ();
				DecodeButton = null;
			}

			if (EncodeButton != null) {
				EncodeButton.Dispose ();
				EncodeButton = null;
			}

			if (GenerateMessages != null) {
				GenerateMessages.Dispose ();
				GenerateMessages = null;
			}

			if (IdentityProviderField != null) {
				IdentityProviderField.Dispose ();
				IdentityProviderField = null;
			}

			if (IdentityProvierProtocol != null) {
				IdentityProvierProtocol.Dispose ();
				IdentityProvierProtocol = null;
			}

			if (IDPInitiated != null) {
				IDPInitiated.Dispose ();
				IDPInitiated = null;
			}

			if (IDPPortInput != null) {
				IDPPortInput.Dispose ();
				IDPPortInput = null;
			}

			if (MsgOutlet != null) {
				MsgOutlet.Dispose ();
				MsgOutlet = null;
			}

			if (ResultsOutlet != null) {
				ResultsOutlet.Dispose ();
				ResultsOutlet = null;
			}

			if (SAML1 != null) {
				SAML1.Dispose ();
				SAML1 = null;
			}

			if (SAML2 != null) {
				SAML2.Dispose ();
				SAML2 = null;
			}

			if (ServiceProviderField != null) {
				ServiceProviderField.Dispose ();
				ServiceProviderField = null;
			}

			if (SPInitiated != null) {
				SPInitiated.Dispose ();
				SPInitiated = null;
			}

			if (TargetURLField != null) {
				TargetURLField.Dispose ();
				TargetURLField = null;
			}

			if (UserInputOutlet != null) {
				UserInputOutlet.Dispose ();
				UserInputOutlet = null;
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

		[Action ("TextInput:")]
		partial void TextInput (MonoMac.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
		}
	}
}
