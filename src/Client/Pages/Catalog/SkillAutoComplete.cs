using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;
using FSH.BlazorWebAssembly.Client.Infrastructure.ApiClient;
using FSH.BlazorWebAssembly.Client.Shared;

namespace Portal.Client.Pages.Catalog;

public class SkillAutoComplete : MudAutocomplete<Guid>
{
    [Inject]
    private IStringLocalizer<SkillAutoComplete> L { get; set; } = default!;
    [Inject]
    private ISkillsClient SkillsClient { get; set; } = default!;
    [Inject]
    private ISnackbar Snackbar { get; set; } = default!;

    private List<SkillDto> _skills = new();

    // supply default parameters, but leave the possibility to override them
    public override Task SetParametersAsync(ParameterView parameters)
    {
        Label = L["Skill"];
        Variant = Variant.Filled;
        Dense = true;
        Margin = Margin.Dense;
        ResetValueOnEmptyText = true;
        SearchFunc = SearchSkills;
        ToStringFunc = GetSkillName;
        Clearable = true;
        return base.SetParametersAsync(parameters);
    }

    // when the value parameter is set, we have to load that one skill to be able to show the name
    // we can't do that in OnInitialized because of a strange bug (https://github.com/MudBlazor/MudBlazor/issues/3818)
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender &&
            _value != default &&
            await ApiHelper.ExecuteCallGuardedAsync(
                () => SkillsClient.GetAsync(_value), Snackbar) is { } skill)
        {
            _skills.Add(skill);
            ForceRender(true);
        }
    }

    private async Task<IEnumerable<Guid>> SearchSkills(string value)
    {
        var filter = new SearchSkillRequest
        {
            PageSize = 10,
            AdvancedSearch = new() { Fields = new[] { "name" }, Keyword = value }
        };

        if (await ApiHelper.ExecuteCallGuardedAsync(
                () => SkillsClient.SearchAsync(filter), Snackbar)
            is PaginationResponsesOfSkillDto response)
        {
            _skills = response.Data.ToList();
        }

        return _skills.Select(x => x.Id);
    }

    private string GetSkillName(Guid id) =>
        _skills.Find(b => b.Id == id)?.Name ?? string.Empty;
}
