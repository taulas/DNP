using System.Collections.Generic;
using Models;
using System.IO;
using System.Linq;
using System.Text.Json;


namespace Managing_Adults.Data.Impl
{
    public class AdultService : IAdultService
    {
        private string adultsFile = "adults.json";
        private IList<Adult> adults;

        public AdultService()
        {
            adults = File.Exists(adultsFile) ? ReadData<Adult>(adultsFile) : new List<Adult>();
        }

        private IList<T> ReadData<T>(string s)
        {
            using (var jsonReader = File.OpenText(s))
            {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }

        public IList<Adult> GetAdults()
        {
            List<Adult> tmp = new List<Adult>(adults);
            return tmp;
        }

        public void AddAdult(Adult adult)
        {
            int max = adults.Max(adult => adult.Id);
            adult.Id = (++max);
            adults.Add(adult);
            SaveChanges();
        }

        public void RemoveAdult(int Id)
        {
            Adult toRemove = adults.First(t => t.Id == Id);
            adults.Remove(toRemove);
            SaveChanges();
        }

        public void Update(Adult adult)
        {
            adult.Update(adult);
            SaveChanges();
        }

        public Adult getAdultById(int Id)
        {
            for (int i = 0; i < adults.Count; i++)
            {
                if (adults[i].Id == Id)
                {
                    return adults[i];
                }
            }

            return null;
        }

        public void SaveChanges()
        {

           
            string jsonAdults = JsonSerializer.Serialize(adults, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            using (StreamWriter outputFile = new StreamWriter(adultsFile, false))
            {
                outputFile.Write(jsonAdults);
            }
        }

        
        
    }
}