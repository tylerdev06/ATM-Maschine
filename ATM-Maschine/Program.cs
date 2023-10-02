int erwarteteKartennummer = 123456789;
int erwarteterPin = 1234;

Console.WriteLine("Willkommen bei der ATM-Maschine");
Console.WriteLine("Bitte geben Sie Ihre Kartennummer ein:");
string kartenummerEingabe = Console.ReadLine();
int kartenummer;

if (int.TryParse(kartenummerEingabe, out kartenummer) && kartenummer == erwarteteKartennummer)
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
int pin;

if (int.TryParse(pinEingabe, out pin) && pin == erwarteterPin)
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
