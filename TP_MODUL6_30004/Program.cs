using System;
using System.Diagnostics;

class SayaMusicTrack
{
    private int id;
    private int playCount;
    private string title;

    public SayaMusicTrack(string title)
    {
        Debug.Assert(title != null, "Judul tidak boleh null");
        Debug.Assert(title.Length <= 100, "Judul maksimal 100 karakter");

        if (title == null)
        {
            throw new ArgumentException("Judul tidak boleh null");
        }
        if (title.Length > 100)
        {
            throw new ArgumentException("Judul maksimal 100 karakter");
        }

        this.title = title;

        Random rand = new Random();
        this.id = rand.Next(10000, 100000);

        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        Debug.Assert(count > 0, "Play count harus > 0");
        Debug.Assert(count <= 10000000, "Maksimal 10.000.000");

        if (count <= 0)
        {
            Console.WriteLine("Input tidak valid (harus > 0)");
            return;
        }
        if (count > 10000000)
        {
            Console.WriteLine("Input melebihi batas maksimal");
            return;
        }

        try
        {
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Terjadi overflow! PlayCount terlalu besar.");
        }
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine("ID Lagu     : " + id);
        Console.WriteLine("Judul Lagu  : " + title);
        Console.WriteLine("Play Count  : " + playCount);
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            SayaMusicTrack lagu1 = new SayaMusicTrack("Mama papa larang");
            lagu1.IncreasePlayCount(5000);
            lagu1.PrintTrackDetails();
            SayaMusicTrack laguError = new SayaMusicTrack(null);

        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        SayaMusicTrack lagu2 = new SayaMusicTrack("Aku iki anak lanang");
        lagu2.IncreasePlayCount(-5);
        lagu2.IncreasePlayCount(20000000);
        for (int i = 0; i < 100; i++)
        {
            lagu2.IncreasePlayCount(10000000);
        }
        lagu2.PrintTrackDetails();
    }
}