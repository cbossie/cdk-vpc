using Amazon.CDK;

namespace CdkVpc
{
    public class CdkVpcStack : Stack
    {
        public string Cidr {get; set;} = "10.0.0.0/16";
        internal CdkVpcStack(Construct scope, string id, IStackProps props = null) 
        : base(scope, id, props)
        {
            // The code that defines your stack goes here
            var vpc = new CustomVpc(this, $"{id}", Cidr);
        }
    }
}
