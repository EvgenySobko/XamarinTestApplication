// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TestApp2.iOS
{
    [Register ("BeerCell")]
    partial class BeerCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView BeerImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel BeerNameLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (BeerImage != null) {
                BeerImage.Dispose ();
                BeerImage = null;
            }

            if (BeerNameLabel != null) {
                BeerNameLabel.Dispose ();
                BeerNameLabel = null;
            }
        }
    }
}