using System;
using UIKit;

namespace TextFieldTest
{
    class CustomTextField : UITextField
    {
        public CustomTextField(CoreGraphics.CGRect frame)
            : base(frame)
        {
            BorderStyle = UITextBorderStyle.RoundedRect;
            EditingChanged += CustomTextField_EditingChanged;   
        }

        private void CustomTextField_EditingChanged(object sender, EventArgs e)
        {
            new UIAlertView("Text Changed", $"New text is {Text}", null, "Cancel").Show();
        }
    }
}
