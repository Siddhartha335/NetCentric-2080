// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Console.Write("Enter your full name:");
// string fullname = Console.ReadLine();
// Console.WriteLine($"Your name is {fullname}");

// string cFullName = fullname.ToUpper();

// Console.WriteLine(fullname,cFullName);

// Console.WriteLine($"Name:{fullname}, Capital Name:{cFullName}");  //string interpolation $""



// Console.Write(year);



// DateTime today = DateTime.Year;
// DateTime age = today-dob;
// Console.WriteLine(age);


string getAge() {
    // Console.Write("Enter your date of birth:");
    // string dobstring = Console.ReadLine();
    // dobstring = Console.ReadLine();
    // DateTime dob = DateTime.Parse(dobstring); //tryparse
    // int year = dob.Year;
    // int month = dob.Month;
    // int day = dob.Day;

    // DateTime today = DateTime.Now;
    // int years = today.Year-year;
    // int months = today.Month-month;
    // int days = today.Day-day;

    // return $"Your age is {years} year {months} month {days} day";
    string dobstring;
        DateTime dob;

        do
        {
            Console.Write("Enter your date of birth (YYYY-MM-DD): ");
            dobstring = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(dobstring))
            {
                Console.WriteLine("Please enter a valid date.");
            }
            else if (!DateTime.TryParse(dobstring, out dob))
            {
                Console.WriteLine("Invalid date format. Please enter date in YYYY-MM-DD format.");
            }
        } while (string.IsNullOrWhiteSpace(dobstring) || !DateTime.TryParse(dobstring, out dob));

        int year = dob.Year;
        int month = dob.Month;
        int day = dob.Day;

        DateTime today = DateTime.Now;
        int years = today.Year - year;
        int months = today.Month - month;
        int days = today.Day - day;

        if (months < 0 || (months == 0 && days < 0))
        {
            years--;
            months += 12;
        }

        if (days < 0)
        {
            months--;
            days += DateTime.DaysInMonth(today.Year, today.Month);
        }

        return $"Your age is {years} years, {months} months, and {days} days";
}

// Console.WriteLine(getAge());

Console.Write(getAge());