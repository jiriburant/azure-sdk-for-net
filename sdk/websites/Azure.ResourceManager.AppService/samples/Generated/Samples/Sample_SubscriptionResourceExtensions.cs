// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_SubscriptionResourceExtensions
    {
        // List ResourceHealthMetadata for a subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAllResourceHealthMetadata_ListResourceHealthMetadataForASubscription()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/ListResourceHealthMetadataBySubscription.json
            // this example is just showing the usage of "ResourceHealthMetadata_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "4adb32ad-8327-4cbb-b775-b84b4465bb38";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (ResourceHealthMetadataData item in subscriptionResource.GetAllResourceHealthMetadataAsync())
            {
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {item.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // VerifyHostingEnvironmentVnet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task VerifyHostingEnvironmentVnet_VerifyHostingEnvironmentVnet()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/VerifyHostingEnvironmentVnet.json
            // this example is just showing the usage of "VerifyHostingEnvironmentVnet" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AppServiceVirtualNetworkValidationContent content = new AppServiceVirtualNetworkValidationContent()
            {
                VnetResourceGroup = "vNet123rg",
                VnetName = "vNet123",
                VnetSubnetName = "vNet123SubNet",
            };
            VirtualNetworkValidationFailureDetails result = await subscriptionResource.VerifyHostingEnvironmentVnetAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Generates a preview workflow file for the static site
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task PreviewStaticSiteWorkflow_GeneratesAPreviewWorkflowFileForTheStaticSite()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/GenerateStaticSiteWorkflowPreview.json
            // this example is just showing the usage of "StaticSites_PreviewWorkflow" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("West US 2");
            StaticSitesWorkflowPreviewContent content = new StaticSitesWorkflowPreviewContent()
            {
                RepositoryUri = new Uri("https://github.com/username/RepoName"),
                Branch = "master",
                BuildProperties = new StaticSiteBuildProperties()
                {
                    AppLocation = "app",
                    ApiLocation = "api",
                    AppArtifactLocation = "build",
                },
            };
            StaticSitesWorkflowPreview result = await subscriptionResource.PreviewStaticSiteWorkflowAsync(location, content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
