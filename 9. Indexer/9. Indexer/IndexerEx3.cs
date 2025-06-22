using System;

namespace _9.Indexer
{
    public class BCA5Sem
    {
        private string[] subject_name = new string[5];

        public object this[int index]
        {
            set
            {
                 subject_name[index] = (string)value ;
            }
            get
            {
                return subject_name[index];
            }
        }
    }
    


    class IndexerEx3
    {
        public static void Main()
        {
            BCA5Sem f = new BCA5Sem();
            f[0] = "MIS and EBusiness";
            f[1] = "Dot Net Technology";
            f[2] = "Computer Network";
            f[3] = "Introductin to Management";
            f[4] = "Computer Graphics and Animation";

            Console.WriteLine("BCA Fifth Sem Subject");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(f[i]);
            }
        }
    }
}
