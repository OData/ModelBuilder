// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Xml;
using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Csdl;
using Microsoft.OData.Edm.Validation;
using Xunit;

namespace Microsoft.OData.ModelBuilder.Tests.Commons
{
    /// <summary>
    /// Helper methods to serialize <see cref="IEdmModel"/> as XML/JSON CSDL.
    /// </summary>
    public static class CsdlSerializer
    {
        public static string SerializeAsXml(this IEdmModel model)
        {
            StringWriter writer = new StringWriter();
            var xwriter = XmlWriter.Create(writer);
            IEnumerable<EdmError> errors;
            if (CsdlWriter.TryWriteCsdl(model, xwriter, CsdlTarget.OData, out errors))
            {
                xwriter.Flush();
                return writer.ToString();
            }
            else
            {
                throw new Exception(errors.First().ErrorMessage);
            }
        }

        public static string SerializeAsJson(this IEdmModel model, bool indented = true, bool isIeee754Compatible = false)
        {
            using (MemoryStream memStream = new MemoryStream())
            {
                JsonWriterOptions options = new JsonWriterOptions
                {
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                    Indented = indented,
                    SkipValidation = false
                };

                using (Utf8JsonWriter jsonWriter = new Utf8JsonWriter(memStream, options))
                {
                    CsdlJsonWriterSettings settings = new CsdlJsonWriterSettings();
                    settings.IsIeee754Compatible = isIeee754Compatible;
                    IEnumerable<EdmError> errors;
                    bool ok = CsdlWriter.TryWriteCsdl(model, jsonWriter, settings, out errors);
                    jsonWriter.Flush();
                    Assert.True(ok);
                }

                memStream.Seek(0, SeekOrigin.Begin);
                return new StreamReader(memStream).ReadToEnd();
            }
        }
    }
}
