using System;
//Exceeded requirements by creating an extra menu option to remove the most recent entry from the journal. A corresponding method was created in Journal called RemoveLast() Useful if there was a mistake.
class Program
{
    static void Main(string[] args)
    {
        int menu;
        Journal journal = new Journal();
        do
        {
            menu = Menu();
            if (menu == 1)
            {
                journal.Add();
            }
            if (menu == 2)
            {
                journal.Display();
            }
            if (menu == 3)
            {
                journal.Save(FileName());
            }
            if (menu == 4)
            {
                journal.Load(FileName());
            }
            if (menu == 5)
            {
                journal.RemoveLast();
            }
        }while(menu < 6 && menu >0);
    }
    static int Menu()
    {
        Console.WriteLine("What would you like to do? (Enter the number)");
        Console.WriteLine("0. Quit");
        Console.WriteLine("1. New entry");
        Console.WriteLine("2. Display journal");
        Console.WriteLine("3. Save journal");
        Console.WriteLine("4. Load journal");
        Console.WriteLine("5. Delete last entry" );
        int menu = int.Parse(Console.ReadLine());

        return menu;
    }
    static string FileName()
    {
        Console.WriteLine("What is the file name? ");
        return Console.ReadLine();
    }
}

