using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace QuanLySangKien.Web.Menus;

public class QuanLySangKienMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(QuanLySangKienMenus.Prefix, displayName: "QuanLySangKien", "~/QuanLySangKien", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
