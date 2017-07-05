using System;

using UIKit;

namespace DivisasNative.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }

        partial void ButtonConvert_TouchUpInside(UIButton sender)
        {
            if (string.IsNullOrEmpty(textFieldPesos.Text))
            {
                var alert = new UIAlertView(
                    "Error",
                    "Debes ingresar un valor en pesos",
                    null,
                    "Aceptar",
                    null);
                alert.Show();
                return;
            }

			var pesos = decimal.Parse(textFieldPesos.Text);
			var exchange = Converter.Convert(pesos);
			textFieldDollars.Text = string.Format("${0:N2}", exchange.Dollars);
			textFieldEuros.Text = string.Format("€{0:N2}", exchange.Euros);
			textFieldPounds.Text = string.Format("£{0:N2}", exchange.Pounds);
		}
    }
}
