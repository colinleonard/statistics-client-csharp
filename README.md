# Genesys.Statistics - the C# library for the Statistics Service API

Statistics API

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 9.0.000.00.333
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Genesys.Statistics.Api;
using Genesys.Statistics.Client;
using Genesys.Statistics.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Genesys.Statistics.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Genesys.Statistics.Api;
using Genesys.Statistics.Client;
using Genesys.Statistics.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            var apiInstance = new StatisticsApi();
            var statistics = statistics_example;  // string | definitions for statistics which are to be opened with stat server

            try
            {
                // Opens the stat server subscription for the specified set of statistics
                ApiResponse result = apiInstance.CreateSubscription(statistics);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatisticsApi.CreateSubscription: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*StatisticsApi* | [**CreateSubscription**](docs/StatisticsApi.md#createsubscription) | **POST** /statistics/v3/subscriptions | Opens the stat server subscription for the specified set of statistics
*StatisticsApi* | [**DeleteSubscription**](docs/StatisticsApi.md#deletesubscription) | **DELETE** /statistics/v3/subscriptions/{id} | Deletes the specified stat server subscription
*StatisticsApi* | [**GetStatValue**](docs/StatisticsApi.md#getstatvalue) | **GET** /statistics/v3/statistic-values/{statisticName} | Peeks the value of specified statistic
*StatisticsApi* | [**GetStatValues**](docs/StatisticsApi.md#getstatvalues) | **POST** /statistics/v3/operations/get-statistic-ex | Peeks the values of specified statistics
*StatisticsApi* | [**PeekSubscriptionStats**](docs/StatisticsApi.md#peeksubscriptionstats) | **GET** /statistics/v3/subscriptions/{id}/statistic-values | Peeks the values of statistics opened inside the specified subscription


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.ApiResponse](docs/ApiResponse.md)
 - [Model.ApiResponseStatus](docs/ApiResponseStatus.md)
 - [Model.PeekedStatisticValue](docs/PeekedStatisticValue.md)
 - [Model.StatisticValue](docs/StatisticValue.md)
 - [Model.StatisticsData](docs/StatisticsData.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.
