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
	[Protocol (Name = "WMCampaignInfoDelegate", WrapperType = typeof (WMCampaignInfoDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CampaignDidDismiss", Selector = "campaignDidDismiss:", ParameterType = new Type [] { typeof (WalkMeXamariniOSBinding.WMCampaignInfo) }, ParameterByRef = new bool [] { false })]
	public interface IWMCampaignInfoDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("campaignDidDismiss:")]
		[Preserve (Conditional = true)]
		void CampaignDidDismiss (WMCampaignInfo campaignInfo);
		
	}
	
	internal sealed class WMCampaignInfoDelegateWrapper : BaseWrapper, IWMCampaignInfoDelegate {
		[Preserve (Conditional = true)]
		public WMCampaignInfoDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("campaignDidDismiss:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CampaignDidDismiss (WMCampaignInfo campaignInfo)
		{
			if (campaignInfo == null)
				throw new ArgumentNullException ("campaignInfo");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("campaignDidDismiss:"), campaignInfo.Handle);
		}
		
	}
}
namespace WalkMeXamariniOSBinding {
	[Protocol()]
	[Register("WMCampaignInfoDelegate", false)]
	[Model]
	public unsafe abstract partial class WMCampaignInfoDelegate : NSObject, IWMCampaignInfoDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected WMCampaignInfoDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected WMCampaignInfoDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal WMCampaignInfoDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("campaignDidDismiss:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void CampaignDidDismiss (WMCampaignInfo campaignInfo);
	} /* class WMCampaignInfoDelegate */
}
