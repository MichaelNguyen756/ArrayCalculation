using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArrayCalculation.Controllers
{
    public class APIController : Controller
    {
        // GET: API
        public string Index()
        {
            return "Please choose either \"reverse\" or  \"deletepart\" to test";
        }

        public string reverse()
        {
            string[] reversedArrayOfProductIDs = ReverseArray(Request.QueryString.GetValues("productIds"));
            return BuildArrayString(reversedArrayOfProductIDs);
        }

        public string deletepart(int position = 0)
        {
            string[] deletedArray = DeleteArrayAtIndex(Request.QueryString.GetValues("productIds"), position);
            return BuildArrayString(deletedArray);
        }

        /// <summary>
        /// Reverses the values of an array
        /// </summary>
        /// <param name="arrayToReverse">Array of strings</param>
        /// <returns>A new array with its values reversed</returns>
        private string[] ReverseArray(string[] arrayToReverse)
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
        private string[] DeleteArrayAtIndex(string[] arrayToDelete, int indexToDelete = 0)
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

        private string BuildArrayString(string[] array)
        {
            return $"[{String.Join(",", array)}]";
        }
    }
}