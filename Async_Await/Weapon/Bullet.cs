using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Await.Weapon
{
    public class Bullet
    {

        public string Typeaa { get; set; }
        public static int Id { get; set; }
        public  Bullet()
        {
            Id++; 
        }



    }
}
