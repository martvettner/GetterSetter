using System;

namespace GetterSetter
{
    class Program
    {
        class Person
        {
            string name;
            int age;
            string gender;
            string idCode;

            public Person(string _name, string _gender, int _age, string _idCode)
            {
                name = _name;
                Age = _age;
                Gender = _gender;
                IdCode = _idCode;
            }
            public string Name
            {
                get { return name; }
                
            }
            public string Gender
            {
                get { return gender; }
                set
                {
                    if(value == "male" || value == "female")
                    {
                        gender = value;
                    }
                    else
                    {
                        gender = "Unicorn";
                    }
                }
            }
            public int Age
            {
                get { return age; }
                set
                {

                }
            }
            public string IdCode
            {
                get { return idCode; }
                set
                {
                    if (value.Length == 11)
                    {
                        idCode = value;
                    }
                    else
                    {
                        idCode = "not valid idcode";
                    }
                }
            }
            public void ChangeName()
            {
                name = newName;
            }
        }
        static void Main(string[] args)
        {
            Person newPerson = new Person("promees", "female", 69, "1234");

            newPerson.ChangeName("pronaine");

            Console.WriteLine(newPerson.Gender);
            Console.WriteLine(newPerson.IdCode);
        }
    }
}
