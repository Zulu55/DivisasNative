// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace DivisasNative.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIButton Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonConvert { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textFieldDollars { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textFieldEuros { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textFieldPesos { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textFieldPounds { get; set; }

        [Action ("ButtonConvert_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ButtonConvert_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (buttonConvert != null) {
                buttonConvert.Dispose ();
                buttonConvert = null;
            }

            if (textFieldDollars != null) {
                textFieldDollars.Dispose ();
                textFieldDollars = null;
            }

            if (textFieldEuros != null) {
                textFieldEuros.Dispose ();
                textFieldEuros = null;
            }

            if (textFieldPesos != null) {
                textFieldPesos.Dispose ();
                textFieldPesos = null;
            }

            if (textFieldPounds != null) {
                textFieldPounds.Dispose ();
                textFieldPounds = null;
            }
        }
    }
}