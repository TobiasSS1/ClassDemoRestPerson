using System;

namespace ClassDemoRestPerson
{
    public class Person
    {
        private int _id;
        private String _name;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public Person():this(1001,"dummyName")
        {
        }

        public Person(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}";
        }
    }
}