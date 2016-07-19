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
	[Protocol (Name = "ARSPVisibilityStateDelegate", WrapperType = typeof (ARSPVisibilityStateDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PanelControllerChangedVisibilityState", Selector = "panelControllerChangedVisibilityState:", ParameterType = new Type [] { typeof (ARSlidingPanel.ARSPVisibilityState) }, ParameterByRef = new bool [] { false })]
	public interface IARSPVisibilityStateDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("panelControllerChangedVisibilityState:")]
		[Preserve (Conditional = true)]
		void PanelControllerChangedVisibilityState (ARSPVisibilityState state);
		
	}
	
	internal sealed class ARSPVisibilityStateDelegateWrapper : BaseWrapper, IARSPVisibilityStateDelegate {
		public ARSPVisibilityStateDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public ARSPVisibilityStateDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("panelControllerChangedVisibilityState:")]
		[CompilerGenerated]
		public void PanelControllerChangedVisibilityState (ARSPVisibilityState state)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("panelControllerChangedVisibilityState:"), (UInt32)state);
		}
		
	}
}
namespace ARSlidingPanel {
	[Protocol]
	[Register("ARSPVisibilityStateDelegate", false)]
	[Model]
	public unsafe abstract partial class ARSPVisibilityStateDelegate : NSObject, IARSPVisibilityStateDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected ARSPVisibilityStateDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ARSPVisibilityStateDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ARSPVisibilityStateDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("panelControllerChangedVisibilityState:")]
		[CompilerGenerated]
		public abstract void PanelControllerChangedVisibilityState (ARSPVisibilityState state);
	} /* class ARSPVisibilityStateDelegate */
}
