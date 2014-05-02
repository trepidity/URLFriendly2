//
// DragDelegate.cs
//
// Author:
//       Jared L Jennings <jared@jaredjennings.org>
//
// Copyright (c) 2014 Jared L Jennings
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using MonoMac.AppKit;

namespace URLFriendly2
{
	public class DragDelegate: NSDraggingDestination
	{
		public override NSDragOperation DraggingEntered (NSDraggingInfo sender)
		{
			Console.WriteLine ("DraggingEntered");
			return DraggingUpdated (sender);
		}

		public override NSDragOperation DraggingUpdated (NSDraggingInfo sender)
		{
			throw new System.NotImplementedException ();
		}

		public override bool PerformDragOperation (NSDraggingInfo sender)
		{
			throw new System.NotImplementedException ();
		}

		public override bool PrepareForDragOperation (NSDraggingInfo sender)
		{
			throw new System.NotImplementedException ();
		}

		public override void ConcludeDragOperation (NSDraggingInfo sender)
		{
			throw new System.NotImplementedException ();
		}

		public override void DraggingEnded (NSDraggingInfo sender)
		{
			throw new System.NotImplementedException ();
		}

		public override bool WantsPeriodicDraggingUpdates {
			get {
				return base.WantsPeriodicDraggingUpdates;
			}
		}
	}
}

