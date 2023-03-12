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