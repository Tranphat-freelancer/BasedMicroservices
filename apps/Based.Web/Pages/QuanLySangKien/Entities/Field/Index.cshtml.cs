using System.Threading.Tasks;

namespace Based.Web.Pages.QuanLySangKien.Entities.Field;

public class IndexModel : BasedPageModel
{
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}
