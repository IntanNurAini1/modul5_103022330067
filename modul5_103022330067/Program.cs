using System;

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

public class Program
{
    public static void Main()
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
    }
}