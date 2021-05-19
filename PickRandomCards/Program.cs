﻿using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");
            string line = Console.ReadLine();

            if (int.TryParse(line, out int numberOfCards))
            {
                // this block is executed if line COULD be converted to an int
                // value that's stored in a new variable called numberOfCards
                string[] cards = CardPicker.PickSomeCards(numberOfCards);
                foreach (string card in cards)
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                // this block is executed if line COULD NOT be converted to an int
                Console.WriteLine("Not a valid number.");
            }
        }
    }
}
