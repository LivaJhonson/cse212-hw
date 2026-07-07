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

        // Step 1: Create a new double array with the size of length.
        // Step 2: Use a loop to go through each position in the array.
        // Step 3: For each position, multiply the starting number by the position number plus one.
        // Step 4: Store the calculated multiple in the array.
        // Step 5: Return the completed array.

          double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples; // replace this return statement with your own
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

        // Step 1: Find the index where the rotation should begin.
        // Step 2: Copy the values from that index to the end of the list.
        // Step 3: Copy the values from the beginning of the list up to the rotation point.
        // Step 4: Combine both parts into a new rotated list.
        // Step 5: Clear the original list.
        // Step 6: Add the rotated values back into the original list.
        int startIndex = data.Count - amount;

        List<int> rotated = new();

        rotated.AddRange(data.GetRange(startIndex, amount));
        rotated.AddRange(data.GetRange(0, startIndex));

        data.Clear();
        data.AddRange(rotated);
    }
}
