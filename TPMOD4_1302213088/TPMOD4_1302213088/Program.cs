// See https://aka.ms/new-console-template for more information

public class KodePost
{
    public enum kelurahan { batununggal, kujangsari, mengger, weters, cijaura, jatisari, margasari, sekajati, kebonwaru, maleer, samoja }
    public static int getKodePost(kelurahan kel)
    {
        int[] kodepost = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
        return kodepost[(int)kel];
    }
}

public class doorMachine
{
    enum state { terkunci, terbuka};

    public static void Main()
    {
        int getKodePost = KodePost.getKodePost(KodePost.kelurahan.kujangsari);
        Console.WriteLine(getKodePost);
        Console.WriteLine();

        state state1 = state.terkunci;
        string[] kondisi = { "Pintu terkunci", "Pintu terbuka" };
        while (state1 != null)
        {
            Console.WriteLine(kondisi[(int)state1]);
            Console.WriteLine();
            Console.WriteLine("Masukkan perintah: ");

            string perintah = Console.ReadLine();
            switch (state1)
            {
                case state.terkunci:
                    if (perintah == "Kunci pintu")
                    {
                        state1 = state.terkunci;
                    }
                    else if (perintah == "Buka pintu")
                    {
                        state1 = state.terbuka;
                    }
                    else
                    {
                        state1 = state.terkunci;
                        Console.WriteLine("Perintah salah");
                    }
                    Console.WriteLine();
                    break;

                case state.terbuka:
                    if (perintah == "Kunci pintu")
                    {
                        state1 = state.terkunci;
                    }
                    else if (perintah == "Buka pintu")
                    {
                        state1 = state.terbuka;
                    }
                    else
                    {
                        state1 = state.terbuka;
                        Console.WriteLine("Perintah salah");
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    break;
            }
        }
    }
                
}