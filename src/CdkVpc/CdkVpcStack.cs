using Amazon.CDK;

namespace CdkVpc
{
    public class CdkVpcStack : Stack
    {
        internal CdkVpcStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            // The code that defines your stack goes here
            var vpc = new CustomVpc(this, "myVpc", "10.0.0.0/16");
        }
    }
}
