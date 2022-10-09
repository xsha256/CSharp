// See https://aka.ms/new-console-template for more information

using System;

//string Name = "Moha";

//Console.WriteLine("Hello, " + Name.ToUpper() + "!");



////Data Type
//string Phrase = "Hola, World!";
//char letter = 'A';
//int age = 29;
//// for decimal number there's 3 options: float (less precise), double (normal) and decimal (more precise for money for exemple)
//double gpa = 3.3;
//bool isFemale = true;

//// To print a variable. Length to know how much character 
//Console.WriteLine(Phrase + " " + "(" + Phrase.Length + " Characters)");

//// Upper string
//string frase = "en mayuscula";
//Console.WriteLine(frase.ToUpper());

//// Lower string
//string frase2 = "EN MINISCULA";
//Console.WriteLine(frase2.ToLower());

//// Search if contain an word o phrase, the return is boolen (true or false)
//string frase3 = "Buenos días, hermano";
//Console.WriteLine(frase3.Contains("hermano"));

//// "\" before " to show " in terminal 
//Console.WriteLine("\"Hello, Hello!\"");

//// To print one lettre en phrase 
//string frase4 = "Iba a casa";
//Console.WriteLine(frase4[7]);

//// To look if there's a word or character in the phrase and it's position !!! -1 mean there isn't the character or word in the phrase or text
//string frase5 = "Siempre hay una solucion";
//Console.WriteLine(frase5.IndexOf("una"));

//Console.WriteLine(frase5.IndexOf('a'));


//// To grab some parte of word or al word in phrase or text 
//string frase6 = "It's a bubble";
//Console.WriteLine(frase6.Substring(7, 5)); // 7 is the position of letter, 5 the number of letter to display

//// To do calculation we should use method Math.'name of the oparation'
//Console.WriteLine(Math.Pow(2, 2));
//Console.WriteLine(Math.Sqrt(9));
//Console.WriteLine(Math.Max(9, 1000));

////To keep the terminal without exit
//Console.ReadLine();


// To ask the use to put info: (Diffrent between Write and WriteLine: Write doesn't start new line but WriteLine yes start new line after show the messege)
Console.Write("What's your name?: ");
string name = Console.ReadLine();
Console.Write("What's your age?: ");
string age = Console.ReadLine();

Console.WriteLine("Hello, " + name + "." + "Your age is: " + age);




//To keep the terminal without exit
Console.ReadLine();
