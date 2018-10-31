using System;
using System.Web.Mvc;
using ArrayCalculation.API;

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
            string[] reversedArrayOfProductIDs = ArrayMethods.ReverseArray(Request.QueryString.GetValues("productIds"));
            return BuildArrayString(reversedArrayOfProductIDs);
        }

        public string deletepart(int position = 0)
        {
            string[] deletedArray = ArrayMethods.DeleteArrayAtIndex(Request.QueryString.GetValues("productIds"), position);
            return BuildArrayString(deletedArray);
        }

        private string BuildArrayString(string[] array)
        {
            return $"[{string.Join(",", array)}]";
        }
    }
}