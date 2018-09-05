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
	[Register("ABBI", true)]
	public unsafe partial class ABBI : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("ABBI");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ABBI () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ABBI (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ABBI (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("clearPrivateUserAttributes")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ClearPrivateUserAttributes ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("clearPrivateUserAttributes"));
		}
		
		[Export ("sendGoal:withProperites:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SendGoal (string goalName, NSDictionary properties)
		{
			if (goalName == null)
				throw new ArgumentNullException ("goalName");
			if (properties == null)
				throw new ArgumentNullException ("properties");
			var nsgoalName = NSString.CreateNative (goalName);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("sendGoal:withProperites:"), nsgoalName, properties.Handle);
			NSString.ReleaseNative (nsgoalName);
			
		}
		
		[Export ("setCampaignInfoDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetCampaignInfoDelegate (WMCampaignInfoDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setCampaignInfoDelegate:"), @delegate.Handle);
		}
		
		[Export ("setFlag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetFlag (int n)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_int (class_ptr, Selector.GetHandle ("setFlag:"), n);
		}
		
		[Export ("setPrivateUserAttributeWithKey:andValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetPrivateUserAttributeWithKey (string key, NSObject value)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			if (value == null)
				throw new ArgumentNullException ("value");
			var nskey = NSString.CreateNative (key);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("setPrivateUserAttributeWithKey:andValue:"), nskey, value.Handle);
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("setPrivateUserAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetPrivateUserAttributes (NSDictionary<NSString, NSObject> attributes)
		{
			if (attributes == null)
				throw new ArgumentNullException ("attributes");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setPrivateUserAttributes:"), attributes.Handle);
		}
		
		[Export ("setUserAttributeWithKey:andValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetUserAttributeWithKey (string key, NSObject value)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			if (value == null)
				throw new ArgumentNullException ("value");
			var nskey = NSString.CreateNative (key);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("setUserAttributeWithKey:andValue:"), nskey, value.Handle);
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("setUserAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetUserAttributes (NSDictionary<NSString, NSObject> attributes)
		{
			if (attributes == null)
				throw new ArgumentNullException ("attributes");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setUserAttributes:"), attributes.Handle);
		}
		
		[Export ("setUserID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetUserID (string userId)
		{
			if (userId == null)
				throw new ArgumentNullException ("userId");
			var nsuserId = NSString.CreateNative (userId);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setUserID:"), nsuserId);
			NSString.ReleaseNative (nsuserId);
			
		}
		
		[Export ("start:withSecretKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Start (string appId, string appSecretKey)
		{
			if (appId == null)
				throw new ArgumentNullException ("appId");
			if (appSecretKey == null)
				throw new ArgumentNullException ("appSecretKey");
			var nsappId = NSString.CreateNative (appId);
			var nsappSecretKey = NSString.CreateNative (appSecretKey);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("start:withSecretKey:"), nsappId, nsappSecretKey);
			NSString.ReleaseNative (nsappId);
			NSString.ReleaseNative (nsappSecretKey);
			
		}
		
		[Export ("start:withSecretKey:andApplicationType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Start (string appId, string appSecretKey, ABBIAppType type)
		{
			if (appId == null)
				throw new ArgumentNullException ("appId");
			if (appSecretKey == null)
				throw new ArgumentNullException ("appSecretKey");
			var nsappId = NSString.CreateNative (appId);
			var nsappSecretKey = NSString.CreateNative (appSecretKey);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt32 (class_ptr, Selector.GetHandle ("start:withSecretKey:andApplicationType:"), nsappId, nsappSecretKey, (UInt32)type);
			NSString.ReleaseNative (nsappId);
			NSString.ReleaseNative (nsappSecretKey);
			
		}
		
		[Export ("trigger:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Trigger (string myTriggerName)
		{
			if (myTriggerName == null)
				throw new ArgumentNullException ("myTriggerName");
			var nsmyTriggerName = NSString.CreateNative (myTriggerName);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("trigger:"), nsmyTriggerName);
			NSString.ReleaseNative (nsmyTriggerName);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public WMCampaignInfoDelegate CampaignInfoDelegate {
			get {
				return WeakCampaignInfoDelegate as WMCampaignInfoDelegate;
			}
			set {
				var rvalue = value as NSObject;
				if (value != null && rvalue == null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakCampaignInfoDelegate = rvalue;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_WeakCampaignInfoDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject WeakCampaignInfoDelegate {
			[Export ("campaignInfoDelegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("campaignInfoDelegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("campaignInfoDelegate")));
				}
				MarkDirty ();
				__mt_WeakCampaignInfoDelegate_var = ret;
				return ret;
			}
			
			[Export ("setCampaignInfoDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCampaignInfoDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCampaignInfoDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakCampaignInfoDelegate_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakCampaignInfoDelegate_var = null;
			}
		}
	} /* class ABBI */
}
