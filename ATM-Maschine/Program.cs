internal class Program
{
    private static void Main(string[] args)
    {
        string erwarteteKartennummer = "123456789"; 
        string erwarteterPin = "1234";

        Console.WriteLine("Haben Sie schon einen Account? (ja/nein)");
        string accountabfrage = Console.ReadLine();

        if (accountabfrage  == "nein")
        {
            Console.WriteLine("Dann beantragen Sie eine Kreditkarte.");
            return;
        } 

        Console.WriteLine("Willkommen bei der ATM-Maschine");
        Console.WriteLine("Bitte geben Sie Ihre Kartennummer ein:");
        string kartenummerEingabe = Console.ReadLine();

        if (kartenummerEingabe == erwarteteKartennummer)
        {
            Console.WriteLine("Ihre Kartennummer wurde erfolgreich überprüft!");
        }
        else
        {
            Console.WriteLine("Ihre Kartennummer ist falsch!");
            return;
        }

        Console.WriteLine("Bitte geben Sie Ihre PIN ein:");
        string pinEingabe = Console.ReadLine();

        if (pinEingabe == erwarteterPin)
        {
            Console.WriteLine("Ihre PIN wurde erfolgreich überprüft!");
        }
        else
        {
            Console.WriteLine("Ihre PIN ist falsch!");
            return;
        }

        Console.WriteLine("Bitte geben Sie den Betrag ein, den Sie abheben möchten:");
        string betragEingabe = Console.ReadLine();

        Console.WriteLine("Bitte warten Sie, während wir Ihre Daten überprüfen...");
        Console.WriteLine("Ihre Daten wurden erfolgreich überprüft!");
        Console.WriteLine("Ihr Aktueller Kontostand ist: " + betragEingabe);
    }
}
