using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace NguyenThiHanh073.Controllers
{
    public class PersonNTH073Controller : Controller
    {
        // 
        // GET: /PersonNTH073/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /PersonNTH073/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}