using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public class GamerEventArgs : EventArgs
    {
        public int Money { get; set; }
        public GamerEventArgs(int Money)
        {
            this.Money = Money;
        }
    }
    public class Gamer
    {
        public EventHandler<GamerEventArgs> ChangeMoney;
        List<Card> cards = new List<Card>();
        private int money=1000;

        public int Money
        {
            get { return money; }
            set { money = value;
                ChangeMoney?.Invoke(this, new GamerEventArgs(money));
            }
        }
        public void SetCard(Card card)
        {
            cards.Add(card);
        }
        public int GetPoints()
        {
            int sum = 0;
            for(int i=0;i<cards.Count;i++)
            {
                //MessageBox.Show(cards[i].ImageCard.ToString()+ cards[i].CountPoint.ToString());
                sum += cards[i].CountPoint;
            }
            return sum;
        }
        public void Clear()
        {
            cards.Clear();
        }

    }
}
