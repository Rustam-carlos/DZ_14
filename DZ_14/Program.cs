using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Сколько игроков?");
            int cntplayer = int.Parse(Console.ReadLine());
            string[] suit = { "C", "D", "S", "H" };
            int[] cartInt = new int[] { 6, 7, 8, 9, 10 };
            string[] cartString = new string[] { "J", "Q", "K", "A" };
            Game<int> game1 = new Game<int>();
            Game<string> game2 = new Game<string>();
            int cntcart = 1;
            game1.ShowCart(cartInt, suit, cntcart);
            game1.RandomizerCarts(cartInt, suit, cntcart);
            cntcart = 21;
            game2.ShowCart(cartString, suit, cntcart);
            game2.RandomizerCarts(cartString, suit, cntcart);
            Console.ReadLine();
            Console.Clear();
            Game<int>[] players = new Game<int>[cntplayer];
            Game<string>[] players1 = new Game<string>[cntplayer];
            for (int i = 0; i < cntplayer; i++)
            {
                Console.WriteLine($"{i + 1}-players cards = ");
                players[i].cartNumber[];
                players1[i].Razd(cntplayer, 7, cartString, suit);
            }
        }
    }
}
