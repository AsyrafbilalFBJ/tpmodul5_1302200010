using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302200010
{
    class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(String a, int b)
        {
            Debug.Assert(a.Length <= 100 && a.Length != null, "Karakter Judul kurang dari 100 dan tidak boleh kosong");
            Random rnd = new Random();
            id = rnd.Next(0, 100000);
            string dig5 = id.ToString("D5");
            title = a;
            playCount = b;
        }
        public int increasePlayCount(int a)
        {
            Debug.Assert(a <= 10000000, "Maksimal play count adalah 10.000.000");
            Debug.Assert(a <= int.MaxValue);
            try
            {
                playCount = checked(a);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("play count melebihi batas overflow"+ e.Message);
                playCount = 0;
            }
            return playCount;
        }
        public void printVideoDetails()
        {
            Console.WriteLine("id           : " + id);
            Console.WriteLine("title        : " + title);
            Console.WriteLine("play count   : " + playCount);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo obj = new SayaTubeVideo("Tutorial Design By Contract – Asyraf.", 0);
            obj.increasePlayCount(100); 
            obj.printVideoDetails();
            Console.ReadKey();
        }
    }
}
