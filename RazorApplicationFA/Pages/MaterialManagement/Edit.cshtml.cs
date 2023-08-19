using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorApplicationFA.Data;
using RazorApplicationFA.Model.Doamin;

namespace RazorApplicationFA.Pages.MaterialManagement
{
    public class EditModel : PageModel
    {
        private readonly FADbContext _fADbContext;

        [BindProperty]
        public TFAMtrlGrp tFAMtrlGrp { get; set; }

        public EditModel(FADbContext fADbContext)
        {
            _fADbContext = fADbContext;
        }
        public void OnGet(int FAMtrlGrpId)
        {
            tFAMtrlGrp = _fADbContext.tFAMtrlGrp.FirstOrDefault(x => x.FAMtrlGrpId == FAMtrlGrpId);
        }
        public IActionResult OnPost()
        {
            _fADbContext.tFAMtrlGrp.Update(tFAMtrlGrp);
            _fADbContext.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
