

/*  Task 1: Processing user input  */
userInput();


/*  Task 2: Selection statements  */
selectionStatement();


/*  Task 3: Logical operators  */
logicalOperator();


/*  Task 4: Leap Year Checker  */
leapYear();


/*  Task 5: Even or Odd Checker  */
evenOddChecker();


void userInput() {
    Console.WriteLine("Please enter your name :");

    String name = Console.ReadLine();

    Console.WriteLine("Please enter your age?");
    int age = Convert.ToInt32(Console.ReadLine());

    age += 5;

    Console.WriteLine("Hello {0}, you will be {1} in 5 years,", name, age);
}


void selectionStatement()
{

    Console.WriteLine("Please enter your age?");
    int age = Convert.ToInt32(Console.ReadLine());

    if (age < 0 || age > 110)
    {
        Console.WriteLine("An age that is outside the 0-110 range");
    }
    else if (age < 13)
    {
        Console.WriteLine("You are a child");
    }
    else if (age >= 13 && age <= 19)
    {
        Console.WriteLine("You are a teenager");
    }
    else if (age > 19 && age < 110)
    {
        Console.WriteLine("You are an adult and oldest person");
    }
}



void logicalOperator() {

Console.WriteLine("Please enter an integer");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
    {
        Console.WriteLine("This is a negative number");
    }
    else if (number > 0)
    {
        Console.WriteLine("This is a positive number");
    }
    else
    {
        Console.WriteLine("This is zero");
    }

}


void leapYear() {

    Console.WriteLine("Enter a year: ");
    int year = Convert.ToInt32(Console.ReadLine());
    if (year < 0)
    {
        Console.WriteLine("Invalid input: Year cannot be negative");
    }
    else if ((year % 4 == 0 && year % 100 !=0 ) || (year % 400 ==0))
    {
        Console.WriteLine($"{year} is a leap year");
    }
    else {
        Console.WriteLine($"{year} is not a leap year");
    }

    }



void evenOddChecker()
{

    Console.WriteLine("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number % 2 == 0 )
    {
        Console.WriteLine($"{number} is a Even number");
    }
    else
    {
        Console.WriteLine($"{number} is a Odd number");
    }

}

