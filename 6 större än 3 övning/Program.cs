// // // if (6 >= 3)
// // {

// // Console.WriteLine("Hello word");
// // }


// // // Console.ReadLine()
// string lös;
// Console.WriteLine("Hej vad heter du?");
// string name = Console.ReadLine();

// Console.WriteLine("Okej vad är ditt lösenord");
// lös = Console.ReadLine();


// if (name == "noname")
// {
//     if (lös == "nopass")
//     {
//         Console.WriteLine("Välkommen");
//     }
//     else
//     {
//         Console.WriteLine("Fel namn eller lösenord");
// //     }

// // }




// Console.ReadLine();


// for (int wew = 0; wew <32; wew++)
// {
//     Console.WriteLine("Welcome world!");    
// }

// Console.ReadLine();

// string pas = "";
// Console.WriteLine("skriv rätt lösenord");
// while (pas != "nopass")
// {
//     pas = Console.ReadLine();
// }

// Console.ReadLine();

// for (int kör = 0; kör < 5; kör++)
// {
//     Console.WriteLine("skriv ett nummer 1-5");
//     string num = Console.ReadLine();
//     int n = 0;
//     int.TryParse(num, out n);
//     if (n > 5)
//     {
//         Console.WriteLine("Högre en fem!");
//     }
//     else if (n < 5)
//     {
//         Console.WriteLine("Det är mindre en fem");
//     }


// }

// Console.ReadLine();

// int target = 0;
// bool success = false;

// while (success == false)
// {
//     Console.WriteLine("skriv ett tal");
//     String num = Console.ReadLine();

//     success = int.TryParse(num, out target);
// }

// Console.ReadLine();


int tal = 0;

while (tal != 7)
{
    bool success = false;

    while (success == false)
    {
        Console.WriteLine("Gissa rätt sifra mellan 1-10");
        String num = Console.ReadLine();
        success = int.TryParse(num, out tal);
    }

    if(tal < 7)
    {
        Console.WriteLine("Talet är större");
    }
    else if (tal > 7)
    {
        Console.WriteLine("Talet är mindre");
    }
    else
    {
    Console.WriteLine("Rätt svar");
    }

}


Console.ReadLine();