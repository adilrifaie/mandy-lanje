using Microsoft.AspNetCore.Mvc;
using Repositories;
using Services.Contracts;

namespace StoreApp.Components;

public class UserSummaryViewComponent : ViewComponent
{
    private readonly IServiceManager _manager;

    public UserSummaryViewComponent(IServiceManager manager)
    {
        _manager = manager;
    }

    public string Invoke()
    {
        // service
        return _manager.AuthService.GetAllUsers().Count().ToString();
    }
}
