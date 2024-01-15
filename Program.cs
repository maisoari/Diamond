using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x;                      //Muttujaan x talletetaan luettu rivien määrä
            int n = 0, y = 0, m = 0;   

            Console.WriteLine("Anna yläosan rivien määrä");  //Käsketään käyttäjää antamaan timantin
                                                           // yläosan rivien määrä
            x = Console.ReadLine();                     //Talletetaan rivien määrä muttujaan (x)
            n = Convert.ToInt32(x);                 //Muutetaan rivien määrä (x) kokonaisluvuksi (n)

            m = n;                          //Talletetaan (n) myös apumuuttujaan (m)

            //Console.WriteLine(y);

            //_______Tulostetaan ensin timantin yläosa ________________________________________________

            for (int i = 0; i < n; i++)     //for-luuppi käy läpi luvut (0->n), n=yläosan rivien määrä
            {   
                     for(int z=m; z>0; z--)    //Tulostetaan jokaisen rivin alkuun riittävä määrä väilyöntejä
                     { Console.Write(" "); }   //for-luupin, apumuuttujan (m) ja kierrosmuttujan (z) avulla

                         m = m - 1;          //kun (m) pienenee, niin jokaisen rivin alkuun tulee yksi vähemmän
                                            //välilyötejä, kun mennään timantin kesikohtaa kohti
                
                for (int j=0; j <= y; j++)  //tämä for-luuppi tulostaa (*) merkit. Ensimmäiselle riville tulee
                {                           //yksi merkki ja sitä seuraaville riveille aina kaksi merkkiä lisää

                    Console.Write("*");    //(*) merkin tulostus
                }
                     y = y + 2;         //kun lisätään (y):tä aina kahdella, saadaan aina kaksi merkkiä lisää

                Console.WriteLine();   //tässä siirrytään seuraavalle riville
            }

            //______Sitten tulostetaan timantin alaosa______________________________________________________

            y = y - 2;  //vähennetään (y):stä ylimääräiset 2, joka lisättin yläosan tulostuksen jälkeen.
            y = y - 2;  //vähennetään myös ylimääriset 2, koska alaosan yläosassa on kaksi tähteä vähemmän
                            //kuin yläosan alaosassa.
           
            n = n - 1;
            m = n;
            for (int i = 0; i < n; i++)
            { 
                m = m + 1;

                for (int z = n; z <= m; z++) { Console.Write(" "); }
               


                for (int j = 0; j <= y; j++)
                {
                    Console.Write("*");
                }
                y = y - 2;

                Console.WriteLine();
            }








            Console.ReadLine();
        }
    }
}
