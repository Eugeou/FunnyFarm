using FunnyFarm.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyFarm.BUS
{
    public class FarmBLL
    {
        public List<GiaSuc> GiaSucs { get; set; }

        public FarmBLL(int boCount, int cuuCount, int deCount)
        {
            GiaSucs = new List<GiaSuc>
        {
            new Bo(boCount),
            new Cuu(cuuCount),
            new De(deCount)
        };
        }

        public string GetAllSounds()
        {
            return string.Join(", ", GiaSucs.Select(g => g.Sound).ToArray());
        }

        public int GetTotalMilk()
        {
            return GiaSucs.Sum(g => g.Count * g.GiveMilk());
        }

        public void PerformReproduction()
        {
            foreach (var giaSuc in GiaSucs)
            {
                giaSuc.Count += giaSuc.GiveBirth();
            }
        }

        public Dictionary<string, int> GetLivestockCount()
        {
            return GiaSucs.ToDictionary(g => g.Name, g => g.Count);
        }
    }

}
