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
        // Answer Here: In a field declaration, readonly indicates that assignment to the field can only occur as part of the declaration or in a constructor in the same class. 
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
            // Answer Here: It will cause an error because the myVar field has been encapsulated by the private access modifier



            // Thought Experiment: How would you access the myVar variable and print it out to the console?
            // TODO: Console.WriteLine(MyProperty); 
            // Why: ? Because the property is public, it is not encapsulated, therefore we can access it directly. And when we call it's getter method, we return myVar



            // TODO: Create an instance of the PII_Info class
            var pii = new PII_Info("!@@fghfghh$#@#LKJ&dh#$lkjd$KLJsfd");



            // TODO: Set the values for the PII_Info instance
            pii.SetAuthenticatedStatus(true);
            pii.SetBalance(1000.00M);
            pii.SetEncryptedString("alsde#@%##@!!!!LESDKHJF*##@$UHEslkdjhfjkh31f3298hkjqh");
            pii.SetUserID(100338);
            pii.SetInfo("johndoe4321", "JohnDoe1234!!!");



            // TODO: Call the InformationReport() method 
            pii.InformationReport();

        }
    }
}
