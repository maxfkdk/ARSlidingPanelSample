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
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using Security;
using SceneKit;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace ARSlidingPanel {
	[Register("ARSPContainerController", true)]
	public unsafe partial class ARSPContainerController : global::UIKit.UIViewController {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("ARSPContainerController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ARSPContainerController () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public ARSPContainerController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ARSPContainerController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ARSPContainerController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("closePanelControllerAnimated:completion:")]
		[CompilerGenerated]
		public unsafe virtual void ClosePanelControllerAnimated (bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, Selector.GetHandle ("closePanelControllerAnimated:completion:"), animated, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("closePanelControllerAnimated:completion:"), animated, (IntPtr) block_ptr_completion);
			}
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("closePanelControllerAnimated:animations:completion:")]
		[CompilerGenerated]
		public unsafe virtual void ClosePanelControllerAnimated (bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animations, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (animations == null)
				throw new ArgumentNullException ("animations");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_animations;
			BlockLiteral block_animations;
			block_animations = new BlockLiteral ();
			block_ptr_animations = &block_animations;
			block_animations.SetupBlock (Trampolines.SDAction.Handler, animations);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("closePanelControllerAnimated:animations:completion:"), animated, (IntPtr) block_ptr_animations, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("closePanelControllerAnimated:animations:completion:"), animated, (IntPtr) block_ptr_animations, (IntPtr) block_ptr_completion);
			}
			block_ptr_animations->CleanupBlock ();
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("maximizePanelControllerAnimated:completion:")]
		[CompilerGenerated]
		public unsafe virtual void MaximizePanelControllerAnimated (bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, Selector.GetHandle ("maximizePanelControllerAnimated:completion:"), animated, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("maximizePanelControllerAnimated:completion:"), animated, (IntPtr) block_ptr_completion);
			}
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("maximizePanelControllerAnimated:animations:completion:")]
		[CompilerGenerated]
		public unsafe virtual void MaximizePanelControllerAnimated (bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animations, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (animations == null)
				throw new ArgumentNullException ("animations");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_animations;
			BlockLiteral block_animations;
			block_animations = new BlockLiteral ();
			block_ptr_animations = &block_animations;
			block_animations.SetupBlock (Trampolines.SDAction.Handler, animations);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("maximizePanelControllerAnimated:animations:completion:"), animated, (IntPtr) block_ptr_animations, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("maximizePanelControllerAnimated:animations:completion:"), animated, (IntPtr) block_ptr_animations, (IntPtr) block_ptr_completion);
			}
			block_ptr_animations->CleanupBlock ();
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("minimizePanelControllerAnimated:completion:")]
		[CompilerGenerated]
		public unsafe virtual void MinimizePanelControllerAnimated (bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, Selector.GetHandle ("minimizePanelControllerAnimated:completion:"), animated, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("minimizePanelControllerAnimated:completion:"), animated, (IntPtr) block_ptr_completion);
			}
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("minimizePanelControllerAnimated:animations:completion:")]
		[CompilerGenerated]
		public unsafe virtual void MinimizePanelControllerAnimated (bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animations, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (animations == null)
				throw new ArgumentNullException ("animations");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_animations;
			BlockLiteral block_animations;
			block_animations = new BlockLiteral ();
			block_ptr_animations = &block_animations;
			block_animations.SetupBlock (Trampolines.SDAction.Handler, animations);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("minimizePanelControllerAnimated:animations:completion:"), animated, (IntPtr) block_ptr_animations, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("minimizePanelControllerAnimated:animations:completion:"), animated, (IntPtr) block_ptr_animations, (IntPtr) block_ptr_completion);
			}
			block_ptr_animations->CleanupBlock ();
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat AnimationDuration {
			[Export ("animationDuration")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("animationDuration"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("animationDuration"));
				}
			}
			
			[Export ("setAnimationDuration:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setAnimationDuration:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setAnimationDuration:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public static ARSPContainerController Controller {
			[Export ("getController")]
			get {
				ARSPContainerController ret;
				ret =  Runtime.GetNSObject<ARSPContainerController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getController")));
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public ARSPDragDelegate DragDelegate {
			get {
				return WeakDragDelegate as /**/ARSPDragDelegate;
			}
			set {
				WeakDragDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool DraggingEnabled {
			[Export ("draggingEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("draggingEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("draggingEnabled"));
				}
			}
			
			[Export ("setDraggingEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDraggingEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDraggingEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool DropShadow {
			[Export ("dropShadow")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("dropShadow"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dropShadow"));
				}
			}
			
			[Export ("setDropShadow:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDropShadow:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDropShadow:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIViewController MainViewController {
			[Export ("mainViewController", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("mainViewController")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mainViewController")));
				}
				return ret;
			}
			
			[Export ("setMainViewController:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMainViewController:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMainViewController:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat MaxPanelHeight {
			[Export ("maxPanelHeight")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("maxPanelHeight"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maxPanelHeight"));
				}
			}
			
			[Export ("setMaxPanelHeight:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setMaxPanelHeight:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setMaxPanelHeight:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIViewController PanelViewController {
			[Export ("panelViewController", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("panelViewController")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("panelViewController")));
				}
				return ret;
			}
			
			[Export ("setPanelViewController:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPanelViewController:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPanelViewController:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat ShadowOpacity {
			[Export ("shadowOpacity")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("shadowOpacity"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shadowOpacity"));
				}
			}
			
			[Export ("setShadowOpacity:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setShadowOpacity:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setShadowOpacity:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat ShadowRadius {
			[Export ("shadowRadius")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("shadowRadius"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shadowRadius"));
				}
			}
			
			[Export ("setShadowRadius:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setShadowRadius:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setShadowRadius:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldOverlapMainViewController {
			[Export ("shouldOverlapMainViewController")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldOverlapMainViewController"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldOverlapMainViewController"));
				}
			}
			
			[Export ("setShouldOverlapMainViewController:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldOverlapMainViewController:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShouldOverlapMainViewController:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldShiftMainViewController {
			[Export ("shouldShiftMainViewController")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldShiftMainViewController"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldShiftMainViewController"));
				}
			}
			
			[Export ("setShouldShiftMainViewController:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldShiftMainViewController:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShouldShiftMainViewController:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat SwipableZoneHeight {
			[Export ("swipableZoneHeight")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("swipableZoneHeight"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("swipableZoneHeight"));
				}
			}
			
			[Export ("setSwipableZoneHeight:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setSwipableZoneHeight:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setSwipableZoneHeight:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual ARSPVisibilityState VisibilityState {
			[Export ("visibilityState")]
			get {
				if (IsDirectBinding) {
					return (ARSPVisibilityState) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("visibilityState"));
				} else {
					return (ARSPVisibilityState) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("visibilityState"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public ARSPVisibilityStateDelegate VisibilityStateDelegate {
			get {
				return WeakVisibilityStateDelegate as /**/ARSPVisibilityStateDelegate;
			}
			set {
				WeakVisibilityStateDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat VisibleZoneHeight {
			[Export ("visibleZoneHeight")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("visibleZoneHeight"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("visibleZoneHeight"));
				}
			}
			
			[Export ("setVisibleZoneHeight:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setVisibleZoneHeight:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setVisibleZoneHeight:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDragDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDragDelegate {
			[Export ("dragDelegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dragDelegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dragDelegate")));
				}
				MarkDirty ();
				__mt_WeakDragDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDragDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDragDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDragDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDragDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakVisibilityStateDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakVisibilityStateDelegate {
			[Export ("visibilityStateDelegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("visibilityStateDelegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("visibilityStateDelegate")));
				}
				MarkDirty ();
				__mt_WeakVisibilityStateDelegate_var = ret;
				return ret;
			}
			
			[Export ("setVisibilityStateDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setVisibilityStateDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setVisibilityStateDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakVisibilityStateDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDragDelegate_var = null;
				__mt_WeakVisibilityStateDelegate_var = null;
			}
		}
	} /* class ARSPContainerController */
}
