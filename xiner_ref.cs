using System;
public class Xiner_ref
{
    public Xiner_ref()
    {   
        Console.WriteLine("unknown 1128");
    }

    public void RefTest()
    {
        string temp = "a_temp";
        Change(temp);
        Console.WriteLine(temp);
    
        ChangeByRef(ref temp);
        Console.WriteLine(temp);
        Console.ReadKey();
    }



    
    private static void Change(string temp)
    {
        temp = temp + "--changed";
    }
    
    private static void ChangeByRef(ref string temp)
    {
        temp = temp + "--refchanged";
    } 
}