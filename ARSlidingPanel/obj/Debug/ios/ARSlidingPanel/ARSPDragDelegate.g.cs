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
	[Protocol (Name = "ARSPDragDelegate", WrapperType = typeof (ARSPDragDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PanelControllerWasDragged", Selector = "panelControllerWasDragged:", ParameterType = new Type [] { typeof (nfloat) }, ParameterByRef = new bool [] { false })]
	public interface IARSPDragDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("panelControllerWasDragged:")]
		[Preserve (Conditional = true)]
		void PanelControllerWasDragged (global::System.nfloat panelControllerVisibility);
		
	}
	
	internal sealed class ARSPDragDelegateWrapper : BaseWrapper, IARSPDragDelegate {
		public ARSPDragDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public ARSPDragDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("panelControllerWasDragged:")]
		[CompilerGenerated]
		public void PanelControllerWasDragged (global::System.nfloat panelControllerVisibility)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("panelControllerWasDragged:"), panelControllerVisibility);
		}
		
	}
}
namespace ARSlidingPanel {
	[Protocol]
	[Register("ARSPDragDelegate", false)]
	[Model]
	public unsafe abstract partial class ARSPDragDelegate : NSObject, IARSPDragDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected ARSPDragDelegate () : base (NSObjectFlag.Empty)
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
		protected ARSPDragDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ARSPDragDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("panelControllerWasDragged:")]
		[CompilerGenerated]
		public abstract void PanelControllerWasDragged (global::System.nfloat panelControllerVisibility);
	} /* class ARSPDragDelegate */
}
