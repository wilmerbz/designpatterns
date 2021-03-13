using InterpreterPattern.Counter;
using System;

namespace InterpreterPattern
{

    class Program
    {
        static void Main(string[] args)
        {
            var fileContent = new string[] {
                "using System;",
                "using System.Text;",
                "",
                "namespace InterpreterPattern.Counter.Interpreter",
                "{",
                "    public enum Types",
                "    {",
                "			One,",
                "			Two,",
                "			Three,",
                "			//Four,",
                "			Five,",
                "    }",
                "	   //My Comment",
                "",
                "}"
                
                //"using System;",
                //"using System.Collections.Generic;",
                //"using System.Text;",
                //"",
                //"namespace InterpreterPattern.Counter.Interpreter",
                //"{",
                //"    public interface IExpression",
                //"    {",
                //"",
                //"        bool Interpret(Context context);",
                //"",
                //"    }",
                //"}"

                //"using System;",
                //"",
                //"namespace InterpreterPattern",
                //"{",
                //"       public class Program",
                //"       {",
                //"              public void SomeMethod()",
                //"              {",
                //"              ",
                //"                     //int index = 0;",
                //"                     return;",
                //"              //public class comment",
                //"              }",
                //"              ",
                //"              ",
                //"              public T SomeMethod<T>(int a, bool b)" +
                //"              : where T: new()",
                //"              {",
                //"              ",
                //"                     //int index = 0;",
                //"                     return;",
                //"              //public class comment",
                //"              }",
                //"              ",
                //"              ",
                //"       }",
                //"}"
            };

            var locCounter = new LOCCounter();
            var result = locCounter.ProcessFile(fileContent);

            Console.WriteLine($"Name: {result.PartName} - Number of Items: {result.NumberOfItems} - Size: {result.Size}");
            Console.ReadKey();
        }

        public static T  SomeMethod<T>(int a, bool b)where T: new(){
            return default(T);
        }
    }
}
