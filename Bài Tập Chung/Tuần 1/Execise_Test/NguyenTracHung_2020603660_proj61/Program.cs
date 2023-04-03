using System;
using System.Collections.Generic;
namespace NguyenTracHung_2020603660_proj61
{
    class Program 
    {
        class DataToShortExp : Exception  
        {
            public DataToShortExp() : base("Dữ liệu quá ngắn") { }
        }
        class Employee 
        {
            int _id;
            public int Id {
                get
                {
                    return _id;
                }
                set
                {
                    _id = value;
                }

            }
            string _name;
            public string Name { get => _name;  
                set {
                    try
                    {
                        if (Name.Length < 3)
                        {
                            throw new Exception();
                        }
                        else
                        {
                            _name = Name;
                        }
                    }
                    catch (Exception)
                    {
                        throw new DataToShortExp();
                    }
                }
            }
            Employee(int id)
            {

                _id = id;
                _name = "No Name";
            }

            public Employee(int id, string name) : this(id)
            {
                try
                {
                    if (name.Length < 3)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        _name = name;
                    }
                }
                catch (Exception)
                {
                    throw new DataToShortExp();
                }
            }
        }
        static void Main(string[] args)
        {
            Employee employee = new Employee(111,"1111");
        }
    }
}
