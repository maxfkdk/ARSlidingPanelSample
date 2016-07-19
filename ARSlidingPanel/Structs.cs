using System;

namespace ARSlidingPanel
{
	public enum ARSPVisibilityState : uint
	{
		Closed = 0,
		Minimized,
		IsMaximizing,
		IsMinimizing,
		IsClosing,
		IsDragging,
		Maximized
	}
}

