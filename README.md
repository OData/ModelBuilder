OData Model Builder
 ============= 
 Component | Build  | Status 
--------|--------- |---------
Model Builder|Rolling | [![Build Status](https://identitydivision.visualstudio.com/OData/_apis/build/status%2FOData.ModelBuilder%2FOData.ModelBuilder-rolling-1ES?repoName=OData%2FModelBuilder&branchName=main)](https://identitydivision.visualstudio.com/OData/_build/latest?definitionId=2690&repoName=OData%2FModelBuilder&branchName=main)
Model Builder|Nightly | [![Build Status](https://identitydivision.visualstudio.com/OData/_apis/build/status%2FOData.ModelBuilder%2FOData.ModelBuilder-nightly-1ES?repoName=OData%2FModelBuilder&branchName=main)](https://identitydivision.visualstudio.com/OData/_build/latest?definitionId=2691&repoName=OData%2FModelBuilder&branchName=main)



## 1. Introduction
This is the official OData Model Builder repository.

## 2. Project structure

* [Product Codes](https://github.com/OData/ModelBuilder/tree/main/src/Microsoft.OData.ModelBuilder)

* [Test Codes](https://github.com/OData/ModelBuilder/tree/main/test/Microsoft.OData.ModelBuilder.Tests)

## 3. Building, Testing, Debugging and Release

### 3.1 Building and Testing in Visual Studio

Simply open the shortcut [OData.ModelBuilder.sln](https://github.com/OData/ModelBuilder/blob/main/sln/) at `sln` folder to launch a solution that contains the product source and relevant unit tests.

The solution contains the corresponding test project. Please open it, build it and run all the tests in the test explorer.

### 3.2 One-click build and test script in command line

N/A

### 3.3 Debug

Please refer to the [How to debug](http://odata.github.io/WebApi/10-01-debug-webapi-source).

### 3.4 Nightly Builds

The nightly build process will upload a NuGet packages for Model builder to the [MyGet.org odatanightly feed](https://www.myget.org/F/odatanightly/api/v3/index.json).

To connect to odatanightly feed, use the following feed URLs: 

- [https://www.myget.org/F/odatanightly/api/v3/index.json](https://www.myget.org/F/odatanightly/api/v3/index.json) (Visual Studio 2015+)

- [https://www.myget.org/F/odatanightly/api/v2](https://www.myget.org/F/odatanightly/api/v2) (Visual Studio 2012+)

You can query the latest nightly NuGet packages using this query: [MAGIC OData query](https://www.myget.org/F/odatanightly/Packages?$select=Id,Version&$orderby=Version%20desc&$top=4&$format=application/json)

### 3.5 Official Release

The release of the component binaries is carried out regularly through [Nuget](http://www.nuget.org/).

## 4. Documentation

Please visit the [OData docs](https://docs.microsoft.com/en-us/odata/) pages. It has detailed descriptions on each feature provided by OData model builderetc.

## 5. Community

### 5.1 Contribution

There are many ways for you to contribute to OData model builder. The easiest way is to participate in discussion of features and issues. You can also contribute by sending pull requests of features or bug fixes to us. Contribution to the documentations is also highly welcomed. Please refer to the CONTRIBUTING.md for more details.

### 5.2 Reporting Security Issues

Security issues and bugs should be reported privately, via email, to the Microsoft Security Response Center (MSRC) <secure@microsoft.com>. You should receive a response within 24 hours. If for some reason you do not, please follow up via email to ensure we received your original message. Further information, including the MSRC PGP key, can be found in the [Security TechCenter](https://www.microsoft.com/msrc/faqs-report-an-issue). You can also find these instructions in this repo's [SECURITY.md](./SECURITY.md).

### 5.3 Support

- Issues: Report issues on [Model Builder issues](https://github.com/OData/ModelBuilder/issues).
- Questions: Ask questions on [Stack Overflow](http://stackoverflow.com/questions/ask?tags=odata).
- Feedback: Please send mails to [odatafeedback@microsoft.com](mailto:odatafeedback@microsoft.com).
- Team blog: Please visit [https://devblogs.microsoft.com/odata/](https://devblogs.microsoft.com/odata/) and [http://www.odata.org/blog/](http://www.odata.org/blog/).

## Code of Conduct

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.
