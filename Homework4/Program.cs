using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            var train = new Train("vagon", 10, "160km/c", 80, 5, 7500, true);

            Train[] trains = new Train[6];

        }
    }

    public partial class Train
    {
        public void SetTicketPrice(double ticketPrice)
        {
            this.ticketPrice = ticketPrice;
        }
    }
}
