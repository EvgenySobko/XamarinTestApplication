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
    [Register ("DescriptionViewController")]
    partial class DescriptionViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        TestApp2.iOS.LargeImageView BeerImageLarge { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        TestApp2.iOS.DescriptionViewController Description { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (BeerImageLarge != null) {
                BeerImageLarge.Dispose ();
                BeerImageLarge = null;
            }

            if (Description != null) {
                Description.Dispose ();
                Description = null;
            }
        }
    }
}