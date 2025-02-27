// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Media;
using Azure.ResourceManager.Media.Models;

namespace Azure.ResourceManager.Media.Samples
{
    public partial class Sample_StreamingLocatorCollection
    {
        // Lists Streaming Locators
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListsStreamingLocators()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/streaming-locators-list.json
            // this example is just showing the usage of "StreamingLocators_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this StreamingLocatorResource
            StreamingLocatorCollection collection = mediaServicesAccount.GetStreamingLocators();

            // invoke the operation and iterate over the result
            await foreach (StreamingLocatorResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StreamingLocatorData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get a Streaming Locator by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAStreamingLocatorByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/streaming-locators-get-by-name.json
            // this example is just showing the usage of "StreamingLocators_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this StreamingLocatorResource
            StreamingLocatorCollection collection = mediaServicesAccount.GetStreamingLocators();

            // invoke the operation
            string streamingLocatorName = "clearStreamingLocator";
            StreamingLocatorResource result = await collection.GetAsync(streamingLocatorName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingLocatorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a Streaming Locator by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAStreamingLocatorByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/streaming-locators-get-by-name.json
            // this example is just showing the usage of "StreamingLocators_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this StreamingLocatorResource
            StreamingLocatorCollection collection = mediaServicesAccount.GetStreamingLocators();

            // invoke the operation
            string streamingLocatorName = "clearStreamingLocator";
            bool result = await collection.ExistsAsync(streamingLocatorName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a Streaming Locator by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAStreamingLocatorByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/streaming-locators-get-by-name.json
            // this example is just showing the usage of "StreamingLocators_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this StreamingLocatorResource
            StreamingLocatorCollection collection = mediaServicesAccount.GetStreamingLocators();

            // invoke the operation
            string streamingLocatorName = "clearStreamingLocator";
            NullableResponse<StreamingLocatorResource> response = await collection.GetIfExistsAsync(streamingLocatorName);
            StreamingLocatorResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StreamingLocatorData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Creates a Streaming Locator with clear streaming
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreatesAStreamingLocatorWithClearStreaming()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/streaming-locators-create-clear.json
            // this example is just showing the usage of "StreamingLocators_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this StreamingLocatorResource
            StreamingLocatorCollection collection = mediaServicesAccount.GetStreamingLocators();

            // invoke the operation
            string streamingLocatorName = "UserCreatedClearStreamingLocator";
            StreamingLocatorData data = new StreamingLocatorData()
            {
                AssetName = "ClimbingMountRainier",
                StreamingPolicyName = "clearStreamingPolicy",
            };
            ArmOperation<StreamingLocatorResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, streamingLocatorName, data);
            StreamingLocatorResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingLocatorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Creates a Streaming Locator with secure streaming
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreatesAStreamingLocatorWithSecureStreaming()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/streaming-locators-create-secure.json
            // this example is just showing the usage of "StreamingLocators_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this StreamingLocatorResource
            StreamingLocatorCollection collection = mediaServicesAccount.GetStreamingLocators();

            // invoke the operation
            string streamingLocatorName = "UserCreatedSecureStreamingLocator";
            StreamingLocatorData data = new StreamingLocatorData()
            {
                AssetName = "ClimbingMountRainier",
                StartOn = DateTimeOffset.Parse("2018-03-01T00:00:00Z"),
                EndOn = DateTimeOffset.Parse("2028-12-31T23:59:59.9999999Z"),
                StreamingPolicyName = "UserCreatedSecureStreamingPolicy",
            };
            ArmOperation<StreamingLocatorResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, streamingLocatorName, data);
            StreamingLocatorResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingLocatorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Creates a Streaming Locator with user defined content keys
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreatesAStreamingLocatorWithUserDefinedContentKeys()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/streaming-locators-create-secure-userDefinedContentKeys.json
            // this example is just showing the usage of "StreamingLocators_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this StreamingLocatorResource
            StreamingLocatorCollection collection = mediaServicesAccount.GetStreamingLocators();

            // invoke the operation
            string streamingLocatorName = "UserCreatedSecureStreamingLocatorWithUserDefinedContentKeys";
            StreamingLocatorData data = new StreamingLocatorData()
            {
                AssetName = "ClimbingMountRainier",
                StreamingLocatorId = Guid.Parse("90000000-0000-0000-0000-00000000000A"),
                StreamingPolicyName = "secureStreamingPolicy",
                ContentKeys =
{
new StreamingLocatorContentKey(Guid.Parse("60000000-0000-0000-0000-000000000001"))
{
LabelReferenceInStreamingPolicy = "aesDefaultKey",
Value = "1UqLohAfWsEGkULYxHjYZg==",
},new StreamingLocatorContentKey(Guid.Parse("60000000-0000-0000-0000-000000000004"))
{
LabelReferenceInStreamingPolicy = "cencDefaultKey",
Value = "4UqLohAfWsEGkULYxHjYZg==",
},new StreamingLocatorContentKey(Guid.Parse("60000000-0000-0000-0000-000000000007"))
{
LabelReferenceInStreamingPolicy = "cbcsDefaultKey",
Value = "7UqLohAfWsEGkULYxHjYZg==",
}
},
            };
            ArmOperation<StreamingLocatorResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, streamingLocatorName, data);
            StreamingLocatorResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingLocatorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
