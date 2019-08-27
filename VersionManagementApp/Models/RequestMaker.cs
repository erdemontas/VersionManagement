using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using VersionManagement.DTOs;

namespace VersionManagementApp.Models
{
    public class RequestMaker
    {
        public const string DefaultAppBaseUri = "https://localhost:5002";
        public const string DefaultBaseUri = "https://localhost:5001/api";
        public string BaseUri { get; set; }

        public RequestMaker(string baseUri = DefaultBaseUri)
        {
            BaseUri = baseUri;
        }
        protected T Get<T>(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.  
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.  
                var responseFromServer = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(responseFromServer);
            }
        }
        protected T GetByPath<T>(string path) => Get<T>($"{BaseUri}/{path}");
        protected IEnumerable<T> GetManyByPath<T>(string path) => Get<IEnumerable<T>>($"{BaseUri}/{path}");
    }
    public class EntityRequestMaker<T> : RequestMaker
    {
        public string EntityName { get; set; }

        public EntityRequestMaker(string entityName, string baseUri = DefaultBaseUri) : base(baseUri)
        {
            EntityName = entityName;
        }

        public T Get(Guid id) => GetByPath<T>($"{EntityName}/{id}");
        public IEnumerable<T> GetManyById(Guid id) => GetByPath<IEnumerable<T>>($"{EntityName}/{id}");
        public IEnumerable<T> Get() => GetByPath<IEnumerable<T>>(EntityName);
    }
    public class RequestMakerWrapper
    {
        private static Lazy<RequestMakerWrapper> instance = new Lazy<RequestMakerWrapper>(() => new RequestMakerWrapper());
        public static RequestMakerWrapper Instance => instance.Value;

        public RequestMakerWrapper(string baseUri = RequestMaker.DefaultBaseUri)
        {
            ChangeLogs = new EntityRequestMaker<ChangeLogDTO>(ChangeLogsPath, baseUri);
            ChangeLogTypes = new EntityRequestMaker<ChangeLogTypeDTO>(ChangeLogTypesPath, baseUri);
            Components = new EntityRequestMaker<ComponentDTO>(CopmonentsPath, baseUri);
            ComponentTypes = new EntityRequestMaker<ComponentTypeDTO>(CopmonentTypesPath, baseUri);
            Customers = new EntityRequestMaker<CustomerDTO>(CustomersPath, baseUri);
            CustomerProducts = new EntityRequestMaker<CustomerProductDTO>(CustomerProductsPath, baseUri);
            Products = new EntityRequestMaker<ProductDTO>(ProductsPath, baseUri);
            PublishActivities = new EntityRequestMaker<PublishActivityDTO>(PublishActivitiesPath, baseUri);
            Versions = new EntityRequestMaker<VersionDTO>(VersionsPath, baseUri);
            CustomerProductsByProductId = new EntityRequestMaker<CustomerProductDTO>($"{CustomerProductsPath}/GetByProductId", baseUri);
            CustomerProductsByCustomerId = new EntityRequestMaker<CustomerProductDTO>($"{CustomerProductsPath}/GetByCustomerId", baseUri);
        }

        private const string ChangeLogsPath = "ChangeLog";
        private const string ChangeLogTypesPath = "ChangeLogType";
        private const string CopmonentsPath = "Component";
        private const string CopmonentTypesPath = "ComponentType";
        private const string CustomersPath = "Customer";
        private const string CustomerProductsPath = "CustomerProduct";
        private const string ProductsPath = "Product";
        private const string PublishActivitiesPath = "PublishActivity";
        private const string VersionsPath = "Version";

        public EntityRequestMaker<ChangeLogDTO> ChangeLogs { get; set; }
        public EntityRequestMaker<ChangeLogTypeDTO> ChangeLogTypes { get; set; }
        public EntityRequestMaker<ComponentDTO> Components { get; set; }
        public EntityRequestMaker<ComponentTypeDTO> ComponentTypes { get; set; }
        public EntityRequestMaker<CustomerDTO> Customers { get; set; }
        public EntityRequestMaker<CustomerProductDTO> CustomerProducts { get; set; }
        public EntityRequestMaker<ProductDTO> Products { get; set; }
        public EntityRequestMaker<PublishActivityDTO> PublishActivities { get; set; }
        public EntityRequestMaker<VersionDTO> Versions { get; set; }
        public EntityRequestMaker<CustomerProductDTO> CustomerProductsByProductId { get; set; }
        public EntityRequestMaker<CustomerProductDTO> CustomerProductsByCustomerId { get; set; }
    }
}
