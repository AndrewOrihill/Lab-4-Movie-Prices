using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviePrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I know you would like to go to the movies. " +
                "\nHowever, evening tickets are more expensive than matinee tickets. " +
                "\nAre you going in the evening? (True for yes; false for no.) ");
            bool isMovieEvening = bool.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease answer the following questions as numerical values:");

            Console.WriteLine("How many children are going with you? ");
            int numberOfChildTickets = int.Parse(Console.ReadLine());

            Console.WriteLine("How many adults are going with you? ");
            int numberOfAdultTickets = int.Parse(Console.ReadLine());

            Console.WriteLine("How many senior citizens are going with you? ");
            int numberOfSeniorTickets = int.Parse(Console.ReadLine());

            Console.WriteLine("Do not forget about the concessions! Please answer with numerical values:");

            Console.WriteLine("How many small sodas are you buying? Each one costs $3.50");
            int numberOfSmallSodas = int.Parse(Console.ReadLine());

            Console.WriteLine("How many large sodas are you buying? Each one costs $5.99");
            int numberOfLargeSodas = int.Parse(Console.ReadLine());

            Console.WriteLine("How many hotdogs are you buying? Each one costs $3.99");
            int numberOfHotdogs = int.Parse(Console.ReadLine());

            Console.WriteLine("How many popcorns are you buying? Each one costs $4.50");
            int numberOfPopcorns = int.Parse(Console.ReadLine());

            Console.WriteLine("How many candies are you buying? Each one costs $1.99");
            int numberOfCandies = int.Parse(Console.ReadLine());



            double ticketTotal = 0;



            if (isMovieEvening == false)
            {
                ticketTotal += (numberOfChildTickets * 3.99 + numberOfAdultTickets * 5.99 + numberOfSeniorTickets * 4.50);
            }
            else if (isMovieEvening == true)
            {
                ticketTotal += (numberOfChildTickets * 6.99 + numberOfAdultTickets * 10.99 + numberOfSeniorTickets * 8.50);
            }
            else
            {
                Console.WriteLine("Something went wrong...");
            }

            double concessionsTotal = (numberOfSmallSodas * 3.50 + numberOfLargeSodas * 5.99 + numberOfHotdogs * 3.99 + numberOfPopcorns * 4.50 + numberOfCandies * 1.99);

            double totalPrice = (ticketTotal + concessionsTotal);

            
            if ((numberOfPopcorns >= 1) && (numberOfLargeSodas >= 1) && ((numberOfChildTickets + numberOfAdultTickets + numberOfSeniorTickets) >= 1))
            {
                totalPrice -= 2.00;
            }

            if ((numberOfPopcorns >= 1) && ((numberOfChildTickets + numberOfAdultTickets + numberOfSeniorTickets) >= 3) && (isMovieEvening == true))
            {
                totalPrice -= 4.50;
            }

            int numberOfCandyDiscounts = numberOfCandies / 4;
            totalPrice -= (numberOfCandyDiscounts * 1.99);

            
            Console.WriteLine("Your total is $" + totalPrice + ". Please enjoy the show!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
