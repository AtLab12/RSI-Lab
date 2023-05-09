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
            MyData.info();

            RestClient client = new RestClient();

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
                        method = "GET";
                        type = "text/xml";
                        break;
                    case 2:
                        Console.Write("Podaj indeks: ");
                        int getId = int.Parse(Console.ReadLine());
                        endpoint = $"xml/People/{getId}";
                        method = "GET";
                        type = "text/xml";
                        break;
                    case 3:
                        endpoint = "xml/People";
                        method = "POST";
                        type = "text/xml";
                        break;
                    case 4:
                        Console.Write("Podaj indeks: ");
                        int delId = int.Parse(Console.ReadLine());
                        endpoint = $"xml/People{delId}";
                        method = "DELETE";
                        type = "text/xml";
                        break;
                    case 5:
                        Console.Write("Podaj indeks: ");
                        int editId = int.Parse(Console.ReadLine());
                        endpoint = $"xml/People{editId}";
                        method = "PUT";
                        type = "text/xml";
                        break;
                    case 6:
                        endpoint = "xml/People/count";
                        method = "GET";
                        type = "text/xml";
                        break;
                    case 7:
                        endpoint = "json/People";
                        method = "GET";
                        type = "application/json";
                        break;
                    case 8:
                        Console.Write("Podaj indeks: ");
                        int getIdJson = int.Parse(Console.ReadLine());
                        endpoint = $"json/People/{getIdJson}";
                        method = "GET";
                        type = "application/json";
                        break;
                    case 9:
                        endpoint = "json/People";
                        method = "POST";
                        type = "application/json";
                        break;
                    case 10:
                        Console.Write("Podaj indeks: ");
                        int delIdJson = int.Parse(Console.ReadLine());
                        endpoint = $"json/People{delIdJson}";
                        method = "DELETE";
                        type = "application/json";
                        break;
                    case 11:
                        Console.Write("Podaj indeks: ");
                        int editIdJson = int.Parse(Console.ReadLine());
                        endpoint = $"json/People{editIdJson}";
                        method = "PUT";
                        type = "application/json";
                        break;
                    case 12:
                        endpoint = "json/People/count";
                        method = "GET";
                        type = "application/json";
                        break;
                    default:
                        EXIT = true;
                        break;
                }

                client.request(endpoint, method, type);
            }


        }
    }
}
