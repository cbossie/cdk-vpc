using Amazon.CDK;
using Amazon.CDK.AWS.EC2;

namespace CdkVpc 
{
    public class CustomVpc : Construct
    {
        public Vpc Vpc {get;}
        public CustomVpc(Construct scope, string id, string cidr) 
        : base(scope, id)
        {
            SubnetConfiguration privateSubnetConfig = new SubnetConfiguration
            {
                CidrMask = 26,
                SubnetType = SubnetType.PRIVATE,
                Name = "privateSubnet"

            };

            SubnetConfiguration publicSubnetConfig = new SubnetConfiguration
            {
                CidrMask = 26,
                SubnetType = SubnetType.PUBLIC,
                Name = "publicSubnet"

            };

            VpcProps props = new VpcProps
            {
                Cidr = cidr,
                DefaultInstanceTenancy = DefaultInstanceTenancy.DEFAULT,
                MaxAzs = 99,
                SubnetConfiguration = new ISubnetConfiguration[]{
                    privateSubnetConfig,
                    publicSubnetConfig
                },
                NatGateways = 1,
                EnableDnsHostnames = true,
                EnableDnsSupport = true
            };
            var vpc = new Vpc(this, id + $"{id}-vpc", props);

            this.Vpc = vpc;
        }
    }
}