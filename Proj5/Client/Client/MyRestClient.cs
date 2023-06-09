﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Client
{
    public class MyRestClient
    {
        private static readonly string ADDRESS = "http://localhost:55701/Service1.svc/";

        public void processRequest(string endpoint, string method, string type)
        {
            try
            {
                HttpWebRequest req = WebRequest.Create(ADDRESS + endpoint) as HttpWebRequest;
                req.KeepAlive = false;
                req.Method = method;
                req.ContentType = type;

                string payload = "";
                if (method == "POST" || method == "PUT")
                {
                    if (type == "text/xml")
                    {
                        payload = getXmlPerson();
                    }
                    else
                    {
                        payload = getJsonPerson();
                    }
                }

                switch (method)
                {

                    case "GET":
                        break;
                    case "POST":
                        byte[] buforPost = Encoding.UTF8.GetBytes(payload);
                        req.ContentLength = buforPost.Length;
                        Stream postData = req.GetRequestStream();
                        postData.Write(buforPost, 0, buforPost.Length);
                        postData.Close();
                        break;
                    case "PUT":
                        byte[] buforPut = Encoding.UTF8.GetBytes(payload);
                        req.ContentLength = buforPut.Length;
                        Stream putData = req.GetRequestStream();
                        putData.Write(buforPut, 0, buforPut.Length);
                        putData.Close();
                        break;
                    case "DELETE":
                        break;
                }

                HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
                Encoding enc = Encoding.GetEncoding("UTF-8");
                StreamReader responseStream = new StreamReader(resp.GetResponseStream(), enc);
                string responseString = responseStream.ReadToEnd();
                responseStream.Close();
                resp.Close();

                if (method == "POST" || method == "PUT")
                {
                    Console.WriteLine("Odpowiedź serwera: "+DecodeString(responseString));
                }
                else
                {

                    if (type == "text/xml")
                    {
                        Console.WriteLine(FormatXml(responseString));
                        ExtractDataXml(responseString);


                    }
                    else if (type == "application/json")
                    {
                        Console.WriteLine(FormatJson(responseString));

                    }
                    else
                    {
                        Console.WriteLine(responseString);

                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd: "+ex.Message.ToString());
            }
        }

        private static string DecodeString(string responseString)
        {
            Match match = Regex.Match(responseString, "<string.*?>(.*?)</string>", RegexOptions.Singleline);
            string result = responseString;
            if (match.Success)
            {
                result = match.Groups[1].Value;
            }

            return result;
        }

        private static string FormatXml(string xmlString)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlString);

            StringBuilder sb = new StringBuilder();
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "    "
            };

            using (XmlWriter writer = XmlWriter.Create(sb, settings))
            {
                doc.Save(writer);
            }

            return sb.ToString();
        }

        private static void ExtractDataXml(string xmlString)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlString);

            XmlNodeList personNodes = doc.GetElementsByTagName("Person");

            foreach (XmlNode personNode in personNodes)
            {

                Console.Write("Osoba " + personNode.ChildNodes[0].InnerText);
                Console.Write(": " + personNode.ChildNodes[1].InnerText);
                Console.Write(", " + personNode.ChildNodes[2].InnerText);
                Console.WriteLine(", " + personNode.ChildNodes[3].InnerText);
            }
        }

        private static string FormatJson(string jsonString)
        {
            JsonDocument doc = JsonDocument.Parse(jsonString);

            return JsonSerializer.Serialize(doc, new JsonSerializerOptions
            {
                WriteIndented = true
            });
        }

        public static String getXmlPerson()
        {
            StringBuilder builder = new StringBuilder("<Person xmlns=\"http://schemas.datacontract.org/2004/07/MyWebService\" xmlns:i=\"http://www.w3.org/2001/XMLSchema-instance\">");
            builder.Append("<id>" + 0 + "</id>");
            Console.Write("Podaj imię i nazwisko osoby: ");
            builder.Append("<name>" + Console.ReadLine() + "</name>");
            Console.Write("Podaj wiek osoby: ");
            builder.Append("<age>" + int.Parse(Console.ReadLine()) + "</age>");
            Console.Write("Podaj email: ");
            builder.Append("<email>" + Console.ReadLine() + "</email>");
            builder.Append("</Person>");

            Console.WriteLine(builder.ToString());

            return builder.ToString();
        }

        public static String getJsonPerson()
        {
            StringBuilder builder = new StringBuilder();
            Console.Write("Podaj imię i nazwisko osoby: ");
            string name = Console.ReadLine();
            Console.Write("Podaj wiek osoby: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Podaj email: ");
            string email = Console.ReadLine();

            builder.AppendFormat("{{\"id\":0,\"name\":\"{0}\",\"age\":{1},\"email\":\"{2}\"}}", name, age, email);
            Console.WriteLine(builder.ToString());

            return builder.ToString();
        }

    }
}
