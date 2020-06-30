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
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
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
using NetworkExtension;

namespace CCLocation {
	[Register("CCLocation", true)]
	public unsafe partial class CCLocation : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CCLocation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CCLocation () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CCLocation (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CCLocation (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("addAliasWithKey:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAliasWithKey (string key, string value)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			if (value == null)
				throw new ArgumentNullException ("value");
			var nskey = NSString.CreateNative (key);
			var nsvalue = NSString.CreateNative (value);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("addAliasWithKey:value:"), nskey, nsvalue);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("addAliasWithKey:value:"), nskey, nsvalue);
			}
			NSString.ReleaseNative (nskey);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[Export ("askMotionPermissions")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AskMotionPermissions ()
		{
			global::ApiDefinitions.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("askMotionPermissions"));
		}
		
		[Export ("receivedSilentNotificationWithUserInfo:clientKey:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ReceivedSilentNotificationWithUserInfo (NSDictionary userInfo, string key, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completion)
		{
			if (userInfo == null)
				throw new ArgumentNullException ("userInfo");
			if (key == null)
				throw new ArgumentNullException ("key");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			var nskey = NSString.CreateNative (key);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V0.Handler, completion);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("receivedSilentNotificationWithUserInfo:clientKey:completion:"), userInfo.Handle, nskey, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("receivedSilentNotificationWithUserInfo:clientKey:completion:"), userInfo.Handle, nskey, (IntPtr) block_ptr_completion);
			}
			NSString.ReleaseNative (nskey);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("registerLocationListener")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegisterLocationListener ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("registerLocationListener"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("registerLocationListener"));
			}
		}
		
		[Export ("requestLocation")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RequestLocation ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("requestLocation"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("requestLocation"));
			}
		}
		
		[Export ("setAliasesWithAliases:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAliasesWithAliases (NSDictionary<NSString, NSString> aliases)
		{
			if (aliases == null)
				throw new ArgumentNullException ("aliases");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAliasesWithAliases:"), aliases.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAliasesWithAliases:"), aliases.Handle);
			}
		}
		
		[Export ("setLoggerLevelsWithVerbose:info:debug:warning:error:severe:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetLoggerLevelsWithVerbose (bool verbose, bool info, bool debug, bool warning, bool error, bool severe)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_bool_bool_bool_bool_bool_bool (this.Handle, Selector.GetHandle ("setLoggerLevelsWithVerbose:info:debug:warning:error:severe:"), verbose, info, debug, warning, error, severe);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool_bool_bool_bool_bool_bool (this.SuperHandle, Selector.GetHandle ("setLoggerLevelsWithVerbose:info:debug:warning:error:severe:"), verbose, info, debug, warning, error, severe);
			}
		}
		
		[Export ("setSurveyModeWithState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSurveyModeWithState (bool state)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSurveyModeWithState:"), state);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setSurveyModeWithState:"), state);
			}
		}
		
		[Export ("startWithApiKey:urlString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartWithApiKey (string apiKey, string urlString)
		{
			if (apiKey == null)
				throw new ArgumentNullException ("apiKey");
			var nsapiKey = NSString.CreateNative (apiKey);
			var nsurlString = NSString.CreateNative (urlString);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("startWithApiKey:urlString:"), nsapiKey, nsurlString);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("startWithApiKey:urlString:"), nsapiKey, nsurlString);
			}
			NSString.ReleaseNative (nsapiKey);
			NSString.ReleaseNative (nsurlString);
			
		}
		
		[Export ("stop")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Stop ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stop"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stop"));
			}
		}
		
		[Export ("triggerBluetoothPermissionPopUp")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TriggerBluetoothPermissionPopUp ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("triggerBluetoothPermissionPopUp"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("triggerBluetoothPermissionPopUp"));
			}
		}
		
		[Export ("triggerMotionPermissionPopUp")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TriggerMotionPermissionPopUp ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("triggerMotionPermissionPopUp"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("triggerMotionPermissionPopUp"));
			}
		}
		
		[Export ("unregisterLocationListener")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnregisterLocationListener ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("unregisterLocationListener"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("unregisterLocationListener"));
			}
		}
		
		[Export ("updateLibraryBasedOnClientStatusWithClientKey:isSilentNotification:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void UpdateLibraryBasedOnClientStatusWithClientKey (string key, bool isSilentNotification, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completion)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			var nskey = NSString.CreateNative (key);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V0.Handler, completion);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_bool_IntPtr (this.Handle, Selector.GetHandle ("updateLibraryBasedOnClientStatusWithClientKey:isSilentNotification:completion:"), nskey, isSilentNotification, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("updateLibraryBasedOnClientStatusWithClientKey:isSilentNotification:completion:"), nskey, isSilentNotification, (IntPtr) block_ptr_completion);
			}
			NSString.ReleaseNative (nskey);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CCLocationDelegate Delegate {
			get {
				return WeakDelegate as CCLocationDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string DeviceId {
			[Export ("getDeviceId")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getDeviceId")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getDeviceId")));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CCLocation SharedInstance {
			[Export ("sharedInstance", ArgumentSemantic.Retain)]
			get {
				CCLocation ret;
				ret =  Runtime.GetNSObject<CCLocation> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedInstance")));
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string TestLibraryIntegration {
			[Export ("testLibraryIntegration")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("testLibraryIntegration")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("testLibraryIntegration")));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class CCLocation */
}
