using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Async_Await.Weapon
{
    public class Weapon<T> : Bullet
    {
        public int[] weapon;
        public Weapon()
        {
            weapon = new int[0];

           
        }
       
       public static  int Id ;
        public string BulletName { get; set; }
        public int BulletNumber { get; set; }
        public static int Count;
        public void Fire(string bulletname,int bulletnum)
        {
            BulletName = bulletname;
            BulletNumber= bulletnum ;
            //Console.WriteLine("1 yazarsaniz 40 gulle 5,56 gulleli silah   2 yazarsaniz 60 gulle 7,62 silah");
           
                for (int i = 1; i < BulletNumber; i++)
                {
                    BulletNumber -= i;
                    Id++;
                    break;

                }
                Console.WriteLine($"Id {Id}  BulletName is {BulletName} BulletNumber is {BulletNumber} ");
            

        }

        public void Fill(int bulletnumber)
        {
            Array.Resize(ref weapon, weapon.Length+1);
            weapon[weapon.Length -1] = bulletnumber;
            foreach (var item in weapon)
            {
                Console.WriteLine( item);
            }

            //if (bulletnumber == BulletNumber && bulletname==BulletName)
            //{
            //    foreach (var item in weapon)
            //    {
            //   Console.WriteLine($"Gullelerin sayi {BulletNumber} Gullelerin Adi {BulletName}");
            //    }
            //}

        }

        public void PullTrigger()
        {
            for (int i = 1; i < BulletNumber; i++)
            {
                
                BulletNumber -= i;


                Console.WriteLine(BulletNumber);
                break;

            }
            



        }

    }
}
