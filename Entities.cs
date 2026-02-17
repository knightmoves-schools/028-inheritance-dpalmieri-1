namespace knightmoves;

public class Ageable{
    protected int Year;
    public Ageable(int year){
        Year = year;
    }
    protected int Age(){
        return DateTime.Now.Year - Year;
    }
}

public class Company : Ageable{
    private string Name;
    private string TaxId;
    private decimal TaxRate;

    public Company(string name, string taxId, int yearEstablished, decimal taxRate) : base(Year){
        Name = name;
        TaxId = taxId;
        TaxRate = taxRate;
    }
}

public class Person : Ageable{
    private string Name;
    private string Ssn;
    private decimal TaxRate;

    public Person(string name, string ssn, int birthYear, decimal taxRate) : base(Year){
        Name = name;
        Ssn = ssn;
        TaxRate = taxRate;
    }
}

public class Car : Ageable{
    private string Name;
    private string Vin;

    public Car(string model, string vin, int year) : base(Year){
        Name = name;
        Vin = vin;
    }
}








