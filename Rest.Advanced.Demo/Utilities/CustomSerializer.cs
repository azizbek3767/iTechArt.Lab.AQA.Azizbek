
using RestSharp;
using RestSharp.Serializers;
using RestSharp.Serializers.Json;

namespace Rest.Advanced.Demo.Utilities
{
    public class CustomSerializer : IRestSerializer, ISerializer, IDeserializer
    {
        public ISerializer Serializer => this;

        public IDeserializer Deserializer => this;

        public string[] AcceptedContentTypes => new SystemTextJsonSerializer().AcceptedContentTypes; 

        public SupportsContentType SupportsContentType => new SystemTextJsonSerializer().SupportsContentType;

        public DataFormat DataFormat => new SystemTextJsonSerializer().DataFormat;

        public ContentType ContentType {
            get { return new SystemTextJsonSerializer().ContentType; } 
            set { ContentType= value; } 
        }

        public T? Deserialize<T>(RestResponse response)
        {
            return new SystemTextJsonSerializer().Deserialize<T>(response);
        }

        public string? Serialize(Parameter parameter)
        {
            return new SystemTextJsonSerializer().Serialize(parameter);
        }
         
        public string? Serialize(object obj)
        {
            return new SystemTextJsonSerializer().Serialize(obj);
        }
    }
}
