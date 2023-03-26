using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsNames
{
    public class Character
    {
        public string Name { get; init; } = string.Empty;
        public string Height { get; init; } = string.Empty;
        public string Mass { get; init; } = string.Empty;
        public string Hair_color { get; init; } = string.Empty;
        public string Skin_color { get; init; } = string.Empty;
        public string Eye_olor { get; init; } = string.Empty;
        public string Birth_year { get; init; } = string.Empty;
        public string Gender { get; init; } = string.Empty;
        public string Homeworld { get; init; } = string.Empty;
        public string[] Films { get; init; } = Array.Empty<string>();
        public string[] Species { get; init; } = Array.Empty<string>();
        public string[] Vehicles { get; init; } = Array.Empty<string>();
        public string[] Starships { get; init; } = Array.Empty<string>();
        public DateTime Created { get; init; }
        public DateTime Edited { get; init; }
        public string Url { get; init; } = string.Empty;
    }
}
