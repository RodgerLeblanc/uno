#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Core
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum CoreInputDeviceTypes 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		None,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Touch,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Pen,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Mouse,
		#endif
	}
	#endif
}