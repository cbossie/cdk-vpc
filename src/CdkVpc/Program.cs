using Amazon.CDK;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CdkVpc
{
    sealed class Program
    {
        public static void Main(string[] args)
        {

            var stackName = "CdkVpcStack";
            var account = "014168299099";
            var region = "us-east-2";

            var app = new App();
            var env = new Amazon.CDK.Environment
            {
                Region = region,
                Account = account
            };

            new CdkVpcStack(app, stackName , new StackProps
            {
                Env = env,
            })
            {
                Cidr = "10.0.0.0/16"
            };
            app.Synth();
        }
    }
}
