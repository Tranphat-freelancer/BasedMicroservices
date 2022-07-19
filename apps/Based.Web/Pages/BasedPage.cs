using Based.Localization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.Extensions.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Based.Web.Pages;

public abstract class BasedPage : AbpPage
{
    [RazorInject]
    public IStringLocalizer<BasedResource> L { get; set; }
    [RazorInject]
    public IAuthorizationService AuthorizationService { get; set; }

}
