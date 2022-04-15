using GenericApp.Domain.Interfaces;
using GenericApp.Domain.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GenericWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IGenericApiService _genericApiService;
        public Person? Person { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IGenericApiService genericApiService)
        {
            _logger = logger;
            _genericApiService = genericApiService;
        }

        public async Task OnGet()
        {
            Person = await _genericApiService.GetPerson();
        }
    }
}