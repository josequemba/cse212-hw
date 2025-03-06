using System.Diagnostics;
public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        double[] arrayMultiples = new double [length]; // 1 - created an array with with the length of the multiples of given number
        
        for (int i = 0; i < length; ++i) { //itaration to get the index of the elements in the array
            arrayMultiples[i] = number * (i + 1); //adding the multiplication of number * 1 to length, to the right index from 0 to length
        }

        //Debug.WriteLine("result here Eliud:", string.Join(", ", arrayMultiples));

        return arrayMultiples; //returning the array with the multiples of number
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        List<int> rotate = new List<int>();
        int count = data.Count;
        int rotationRange = count - amount;

        for (int i = rotationRange; i < count; ++i) // first adding the last numbers accordint to amount to the new list
        {
            rotate.Add(data[i]);
        }
        
        for (int i = 0; i < rotationRange; ++i) // Then adding the remaining number
        {
            rotate.Add(data[i]);
        }

        data.Clear(); //empting the list befor adding the rotation result
            
        data.AddRange(rotate); // overrideing the data list with the new results of the rotation

        //Console.WriteLine(string.Join(", ", data));
    }
}
