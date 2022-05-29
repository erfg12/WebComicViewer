using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class ViewModel : PageModel
    {
        private readonly ILogger<ViewModel> _logger;

        public ViewModel(ILogger<ViewModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string readfile)
        {
            ReadFile = readfile;
        }
        [BindProperty]
        public static string ReadFile { get; set; }
    }
}