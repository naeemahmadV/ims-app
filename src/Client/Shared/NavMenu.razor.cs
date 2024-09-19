using FSH.BlazorWebAssembly.Client.Infrastructure.Auth;
using FSH.BlazorWebAssembly.Client.Infrastructure.Common;
using FSH.WebApi.Shared.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace FSH.BlazorWebAssembly.Client.Shared;

public partial class NavMenu
{
    [CascadingParameter]
    protected Task<AuthenticationState> AuthState { get; set; } = default!;
    [Inject]
    protected IAuthorizationService AuthService { get; set; } = default!;

    private string? _hangfireUrl;
    private bool _canViewHangfire;
    private bool _canViewDashboard;
    private bool _canViewRoles;
    private bool _canViewUsers;
    private bool _canViewProducts;
    private bool _canViewSubSkills;
    private bool _canViewBrands;
    private bool _canViewSkills;
    private bool _canViewTenants;
    private bool _canViewCompany;
    private bool _canViewLead;
    private bool _canViewUserTask;
    private bool CanViewAdministrationGroup => _canViewUsers || _canViewRoles || _canViewTenants;

    protected override async Task OnParametersSetAsync()
    {
        _hangfireUrl = Config[ConfigNames.ApiBaseUrl] + "jobs";
        var user = (await AuthState).User;
        _canViewHangfire = await AuthService.HasPermissionAsync(user, FSHAction.View, FSHResource.Hangfire);
        _canViewDashboard = await AuthService.HasPermissionAsync(user, FSHAction.View, FSHResource.Dashboard);
        _canViewRoles = await AuthService.HasPermissionAsync(user, FSHAction.View, FSHResource.Roles);
        _canViewUsers = await AuthService.HasPermissionAsync(user, FSHAction.View, FSHResource.Users);
        _canViewProducts = await AuthService.HasPermissionAsync(user, FSHAction.View, FSHResource.Products);
        _canViewBrands = await AuthService.HasPermissionAsync(user, FSHAction.View, FSHResource.Brands);
        _canViewSkills = await AuthService.HasPermissionAsync(user, FSHAction.View, FSHResource.Skill);
        _canViewTenants = await AuthService.HasPermissionAsync(user, FSHAction.View, FSHResource.Tenants);
        _canViewCompany = await AuthService.HasPermissionAsync(user, FSHAction.View, FSHResource.Company);
        _canViewSubSkills = await AuthService.HasPermissionAsync(user, FSHAction.View, FSHResource.SubSkill);
        _canViewLead = await AuthService.HasPermissionAsync(user, FSHAction.View, FSHResource.Lead);
        //_canViewUserTask = await AuthService.HasPermissionAsync(user, FSHAction.View, FSHResource.Us);
    }
}