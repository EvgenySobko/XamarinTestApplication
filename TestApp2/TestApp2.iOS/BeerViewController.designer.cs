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
    [Register ("BeerViewController")]
    partial class BeerViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView MyTable { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (MyTable != null) {
                MyTable.Dispose ();
                MyTable = null;
            }
        }
    }
}