using FunnyFarm.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyFarm.DAL
{
    public class FarmDAL
    {
        public static FarmBLL LoadFarmData(int boCount, int cuuCount, int deCount)
        {
            return new FarmBLL(boCount, cuuCount, deCount);
        }
    }
}
