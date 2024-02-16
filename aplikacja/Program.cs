string name = "Ewa";
string sex = "Mężczyzna";
var age = 30;

if (sex == "Kobieta")
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta ponizej 30 lat");
    }
    else if (age == 30 && name == "Ewa")
    {
        Console.WriteLine("Ewa ma 30 lat");
    }
}
else if (sex == "Mezczzyzna" && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
