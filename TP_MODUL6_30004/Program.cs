using System;
using System.Security.Cryptography.X509Certificates;
class SayaMusicTrack
{
    private int id;
    private int playCount;
    private string title;
    public SayaMusicTrack(string title)
    {
        this.title = title;
        Random count = new Random();
        this.id = count.Next(10000, 100000);
        this.playCount = 0;
    }
    public void IncreasePlayCount(int count)
    {
        if (count > 0)
        {
            this.playCount += count;
        }
    }
    public void PrintTrackDetails()
    {
        Console.WriteLine("ID: " + this.id);
        Console.WriteLine("PlayCount: " + this.playCount);
        Console.WriteLine("Title: " + this.title);
    }
}
class main
{
    public static void Main(string[] args)
    {
        SayaMusicTrack m1 = new SayaMusicTrack("Mama papa larang");
        SayaMusicTrack m2 = new SayaMusicTrack("Aku iki anak lanang");

        m1.IncreasePlayCount(10);
        m2.IncreasePlayCount(44);

        m1.PrintTrackDetails();
        m2.PrintTrackDetails();
    }
}