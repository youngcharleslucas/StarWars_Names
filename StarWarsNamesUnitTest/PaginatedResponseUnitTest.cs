using StarWarsNames;
namespace StarWarsNamesUnitTest
{
    public class PaginatedResponseUnitTest
    {
        private string uri;
        private HttpClient client;
        private string _82names;
        private PaginatedResponse paginatedResponse;
        [SetUp]
        public void Setup()
        {
            uri = "https://swapi.dev/api/people";
            client = new HttpClient();
            _82names = $"Luke Skywalker, C-3PO, R2-D2, Darth Vader, Leia Organa, Owen Lars, " +
                $"Beru Whitesun lars, R5-D4, Biggs Darklighter, Obi-Wan Kenobi, Anakin Skywalker, Wilhuff Tarkin, " +
                $"Chewbacca, Han Solo, Greedo, Jabba Desilijic Tiure, Wedge Antilles, Jek Tono Porkins, Yoda, Palpatine, " +
                $"Boba Fett, IG-88, Bossk, Lando Calrissian, Lobot, Ackbar, Mon Mothma, Arvel Crynyd, Wicket Systri Warrick, " +
                $"Nien Nunb, Qui-Gon Jinn, Nute Gunray, Finis Valorum, Padm� Amidala, Jar Jar Binks, Roos Tarpals, " +
                $"Rugor Nass, Ric Oli�, Watto, Sebulba, Quarsh Panaka, Shmi Skywalker, Darth Maul, Bib Fortuna, Ayla Secura, " +
                $"Ratts Tyerel, Dud Bolt, Gasgano, Ben Quadinaros, Mace Windu, Ki-Adi-Mundi, Kit Fisto, Eeth Koth, Adi Gallia, " +
                $"Saesee Tiin, Yarael Poof, Plo Koon, Mas Amedda, Gregar Typho, Cord�, Cliegg Lars, Poggle the Lesser, " +
                $"Luminara Unduli, Barriss Offee, Dorm�, Dooku, Bail Prestor Organa, Jango Fett, Zam Wesell, Dexter Jettster, " +
                $"Lama Su, Taun We, Jocasta Nu, R4-P17, Wat Tambor, San Hill, Shaak Ti, Grievous, Tarfful, Raymus Antilles, " +
                $"Sly Moore, Tion Medon";
            paginatedResponse = new PaginatedResponse();
        }

        [Test]
        public void GetSwapiNames_List82Names()
        {
            Assert.That(paginatedResponse.ListNames(uri, client), Is.EqualTo(_82names));
        }
    }
}