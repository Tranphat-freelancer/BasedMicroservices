using System.Threading.Tasks;

namespace Based.Web.Pages.QuanLySangKien.Entities.Unit;

public class IndexModel : BasedPageModel
{
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}
