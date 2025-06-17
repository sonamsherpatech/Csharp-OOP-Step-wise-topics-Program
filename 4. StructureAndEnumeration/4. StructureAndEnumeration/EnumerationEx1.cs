using System;
///<summary>
///
/// Enumeration or (enum) is a user defined value type that consists of set of named constants called enumerator list
/// It makes code more readable and meaningful by using names instead of numbers for related constants values
/// 
/// KEY POINTS:
/// -> Enum are value type
/// -> By default, the underlying type is int
/// -> Can change the underlying type to byte, short etc
/// -> By default first element of enum list is represented by integer 0
/// -> Can assign specific numeric values to the names
/// 
/// SYNTAX
/// enum <enum_name> {
///     //enum list
/// }
/// 
/// </summary>

namespace _4.StructureAndEnumeration
{
    enum days {Sun = 22, Mon, Tues, Wed, Thurs, Fri, Sat };
    // we can change the integer representation of enum list constant using = <any number>
    class EnumerationEx1
    {
        public static void Main()
        {
            days today = days.Tues;
            Console.WriteLine($"First day of week = { days.Sun}");
            Console.WriteLine($"First day of week = {(int)days.Sun}");

            Console.WriteLine($"Today is {today}");
            Console.WriteLine($"Numeric Value {(int)today}");
            
            switch(today)
            {
                case days.Sun:
                case days.Sat:
                    Console.WriteLine("Weekend.. Enjoy🥳");
                    break;
                default:
                    Console.WriteLine("Let's get ready to work");
                    break;
            }
        }
    }
}
