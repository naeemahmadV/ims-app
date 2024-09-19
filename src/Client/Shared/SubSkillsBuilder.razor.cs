using Microsoft.AspNetCore.Components;
using MudBlazor;
using FSH.BlazorWebAssembly.Client.Infrastructure.ApiClient;
using System.Text.RegularExpressions;

namespace FSH.BlazorWebAssembly.Client.Shared;

public partial class SubSkillsBuilder
{
    [Inject]
    private ISubSkillsClient SubSkillsClient { get; set; }
    private readonly ISnackbar snackbar;

    //  [CascadingParameter] private HubConnection HubConnection { get; set; }

    private Guid Id => Guid.NewGuid();
    protected string Value { get; set; }
    protected bool IsContainSpecialCharacter { get; set; }
    [Parameter]
    public List<string> ExistSubSkills { get; set; }
    private List<string> SubSkills { get; set; } = new List<string>();
    public List<string> RequestedSubSkills { get; set; } = new List<string>();
    private List<string> _matchedSubSkillList { get; set; } = new List<string>();
    private List<string> _allSubSkills { get; set; }
    [Parameter]
    public EventCallback<List<string>> SelectedSubSkills { get; set; }
    [Parameter]
    public EventCallback<bool> SubSkillRemove { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (ExistSubSkills != null && ExistSubSkills.Count > 0)
        {
            SubSkills = ExistSubSkills;
        }

        await GetSkillsAsync();
        //HubConnection = HubConnection.TryInitialize(_navigationManager);
        //if (HubConnection.State == HubConnectionState.Disconnected)
        //{
        //    await HubConnection.StartAsync();
        //}
    }

    private async Task GetSkillsAsync()
    {
        var response = await SubSkillsClient.SearchAsync(new SearchSubSkillsRequest());
        if (response.Data is not null)
        {
            _allSubSkills = response.Data.ToList().Select(x => x.SubSkillName).ToList();
        }
        else
        {
            snackbar.Add("skill not found", Severity.Error);
        }
    }

    protected void AddSelectedSubSkills(string skill)
    {
        if (!string.IsNullOrEmpty(skill))
        {
            IsContainSpecialCharacter = false;
            var regex = new Regex(@"[^a-zA-Z0-9\s]");
            if (!regex.IsMatch(skill))
            {
                if (!SubSkills.Exists(t => t.Equals(skill, StringComparison.CurrentCultureIgnoreCase)))
                {
                    SubSkills.Add(skill);
                }

                Value = string.Empty;
                _matchedSubSkillList.Clear();
                RequestedSubSkills = SubSkills;
            }
            else
            {
                IsContainSpecialCharacter = true;
            }

            SelectedSubSkills.InvokeAsync(RequestedSubSkills);
        }
    }

    private void GetMatchedSubSkills(string category)
    {
        IsContainSpecialCharacter = false;
        if (!string.IsNullOrEmpty(category))
        {
            _matchedSubSkillList = _allSubSkills.Where(x => x.Contains(category, StringComparison.InvariantCultureIgnoreCase)).ToList();
        }
        else
        {
            _matchedSubSkillList.Clear();
        }
    }

    protected void DeleteSubSkill(string value)
    {
        if (string.IsNullOrEmpty(value)) return;

        var subskill = SubSkills.FirstOrDefault(t => t == value);

        if (subskill == null) return;

        if (SubSkills.Count == 1)
        {
            SubSkillRemove.InvokeAsync(true);
        }

        SubSkills.Remove(subskill);

        SelectedSubSkills.InvokeAsync(SubSkills);
    }
}
