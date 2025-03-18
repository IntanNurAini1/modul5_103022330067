using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;
    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void addNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data: " + storedData[i] + " Date: " + inputDates[i]);
        }
    }
}

public class PemrosesData
{
    public void DapatkanNilaiTerbesar<T>(T nilai1, T nilai2, T nilai3)
    {
        dynamic a = (dynamic)nilai1;
        dynamic b = (dynamic)nilai2;
        dynamic c = (dynamic)nilai3;
        if (a > b && a > c)
        {
            Console.WriteLine("Nilai terbesar adalah: " + a);
        }
        else if (b > a && b > c)
        {
            Console.WriteLine("Nilai terbesar adalah: " + b);
        }
        else
        {
            Console.WriteLine("Nilai terbesar adalah: " + c);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        SimpleDataBase<int> db = new SimpleDataBase<int>();
        Console.Write("Input data: ");
        int data = Convert.ToInt32(Console.ReadLine());
        db.addNewData(data);
        Console.Write("Input data: ");
        int data1 = Convert.ToInt32(Console.ReadLine());
        db.addNewData(data1);
        Console.Write("Input data: ");
        int data2 = Convert.ToInt32(Console.ReadLine());
        db.addNewData(data2);
        db.PrintAllData();
        PemrosesData pemrosesData = new PemrosesData();
        Console.Write("Masukkan nilai 1: ");
        int nilai1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukkan nilai 2: ");
        int nilai2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukkan nilai 3: ");
        int nilai3 = Convert.ToInt32(Console.ReadLine());
        pemrosesData.DapatkanNilaiTerbesar(nilai1, nilai2, nilai3);
    }
}


