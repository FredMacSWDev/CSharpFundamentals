using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _11_API_Challenge_W5D1
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();

            HttpResponseMessage response = httpClient.GetAsync($"https://superheroapi.com/api/10165318465550361/644").Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Result");
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);

                Root root = response.Content.ReadAsAsync<Root>().Result;
                Console.WriteLine($"This looks like a job for {root.Name}!");

                Biography biography = response.Content.ReadAsAsync<Biography>().Result;
                Console.WriteLine($"Full Name: {biography.FullName}");
                Console.WriteLine($"Alter-Ego:\t {biography.AlterEgos}");
                Console.WriteLine($"Alias:\t {biography.Aliases}");
                Console.WriteLine($"Place of Birth:\t {biography.PlaceOfBirth}");

                Appearance appearance = response.Content.ReadAsAsync<Appearance>().Result;
                Console.WriteLine($"Height:\t {appearance.Height}");
                Console.WriteLine($"Weight:\t {appearance.Weight}");
                Console.WriteLine($"Eye Color:\t {appearance.EyeColor}");
                Console.WriteLine($"Hair Color:\t {appearance.HairColor}");

                Work work = response.Content.ReadAsAsync<Work>().Result;
                Console.WriteLine($"Occupation:\t {work.Occupation}");
                Console.WriteLine($"Base:\t {work.Base}");
            }

            Console.ReadKey();

        }
    }
}
