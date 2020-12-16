using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{
    public partial class Train
    {
        private string name;
        private string speed;
        private int countOfWagons;
        private int countOfSeats;
        private int countOfToilets;
        private double ticketPrice;
        private bool haveWagonsRestaurant;
        
        static double minTicketPrice = 5000;
        static double maxTicketPrice = 30000;
        static string nameOfCompany = "Train-train";

        public Train() { }

        public Train(string name, int countOfWagons,int countOfSeats,double ticketPrice)
        {
            this.name = name;
            this.countOfWagons = countOfWagons;
            this.countOfSeats = countOfSeats;
            this.ticketPrice = ticketPrice;
        }

        public Train(string name, int countOfWagons, string speed, int countOfSeats, int countOfToilets, double ticketPrice, bool haveWagonsRestaurant)
        {
            this.name = name;
            this.countOfWagons = countOfWagons;
            this.speed = speed;
            this.countOfSeats = countOfSeats;
            this.countOfToilets = countOfToilets;
            this.haveWagonsRestaurant = haveWagonsRestaurant;
            this.ticketPrice = ticketPrice;
        }

        static Train()
        {
            Console.WriteLine("Создан первый поезд");
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(ref string name)
        {
            this.name = name;
        }

        public int GetCountOfWagons()
        {
            return countOfWagons;
        }

        public int GetCountOfSeats()
        {
            return countOfSeats;
        }

        public double GetTicketPrice()
        {
            return ticketPrice;
        }

    }
}
