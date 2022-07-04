using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Based.Web.Pages;

public class IndexModel : BasedPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
