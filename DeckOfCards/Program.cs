using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            DeckOfCards myCards = new DeckOfCards();

            Console.WriteLine("Welcome To Card-Dealer");
            Console.WriteLine();

            Console.WriteLine("What Would You Like Me To Do.");
            Console.WriteLine();
            Console.WriteLine("Press a Number");
            Console.WriteLine();
            Console.WriteLine("[ 1 ] To Shuffle the Cards.");
            Console.WriteLine("[ 2 ] To Deal one Card from Shuffled Deck of Cards.");
            Console.WriteLine("[ 3 ] To Deal Whole Shuffled Deck of Cards.");
            Console.WriteLine("[ 0 ] To Exit.");
            Console.WriteLine();

            char input = ' ';

            while(input != '0')
            {
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.WriteLine();

                switch (input)
                {
                    case '1':
                        Console.WriteLine("Succesfully Shuffled the Cards.");
                        Console.WriteLine();
                        myCards.Shuffle();
                        break;

                    case '2':
                        Console.WriteLine("Here is the First Card Of the Shuffled Deck of Cards.");
                        Console.WriteLine();
                        myCards.DealACard();
                        break;

                    case '3':
                        Console.WriteLine("Here is the Shuffled Deck of Cards.");
                        Console.WriteLine();
                        myCards.DealADeck();
                        break;
                }
            }
        }
    }
}
