﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class DeckOfCards
    {
        public int Index { get; set; } = 0;

        public List<Card> Cards { get; set; } = new List<Card>();

        public DeckOfCards()
        {
            Cards.Add(new Card("Ace", "Hearts"));
            Cards.Add(new Card("2", "Hearts"));
            Cards.Add(new Card("3", "Hearts"));
            Cards.Add(new Card("4", "Hearts"));
            Cards.Add(new Card("5", "Hearts"));
            Cards.Add(new Card("6", "Hearts"));
            Cards.Add(new Card("7", "Hearts"));
            Cards.Add(new Card("8", "Hearts"));
            Cards.Add(new Card("9", "Hearts"));
            Cards.Add(new Card("10", "Hearts"));
            Cards.Add(new Card("Jack", "Hearts"));
            Cards.Add(new Card("Queen", "Hearts"));
            Cards.Add(new Card("King", "Hearts"));

            Cards.Add(new Card("Ace", "Spades"));
            Cards.Add(new Card("2", "Spades"));
            Cards.Add(new Card("3", "Spades"));
            Cards.Add(new Card("4", "Spades"));
            Cards.Add(new Card("5", "Spades"));
            Cards.Add(new Card("6", "Spades"));
            Cards.Add(new Card("7", "Spades"));
            Cards.Add(new Card("8", "Spades"));
            Cards.Add(new Card("9", "Spades"));
            Cards.Add(new Card("10", "Spades"));
            Cards.Add(new Card("Jack", "Spades"));
            Cards.Add(new Card("Queen", "Spades"));
            Cards.Add(new Card("King", "Spades"));

            Cards.Add(new Card("Ace", "Diamonds"));
            Cards.Add(new Card("2", "Diamonds"));
            Cards.Add(new Card("3", "Diamonds"));
            Cards.Add(new Card("4", "Diamonds"));
            Cards.Add(new Card("5", "Diamonds"));
            Cards.Add(new Card("6", "Diamonds"));
            Cards.Add(new Card("7", "Diamonds"));
            Cards.Add(new Card("8", "Diamonds"));
            Cards.Add(new Card("9", "Diamonds"));
            Cards.Add(new Card("10", "Diamonds"));
            Cards.Add(new Card("Jack", "Diamonds"));
            Cards.Add(new Card("Queen", "Diamonds"));
            Cards.Add(new Card("King", "Diamonds"));

            Cards.Add(new Card("Ace", "Clubs"));
            Cards.Add(new Card("2", "Clubs"));
            Cards.Add(new Card("3", "Clubs"));
            Cards.Add(new Card("4", "Clubs"));
            Cards.Add(new Card("5", "Clubs"));
            Cards.Add(new Card("6", "Clubs"));
            Cards.Add(new Card("7", "Clubs"));
            Cards.Add(new Card("8", "Clubs"));
            Cards.Add(new Card("9", "Clubs"));
            Cards.Add(new Card("10", "Clubs"));
            Cards.Add(new Card("Jack", "Clubs"));
            Cards.Add(new Card("Queen", "Clubs"));
            Cards.Add(new Card("King", "Clubs"));

            Shuffle();
        }

        public void Shuffle()
        {
            Index = 0;

            Cards = Cards.OrderBy(a => Guid.NewGuid()).ToList();
        }

        public void DealACard()
        {
            if(Index <= 51 && Index >= 0)
            {
                Console.WriteLine(Cards[Index].Name);

                Index++;
            }
            else
            {
                Console.WriteLine("That Was The Last Card.");
            }
        }

        public void DealADeck() 
        {
            foreach (Card card in Cards)
            {
                Console.WriteLine(card.Name);
            }
        }
    }
}
