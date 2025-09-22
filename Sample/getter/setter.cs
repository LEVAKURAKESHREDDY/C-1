class Person
{
    private string name;   // hidden variable (backing field)

    public string Name     // Property
    {
        get { return name; }        // getter -> reads the value
        set { name = value; }       // setter -> writes the value
    }
    static void Main(string[] args)
    {
       Person p = new Person();
        p.name = "rakesh";
        Console.WriteLine(p.Name);
    }
}
