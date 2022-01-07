// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.IO;
using System.Linq;
using Xunit;

namespace Microsoft.OData.ModelBuilder.Tests.PublicApi
{
    public class PublicApiTest
    {
        private const string AssemblyName = "Microsoft.OData.ModelBuilder.dll";

#if NET6_0_OR_GREATER
        private const string BaseLineFileName = "Microsoft.OData.ModelBuilder.PublicApi.net60.bsl";
        private const string OutputFileName = "Microsoft.OData.ModelBuilder.PublicApi.net60.out";
#else
        private const string BaseLineFileName = "Microsoft.OData.ModelBuilder.PublicApi.bsl";
        private const string OutputFileName = "Microsoft.OData.ModelBuilder.PublicApi.out";
#endif
        private const string BaseLineFileFolder = @"test\Microsoft.OData.ModelBuilder.Tests\PublicApi\";

        [Fact]
        public void TestPublicApi()
        {
            // Arrange
            string outputPath = Environment.CurrentDirectory;
            string outputFile = outputPath + Path.DirectorySeparatorChar + OutputFileName;

            // Act
            using (FileStream fs = new FileStream(outputFile, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    string assemblyPath = outputPath + Path.DirectorySeparatorChar + AssemblyName;
                    Assert.True(File.Exists(assemblyPath), string.Format("{0} does not exist in current directory", assemblyPath));
                    PublicApiHelper.DumpPublicApi(sw, assemblyPath);
                }
            }
            string outputString = File.ReadAllText(outputFile);
            string baselineString = GetBaseLineString();

            // Assert
            if (string.Compare(baselineString, outputString, StringComparison.Ordinal) != 0)
            {
                const int sliceSize = 128;

                var diffPoint = baselineString.Zip(outputString, (c1, c2) => c1 == c2).TakeWhile(b => b).Count();

                var displayBaseline = baselineString.SliceCenter(diffPoint, sliceSize);
                var displayOutput = outputString.SliceCenter(diffPoint, sliceSize);

                Assert.True(false,
                    string.Format("Base line file {1} and output file {2} do not match, please check.{0}" +
                    "Baseline:{0}\"{3}\"{0}" +
                    "Output:  {0}\"{4}\"{0}{0}" +
                    "To update the baseline, please run:{0}{0}" +
                    "copy /y \"{2}\" \"{1}\"", Environment.NewLine,
                    BaseLineFileFolder + BaseLineFileName,
                    outputFile,
                    displayBaseline, displayOutput));
            }
        }

        private string GetBaseLineString()
        {
            const string projectDefaultNamespace = "Microsoft.OData.ModelBuilder.Tests";
            const string resourcesFolderName = "PublicApi";
            const string pathSeparator = ".";
            string path = projectDefaultNamespace + pathSeparator + resourcesFolderName + pathSeparator + BaseLineFileName;

            using (Stream stream = typeof(PublicApiTest).Assembly.GetManifestResourceStream(path))
            {
                if (stream == null)
                {
                    string message = Error.Format("The embedded resource '{0}' was not found.", path);
                    throw new FileNotFoundException(message, path);
                }

                using (TextReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }

    static class TestStringExtensions
    {
        internal static string SliceCenter(this string text, int center, int width)
        {
            int start;

            if (center < 0)
            {
                start = 0;
                return string.Empty;
            }

            center = (center <= text.Length) ? center : text.Length;

            start = center - (width / 2);
            var length = width;

            if (start < 0)
            {
                start = 0;
                length = center + (width / 2);
            }

            if (start + length > text.Length)
            {
                length = text.Length - start;
            }

            return text.Substring(start, length);
        }
    }
}
