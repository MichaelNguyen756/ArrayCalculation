namespace ArrayCalculation.API
{
    public class ArrayMethods
    {
        /// <summary>
        /// Reverses the values of an array
        /// </summary>
        /// <param name="arrayToReverse">Array of strings</param>
        /// <returns>A new array with its values reversed</returns>
        public static string[] ReverseArray(string[] arrayToReverse)
        {
            string[] reversedArray = new string[arrayToReverse.Length];

            for (int i = 0; i < arrayToReverse.Length; i++)
                reversedArray[(arrayToReverse.Length - 1) - i] = arrayToReverse[i];

            return reversedArray;
        }

        /// <summary>
        /// Deletes an item from an array
        /// </summary>
        /// <param name="arrayToDelete">Array of strings</param>
        /// <param name="indexToDelete">Index of the array to remove</param>
        /// <returns>A new array with the value at the index deleted</returns>
        public static string[] DeleteArrayAtIndex(string[] arrayToDelete, int indexToDelete = 0)
        {
            if (indexToDelete < arrayToDelete.Length)
            {
                string[] deletedArray = new string[arrayToDelete.Length - 1];
                bool foundIndex = false;

                for (int i = 0; i < arrayToDelete.Length; i++)
                    if (i != indexToDelete)
                        deletedArray[i - (foundIndex ? 1 : 0)] = arrayToDelete[i];
                    else
                        foundIndex = true;

                return deletedArray;
            }
            else
                return arrayToDelete;
        }
    }
}