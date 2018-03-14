using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public class Game
    {
        List<Card> cards = new List<Card>();
        private int Bet { get; set; }
        public Game()
        {
            NewGame();
        }
        public void NewGame()
        {
            cards.Clear();
            cards.AddRange(new Card[] {
                new Card(Properties.Resources._6Бубна,6),
                new Card(Properties.Resources._6Крест,6),
                new Card(Properties.Resources._6Пик,6),
                new Card(Properties.Resources._6Червей,6),
                new Card(Properties.Resources._7Бубна,7),
                new Card(Properties.Resources._7Крест,7),
                new Card(Properties.Resources._7Пик,7),
                new Card(Properties.Resources._7Червей,7),
                new Card(Properties.Resources._8Бубна,8),
                new Card(Properties.Resources._8Крест,8),
                new Card(Properties.Resources._8Пик,8),
                new Card(Properties.Resources._8Червей,8),
                new Card(Properties.Resources._9Бубна,9),
                new Card(Properties.Resources._9Крест,9),
                new Card(Properties.Resources._9Пик,9),
                new Card(Properties.Resources._9Червей,9),
                new Card(Properties.Resources._10Бубна,10),
                new Card(Properties.Resources._10Крест,10),
                new Card(Properties.Resources._10Пик,10),
                new Card(Properties.Resources._10Червей,10),
                new Card(Properties.Resources._11Бубна,2),
                new Card(Properties.Resources._11Крест,2),
                new Card(Properties.Resources._11Пик,2),
                new Card(Properties.Resources._11Червей,2),
                new Card(Properties.Resources._12Бубна,3),
                new Card(Properties.Resources._12Крест,3),
                new Card(Properties.Resources._12Пик,3),
                new Card(Properties.Resources._12Червей,3),
                new Card(Properties.Resources._13Бубна,4),
                new Card(Properties.Resources._13Крест,4),
                new Card(Properties.Resources._13Пик,4),
                new Card(Properties.Resources._13Червей,4),
                new Card(Properties.Resources._14Бубна,11),
                new Card(Properties.Resources._14Крест,11),
                new Card(Properties.Resources._14Пик,11),
                new Card(Properties.Resources._14Червей,11)});
            Sort();
        }
        private void Sort()
        {
            Random r = new Random();
            SortedList<int, Card> mixedList = new SortedList<int, Card>();
            foreach (Card item in cards)
                mixedList.Add(r.Next(), item);
            cards.Clear();
            for (int i = 0; i < mixedList.Count; i++)
            {
                cards.Add(mixedList.Values[i]);
            }
        }
        public Card GetCard()
        {
            Card card = cards.First();
            MessageBox.Show(card.CountPoint.ToString());
            cards.Remove(cards.First());
            return card;
        }
        public void SetBet(int money)
        {
            Bet = money;
        }
        public int GetBet()
        {
            return Bet;
        }
    }
}
