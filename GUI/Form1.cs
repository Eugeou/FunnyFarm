using FunnyFarm.BUS;
using FunnyFarm.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunnyFarm
{
    public partial class Form1 : Form
    {
        private FarmBLL _farm;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInitFarm_Click(object sender, EventArgs e)
        {
            int boCount = int.Parse(txtBoCount.Text);
            int cuuCount = int.Parse(txtCuuCount.Text);
            int deCount = int.Parse(txtDeCount.Text);

            _farm = FarmDAL.LoadFarmData(boCount, cuuCount, deCount);
            MessageBox.Show("Nông trại đã được khởi tạo!");
        }

        private void btnFeedAnimals_Click(object sender, EventArgs e)
        {
            string sounds = _farm.GetAllSounds();
            MessageBox.Show("Các gia súc kêu: " + sounds);
        }

        private void btnGetStatistics_Click(object sender, EventArgs e)
        {
            _farm.PerformReproduction();
            int totalMilk = _farm.GetTotalMilk();
            var counts = _farm.GetLivestockCount();

            string result = $"Số lượng gia súc:\nBò: {counts["Bo"]}\nCừu: {counts["Cuu"]}\nDê: {counts["De"]}\n" +
                            $"Tổng số lít sữa: {totalMilk} lít.";
            MessageBox.Show(result);
        }
    }
}
