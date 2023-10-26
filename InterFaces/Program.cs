﻿using InterFaces;
using System.Net;
using static IPerson;

//InterfacesIntro();
//IPerson person = new Customer();
CustomerManager customerManager = new CustomerManager();
customerManager.Add(new SqlServerCustomerDal());
static void InterfacesIntro()
{
    PersonManager manager = new PersonManager();
    Customer customer = new Customer
    {
        Id = 1,
        FirstName = "Ahmet",
        LastName = "Özkan",
        Address = "Ankara"
    };
    Student student = new Student()
    {
        Id = 2,
        FirstName = "Derin",
        LastName = "Demiroğ",
        Departmant = "Computer Sciences"
    };
    Worker worker = new Worker()
    {
        Id = 2,
        FirstName = "Ali",
        LastName = "Özkan",
        Departmant = "Computer Sciences"
    };

    manager.Add(customer);
    manager.Add(student);
    manager.Add(worker);
}

interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }

    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }

    }
}

class PersonManager
{
    public void Add(IPerson person) 
    {
        Console.WriteLine(person.FirstName);
        Console.WriteLine(person.LastName);
    }
}