#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TimePickerFlyoutPresenterAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer
	{
	}
}