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
            var app = new App();
            var env = new Amazon.CDK.Environment
            {
                Region = "eu-west-3",
                Account = "014168299099"
            };

            new CdkVpcStack(app, "CdkVpcStack", new StackProps
            {
                Env = env
            });
            app.Synth();
        }
    }
}
