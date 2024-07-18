using System.Security.Cryptography;

//Pirma uzduotis*****************************************************************************

//int metai = 2024;

//Console.WriteLine("Jusu vardas");
//string vardas = Console.ReadLine();

//Console.WriteLine("Jusu pavarde");
//string pavarde = Console.ReadLine();

//Console.WriteLine("Gimimo metai");
//int gimimoMetai = int.Parse(Console.ReadLine());

//int amzius = metai - gimimoMetai;

//Console.WriteLine("As esu " + vardas + " " + pavarde + ". " + "Man yra " + amzius + " metai.");

// Antra uzduotis*******************************************************************************

//Random pirmasSkaicius = new Random();
//Random antrasSkaicius = new Random();

//float pirmasKintamasis = pirmasSkaicius.Next(0, 4);
//float antrasKintamasis = antrasSkaicius.Next(0, 4);



//if (pirmasKintamasis > antrasKintamasis)
//{
//   float pirmasDidesnis = pirmasKintamasis / antrasKintamasis;
//    string suapvalintasPirmas = pirmasKintamasis.ToString("0.00");
//    Console.WriteLine("Pirmas skaicius didesnis, suapvalintas rezultatas: " + suapvalintasPirmas);
//}

//else
//{
//    float antrasDidesnis = antrasKintamasis / pirmasKintamasis;
//    string suapvalintasAntras = antrasKintamasis.ToString("0.00");
//    Console.WriteLine("Antras skaicius didesnis, suapvalintas rezultatas: " + suapvalintasAntras);
//}

// Trecia uzduotis***************************************************************************

//Random randomGenerator1 = new Random();
//Random randomGenerator2 = new Random();
//Random randomGenerator3 = new Random();

//int randomKintamasis1 = randomGenerator1.Next(0, 25);
//int randomKintamasis2 = randomGenerator2.Next(0, 25);
//int randomKintamasis3 = randomGenerator3.Next(0, 25);

//Console.WriteLine("Sugeneruoti skaiciai");
//Console.WriteLine(randomKintamasis1 + " " + randomKintamasis2 + " " + randomKintamasis3);

//if (randomKintamasis1 > randomKintamasis2 && randomKintamasis1 < randomKintamasis3 || randomKintamasis1 < randomKintamasis2 && randomKintamasis1 > randomKintamasis3)
//{
//    Console.WriteLine("Vidurine siu skaiciu reiksme yra " + randomKintamasis1);
//}

//else if (randomKintamasis2 > randomKintamasis1 && randomKintamasis2 < randomKintamasis3 || randomKintamasis2 < randomKintamasis1 && randomKintamasis2 > randomKintamasis3)
//{
//    Console.WriteLine("Vidurine siu skaiciu reiksme yra " + randomKintamasis2);
//}

//else if (randomKintamasis3 > randomKintamasis1 && randomKintamasis3 < randomKintamasis2 || randomKintamasis3 < randomKintamasis1 && randomKintamasis3 > randomKintamasis2)
//{
//    Console.WriteLine("Vidurine siu skaiciu reiksme yra " + randomKintamasis3);
//}

//else
//{
//    Console.WriteLine("Kazkurie sugeneruoti skaiciai yra vienodi");
//}

//Ketvirta uzduotis*******************************************************************************

//Random randomKrastine1 = new Random();
//Random randomKrastine2 = new Random();
//Random randomKrastine3 = new Random();

//int a = randomKrastine1.Next(1, 10);
//int b = randomKrastine2.Next(1, 10);
//int c = randomKrastine3.Next(1, 10);

//Console.WriteLine("Trikampio krastiniu ilgiai: a = " + a + "; b = " + b + "; c = " + c + ";"); 

//if (a + b > c && a + c > b && b + c > a)
//{
//    Console.WriteLine("Trikampi sudaryti galima");
//}

//else
//{
//    Console.WriteLine("Trikampio sudaryti negalima");
//}

//Penkta uzduotis*********************************************************************************

//Random randomSkaicius1 = new Random();
//Random randomSkaicius2 = new Random();
//Random randomSkaicius3 = new Random();
//Random randomSkaicius4 = new Random();

//int reiksme1 = randomSkaicius1.Next(0, 2);
//int reiksme2 = randomSkaicius2.Next(0, 2);
//int reiksme3 = randomSkaicius3.Next(0, 2);
//int reiksme4 = randomSkaicius4.Next(0, 2);

//int nuliuKiekis = 0;
//int vienetuKiekis = 0;
//int dvejetuKiekis = 0;

//Console.WriteLine("Sugeneruoti skaiciai: " + reiksme1 + " " + reiksme2 + " " + reiksme3 + " " + reiksme4);

//switch (reiksme1)
//{
//    case 0:
//        nuliuKiekis++; 
//        break;
//    case 1: 
//        vienetuKiekis++;
//        break;
//    case 2:
//        dvejetuKiekis++;
//        break;
//}

//switch (reiksme2)
//{
//    case 0:
//        nuliuKiekis++;
//        break;
//    case 1:
//        vienetuKiekis++;
//        break;
//    case 2:
//        dvejetuKiekis++;
//        break;
//}

//switch (reiksme3)
//{
//    case 0:
//        nuliuKiekis++;
//        break;
//    case 1:
//        vienetuKiekis++;
//        break;
//    case 2:
//        dvejetuKiekis++;
//        break;
//}

//switch (reiksme4)
//{
//    case 0:
//        nuliuKiekis++;
//        break;
//    case 1:
//        vienetuKiekis++;
//        break;
//    case 2:
//        dvejetuKiekis++;
//        break;
//}

//Console.WriteLine("Nuliu kiekis: " + nuliuKiekis);
//Console.WriteLine("Vienetu kiekis: " + vienetuKiekis);
//Console.WriteLine("Dvejetu kiekis: " + dvejetuKiekis);

//Sesta uzduotis*****************************************************************

//Random randomGenAgain1 = new Random();
//Random randomGenAgain2 = new Random();
//Random randomGenAgain3 = new Random();

//int reiksmeAgain1 = randomGenAgain1.Next(-10, 10);
//int reiksmeAgain2 = randomGenAgain2.Next(-10, 10);
//int reiksmeAgain3 = randomGenAgain3.Next(-10, 10);

//Console.WriteLine("Sugeneruoti skaiciai: ");

//if (reiksmeAgain1 < 0)
//{
//    Console.Write("[" + reiksmeAgain1 + "]");
//}

//else if (reiksmeAgain1 > 0)
//{
//    Console.Write("{" + reiksmeAgain1 + "}");
//}

//else
//{
//    Console.Write("(" + reiksmeAgain1 + ")");
//}


//if (reiksmeAgain2 < 0)
//{
//    Console.Write("[" + reiksmeAgain2 + "]");
//}

//else if (reiksmeAgain2 > 0)
//{
//    Console.Write("{" + reiksmeAgain2 + "}");
//}

//else
//{
//    Console.Write("(" + reiksmeAgain2 + ")");
//}


//if (reiksmeAgain3 < 0)
//{
//    Console.Write("[" + reiksmeAgain3 + "]");
//}

//else if (reiksmeAgain3 > 0)
//{
//    Console.Write("{" + reiksmeAgain3 + "}");
//}

//else
//{
//    Console.Write("(" + reiksmeAgain3 + ")");
//}


//Septinta uzduotis**********************************************************************

//Random zvakiuGen = new Random();

//int zvakiuSkaicius = zvakiuGen.Next(5, 3000);
//double zvakesKaina = 1;
//double visuZvakiuKaina = 0;
//double nuolaida1000 = 0.97;
//double nuolaida2000 = 0.96;

//Console.WriteLine("Perkama " + zvakiuSkaicius + " zvakiu(es)");

//if (zvakiuSkaicius > 1000 && zvakiuSkaicius < 2000)
//{
//    visuZvakiuKaina = zvakiuSkaicius * zvakesKaina * nuolaida1000;
//    zvakesKaina = zvakesKaina * nuolaida1000;
//}

//else if (zvakiuSkaicius > 2000)
//{
//    visuZvakiuKaina = zvakiuSkaicius * zvakesKaina * nuolaida2000;
//    zvakesKaina = zvakesKaina * nuolaida2000;
//}

//else
//{
//    visuZvakiuKaina = zvakiuSkaicius * zvakesKaina;
//}

//Console.WriteLine("Suma - " + visuZvakiuKaina);
//Console.WriteLine("Vienos zvakes kaina - " + zvakesKaina);


//Astunta uzduotis****************************************************************************************

//Random randomNew1 = new Random();
//Random randomNew2 = new Random();
//Random randomNew3 = new Random();

//int atsitiktine1 = randomNew1.Next(0, 100);
//int atsitiktine2 = randomNew2.Next(0, 100);
//int atsitiktine3 = randomNew3.Next(0, 100);

//int avg = 0;
//int avgExc = 0;

//int numNum = 3;

//avg = (atsitiktine1 + atsitiktine2 + atsitiktine3) / numNum;

//Console.WriteLine("Sugeneruoti skaiciai: " + atsitiktine1 + " " + atsitiktine2 + " " + atsitiktine3);

//Console.WriteLine("Sugeneruotu skaiciu vidurkis: " + avg);

//if (atsitiktine1 < 10 || atsitiktine1 > 90)
//{
//    atsitiktine1 = 0;
//    numNum--;
//}

//if (atsitiktine2 < 10 || atsitiktine2 > 90)
//{
//    atsitiktine2 = 0;
//    numNum--;
//}

//if (atsitiktine3 < 10 || atsitiktine3 > 90)
//{
//    atsitiktine3 = 0;
//    numNum--;
//}

//avgExc = (atsitiktine1 + atsitiktine2 + atsitiktine3) / numNum;

//Console.WriteLine("Skaiciu, isskyrus mazesnius nei 10 ir didesnius nei 90, vidurkis: " + avgExc);

// PAPILDOMA 9 uzduotis***************************************************************************

//Random hourGen = new Random();
//Random minuteGen = new Random();
//Random secondGen = new Random();
//Random extraGen = new Random();

//int hours = hourGen.Next(23);
//int minutes = minuteGen.Next(59);
//int seconds = secondGen.Next(59);

//int extraSec = extraGen.Next(300);

//Console.WriteLine(hours + ":" + minutes + ":" + seconds);

//if (seconds + extraSec < 60)
//{
//    seconds = seconds + extraSec;
//}

//else if (seconds + extraSec > 59 && seconds + extraSec <= 119)
//{
//    minutes++;
//    seconds = seconds + extraSec - 60;
//    if (minutes > 59)
//    {
//        hours++;
//        minutes = minutes - 60;
//        if (hours > 23)
//        {
//            hours = hours - 24;
//        }
//    }

//}

//else if (seconds + extraSec > 119 && seconds + extraSec <= 179)
//{
//    minutes += 2;
//    seconds = seconds + extraSec - 120;
//    if (minutes > 59)
//    {
//        hours++;
//        minutes = minutes - 60;
//        if (hours > 23)
//        {
//            hours = hours - 24;
//        }
//    }
//}

//else if (seconds + extraSec > 179 && seconds + extraSec <= 239)
//{
//    minutes = minutes + 3;
//    seconds = seconds + extraSec - 180;
//    if (minutes > 59)
//    {
//        hours++;
//        minutes = minutes - 60;
//        if (hours > 23)
//        {
//            hours = hours - 24;
//        }
//    }
//}

//else if (seconds + extraSec > 239 && seconds + extraSec <= 299)
//{
//    minutes = minutes + 4;
//    seconds = seconds + extraSec - 240;
//    if (minutes > 59)
//    {
//        hours++;
//        minutes = minutes - 60;
//        if (hours > 23)
//        {
//            hours = hours - 24;
//        }
//    }
//}

//else if (seconds + extraSec > 299)
//{
//    minutes = minutes + 5;
//    seconds = seconds + extraSec - 300;
//    if (minutes > 59)
//    {
//        hours++;
//        minutes = minutes - 60;
//        if (hours > 23)
//        {
//            hours = hours - 24;
//        }
//    }
//}



//Console.WriteLine("Ekstra sekundes: " + extraSec);
//Console.WriteLine(hours + ":" + minutes + ":" + seconds);

//PAPILDOMA 10 uzduotis***************************************************************

//Random newKintGen1 = new Random();
//Random newKintGen2 = new Random();
//Random newKintGen3 = new Random();
//Random newKintGen4 = new Random();
//Random newKintGen5 = new Random();
//Random newKintGen6 = new Random();

//int newKint1 = newKintGen1.Next(1000, 9999);
//int newKint2 = newKintGen2.Next(1000, 9999);
//int newKint3 = newKintGen3.Next(1000, 9999);
//int newKint4 = newKintGen4.Next(1000, 9999);
//int newKint5 = newKintGen5.Next(1000, 9999);
//int newKint6 = newKintGen6.Next(1000, 9999);


//PAPILDOMA 5 uzduotis*********************************************************************

//Console.WriteLine("Iveskite sveikaji skaiciu");
//int sveikasSkaicius = int.Parse(Console.ReadLine());

//int liekana = sveikasSkaicius % 2;

//if (liekana != 0)
//{
//    Console.WriteLine("Skaicius yra nelyginis");
//}

//else
//{
//    Console.WriteLine("skaicius yra lyginis");
//}


//10 nepadariau ir 6 is papildomu