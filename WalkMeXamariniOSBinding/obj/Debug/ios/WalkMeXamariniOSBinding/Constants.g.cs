//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;

namespace WalkMeXamariniOSBinding {
	public unsafe static partial class Constants  {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _SDK_VERSION;
		[Field ("SDK_VERSION",  "__Internal")]
		public static NSString SDK_VERSION {
			get {
				if (_SDK_VERSION == null)
					_SDK_VERSION = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "SDK_VERSION");
				return _SDK_VERSION;
			}
		}
	} /* class Constants */
}
