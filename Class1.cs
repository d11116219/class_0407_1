using System;

internal class Program
{
    static void Main(string[] args)
    {
        Person p = new Person();
        Person p1 = new Person("我改過的名字");
        Console.WriteLine(p.name.ToString());
        Console.WriteLine(p1.name.ToString());

        Student s1 = new Student();
        Console.WriteLine(s1.name.ToString());
    }
}

class Person
{
    public string name;

    public Person()
    {
        name = "預設名字";
    }

    public Person(string name)
    {
        this.name = name;
    }
}

class Student : Person
{
    public Student() : base("學生物件**修改後的名字")
    {

    }
}