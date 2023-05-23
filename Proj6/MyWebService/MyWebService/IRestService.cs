using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IRestService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/xml/People")]
        List<Person> getAllXml();

        [OperationContract]
        [WebGet(UriTemplate = "/xml/People/{id}", ResponseFormat = WebMessageFormat.Xml)]
        Person getByIdXml(string id);

        [OperationContract]
        [WebGet(UriTemplate = "/xml/People/ByName/{name}", ResponseFormat = WebMessageFormat.Xml)]
        List<Person> getByNameXml(string name);

        [OperationContract]
        [WebInvoke(UriTemplate = "/xml/People", Method = "POST", RequestFormat = WebMessageFormat.Xml)]
        string addXml(Person item);

        [OperationContract]
        [WebInvoke(UriTemplate = "/xml/People{id}", Method = "DELETE")]
        string deleteXml(string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "/xml/People{id}", Method = "PUT", RequestFormat = WebMessageFormat.Xml)]
        string updateXml(string id, Person person);

        [OperationContract]
        [WebGet(UriTemplate = "/xml/People/count")]
        int getCountXml();

        [OperationContract]
        [WebGet(UriTemplate = "/json/People", ResponseFormat = WebMessageFormat.Json)]
        List<Person> getAllJson();

        [OperationContract]
        [WebGet(UriTemplate = "/json/People/{id}", ResponseFormat = WebMessageFormat.Json)]
        Person getByIdJson(string Id);

        [OperationContract]
        [WebGet(UriTemplate = "/json/People/ByName/{name}", ResponseFormat = WebMessageFormat.Json)]
        List<Person> getByNameJson(string name);

        [OperationContract]
        [WebInvoke(UriTemplate = "/json/People", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string addJson(Person item);

        [OperationContract]
        [WebInvoke(UriTemplate = "/json/People{id}", Method = "DELETE", ResponseFormat = WebMessageFormat.Json)]
        string deleteJson(string Id);

        [OperationContract]
        [WebInvoke(UriTemplate = "/json/People{id}", Method = "PUT", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string updateJson(string Id, Person person);

        [OperationContract]
        [WebGet(UriTemplate = "/json/People/count", ResponseFormat = WebMessageFormat.Json)]
        int getCountJson();

        [OperationContract]
        [WebGet(UriTemplate = "/json/authors", ResponseFormat = WebMessageFormat.Json)]
        string getAuthorsJson();

        [OperationContract]
        [WebGet(UriTemplate = "/xml/authors", ResponseFormat = WebMessageFormat.Xml)]
        string getAuthorsXml();
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Person
    {
        [DataMember(Order = 0)]
        public int id { get; set; }

        [DataMember(Order = 1)]
        public string name { get; set; }

        [DataMember(Order = 2)]
        public int age { get; set; }

        [DataMember(Order = 3)]
        public string email { get; set; }

    }
}
