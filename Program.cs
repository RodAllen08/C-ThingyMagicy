class Program
{
    
    static void Main()
    {
        MyFunction(GetTheNumber());
    }

    static int GetTheNumber()
    {
        int returnNumber = 0;
        returnNumber += 3;
        returnNumber = returnNumber * 4;
        return returnNumber;
    }

    static void MyFunction(int newNumber)
    {
        //Check for prints
        bool extraCheck = false;
        float finalVarCheck = 0.5f;
        newNumber++;
        string Archimedes = "Curren Coutndwon:";
        extraCheck = !extraCheck;
        while(newNumber > 0 && extraCheck && finalVarCheck == 0.5f){
            newNumber -= 1;
            Console.WriteLine(Archimedes + " " + newNumber);
        }
        
    }
}