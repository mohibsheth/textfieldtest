using System;

using UIKit;

namespace TextFieldTest
{
    public partial class HomeViewController : UIViewController
    {
        public HomeViewController() : base("HomeViewController", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var customField = new CustomTextField(new CoreGraphics.CGRect(10, 10, 300, 40));
            View.Add(customField);

            // Perform any additional setup after loading the view, typically from a nib.
        }
    }
}