using Microsoft.AspNetCore.Components;
using MudBlazor;
using FSH.BlazorWebAssembly.Client.Infrastructure.ApiClient;
using System.Text.RegularExpressions;

namespace FSH.BlazorWebAssembly.Client.Shared;

public partial class TechCoordinatorBuilder
{
    [Inject]
    private IUserClient UsersClient { get; set; }
    private readonly ISnackbar snackbar;

    //  [CascadingParameter] private HubConnection HubConnection { get; set; }

    private Guid Id => Guid.NewGuid();
    protected string Value { get; set; }
    protected bool IsContainSpecialCharacter { get; set; }
    [Parameter]
    public List<string> ExistUsers { get; set; }
    private List<string> Users { get; set; } = new List<string>();
    public List<string> RequestedUsers { get; set; } = new List<string>();
    private List<string> _matchedUserList { get; set; } = new List<string>();
    private List<string> _allUsers { get; set; }
    [Parameter]
    public EventCallback<List<string>> SelectedUsers { get; set; }
    [Parameter]
    public EventCallback<bool> UserRemove { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (ExistUsers != null && ExistUsers.Count > 0)
        {
            Users = ExistUsers;
        }

        await GetUsersAsync();
    }

    private async Task GetUsersAsync()
    {
        var response = await UsersClient.GetUserByRole("Technical coordinator");
        if (response is not null)
        {
            _allUsers = response.ToList().Select(x => x.Username).ToList();
        }

        //var response = await UsersClient.GetListAsync();
        //if (response is not null)
        //{
        //    _allUsers = response.ToList().Select(x => x.FirstName + " " + x?.LastName).ToList();
        //}
        else
        {
            snackbar.Add("user not found", Severity.Error);
        }
    }

    protected void AddSelectedUsers(string user)
    {
        if (!string.IsNullOrEmpty(user))
        {
            IsContainSpecialCharacter = false;
            var regex = new Regex(@"[^a-zA-Z0-9\s]");
            if (!regex.IsMatch(user))
            {
                if (!Users.Exists(t => t.Equals(user, StringComparison.CurrentCultureIgnoreCase)))
                {
                    Users.Add(user);
                }

                Value = string.Empty;
                _matchedUserList.Clear();
                RequestedUsers = Users;
            }
            else
            {
                IsContainSpecialCharacter = true;
            }

            SelectedUsers.InvokeAsync(RequestedUsers);
        }
    }

    private void GetMatchedUsers(string category)
    {
        IsContainSpecialCharacter = false;
        if (!string.IsNullOrEmpty(category))
        {
            _matchedUserList = _allUsers.Where(x => x.Contains(category, StringComparison.InvariantCultureIgnoreCase)).ToList();
        }
        else
        {
            _matchedUserList.Clear();
        }
    }

    protected void DeleteSkill(string value)
    {
        if (string.IsNullOrEmpty(value)) return;

        var user = Users.FirstOrDefault(t => t == value);

        if (user == null) return;

        if (Users.Count == 1)
        {
            UserRemove.InvokeAsync(true);
        }

        Users.Remove(user);

        SelectedUsers.InvokeAsync(RequestedUsers);
    }
}
