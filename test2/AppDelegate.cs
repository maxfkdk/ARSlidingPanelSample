using ARSlidingPanel;
using CoreGraphics;
using Foundation;
using UIKit;

namespace test2
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations

		public override UIWindow Window
		{
			get;
			set;
		}

		public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
		{
			// Override point for customization after application launch.
			// If not required for your application you can safely delete this method





				this.Window.RootViewController = new UINavigationController();
				var fistController = new UIViewController();
				fistController.View.BackgroundColor = UIColor.White;
				(this.Window.RootViewController as UINavigationController).PushViewController(fistController, false);
				var button = new UIButton(new CGRect(20, 84, 100, 20));
				button.BackgroundColor = UIColor.Red;
				button.SetTitle("HELLO",UIControlState.Normal);
				button.TintColor = UIColor.White;
				button.TouchUpInside+= (sender, e) => {
					var containerController = ARSPContainerController.Controller;
					containerController.MainViewController = new UIViewController();
					containerController.MainViewController.View.BackgroundColor = UIColor.Blue;

					containerController.PanelViewController = new UIViewController();
					containerController.PanelViewController.View.BackgroundColor = UIColor.Yellow;

					containerController.VisibleZoneHeight = 80;
					containerController.SwipableZoneHeight = 130;
					containerController.DraggingEnabled = true;
					containerController.ShouldOverlapMainViewController = false;
					containerController.ShouldShiftMainViewController = false;
					(this.Window.RootViewController as UINavigationController).PushViewController(containerController, true);
				};
				(this.Window.RootViewController as UINavigationController).TopViewController.View.AddSubview(button);


			return true;
		}

		public override void OnResignActivation(UIApplication application)
		{
			// Invoked when the application is about to move from active to inactive state.
			// This can occur for certain types of temporary interruptions (such as an incoming phone call or SMS message) 
			// or when the user quits the application and it begins the transition to the background state.
			// Games should use this method to pause the game.
		}

		public override void DidEnterBackground(UIApplication application)
		{
			// Use this method to release shared resources, save user data, invalidate timers and store the application state.
			// If your application supports background exection this method is called instead of WillTerminate when the user quits.
		}

		public override void WillEnterForeground(UIApplication application)
		{
			// Called as part of the transiton from background to active state.
			// Here you can undo many of the changes made on entering the background.
		}

		public override void OnActivated(UIApplication application)
		{
			// Restart any tasks that were paused (or not yet started) while the application was inactive. 
			// If the application was previously in the background, optionally refresh the user interface.
		}

		public override void WillTerminate(UIApplication application)
		{
			// Called when the application is about to terminate. Save data, if needed. See also DidEnterBackground.
		}
	}
}


