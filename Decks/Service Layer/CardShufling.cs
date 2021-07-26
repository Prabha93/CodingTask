using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Decks.Service_Layer
{
    public class CardShufling
    {
        static Random r = new Random();      
        static public void Shuffle(int[] deck)
        {
            for (int n = deck.Length - 1; n > 0; --n)
            {
                int k = r.Next(n + 1);
                int temp = deck[n];
                deck[n] = deck[k];
                deck[k] = temp;
            }
        }
    }
}
