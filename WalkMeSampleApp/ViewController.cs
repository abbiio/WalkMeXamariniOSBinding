using System;
using UIKit;
using WalkMeXamariniOSBinding;

namespace WalkMeSampleApp
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            ABBI.SetUserID("my-custom-user-id");
            ABBI.SetUserAttributeWithKey("demo", (Foundation.NSNumber)1);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            ABBI.Start("ebbc472f-f33f-4ff3-88a1-78acbf18c514", "Z0VIa2cwMTZSV1dPU1VNT1FJZ3hhT3ArdEh6YzBPZ2lqQk9IaFB5VjdEd0Y2MzBjbXdLQktBL1ZkekpnUDNUY29B");
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
