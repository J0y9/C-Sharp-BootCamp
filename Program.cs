//1. Write a C# Sharp program to compute the sum of the two numerical values. If the two values are the same, return triple their sum.
static int TripleTheSum(int x,int y){
    return x==y? (x+y)*3 : x+y;
  }
Console.WriteLine (TripleTheSum(1,2));
Console.WriteLine (TripleTheSum(3,2));
Console.WriteLine (TripleTheSum(2,2));

//2. Write a C# Sharp program to get the absolute difference between n and 51. If n is broader than 51 return triple the absolute difference
static int TripleTheAbsoluteDifference(int n){
    int result = Math.Abs(n - 51);
    return n > 51 ? result * 3 : result;
}
    Console.WriteLine (TripleTheAbsoluteDifference(53));
    Console.WriteLine (TripleTheAbsoluteDifference(30));
    Console.WriteLine (TripleTheAbsoluteDifference(51));

// 3. Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.
static bool Thirty(int x,int y){
    return x == 30 || x+y == 30 || y == 30  ;
}
    Console.WriteLine (Thirty(30, 0));
    Console.WriteLine (Thirty(25, 5));
    Console.WriteLine (Thirty(20, 30));
    Console.WriteLine (Thirty(20, 25));

// 4. Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.
static bool WithinHundred(int x){
    return  (x >= 90 && x <= 110) || (x >= 190 && x <= 210);
}
    Console.WriteLine (WithinHundred(103));
    Console.WriteLine (WithinHundred(90));
    Console.WriteLine (WithinHundred(89));

// 5. Write a C# Sharp program to create a string where 'if' is added to the front of a given string. If the string already begins with 'if', return it unchanged.
static String StartWithIf(string s){
    return s.StartsWith("if") ? s : s.Insert(0,"if ");
}
    Console.WriteLine (StartWithIf("if else"));
    Console.WriteLine (StartWithIf("else"));

//6. Write a C# Sharp program to remove the character at a given position in the string. The given position will be in the range 0..(string length -1) inclusive.
static String RemoveAt(string s, int index){
    return (index >=0 && index <= s.Length -1)? s.Remove(index,1) : "index out of range";
}
    Console.WriteLine (RemoveAt("Python",1));
    Console.WriteLine (RemoveAt("Python",0));
    Console.WriteLine (RemoveAt("Python",4));

// 7. Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
static String ReplaceStartWithEnd(string s){
    return s.Length > 1 ? $"{s[s.Length-1]}{s.Substring(1,s.Length-2)}{s[0]}" : s;
}
    Console.WriteLine (ReplaceStartWithEnd("abcd"));
    Console.WriteLine (ReplaceStartWithEnd("a"));
    Console.WriteLine (ReplaceStartWithEnd("xyz"));

// 8. Write a C# Sharp program to create a string which is 4 copies of the 2 front characters of a given string. If the given string length is less than 2 return the original string.
static String CopyFirstTwo(string s){
    return s.Length >= 2 ? $"{s.Substring(0,2)}{s.Substring(0,2)}{s.Substring(0,2)}{s.Substring(0,2)}" : s;
}
    Console.WriteLine (CopyFirstTwo("C Sharp"));
    Console.WriteLine (CopyFirstTwo("JS"));
    Console.WriteLine (CopyFirstTwo("a"));

// 9. Write a C# Sharp program to create a string with the last char added at the front and back of a given string of length 1 or more.
static String AddLastChar(string s){
    return s.Length >= 1 ? $"{s.Last()}{s}{s.Last()}" : s;
}
    Console.WriteLine (AddLastChar("Red"));
    Console.WriteLine (AddLastChar("Green"));
    Console.WriteLine (AddLastChar("1"));

// 10. Write a C# Sharp program to check if a given positive number is a multiple of 3 or 7.
static bool MultipleOf3And7(int n){
    return (n % 3 == 0 || n%7==0) ; }
    Console.WriteLine (MultipleOf3And7(3));
    Console.WriteLine (MultipleOf3And7(14));
    Console.WriteLine (MultipleOf3And7(12));
    Console.WriteLine (MultipleOf3And7(37));

// 11. Write a C# Sharp program to create a string taking the first 3 characters of a given string. Return the string with the 3 characters added at both the front and back. If the given string length is less than 3, use whatever characters are there.
static String AddFirstThree(String s){
    return s.Length >= 3? s.Remove(3) + s + s.Remove(3) : s+s+s;
}
    Console.WriteLine (AddFirstThree("Python"));
    Console.WriteLine (AddFirstThree("JS"));
    Console.WriteLine (AddFirstThree("Code"));

// 12. Write a C# Sharp program to check if a given string starts with 'C#' or not.
static bool IsCSharp(String s){
 return s.StartsWith("C#");
}
    Console.WriteLine (IsCSharp("C# Sharp"));
    Console.WriteLine (IsCSharp("C#"));
    Console.WriteLine (IsCSharp("C++"));

// 13. Write a C# Sharp program that checks whether one temperature is less than 0 and another is greater than 100.
static bool IsBetweenNegativeAnd100(int x,int y){
    return (x < 0 && y > 100) || (x > 100 && y < 0);
}
    Console.WriteLine (IsBetweenNegativeAnd100(120, -1));
    Console.WriteLine (IsBetweenNegativeAnd100(-1, 120));
    Console.WriteLine (IsBetweenNegativeAnd100(2, 120));

//14. Write a C# Sharp program to check two given integers whether either of them is in the range 100..200 inclusive.
static bool IsBetween100And200(int x,int y){
    return (x >= 100 && x <= 200) || (y >= 100 && y <= 200);
}
    Console.WriteLine (IsBetween100And200(100, 199));
    Console.WriteLine (IsBetween100And200(250, 300));
    Console.WriteLine (IsBetween100And200(105, 190));

// 15. Write a C# Sharp program to check whether three given integer values are in the range 20..50 inclusive. Return true if 1 or more of them are in the said range otherwise false.
static bool IsBetween20And50(int x,int y, int z){
    return (x >= 20 && x <= 50) ||  (y >= 20 && y <= 50)  || (z >= 20 && z <= 50);
}
    Console.WriteLine (IsBetween20And50(11, 20, 12));
    Console.WriteLine (IsBetween20And50(30, 30, 17));
    Console.WriteLine (IsBetween20And50(25, 35, 50));
    Console.WriteLine (IsBetween20And50(15, 12, 8));

//16. Write a C# Sharp program to check whether two given integer values are in the range 20..50 inclusive. Return true if 1 or other is in the range, otherwise false.
static bool IsBetween20And50p2(int x,int y){
    bool isFirstTrue = x >= 20 && x <= 50;
    bool isSecondTrue = y >= 20 && y <= 50;
    return (isFirstTrue && !isSecondTrue) || (!isFirstTrue && isSecondTrue);
}
    Console.WriteLine (IsBetween20And50p2(20, 84));
    Console.WriteLine (IsBetween20And50p2(14, 50));
    Console.WriteLine (IsBetween20And50p2(11, 45));
    Console.WriteLine (IsBetween20And50p2(25, 40));

//17. Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string. If it appears return a string without 'yt' otherwise return the original string.
static String StartWithYT(String s)
{
    return (s[1] == 'y' && s[2] == 't') ? s.Remove(1,2) : s;
}

    Console.WriteLine (StartWithYT("Python"));
    Console.WriteLine (StartWithYT("ytade"));
    Console.WriteLine (StartWithYT("jsues"));

//18. Write a C# Sharp program to check the largest number among three given integers.
static int LargestNumber(int x,int y,int z)
{
    return Math.Max(Math.Max(x,y),z);
}
    Console.WriteLine (LargestNumber(1,2,3));
    Console.WriteLine (LargestNumber(1,3,2));
    Console.WriteLine (LargestNumber(1,1,1));
    Console.WriteLine (LargestNumber(1,2,2));

//19. Write a C# Sharp program to check which number is closest to 100 among two given integers. Return 0 if the two numbers are equal.
static int ClosestNumberTo100(int x,int y)
{
    return x==y ? 0 : (100-x < 100-y ? x : y);
}
    Console.WriteLine (ClosestNumberTo100(78, 95));
    Console.WriteLine (ClosestNumberTo100(95,95));
    Console.WriteLine (ClosestNumberTo100(99,70));

//20. Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive, or they are both in the range 50..60 inclusive.
static bool IsBetween40And50Or50And60(int x,int y)
{
    bool isIn40And50 = (x >= 40 && x <= 50) && (y >= 40 && y <= 50);
    bool isIn50And60 = (x >= 50 && x <= 60) && (y >= 50 && y <= 60);
    return isIn40And50 || isIn50And60;
}
    Console.WriteLine (IsBetween40And50Or50And60(78, 95));
    Console.WriteLine (IsBetween40And50Or50And60(25, 35));
    Console.WriteLine (IsBetween40And50Or50And60(40, 50));
    Console.WriteLine (IsBetween40And50Or50And60(55, 60));

//21. Write a C# Sharp program to find the largest value from two positive integer values in the range 20..30 inclusive. Return 0 if neither is in that range.
static int MaxBetween20And30(int x,int y)
{
    bool isIn20And30 = (x >= 20 && x <= 30) && (y >= 20 && y <= 30);

    return isIn20And30 ? Math.Max(x,y) : 0;
}
    Console.WriteLine (MaxBetween20And30(78, 95));
    Console.WriteLine (MaxBetween20And30(20, 30));
    Console.WriteLine (MaxBetween20And30(21, 25));
    Console.WriteLine (MaxBetween20And30(28, 28));

//22. Write a C# Sharp program to check if a given string contains between 2 and 4 'z' characters.
static bool Has2Or4z(String s)
{
    int zts = s.Count(s => s == 'z');
    return  zts == 2 || zts ==4  ;
}
    Console.WriteLine (Has2Or4z("frizz"));
    Console.WriteLine (Has2Or4z("zane"));
    Console.WriteLine (Has2Or4z("Zazz"));
    Console.WriteLine (Has2Or4z("false"));
    Console.WriteLine (Has2Or4z("zzzz"));
    Console.WriteLine (Has2Or4z("ZZZZ"));

//23. Write a C# Sharp program to check if two given non-negative integers have the same last digit.
static bool SameLastInt(int x, int y)
{
    char lastOfx = x.ToString().Last();
    char lastOfy = y.ToString().Last();

    return  (x>0 && y>0) ?  lastOfx == lastOfy : false ;
}
    Console.WriteLine (SameLastInt(123, 456));
    Console.WriteLine (SameLastInt(12, 512));
    Console.WriteLine (SameLastInt(7, 87));
    Console.WriteLine (SameLastInt(12, 45));

//24. Write a C# Sharp program to convert the last 3 characters of a given string to uppercase. If the length of the string is less than 3, then uppercase all the characters.
static String UpperTheLast3(String s)
{
    return  s.Length > 3 ? s.Remove(s.Length-3) + s.Substring(s.Length - 3).ToUpper() : s.ToUpper();
}
    Console.WriteLine (UpperTheLast3("Python"));
    Console.WriteLine (UpperTheLast3("Javascript"));
    Console.WriteLine (UpperTheLast3("js"));
    Console.WriteLine (UpperTheLast3("PHP"));

// 25. Write a C# Sharp program to create a string which is n (non-negative integer) copies of a given string.
static String CloneString(String s,int n)
{
    var m = "";
    for (int i = 0; i < n; i++)
    {
        m += s;
    }
    return m;
}
    Console.WriteLine (CloneString("Javascript",1));
    Console.WriteLine (CloneString("Python",2));
    Console.WriteLine (CloneString("PHP",3));
    Console.WriteLine (CloneString("js",4));


//=======================================================================//
//1. Write a C# Sharp program to accept two integers and check whether they are equal or not.
using static System.Net.Mime.MediaTypeNames;

static string CheckIfEqual()
{
    System.Console.Write("Enter the first number:");
    var n1 = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Enter the second number:");
    var n2 = Convert.ToInt32(Console.ReadLine());
    return n1 == n2 ? "equal" : "not equal";
}
// Console.WriteLine(CheckIfEqual());

//2. Write a C# Sharp program to check whether a given number is even or odd.
static string EvenOdd()
{
    System.Console.Write("Enter the number:");
    var n = Convert.ToInt32(Console.ReadLine());

    return n%2==0 ? "even" : "odd";
}
// Console.WriteLine(EvenOdd());

//3.Write a C# Sharp program to check whether a given number is positive or 
static string PositiveNegative()
{
    System.Console.Write("Enter the number:");
    var n = Convert.ToInt32(Console.ReadLine());

    return n > 0 ? "Positive" : "Negative";
}
// Console.WriteLine(PositiveNegative());

//4. Write a C# Sharp program to find out whether a given year is a leap year or 
static string LeapYear()
{
    System.Console.Write("Enter the year:");
    var n = Convert.ToInt32(Console.ReadLine());

    return n%4==0 ? "Leap Year" : "not Leap Year";
}
//Console.WriteLine(LeapYear());


//5. Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.
static string LegalAgeToVote()
{
    System.Console.Write("Enter the age:");
    var n = Convert.ToInt32(Console.ReadLine());

    return n >=18 ? "Congratulation! You are eligible for casting your vote." : "you're under age";
}
//Console.WriteLine(LegalAgeToVote());


//6.Write a C# Sharp program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less 
static int NumberCheck()
{
    System.Console.Write("Enter the number:");
    var n = Convert.ToInt32(Console.ReadLine());

    return n ==0 ? 0 : (n>0? 1 : -1);
}
//Console.WriteLine(NumberCheck());


//7.Write a C# Sharp program to accept a person's height in centimeters and categorize them according to their height.
static string HeightBully()
{
    System.Console.Write("Enter the height:");
    var n = Convert.ToInt32(Console.ReadLine());

    return n <=140 ? "too short" : (n<=160? "normal height" : "hello big man");
}

// Console.WriteLine(HeightBully());


// 8. Write a C# Sharp program to find the largest of three numbers.
static int LargestNumber()
{
    System.Console.Write("Enter the first number:");
    var x = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Enter the second number:");
    var y = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Enter the third number:");
    var z = Convert.ToInt32(Console.ReadLine());
    return Math.Max(Math.Max(x, y), z);
}
//Console.WriteLine(LargestNumber());


//9. Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
static string CheckQuadrant()
{
    System.Console.Write("Enter the x:");
    var x = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Enter the y:");
    var y = Convert.ToInt32(Console.ReadLine());

    return x>0 && y>0 ? "First Quadrant" : x<0 && y>0? "Second Quadrant" : x<0 && y<0 ? "Third Quadrant" : "Forth Quadrant";
}
//Console.WriteLine(CheckQuadrant());


//10. Write a C# Sharp program to determine the eligibility for admission to a professional course based on the following criteria:
static string ApplyToCourse()
{
    System.Console.Write("Enter the marks obtained in Physics:");
    var p = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Enter the marks obtained in Chemistry:");
    var c = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Enter the marks obtained in Mathematics:");
    var m = Convert.ToInt32(Console.ReadLine());
    return (m >=65 && p >=55 && c >=50 && m+c+p >=180) || m +p >=140 ? "The candidate is eligible for admission." : "you cant enroll" ;
}
//Console.WriteLine(ApplyToCourse());


//11. Write a C# Sharp program to calculate the root of a quadratic equation.
static string QuadraticEquation()
{
    System.Console.Write("Enter the value of a:");
    var a = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Enter the value of b:");
    var b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the value of c:");
    var c = Convert.ToInt32(Console.ReadLine());
    var underTheRoot = b * b - 4 * a * c;
    var x1 = b - Math.Sqrt(underTheRoot);
    var x2 = b + Math.Sqrt(underTheRoot);
    return underTheRoot < 0 ? "Root are imaginary No Solution." : $"{x1},{x2}";
}
//Console.WriteLine(QuadraticEquation());


//12. Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division.
static string StudentInfo()
{
    System.Console.Write("Enter the Roll Number of the student:");
    var roll = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Enter the Name of the Student:");
    var name = Console.ReadLine();
    System.Console.Write("Enter the marks of Physics:");
    var physics = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Enter the marks of Chemistry:");
    var chemistry = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Enter the marks of ComputerApplication:");
    var computerApplication = Convert.ToInt32(Console.ReadLine());
    var total = physics + chemistry + computerApplication;
    var percentage = total / 3;
    var division = percentage >= 80 ? "First" : (percentage >=70  ? "Second" : "Third") ;

    return $"Roll No:{roll}\n" +
           $"Name of Student{name}\n" +
           $"Marks in Physics:{physics}\n" +
           $"Marks in Chemistry:{chemistry}\n" +
           $"Marks in ComputerApplication:{computerApplication}\n" +
           $"Total Marks:{total}\n"+
           $"Percentage:{percentage}\n"+
           $"Division:{division}";
}
//Console.WriteLine(StudentInfo());



//13. Write a C# Sharp program to read temperature in centigrade and display a suitable message according to the temperature state below:
static string CheckTheWeather()
{
    Console.Write("Enter the Temperature :");
    var temp = Convert.ToInt32(Console.ReadLine());
    return temp < 0 ? "Freezing weather" :
        temp is >= 0 and < 10 ? "Very Cold weather" :
        temp is >= 10 and < 20 ? "Cold weather" :
        temp is >= 20 and < 30 ? "Normal Weather" :
        temp is >= 30 and < 40 ? "its hot" : "its very hot";
}
//Console.WriteLine(CheckTheWeather());



//14. Write a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene.
static string CheckTriangle()
{
    Console.Write("Enter the first side:");
    var a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the second side:");
    var b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the third side:");
    var c = Convert.ToInt32(Console.ReadLine());
    return a.Equals(b) && a.Equals(c) && b.Equals(c) ? "equilateral" : a.Equals(b) || a.Equals(c) || b.Equals(c) ? "isosceles " : "Scalene";
}
//Console.WriteLine(CheckTriangle());


//15. Write a C# Sharp program to check whether a triangle can be formed by the given angles value.
static string DrawTriangle()
{
    Console.Write("Enter the first side:");
    var a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the second side:");
    var b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the third side:");
    var c = Convert.ToInt32(Console.ReadLine());
    return a+b+c == 180 ? "the triangle is valid" : "the triangle is not valid";
}
//Console.WriteLine(DrawTriangle());


//16. Write a C# Sharp program to check whether an alphabet letter is a vowel or a consonant.
static string VowelConstant()
{
    Console.Write("Enter the char: ");
    var c = Console.ReadLine()!.ToLower();
    var vowels = "aeoiu";
    return vowels.Contains(c) ? "The alphabet is a vowel" : "The alphabet is a consonant";
}
//Console.WriteLine(VowelConstant());


//17. Write a C# Sharp program to calculate profit and loss on a transaction.
static string ProfitLoss()
{
    Console.Write("Enter the cost:");
    var a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the sell price:");
    var b = Convert.ToInt32(Console.ReadLine());

    return b > a ? $"You can book your profit amount: {b-a}" : "loss";
}
//Console.WriteLine(ProfitLoss());


//18. Write a C# Sharp program to calculate and print the electricity bill of a customer. From the keyboard, the customer's name, ID, and unit consumed should be taken and displayed along with the total amount due.
// The charge are as follow :
static string ElectricityBill()
{
    System.Console.Write("Enter the ID:");
    var id = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Enter the Name :");
    var name = Console.ReadLine();
    System.Console.Write("Enter the Unit Consumed:");
    var unit = Convert.ToInt32(Console.ReadLine());
    var unitCharge = unit < 200 ? 1.20 : unit is >= 200 and < 400 ? 1.50 : unit is >= 400 and < 600 ? 1.80 : 2.00;
    var total = unit * unitCharge;
    var surcharge = total > 400 ? total * 0.15 : 0;
    return $"Customer ID: {id}\n" +
           $"Customer Name: {name}\n" +
           $"Unit Consumed: {unit}\n" +
           $"Amount Charges @Rs. {unitCharge} per unit: {total}\n"+
           $"Surcharge Amount: {surcharge}\n" +
           $"Net Amount Paid By the Customer: {total+surcharge}";
}
//Console.WriteLine(ElectricityBill());


//19. Write a program in C# Sharp to accept a grade and declare the equivalent description :
static string GetGrade()
{
    System.Console.Write("Enter the Grade :");
        var grade = Console.ReadLine()!.ToLower();
        return grade == "e" ? "Excellent" :
            grade == "v" ? "Very Good" :
            grade == "g" ? "Good" :
            grade == "a" ? "Average" :
            grade == "f" ? "Fail" : "not valid";
}
//Console.WriteLine(GetGrade());


//20. Write a C# Sharp program to read any day number as an integer and display the name of the day as a word.
static string GetDay()
{
    System.Console.Write("Enter the number(1-7):");
    var day = Convert.ToInt32(Console.ReadLine());
    return day is 1 ? "Sunday" :
        day is 2 ? "Monday" :
        day is 3 ? "Tuesday" :
        day is 4 ? "Wednesday" :
        day is 5 ? "Thursday" :
        day is 6 ? "Friday" :
        day is 7 ? "Saturday" : "Noday";
}
//Console.WriteLine(GetDay());


// 21. Write a program in C# Sharp to read any digit, display in the word.
static string DigitToWord()
{
    System.Console.Write("Enter the number(0-9):");
    var digit = Convert.ToInt32(Console.ReadLine());
    return digit is 0 ? "zero" :
        digit is 1 ? "one " :
        digit is 2 ? "Two" :
        digit is 3 ? "three " :
        digit is 4 ? "four " :
        digit is 5 ? "five " :
        digit is 6 ? "six " :
        digit is 7 ? "seven " :
        digit is 8 ? "eight" :
        digit is 9 ? "nine" : "invalid input";
}
//Console.WriteLine(DigitToWord());


//22. Write C# Sharp program to read any Month Number in integer and display 

static string NumberToMonth()
{
    System.Console.Write("Enter the number(1-12):");
    var digit = Convert.ToInt32(Console.ReadLine());
    return 
        digit is 1 ? "January " :
        digit is 2 ? "February" :
        digit is 3 ? "March " :
        digit is 4 ? "April " :
        digit is 5 ? "May " :
        digit is 6 ? "June " :
        digit is 7 ? "July " :
        digit is 8 ? "August" :
        digit is 9 ? "September" :
        digit is 10 ? "October" :
        digit is 11 ? "November" :
        digit is 12 ? "December" : "invalid input";
}
//Console.WriteLine(NumberToMonth());


//23. Write a program in C# Sharp to read any Month Number in integer and display the number of days for this month.
static string MonthDays()
{
    System.Console.Write("Enter the number(1-12):");
    var digit = Convert.ToInt32(Console.ReadLine());
    return
        digit is 1 ? "31 days " :
        digit is 2 ? "28 days" :
        digit is 3 ? "31 days " :
        digit is 4 ? "30 days " :
        digit is 5 ? "31 days " :
        digit is 6 ? "30 days " :
        digit is 7 ? "31 days " :
        digit is 8 ? "31 days" :
        digit is 9 ? "30 days" :
        digit is 10 ? "31 days" :
        digit is 11 ? "30 days" :
        digit is 12 ? "31 days" : "invalid input";
}
//Console.WriteLine(MonthDays());


//24. Write a C# Sharp program that calculates the area of geometrical shapes using a menu-driven approach.
static string AreaOfGeometricalShapes()
{
    Console.Write("Enter 1 for Circle 2 for Triangle 3 for Rectangle: ");
    var c = Convert.ToInt32(Console.ReadLine());
    var area = 0.0;
    if (c is 1)
    {
        Console.Write("Enter the Radius:");
        var radius = Convert.ToDouble(Console.ReadLine());
        area = 3.14 * radius * radius;
    }
    else if (c is 2)
    {
        Console.Write("Enter the Base:");
        var b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Height:");
        var h = Convert.ToInt32(Console.ReadLine());
        area = 0.5 * b * h;
    }
    else if (c is 3)
    {
        Console.Write("Enter the Length: ");
        var l = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Width: ");
        var w = Convert.ToInt32(Console.ReadLine());
        area = l * w;
    }
    return $"The Area is: {area}";
}
//Console.WriteLine(AreaOfGeometricalShapes());

//===========================================================================//

//1. Write a program in C# Sharp to input a string and print it.
void PrintInput()
{
    Console.Write("Enter Anything: ");
    var s = Console.ReadLine();
    Console.WriteLine(s);
}
//PrintInput();


//Write a C# Sharp program to find the length of a string without using a library function.
 void StringLength()
{
    Console.Write("Enter Anything: ");
    var s = Console.ReadLine();
    var c = 0;
    foreach (var i in s)
    {
        c++;
    }
    Console.WriteLine("Length is: "+c);
}
//StringLength();


//3. Write a C# Sharp program to separate individual characters from a string.
 void SeparateChar()
{
    Console.Write("Enter Anything: ");
    var s = Console.ReadLine();
    var r = "";
    foreach (var i in s)
    {
        r += i + " ";
    }
    Console.WriteLine(r);
}
//SeparateChar();


//4. Write a program in C# Sharp to print individual characters of the string in reverse order.
 void ReverseString()
{
    Console.Write("Enter Anything: ");
    var s = Console.ReadLine();
    var r = "";
    for (var i=s.Length-1;i>=0;i--)
    {
        r += s[i] + " ";
    }
    Console.WriteLine(r);
}
//ReverseString();


//5. Write a program in C# Sharp to count the total number of words in a string.
 void WordCount()
{
    Console.Write("Enter Anything: ");
    var s = Console.ReadLine();
    Console.WriteLine(s.Split().Length);
}
//WordCount();


//6. Write a program in C# Sharp to compare two strings without using a string library functions.
void CompareString()
{
    Console.Write("Enter the first string: ");
    var s1 = Console.ReadLine();
    Console.Write("Enter the second string: ");
    var s2 = Console.ReadLine();
    bool isEqual = true;
    if (s1.Length != s2.Length)
    {
        isEqual = false;
    }

    for (int i = 0; i < s1.Length; i++)
    {
        if (s1[i] != s2[i])
        {
            isEqual = false;
        }
    }

    if (isEqual)
    {
        Console.WriteLine("Strings has same length and equal;");
    }
    else
    {
        Console.WriteLine("Strings are not equal");
    }
}
//CompareString();


//7. Write a program in C# Sharp to count the number of alphabets, digits and special characters in a string.
void CountChars()
{
    Console.Write("Enter Anything: ");
    var s = Console.ReadLine();
    int l=0, d=0, sp = 0;
    foreach (var i in s)
    {
        if (char.IsLetter(i))
        {
            l++;
        }

        if (char.IsDigit(i))
        {
            d++;
        }

        if (!char.IsLetterOrDigit(i))
        {
            sp++;
        }
    }

    Console.WriteLine($"Number of Alphabets in the string is : {l}\nNumber of Digits in the string is : {d}\nNumber of Special characters in the string is : {sp}\n");
}
//CountChars();


//8. Write a program in C# Sharp to copy one string to another string.
void CopyString()
{
    Console.Write("Enter Anything: ");
    var s = Console.ReadLine();
    var s2 = s;
    Console.WriteLine($"The First string is: {s}\nThe Second string is: {s2}\nNumber of characters copied: {s.Length}");
}
//CopyString();



//9. Write a C# Sharp program to count the number of vowels or consonants in 
void VowelConstant()
{
    Console.Write("Enter Anything: ");
    var s = Console.ReadLine()!.ToLower();
    int v= 0, c = 0;
    foreach (var i in s)
    {
        if (i is 'a' or 'e' or 'o' or 'i' or 'u')
        {
            v++;
        }
        else if(char.IsLetter(i))
        {
            c++;
        }
    }

    Console.WriteLine($"The total number of vowel in the string is : {v}\nThe total number of consonant in the string is: {c}");
}
//VowelConstant();




//10. Write a C# Sharp program to find the maximum number of characters in a string.
void MaxChar()
{
    Console.Write("Enter Anything: ");
    var s = Console.ReadLine()!.ToLower();
    int max = 0;
    var c = "";
    foreach (var i in s)
    {
        if (char.IsLetter(i))
        {
            var count = s.Count(c => c == i);
            if (count > max)
            {
                max = count;
                c = i.ToString();
            }
        }
        
    }

    Console.WriteLine($"The Highest frequency of character: {c} \nappears number of times : {max}");
}
//MaxChar();


//11. Write a C# Sharp program to sort a string array in ascending order.
void AscendingSort()
{
    Console.Write("Enter Anything: ");
    var s = Console.ReadLine()!.ToLower();
    var c = s.ToCharArray();
    Array.Sort(c);
    Console.WriteLine(c);
}
//AscendingSort();


//12. Write a C# Sharp program to read a string through the keyboard and sort it using bubble sort.
void StringBubbleSort()
{
    string temp;
    string [] str = { };
    Console.WriteLine("enter the number of strings: ");
    var l = Convert.ToInt32(Console.ReadLine());
    if (l > 0)
    {
        str = new string[l];
        Console.WriteLine($"enter the {l} strings bellow");
        for (int i = 0; i < l; i++)
        {
            str[i] = Console.ReadLine();
        }
    }

    var n = str.Length;
    
    for (int j = 0; j < n - 1; j++)
    {
        for (int i = j + 1; i < n; i++)
        {
            if (str[j].CompareTo(str[i]) > 0)
            {
                temp = str[j];
                str[j] = str[i];
                str[i] = temp;
            }
        }
    }

    Console.WriteLine("Output: ");
    foreach (var i in str)
    {
        Console.WriteLine(i);
    }
}
//StringBubbleSort();


//13. Write a program in C# Sharp to extract a substring from a given string without using the library function.
void SubString()
{
    Console.Write("Input the string: ");
    var s = Console.ReadLine();
    Console.Write("Input the position to start extraction: ");
    var index = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the length of substring: ");
    var length = Convert.ToInt32(Console.ReadLine());
    for (int i = index; i < index+length; i++)
    {
        Console.Write(s[i]);
    }
}
//SubString();


//14. Write a C# Sharp program to check whether a given substring is present in the given string.
void IsSubString()
{
    Console.Write("Input the string: ");
    var s1 = Console.ReadLine();
    Console.Write("Input the substring to search: ");
    var s2 = Console.ReadLine();
    var result = s1.Contains(s2) ? "The substring exists in the string" : "The substring does not exists in the string";
    Console.WriteLine(result);
}
//IsSubString();


//15. Write a C# Sharp program to read a sentence and replace lowercase characters with uppercase and vice-versa.
void ReverseUpperAndLower()
{
    Console.Write("Input the string: ");
    var s = Console.ReadLine();
    var r = "";
    foreach (var i in s)
    {
        if (char.IsLower(i))
        {
            r += char.ToUpper(i);
        }
        else
        {
            r += char.ToLower(i);
        }
    }

    Console.WriteLine(r);
}
//ReverseUpperAndLower();


//17. Write a program in C# Sharp to search for the position of a substring within a string.
void IndexOfSubString()
{
    Console.Write("Input the string: ");
    var s1 = Console.ReadLine();
    Console.Write("Input a substring to be found in the string: ");
    var s2 = Console.ReadLine();
    Console.WriteLine(s1.IndexOf(s2));
}
//IndexOfSubString();


//18. Write a C# Sharp program to check whether a character is an alphabet and not and if so, check for the case.
void IsAlphaUpper()
{
    Console.Write("Input a character: ");
    var s1 = Convert.ToChar(Console.ReadLine());
    Console.WriteLine(char.IsLetter(s1) ? (char.IsUpper(s1)
        ? "The character is uppercase"
        : "The character is lowercase."):
        "input is not a letter");

}
//IsAlphaUpper();
