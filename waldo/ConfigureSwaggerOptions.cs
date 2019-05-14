﻿//using Microsoft.AspNetCore.Mvc.ApiExplorer;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Options;
//using Swashbuckle.AspNetCore.Swagger;
//using Swashbuckle.AspNetCore.SwaggerGen;

//namespace waldo
//{
//    public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
//    {
//        readonly IApiVersionDescriptionProvider provider;

//        /// <summary>
//        /// Initializes a new instance of the <see cref="ConfigureSwaggerOptions"/> class.
//        /// </summary>
//        /// <param name="provider">The <see cref="IApiVersionDescriptionProvider">provider</see> used to generate Swagger documents.</param>
//        public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider) => this.provider = provider;

//        /// <inheritdoc />
//        public void Configure(SwaggerGenOptions options)
//        {
//            // add a swagger document for each discovered API version
//            // note: you might choose to skip or document deprecated API versions differently
//            foreach (var description in provider.ApiVersionDescriptions)
//            {
//                options.SwaggerDoc(description.GroupName, CreateInfoForApiVersion(description));
//            }
//        }

//        static Info CreateInfoForApiVersion(ApiVersionDescription description)
//        {
//            var info = new Info()
//            {
//                Title = "Where's Waldo",
//                Version = description.ApiVersion.ToString(),
//                Description = "A sample application with Swagger, Swashbuckle, and API versioning.",
//                Contact = new Contact() { Name = "Bill Mei", Email = "bill.mei@somewhere.com" },
//                TermsOfService = "Shareware",
//                License = new License() { Name = "MIT", Url = "https://opensource.org/licenses/MIT" }
//            };

//            if (description.IsDeprecated)
//            {
//                info.Description += " This API version has been deprecated.";
//            }

//            return info;
//        }
//    }
//}