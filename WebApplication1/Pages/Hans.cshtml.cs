using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class HansModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Ruper Dupert fillidupert!";

            var ix = 0;
            for (; ix <= 100000000000; ix++)
            {
                ix += ix * ix;
            }

            Message = $"Result is {ix}";
        }
    }
}