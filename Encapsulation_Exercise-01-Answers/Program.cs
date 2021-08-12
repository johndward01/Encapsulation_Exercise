using System;

namespace Encapsulation_Exercise_01_Answers
{
    class Program
    {
        #region// TODO: Create a Personally Identifiable Information class (Name is PII_Info)

        // TODO: Create 4 private fields
        // TODO: Create 4 public methods to get (read) those fields
        // TODO: Create 4 public methods to set (write) those fields

        // TODO: Create 2 private auto-implemented properties 
        // TODO: Creaet 1 method called SetInfo() which sets the private properties
        // TODO: Create 1 method called InformationReport() which creatively displays the 2 private properties 

        // BONUS
        // TODO: Create 1 private readonly field called _secret of type string
        // Thought Experiment: How can you initialize this field with a value?
        // Answer Here: 
        // TODO: Assign a value to the _secret field

        #endregion


        #region// TODO: Create a FULL PROPERTY by using the code snippet: type propfull and then press tab twice (propfull + tab + tab)
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        #endregion

        static void Main(string[] args)
        {
            // Thought Experiment: Will the following code work or cause a compiler error?
            // Console.WriteLine(myVar); 
            // Answer Here: 



            // Thought Experiment: How would you access the myVar variable and print it out to the console?
            // TODO: Console.WriteLine(MyProperty); 
            // Why?: 



            // TODO: Create an instance of the PII_Info class
        }
    }
}
