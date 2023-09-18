using System;

// Клас Address
public class Address
{
    private string index;
    private string country;
    private string city;
    private string street;
    private string house;
    private string apartment;

    public string Index
    {
        get { return index; }
        set { index = value; }
    }

    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    public string House
    {
        get { return house; }
        set { house = value; }
    }

    public string Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    }

    public Address(string index, string country, string city, string street, string house, string apartment)
    {
        Index = index;
        Country = country;
        City = city;
        Street = street;
        House = house;
        Apartment = apartment;
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"Index: {Index}, Country: {Country}, City: {City}, Street: {Street}, House: {House}, Apartment: {Apartment}");
    }
}

// Клас Converter
public class Converter
{
    private double usd;
    private double eur;
    private double pln;

    public Converter(double usd, double eur, double pln)
    {
        this.usd = usd;
        this.eur = eur;
        this.pln = pln;
    }

    public double ConvertToUAH(double amount, string currency)
    {
        switch (currency.ToUpper())
        {
            case "USD":
                return amount * usd;
            case "EUR":
                return amount * eur;
            case "PLN":
                return amount * pln;
            default:
                throw new ArgumentException("Invalid currency");
        }
    }

    public double ConvertFromUAH(double amount, string currency)
    {
        switch (currency.ToUpper())
        {
            case "USD":
                return amount / usd;
            case "EUR":
                return amount / eur;
            case "PLN":
                return amount / pln;
            default:
                throw new ArgumentException("Invalid currency");
        }
    }
}

// Клас Employee
public class Employee
{
    private string lastName;
    private string firstName;

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public Employee(string lastName, string firstName)
    {
        LastName = lastName;
        FirstName = firstName;
    }

    public void DisplayInfo(string position, int experience)
    {
        // Розрахунок окладу та податкового збору можна налаштовувати залежно від вимог завдання
        double baseSalary = 5000;
        double experienceBonus = 200 * experience;
        double positionBonus = (position == "Manager") ? 1000 : (position == "Developer") ? 1500 : 0;
        double totalSalary = baseSalary + experienceBonus + positionBonus;
        double tax = totalSalary * 0.1; // Податок 10%
        double netSalary = totalSalary - tax;

        Console.WriteLine($"Last Name: {LastName}, First Name: {FirstName}, Position: {position}");
        Console.WriteLine($"Salary: {totalSalary}, Tax: {tax}, Net Salary: {netSalary}");
    }
}

// Клас User
public class User
{
    public string Login { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public DateTime RegistrationDate { get; }

    public User(string login, string firstName, string lastName, int age)
    {
        Login = login;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        RegistrationDate = DateTime.Now;
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine($"Login: {Login}, First Name: {FirstName}, Last Name: {LastName}, Age: {Age}");
        Console.WriteLine($"Registration Date: {RegistrationDate}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Приклад використання класів
        Address address = new Address("12345", "Ukraine", "Kyiv", "Main Street", "145", "50");
        address.DisplayAddress();

        Converter converter = new Converter(26.5, 30.0, 6.8);
        double amountInUAH = 1200;
        string currencyToConvert = "USD";
        double convertedAmount = converter.ConvertToUAH(amountInUAH, currencyToConvert);
        Console.WriteLine($"{amountInUAH} UAH is equal to {convertedAmount} {currencyToConvert}");

        Employee employee = new Employee("Smith", "John");
        employee.DisplayInfo("Manager", 5);

        User user = new User("user123", "Alice", "Johnson", 30);
        user.DisplayUserInfo();
    }
}

