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
	[Register("_TtC10CCLocation16LocationResponse", true)]
	public unsafe partial class LocationResponse : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("_TtC10CCLocation16LocationResponse");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected LocationResponse (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal LocationResponse (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("new")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static LocationResponse New ()
		{
			return  Runtime.GetNSObject<LocationResponse> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("new")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double Error {
			[Export ("error")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("error"));
				} else {
					return global::ApiDefinitions.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("error"));
				}
			}
			
			[Export ("setError:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setError:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setError:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ulong Floor {
			[Export ("floor")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("floor"));
				} else {
					return global::ApiDefinitions.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("floor"));
				}
			}
			
			[Export ("setFloor:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setFloor:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setFloor:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double HeadingOffSet {
			[Export ("headingOffSet")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("headingOffSet"));
				} else {
					return global::ApiDefinitions.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("headingOffSet"));
				}
			}
			
			[Export ("setHeadingOffSet:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setHeadingOffSet:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setHeadingOffSet:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double Latitude {
			[Export ("latitude")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("latitude"));
				} else {
					return global::ApiDefinitions.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("latitude"));
				}
			}
			
			[Export ("setLatitude:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setLatitude:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setLatitude:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double Longitude {
			[Export ("longitude")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("longitude"));
				} else {
					return global::ApiDefinitions.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("longitude"));
				}
			}
			
			[Export ("setLongitude:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setLongitude:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setLongitude:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ulong Timestamp {
			[Export ("timestamp")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("timestamp"));
				} else {
					return global::ApiDefinitions.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("timestamp"));
				}
			}
			
			[Export ("setTimestamp:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setTimestamp:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setTimestamp:"), value);
				}
			}
		}
		
	} /* class LocationResponse */
}
