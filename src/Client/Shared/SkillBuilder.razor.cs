using Microsoft.AspNetCore.Components;
using MudBlazor;
using FSH.BlazorWebAssembly.Client.Infrastructure.ApiClient;
using System.Text.RegularExpressions;

namespace FSH.BlazorWebAssembly.Client.Shared;

public partial class SkillBuilder
{
    [Inject]
    private ISkillsClient SkillsClient { get; set; }
    private readonly ISnackbar snackbar;

    //  [CascadingParameter] private HubConnection HubConnection { get; set; }

    private Guid Id => Guid.NewGuid();
    protected string Value { get; set; }
    protected bool IsContainSpecialCharacter { get; set; }
    [Parameter]
    public List<string> ExistSkills { get; set; }
    private List<string> Skills { get; set; } = new List<string>();
    public List<string> RequestedSkills { get; set; } = new List<string>();
    private List<string> _matchedSkillList { get; set; } = new List<string>();
    private List<string> _allSkills { get; set; }
    [Parameter]
    public EventCallback<List<string>> SelectedSkills { get; set; }
    [Parameter]
    public EventCallback<bool> SkillRemove { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (ExistSkills != null && ExistSkills.Count > 0)
        {
            Skills = ExistSkills;
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
        var response = await SkillsClient.SearchAsync(new SearchSkillRequest());
        if (response.Data is not null)
        {
            _allSkills = response.Data.ToList().Select(x => x.Name).ToList();
        }
        else
        {
           snackbar.Add("skill not found", Severity.Error);
        }
    }

    protected void AddSelectedSkills(string skill)
    {
        if (!string.IsNullOrEmpty(skill))
        {
            IsContainSpecialCharacter = false;
            var regex = new Regex(@"[^a-zA-Z0-9\s]");
            //if (!regex.IsMatch(skill))
            //{
                if (!Skills.Exists(t => t.Equals(skill, StringComparison.CurrentCultureIgnoreCase)))
                {
                    Skills.Add(skill);
                }
                Value = string.Empty;
                _matchedSkillList.Clear();
                RequestedSkills = Skills;
            //}
            //else
            //{
            //    IsContainSpecialCharacter = true;
            //}

            SelectedSkills.InvokeAsync(RequestedSkills);
        }
    }

    private void GetMatchedSkills(string category)
    {
        IsContainSpecialCharacter = false;
        if (!string.IsNullOrEmpty(category))
        {
            _matchedSkillList = _allSkills.Where(x => x.Contains(category, StringComparison.InvariantCultureIgnoreCase)).ToList();
        }
        else
        {
            _matchedSkillList.Clear();
        }
    }

    protected void DeleteSkill(string value)
    {
        if (string.IsNullOrEmpty(value)) return;

        var skill = Skills.FirstOrDefault(t => t == value);

        if (skill == null) return;

        if (Skills.Count == 1)
        {
            SkillRemove.InvokeAsync(true);
        }

        Skills.Remove(skill);

        SelectedSkills.InvokeAsync(Skills);
    }
}
