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
        // Step 1: Create an empty array of doubles with the size equal to 'length'.
        // Step 2: Use a for loop to iterate from 0 to length - 1.
        // Step 3: For each iteration i, calculate the multiple as number * (i + 1).
        // Step 4: Assign the calculated multiple to the array at index i.
        // Step 5: After the loop ends, return the array containing all multiples.
        var multiples = new double[length];
        for (var i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }
        return multiples;
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
        // Step 1: Determine the number of elements in the list (data.Count).
        // Step 2: If amount is equal to the list size or 0, no rotation is needed; exit the function.
        // Step 3: Create a new temporary list to hold the rotated elements.
        // Step 4: Take the last 'amount' elements from the original list and add them first to the temporary list.
        // Step 5: Take the first 'data.Count - amount' elements from the original list and append them to the temporary list.
        // Step 6: Copy the elements from the temporary list back into the original list so that it is rotated in place.
        var size = data.Count;
        if (amount == size || amount == 0)
            return;
        var rotated = new List<int>(size);
        for (var i = size - amount; i < size; i++)
        {
            rotated.Add(data[i]);
        }
        for (var i = 0; i < size - amount; i++)
        {
            rotated.Add(data[i]);
        }
        for (var i = 0; i < size; i++)
        {
            data[i] = rotated[i];
        }
    }
}
