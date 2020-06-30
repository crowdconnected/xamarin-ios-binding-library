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
	[Register("CCLocationDelegate", false)]
	[Model]
	public unsafe abstract partial class CCLocationDelegate : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CCLocationDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CCLocationDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CCLocationDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("ccLocationDidConnect")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void CcLocationDidConnect ();
		[Export ("ccLocationDidFailWithErrorWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void CcLocationDidFailWithErrorWithError (NSError error);
		[Export ("didReceiveCCLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void DidReceiveCCLocation (LocationResponse location);
	} /* class CCLocationDelegate */
}
