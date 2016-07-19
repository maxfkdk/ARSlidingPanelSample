using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace ARSlidingPanel
{
	// @protocol ARSPDragDelegate
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface ARSPDragDelegate
	{
		// @required -(void)panelControllerWasDragged:(CGFloat)panelControllerVisibility;
		[Abstract]
		[Export("panelControllerWasDragged:")]
		void PanelControllerWasDragged(nfloat panelControllerVisibility);
	}

	// @protocol ARSPVisibilityStateDelegate
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface ARSPVisibilityStateDelegate
	{
		// @required -(void)panelControllerChangedVisibilityState:(ARSPVisibilityState)state;
		[Abstract]
		[Export("panelControllerChangedVisibilityState:")]
		void PanelControllerChangedVisibilityState(ARSPVisibilityState state);
	}

	// @interface ARSPContainerController : UIViewController
	[BaseType(typeof(UIViewController))]
	interface ARSPContainerController
	{
		// @property (nonatomic, strong) UIViewController * mainViewController;
		[Export("mainViewController", ArgumentSemantic.Strong)]
		UIViewController MainViewController { get; set; }

		// @property (nonatomic, strong) UIViewController * panelViewController;
		[Export("panelViewController", ArgumentSemantic.Strong)]
		UIViewController PanelViewController { get; set; }

		[Wrap("WeakDragDelegate")]
		ARSPDragDelegate DragDelegate { get; set; }

		// @property (nonatomic, weak) id<ARSPDragDelegate> dragDelegate;
		[NullAllowed, Export("dragDelegate", ArgumentSemantic.Weak)]
		NSObject WeakDragDelegate { get; set; }

		[Wrap("WeakVisibilityStateDelegate")]
		ARSPVisibilityStateDelegate VisibilityStateDelegate { get; set; }

		// @property (nonatomic, weak) id<ARSPVisibilityStateDelegate> visibilityStateDelegate;
		[NullAllowed, Export("visibilityStateDelegate", ArgumentSemantic.Weak)]
		NSObject WeakVisibilityStateDelegate { get; set; }

		// @property (readonly, nonatomic) ARSPVisibilityState visibilityState;
		[Export("visibilityState")]
		ARSPVisibilityState VisibilityState { get; }

		// @property (nonatomic) CGFloat visibleZoneHeight;
		[Export("visibleZoneHeight")]
		nfloat VisibleZoneHeight { get; set; }

		// @property (nonatomic) CGFloat swipableZoneHeight;
		[Export("swipableZoneHeight")]
		nfloat SwipableZoneHeight { get; set; }

		// @property (nonatomic) CGFloat maxPanelHeight;
		[Export("maxPanelHeight")]
		nfloat MaxPanelHeight { get; set; }

		// @property (nonatomic) BOOL dropShadow;
		[Export("dropShadow")]
		bool DropShadow { get; set; }

		// @property (nonatomic) CGFloat shadowRadius;
		[Export("shadowRadius")]
		nfloat ShadowRadius { get; set; }

		// @property (nonatomic) CGFloat shadowOpacity;
		[Export("shadowOpacity")]
		nfloat ShadowOpacity { get; set; }

		// @property (nonatomic) BOOL shouldOverlapMainViewController;
		[Export("shouldOverlapMainViewController")]
		bool ShouldOverlapMainViewController { get; set; }

		// @property (nonatomic) BOOL shouldShiftMainViewController;
		[Export("shouldShiftMainViewController")]
		bool ShouldShiftMainViewController { get; set; }

		// @property (nonatomic) CGFloat animationDuration;
		[Export("animationDuration")]
		nfloat AnimationDuration { get; set; }

		// @property (nonatomic) BOOL draggingEnabled;
		[Export("draggingEnabled")]
		bool DraggingEnabled { get; set; }

		// +(ARSPContainerController *)getController;
		[Static]
		[Export("getController")]
		ARSPContainerController Controller { get; }

		// -(void)maximizePanelControllerAnimated:(BOOL)animated completion:(void (^)(void))completion;
		[Export("maximizePanelControllerAnimated:completion:")]
		void MaximizePanelControllerAnimated(bool animated, Action completion);

		// -(void)minimizePanelControllerAnimated:(BOOL)animated completion:(void (^)(void))completion;
		[Export("minimizePanelControllerAnimated:completion:")]
		void MinimizePanelControllerAnimated(bool animated, Action completion);

		// -(void)closePanelControllerAnimated:(BOOL)animated completion:(void (^)(void))completion;
		[Export("closePanelControllerAnimated:completion:")]
		void ClosePanelControllerAnimated(bool animated, Action completion);

		// -(void)maximizePanelControllerAnimated:(BOOL)animated animations:(void (^)(void))animations completion:(void (^)(void))completion;
		[Export("maximizePanelControllerAnimated:animations:completion:")]
		void MaximizePanelControllerAnimated(bool animated, Action animations, Action completion);

		// -(void)minimizePanelControllerAnimated:(BOOL)animated animations:(void (^)(void))animations completion:(void (^)(void))completion;
		[Export("minimizePanelControllerAnimated:animations:completion:")]
		void MinimizePanelControllerAnimated(bool animated, Action animations, Action completion);

		// -(void)closePanelControllerAnimated:(BOOL)animated animations:(void (^)(void))animations completion:(void (^)(void))completion;
		[Export("closePanelControllerAnimated:animations:completion:")]
		void ClosePanelControllerAnimated(bool animated, Action animations, Action completion);
	}

	// @interface ARSPMainViewControllerSegue : UIStoryboardSegue
	[BaseType(typeof(UIStoryboardSegue))]
	interface ARSPMainViewControllerSegue
	{
	}

	// @interface ARSPPanelViewControllerSegue : UIStoryboardSegue
	[BaseType(typeof(UIStoryboardSegue))]
	interface ARSPPanelViewControllerSegue
	{
	}

	//[Static]
	//partial interface Constants
	//{
	//	// extern double ARSlidingPanelVersionNumber;
	//	[Field("ARSlidingPanelVersionNumber", "__Internal")]
	//	double ARSlidingPanelVersionNumber { get; }

	//	// extern const unsigned char [] ARSlidingPanelVersionString;
	//	[Field("ARSlidingPanelVersionString", "__Internal")]
	//	NSString ARSlidingPanelVersionString { get; }
	//}

}

