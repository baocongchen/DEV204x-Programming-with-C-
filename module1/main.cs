using System.IO;
using System;

class Program
{
    static void Main()
    {
        //Student Info
        string first_name = "Ben";
        Console.WriteLine(first_name);
        string last_name = "Amy";
        Console.WriteLine(last_name);
        DateTime birth_day = new DateTime(1975,4,30);
        Console.WriteLine(birth_day);
        string address = "1/1, Pasteur, district 3";
        Console.WriteLine(address);
        string city = "Saigon";
        Console.WriteLine(city);
        string country = "Republic of South Vietnam";
        Console.WriteLine(country);
        int zip = 1975;
        Console.WriteLine(zip);
        //Professor Info
        string prof_name = "Henri";
        Console.WriteLine(prof_name);
        string prof_office = "School of Law";
        Console.WriteLine(prof_office);
        //Degree Info
        string degree_name = "Juris Doctor";
        Console.WriteLine(degree_name);
        int degree_credits = 130;
        Console.WriteLine(degree_credits);
        //University Program
        string program_name = "Constitutional Law";
        Console.WriteLine(program_name);
        string degree_offers = "Bachelor, Master, PhD";
        Console.WriteLine(degree_offers);
        string department = "Law Department";
        Console.WriteLine(department);
        //Course Info
        string info = "This will follow from the basic introduction to and foundation for the course laid during first year by the course in Public Law. The course makes an effort to integrate division of powers, Charter and Aboriginal rights discussion to highlight both points of overlap and points of departure.";
        Console.WriteLine(info);
    }
}
