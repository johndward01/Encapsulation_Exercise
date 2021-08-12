using System;

namespace Encapsulation_Exercise_01_Answers
{
    class Program
    {
        // TODO: Create a FULL PROPERTY by using the code snippet: type propfull and then press tab twice (propfull + tab + tab)
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        static void Main(string[] args)
        {
            // Thought Experiment: Will the following code work or cause a compiler error?
            // Console.WriteLine(myVar);
            // TODO: It will cause an error because the myVar field has been encapsulated by the private access modifier




            // Thought Experiment: How would you access the myVar variable and print it out to the console?
            // TODO: Console.WriteLine(MyProperty); 
            // Why: ? Because the property is public, it is not encapsulated, therefore we can access it directly. And when we call it's getter method, we return myVar





        }
    }
}
