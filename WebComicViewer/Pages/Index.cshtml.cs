using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using System.Runtime.InteropServices;
using HeapStack.Core.CBR;

namespace WebApplication4.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public string? AppSettingsFile { get; set; }
        [BindProperty]
        public static IConfiguration? Config { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            AppSettingsFile = "settings.json";

            if (!System.IO.File.Exists(AppSettingsFile))
            {
                Debug.WriteLine("ERROR: " + AppSettingsFile + " file missing!"); // if console app
                return;
            }

            Config = new ConfigurationBuilder().AddJsonFile(AppSettingsFile).Build();

            if (!Directory.Exists(Config.GetSection("Comics_Directory").Value))
            {
                Debug.WriteLine("ERROR: Comics_Directory " + Config.GetSection("Comics_Directory").Value + " does not exist!"); // if console app
                return;
            }
        }
    }
}