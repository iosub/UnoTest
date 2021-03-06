// <autogenerated />
#pragma warning disable 618  // Ignore obsolete members warnings
#pragma warning disable 105  // Ignore duplicate namespaces
#pragma warning disable 1591 // Ignore missing XML comment warnings
using System;
using System.Linq;
using System.Collections.Generic;
using Uno.Extensions;
using Uno;
using System.Diagnostics;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using TestTap.Wasm;

#if __WASM__

#endif
namespace TestTap.Wasm
{
	/// <summary>
	/// Contains all the static resources defined for the application
	/// </summary>
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0056", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0058", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV1003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0085", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2001", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2004", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2005", Justification="Generated code")]
	public sealed partial class GlobalStaticResources
	{
		static bool _initialized;
		private static bool _stylesRegistered;
		private static bool _dictionariesRegistered;
		internal static global::Uno.UI.Xaml.XamlParseContext __ParseContext_ {get; } = new global::Uno.UI.Xaml.XamlParseContext()
		{
			AssemblyName = "TestTap.Wasm",
		}
		;

		static GlobalStaticResources()
		{
			Initialize();
		}
		public static void Initialize()
		{
			if (!_initialized)
			{
				_initialized = true;
				global::ColorCode.GlobalStaticResources.Initialize();
				global::Microsoft.Toolkit.Uwp.GlobalStaticResources.Initialize();
				global::Microsoft.Toolkit.Uwp.UI.Animations.GlobalStaticResources.Initialize();
				global::Microsoft.Toolkit.Uwp.UI.Controls.GlobalStaticResources.Initialize();
				global::Microsoft.Toolkit.Uwp.UI.GlobalStaticResources.Initialize();
				global::Microsoft.Xaml.Interactions.GlobalStaticResources.Initialize();
				global::Microsoft.Xaml.Interactivity.GlobalStaticResources.Initialize();
				global::Uno.Material.GlobalStaticResources.Initialize();
				global::Uno.UI.GlobalStaticResources.Initialize();
				global::Uno.UI.Lottie.GlobalStaticResources.Initialize();
				global::Uno.UI.Toolkit.GlobalStaticResources.Initialize();
				global::ColorCode.GlobalStaticResources.RegisterDefaultStyles();
				global::Microsoft.Toolkit.Uwp.GlobalStaticResources.RegisterDefaultStyles();
				global::Microsoft.Toolkit.Uwp.UI.Animations.GlobalStaticResources.RegisterDefaultStyles();
				global::Microsoft.Toolkit.Uwp.UI.Controls.GlobalStaticResources.RegisterDefaultStyles();
				global::Microsoft.Toolkit.Uwp.UI.GlobalStaticResources.RegisterDefaultStyles();
				global::Microsoft.Xaml.Interactions.GlobalStaticResources.RegisterDefaultStyles();
				global::Microsoft.Xaml.Interactivity.GlobalStaticResources.RegisterDefaultStyles();
				global::Uno.Material.GlobalStaticResources.RegisterDefaultStyles();
				global::Uno.UI.GlobalStaticResources.RegisterDefaultStyles();
				global::Uno.UI.Lottie.GlobalStaticResources.RegisterDefaultStyles();
				global::Uno.UI.Toolkit.GlobalStaticResources.RegisterDefaultStyles();
				global::ColorCode.GlobalStaticResources.RegisterResourceDictionariesBySource();
				global::Microsoft.Toolkit.Uwp.GlobalStaticResources.RegisterResourceDictionariesBySource();
				global::Microsoft.Toolkit.Uwp.UI.Animations.GlobalStaticResources.RegisterResourceDictionariesBySource();
				global::Microsoft.Toolkit.Uwp.UI.Controls.GlobalStaticResources.RegisterResourceDictionariesBySource();
				global::Microsoft.Toolkit.Uwp.UI.GlobalStaticResources.RegisterResourceDictionariesBySource();
				global::Microsoft.Xaml.Interactions.GlobalStaticResources.RegisterResourceDictionariesBySource();
				global::Microsoft.Xaml.Interactivity.GlobalStaticResources.RegisterResourceDictionariesBySource();
				global::Uno.Material.GlobalStaticResources.RegisterResourceDictionariesBySource();
				global::Uno.UI.GlobalStaticResources.RegisterResourceDictionariesBySource();
				global::Uno.UI.Lottie.GlobalStaticResources.RegisterResourceDictionariesBySource();
				global::Uno.UI.Toolkit.GlobalStaticResources.RegisterResourceDictionariesBySource();
			}
		}
		public static void RegisterDefaultStyles()
		{
			if(!_stylesRegistered)
			{
				_stylesRegistered = true;
				RegisterDefaultStyles_App_a2561ab72c03fb16a92c7058faedb008();
				RegisterDefaultStyles_MainPage_e7e2a5be20f8f556339963c59d5c8580();
				RegisterDefaultStyles_TestUserControl_8cf5c7f67498ecc723fd3d5752d1eebb();
				RegisterDefaultStyles_TestViewPivot_ccddd6bf2540d9b2cabccfdb863ab22c();
			}
		}
		// Register ResourceDictionaries using ms-appx:/// syntax, this is called for external resources
		public static void RegisterResourceDictionariesBySource()
		{
			if(!_dictionariesRegistered)
			{
				_dictionariesRegistered = true;
			}
		}
		// Register ResourceDictionaries using ms-resource:/// syntax, this is called for local resources
		internal static void RegisterResourceDictionariesBySourceLocal()
		{
		}
		static partial void RegisterDefaultStyles_App_a2561ab72c03fb16a92c7058faedb008();
		static partial void RegisterDefaultStyles_MainPage_e7e2a5be20f8f556339963c59d5c8580();
		static partial void RegisterDefaultStyles_TestUserControl_8cf5c7f67498ecc723fd3d5752d1eebb();
		static partial void RegisterDefaultStyles_TestViewPivot_ccddd6bf2540d9b2cabccfdb863ab22c();
		[global::System.Obsolete("This method is provided for binary backward compatibility. It will always return null.")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static object FindResource(string name) => null;
		
	}
}
