using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Card
    {
        public Image ImageCard { get; }
        public int CountPoint { get; }
        public Card(Image image,int point)
        {
            this.ImageCard = image;
            this.CountPoint = point;
        }
    }
}
