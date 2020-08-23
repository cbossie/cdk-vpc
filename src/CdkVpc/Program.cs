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
            new CdkVpcStack(app, "CdkVpcStack");
            app.Synth();
        }
    }
}
