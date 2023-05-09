using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string xmlType = "text/xml";
            string jsonType = "application/json";
            string get = "GET";
            string post = "POST";
            string put = "PUT";
            string delete = "DELETE";

            MyRestClient client = new MyRestClient();

            int input = -1;
            bool EXIT = false;

            while (!EXIT)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1: Wypisz wszystkich (XML)");
                Console.WriteLine("2: Wypisz jedną osobę (XML)");
                Console.WriteLine("3: Dodaj nową osobę (XML)");
                Console.WriteLine("4: Usuń osobę (XML)");
                Console.WriteLine("5: Edytuj osobę (XML)");
                Console.WriteLine("6: Liczba ludzi w bazie (XML)");
                Console.WriteLine("7: Wypisz wszystkich (XML)");
                Console.WriteLine("8: Wypisz jedną osobę (XML)");
                Console.WriteLine("9: Dodaj nową osobę (XML)");
                Console.WriteLine("10: Usuń osobę (XML)");
                Console.WriteLine("11: Edytuj osobę (XML)");
                Console.WriteLine("12: Liczba ludzi w bazie (XML)");
                Console.WriteLine("Inny przycisk: wyjście");

                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch
                {
                    input = 0;
                }

                if (input == 0)
                {
                    EXIT = true;
                }

                string endpoint = "";
                string method = "";
                string type = "";

                switch (input)
                {
                    case 0:
                        break;
                    case 1:
                        endpoint = "xml/People";
                        method = get;
                        type = xmlType;
                        break;
                    case 2:
                        Console.Write("Podaj indeks osoby: ");
                        int getId = int.Parse(Console.ReadLine());
                        endpoint = $"xml/People/{getId}";
                        method = get;
                        type = xmlType;
                        break;
                    case 3:
                        endpoint = "xml/People";
                        method = post;
                        type = xmlType;
                        break;
                    case 4:
                        Console.Write("Podaj indeks osoby: ");
                        int delId = int.Parse(Console.ReadLine());
                        endpoint = $"xml/People{delId}";
                        method = delete;
                        type = xmlType;
                        break;
                    case 5:
                        Console.Write("Podaj indeks osoby: ");
                        int editId = int.Parse(Console.ReadLine());
                        endpoint = $"xml/People{editId}";
                        method = put;
                        type = xmlType;
                        break;
                    case 6:
                        endpoint = "xml/People/count";
                        method = get;
                        type = xmlType;
                        break;
                    case 7:
                        endpoint = "json/People";
                        method = get;
                        type = jsonType;
                        break;
                    case 8:
                        Console.Write("Podaj indeks osoby: ");
                        int getIdJson = int.Parse(Console.ReadLine());
                        endpoint = $"json/People/{getIdJson}";
                        method = get;
                        type = jsonType;
                        break;
                    case 9:
                        endpoint = "json/People";
                        method = post;
                        type = jsonType;
                        break;
                    case 10:
                        Console.Write("Podaj indeks osoby: ");
                        int delIdJson = int.Parse(Console.ReadLine());
                        endpoint = $"json/People{delIdJson}";
                        method = delete;
                        type = jsonType;
                        break;
                    case 11:
                        Console.Write("Podaj indeks osoby: ");
                        int editIdJson = int.Parse(Console.ReadLine());
                        endpoint = $"json/People{editIdJson}";
                        method = put;
                        type = jsonType;
                        break;
                    case 12:
                        endpoint = "json/People/count";
                        method = get;
                        type = jsonType;
                        break;
                    default:
                        EXIT = true;
                        break;
                }

                client.processRequest(endpoint, method, type);
            }


        }
    }
}
