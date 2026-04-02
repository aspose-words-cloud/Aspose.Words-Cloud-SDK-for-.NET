// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SaveAsTiffOnlineRequest.cs">
//   Copyright (c) 2026 Aspose.Words for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Words.Cloud.Sdk.Model.Requests
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using System.Security.Cryptography;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Responses;

    /// <summary>
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.SaveAsTiffOnline" /> operation.
    /// </summary>
    public class SaveAsTiffOnlineRequest : IRequestModel, ICanUseCustomFontsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveAsTiffOnlineRequest"/> class.
        /// </summary>
        public SaveAsTiffOnlineRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveAsTiffOnlineRequest"/> class.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <param name="saveOptions">Tiff save options.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password of protected Word document. Use the parameter to pass a password via SDK. SDK encrypts it automatically. We don't recommend to use the parameter to pass a plain password for direct call of API.</param>
        /// <param name="encryptedPassword">Password of protected Word document. Use the parameter to pass an encrypted password for direct calls of API. See SDK code for encyption details.</param>
        /// <param name="openTypeSupport">The value indicates whether OpenType support is on.</param>
        /// <param name="useAntiAliasing">The flag indicating whether to use antialiasing.</param>
        /// <param name="useHighQualityRendering">The flag indicating whether to use high quality.</param>
        /// <param name="imageBrightness">The level of brightness for the generated images.</param>
        /// <param name="imageColorMode">The color mode for the generated images.</param>
        /// <param name="imageContrast">The contrast for the generated images.</param>
        /// <param name="numeralFormat">The images numeral format.</param>
        /// <param name="pageCount">The number of pages to render.</param>
        /// <param name="pageIndex">The index of the page to start rendering.</param>
        /// <param name="paperColor">The background image color.</param>
        /// <param name="pixelFormat">The pixel format of the generated images.</param>
        /// <param name="resolution">The resolution of the generated images.</param>
        /// <param name="scale">The zoom factor for the generated images.</param>
        /// <param name="tiffCompression">The compression tipe.</param>
        /// <param name="dmlRenderingMode">The optional dml rendering mode. The default value is Fallback.</param>
        /// <param name="dmlEffectsRenderingMode">The optional dml effects rendering mode. The default value is Simplified.</param>
        /// <param name="tiffBinarizationMethod">The optional TIFF binarization method. Possible values are: FloydSteinbergDithering, Threshold.</param>
        /// <param name="zipOutput">The flag indicating whether to ZIP the output.</param>
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param>
        public SaveAsTiffOnlineRequest(System.IO.Stream document, TiffSaveOptionsData saveOptions, string loadEncoding = null, string password = null, string encryptedPassword = null, bool? openTypeSupport = null, bool? useAntiAliasing = null, bool? useHighQualityRendering = null, double? imageBrightness = null, string imageColorMode = null, double? imageContrast = null, string numeralFormat = null, int? pageCount = null, int? pageIndex = null, string paperColor = null, string pixelFormat = null, double? resolution = null, double? scale = null, string tiffCompression = null, string dmlRenderingMode = null, string dmlEffectsRenderingMode = null, string tiffBinarizationMethod = null, bool? zipOutput = null, string fontsLocation = null)
        {
            this.Document = document;
            this.SaveOptions = saveOptions;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.EncryptedPassword = encryptedPassword;
            this.OpenTypeSupport = openTypeSupport;
            this.UseAntiAliasing = useAntiAliasing;
            this.UseHighQualityRendering = useHighQualityRendering;
            this.ImageBrightness = imageBrightness;
            this.ImageColorMode = imageColorMode;
            this.ImageContrast = imageContrast;
            this.NumeralFormat = numeralFormat;
            this.PageCount = pageCount;
            this.PageIndex = pageIndex;
            this.PaperColor = paperColor;
            this.PixelFormat = pixelFormat;
            this.Resolution = resolution;
            this.Scale = scale;
            this.TiffCompression = tiffCompression;
            this.DmlRenderingMode = dmlRenderingMode;
            this.DmlEffectsRenderingMode = dmlEffectsRenderingMode;
            this.TiffBinarizationMethod = tiffBinarizationMethod;
            this.ZipOutput = zipOutput;
            this.FontsLocation = fontsLocation;
        }

        /// <summary>
        /// The document.
        /// </summary>
        public System.IO.Stream Document { get; set; }

        /// <summary>
        /// Tiff save options.
        /// </summary>
        public TiffSaveOptionsData SaveOptions { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password of protected Word document. Use the parameter to pass a password via SDK. SDK encrypts it automatically. We don't recommend to use the parameter to pass a plain password for direct call of API.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Password of protected Word document. Use the parameter to pass an encrypted password for direct calls of API. See SDK code for encyption details.
        /// </summary>
        public string EncryptedPassword { get; set; }

        /// <summary>
        /// The value indicates whether OpenType support is on.
        /// </summary>
        public bool? OpenTypeSupport { get; set; }

        /// <summary>
        /// The flag indicating whether to use antialiasing.
        /// </summary>
        public bool? UseAntiAliasing { get; set; }

        /// <summary>
        /// The flag indicating whether to use high quality.
        /// </summary>
        public bool? UseHighQualityRendering { get; set; }

        /// <summary>
        /// The level of brightness for the generated images.
        /// </summary>
        public double? ImageBrightness { get; set; }

        /// <summary>
        /// The color mode for the generated images.
        /// </summary>
        public string ImageColorMode { get; set; }

        /// <summary>
        /// The contrast for the generated images.
        /// </summary>
        public double? ImageContrast { get; set; }

        /// <summary>
        /// The images numeral format.
        /// </summary>
        public string NumeralFormat { get; set; }

        /// <summary>
        /// The number of pages to render.
        /// </summary>
        public int? PageCount { get; set; }

        /// <summary>
        /// The index of the page to start rendering.
        /// </summary>
        public int? PageIndex { get; set; }

        /// <summary>
        /// The background image color.
        /// </summary>
        public string PaperColor { get; set; }

        /// <summary>
        /// The pixel format of the generated images.
        /// </summary>
        public string PixelFormat { get; set; }

        /// <summary>
        /// The resolution of the generated images.
        /// </summary>
        public double? Resolution { get; set; }

        /// <summary>
        /// The zoom factor for the generated images.
        /// </summary>
        public double? Scale { get; set; }

        /// <summary>
        /// The compression tipe.
        /// </summary>
        public string TiffCompression { get; set; }

        /// <summary>
        /// The optional dml rendering mode. The default value is Fallback.
        /// </summary>
        public string DmlRenderingMode { get; set; }

        /// <summary>
        /// The optional dml effects rendering mode. The default value is Simplified.
        /// </summary>
        public string DmlEffectsRenderingMode { get; set; }

        /// <summary>
        /// The optional TIFF binarization method. Possible values are: FloydSteinbergDithering, Threshold.
        /// </summary>
        public string TiffBinarizationMethod { get; set; }

        /// <summary>
        /// The flag indicating whether to ZIP the output.
        /// </summary>
        public bool? ZipOutput { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>
        public string FontsLocation { get; set; }

        /// <summary>
        /// Returns the original request for the current operation.
        /// </summary>
        /// <returns>The original request instance.</returns>
        public IRequestModel GetOriginalRequest()
        {
            return this;
        }

        /// <summary>
        /// Creates the http request based on this request.
        /// </summary>
        /// <param name="configuration">SDK configuration.</param>
        /// <param name="encryptor">password encyptor.</param>
        /// <returns>The http request instance.</returns>
        public async Task<HttpRequestMessage> CreateHttpRequest(Configuration configuration, IEncryptor encryptor)
        {
            // verify the required parameter 'document' is set
            if (this.Document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling SaveAsTiffOnline");
            }

            // verify the required parameter 'saveOptions' is set
            if (this.SaveOptions == null)
            {
                throw new ApiException(400, "Missing required parameter 'saveOptions' when calling SaveAsTiffOnline");
            }

            this.SaveOptions?.Validate();

            var path = configuration.GetApiRootUrl() + "/words/online/put/saveAs/tiff";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");
            path = await UrlHelper.AddQueryParameterToUrl(path, "loadEncoding", this.LoadEncoding, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "password", this.Password, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "encryptedPassword", this.EncryptedPassword, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "openTypeSupport", this.OpenTypeSupport, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "useAntiAliasing", this.UseAntiAliasing, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "useHighQualityRendering", this.UseHighQualityRendering, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "imageBrightness", this.ImageBrightness, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "imageColorMode", this.ImageColorMode, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "imageContrast", this.ImageContrast, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "numeralFormat", this.NumeralFormat, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "pageCount", this.PageCount, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "pageIndex", this.PageIndex, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "paperColor", this.PaperColor, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "pixelFormat", this.PixelFormat, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "resolution", this.Resolution, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "scale", this.Scale, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "tiffCompression", this.TiffCompression, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "dmlRenderingMode", this.DmlRenderingMode, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "dmlEffectsRenderingMode", this.DmlEffectsRenderingMode, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "tiffBinarizationMethod", this.TiffBinarizationMethod, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "zipOutput", this.ZipOutput, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "fontsLocation", this.FontsLocation, encryptor);

            var formData = new List< Tuple<string, object> >();
            var result = new HttpRequestMessage(HttpMethod.Put, path);
            if (this.Document != null)
            {
                formData.Add(new Tuple<string, object>("document", new Aspose.Words.Cloud.Sdk.FileInfo() { Name = "Document", FileContent = StreamHelper.ReadAsBytes(this.Document) }));
            }

            if (this.SaveOptions != null)
            {
                formData.Add(new Tuple<string, object>("SaveOptions", this.SaveOptions));
            }

            result.Content = await ApiInvoker.GetRequestContent(formData, encryptor);
            return result;
        }

        /// <summary>
        /// Deserialize response object.
        /// </summary>
        /// <param name="message">Response message.</param>
        /// <returns>Response type.</returns>
        public async Task<object> DeserializeResponse(HttpResponseMessage message)
        {
            var multipart = await ApiInvoker.ToMultipartForm(message);
            return new SaveAsTiffOnlineResponse(
                model: (SaveResponse)SerializationHelper.Deserialize(
                    await new StreamReader(multipart["Model"].Content, System.Text.Encoding.UTF8).ReadToEndAsync(),
                    typeof(SaveResponse)),
                document: await SerializationHelper.DeserializeFilesCollection(multipart["Document"])
            );
        }
    }
}
