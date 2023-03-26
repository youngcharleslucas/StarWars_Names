using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

/*
 * References:
 * 
 * HttpClient:
 * https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=net-6.0
 * 
 * For a better understanding of the JSON Extension
 * https://www.stevejgordon.co.uk/sending-and-receiving-json-using-httpclient-with-system-net-http-json
 * 
 * 
 */

namespace StarWarsNames
{
    public class Program
    {
        static readonly HttpClient client = new HttpClient();
        static string uri = "https://swapi.dev/api/people";
        public static readonly PaginatedResponse _paginatedResponse = new PaginatedResponse();
        static void Main(string[] args)
        {
            string commaSeparatedNames = _paginatedResponse.ListNames(uri, client); 
            Console.WriteLine(commaSeparatedNames);
        }
    }
}