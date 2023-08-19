using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorApplicationFA.Data;
using RazorApplicationFA.Model.Doamin;

namespace RazorApplicationFA.Pages.MaterialManagement
{
    public class IndexModel : PageModel
    {
        private readonly FADbContext _fADbContext;

        public List<TFAMtrlGrp> tFAMtrlGrps { get; set; }

        public IndexModel(FADbContext fADbContext)
        {
            _fADbContext = fADbContext;
        }
        public void OnGet()
        {
            tFAMtrlGrps=_fADbContext.tFAMtrlGrp.ToList();
        }
    }
}
