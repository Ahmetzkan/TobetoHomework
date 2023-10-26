Person[] persons = new Person[3]
{
    new Customer()
    {
        FirstName="Ahmet"
    },
    new Student() {
        FirstName="Engin"
    },
    new Person() {
        FirstName="Salih"
    }
};

foreach (var person in persons)
{
    Console.WriteLine(person.FirstName);
}
//İnheritance'ın İnterfaceden farkı inheritance 2 defa miras alamaz ama interface alır.
//İnterfaceler direkt interface ile tanımlanırken,inheritance direk "Customer:Person" gibi tanımlanır.
 
class Person
{ 
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer:Person
{
    public string City { get; set; }
}
class Student:Person
{
    public string Department { get; set; }
}