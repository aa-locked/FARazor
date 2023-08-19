using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorApplicationFA.Data;
using RazorApplicationFA.Model.Doamin;

namespace RazorApplicationFA.Pages.MaterialManagement
{
    public class CreateGrpModel : PageModel
    {
        private readonly FADbContext _fADbContext;

        [BindProperty]
        public TFAMtrlGrp tFAMtrlGrp { get; set; }

        public CreateGrpModel(FADbContext fADbContext )
        {
            _fADbContext = fADbContext;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            _fADbContext.tFAMtrlGrp.Add(tFAMtrlGrp);
            _fADbContext.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
