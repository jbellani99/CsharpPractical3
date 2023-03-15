using System;
using System.Globalization;

public class Sponsor{
    protected String Owner = "Ratukeen";

}
public class team  : Sponsor
{
    private String teamName="Naruto";

    public String printInfo() {

      //  string conacateString = " Owner Name: " + Owner + " TeamName: " + teamName;

        string conacateString=string.Concat(Owner,teamName);
        return conacateString;
    
    }

    public static void Main(String[] args) { 
    
        team obj=new team();
        string temp=obj.printInfo();
        Console.WriteLine("Owner Name "+temp+" Sponser");

    }

        }