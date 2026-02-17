namespace knightmoves;

public class Ageable{
    protected int year;
    protected int Age(int Year){
        return DateTime.Now.Year - year;
    }
}

public class Company : Ageable{
    private string Name;
    private string Id;
    private decimal TaxRate;

    public Company(string name, string taxId, int yearEstablished, decimal taxRate) : base(Year){
        Name = name;
        TaxId = taxId;
        TaxRate = taxRate;
    }
}

public class Person : Ageable{
    private string Name;
    private string Id;
    private decimal TaxRate;

    public Person(string name, string ssn, int birthYear, decimal taxRate) : base(Year){
        Name = name;
        Id = ssn;
        TaxRate = taxRate;
    }
}

public class Car : Ageable{
    private string Name;
    private string Id;

    public Car(string model, string vin, int year) : base(Year){
        Name = name;
        Vin = vin;
    }
}





