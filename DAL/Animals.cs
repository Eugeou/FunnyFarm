using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyFarm.DAL
{
    public class GiaSuc
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public string Sound { get; set; }

        public GiaSuc(string name, string sound, int count)
        {
            Name = name;
            Sound = sound;
            Count = count;
        }

        public virtual int GiveMilk() { return 0; }  // Cho sữa (ngẫu nhiên)
        public virtual int GiveBirth() { return 0; } // Sinh con (ngẫu nhiên)
    }

    public class Bo : GiaSuc
    {
        public Bo(int count) : base("Bo", "Bò Kêu: Ò Ò", count) { }

        public override int GiveMilk() => new Random().Next(0, 21); // 0 - 20 lit sữa
        public override int GiveBirth() => new Random().Next(1, 4); // Sinh ngẫu nhiên từ 1-3 con
    }

    public class Cuu : GiaSuc
    {
        public Cuu(int count) : base("Cuu", "Cừu Kêu: Bê Bê", count) { }

        public override int GiveMilk() => new Random().Next(0, 6); // 0 - 5 lit sữa
        public override int GiveBirth() => new Random().Next(1, 3); // Sinh ngẫu nhiên từ 1-2 con
    }

    public class De : GiaSuc
    {
        public De(int count) : base("De", "Dê Kêu: Be Be", count) { }

        public override int GiveMilk() => new Random().Next(0, 11); // 0 - 10 lit sữa
        public override int GiveBirth() => new Random().Next(1, 3); // Sinh ngẫu nhiên từ 1-2 con
    }
}
