using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StarWarsNames
{
    public class PaginatedResponse
    {
        public int Count { get; set; }
        public string? Next { get; set; } = string.Empty;
        public string? Previous { get; set; } = string.Empty;
        public Character[] Results { get; set; } = Array.Empty<Character>();
 
        public async Task<PaginatedResponse> GetPageOfSwapiNames(string uri, HttpClient httpClient)
        {
            try
            {
                return await httpClient.GetFromJsonAsync<PaginatedResponse>(uri);
            }
            catch (HttpRequestException) // Non success
            {
                Console.WriteLine("An error occurred.");
            }
            catch (NotSupportedException) // When content type is not valid
            {
                Console.WriteLine("The content type is not supported.");
            }
            catch (JsonException) // Invalid JSON
            {
                Console.WriteLine("Invalid JSON.");
            }

            return null;
        }
        public string ListNames( string uri, HttpClient client ) 
        {    
            StringBuilder starWarsNames = new StringBuilder();
            PaginatedResponse response = new PaginatedResponse();
            do  
            { 
                response =  GetPageOfSwapiNames(uri, client).Result;
                foreach( Character character in response.Results) 
                {
                    starWarsNames.Append(character.Name + ", ");
                }
                uri = response.Next;
            } while (response.Next != null);
            return starWarsNames.ToString().TrimEnd(',', ' ');
        }
    }
}
