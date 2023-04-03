using RazorPagesPizza.Models;
using System.Collections.Generic;
using System.Linq;

namespace RazorPagesPizza.Services;

    public static class SodaService
    {
        static List<Soda> Sodas { get; }
        static int nextId = 3;
        static SodaService()
        {
            Sodas = new List<Soda>
                {
                    new Soda { Id = 1, Name = "Coca-Cola", Price=2.00M, Size=SodaSize.Large, IsDiet = false },
                    new Soda { Id = 2, Name = "Pepsi", Price=1.50M, Size=SodaSize.Medium, IsDiet = true }
                };
        }
        public static List<Soda> GetAll() => Sodas;
        public static Soda? Get(int id) => Sodas.FirstOrDefault(s => s.Id == id);
        public static void Add(Soda soda)
        {
            soda.Id = nextId++;
            Sodas.Add(soda);
        }

        public static void Delete(int id)
        {
            var soda = Get(id);
            if (soda is null)
                return;

            Sodas.Remove(soda);
        }

        public static void Update(Soda soda)
        {
            var index = Sodas.FindIndex(s => s.Id == soda.Id);
            if (index == -1)
                return;

            Sodas[index] = soda;
        }
    }

