using System;


public class laptop {

    private string brand ="MSI";
    private string model="Utron700";
    public void LaptopDetails()
    {

        Console.WriteLine($"Laptop: {brand}");
        Console.WriteLine($"Model: {model}");

    }
    private void MotherBoardInfo() {

        Console.WriteLine("MotherBoard Information");

    }
    public static void Main() {

        laptop obj = new();
        obj.MotherBoardInfo();
        obj.LaptopDetails();

    
    }
}