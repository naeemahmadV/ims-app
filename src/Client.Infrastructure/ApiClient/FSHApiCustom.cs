using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel;

namespace FSH.BlazorWebAssembly.Client.Infrastructure.ApiClient;
public enum Months
{
    Jan = 1,
    Feb = 2,
    Mar = 3,
    Apr = 4,
    May = 5,
    Jun = 6,
    Jul = 7,
    Aug = 8,
    Sep = 9,
    Oct = 10,
    Nov = 11,
    Dec = 12
}

public enum LeadStatus
{
    [Description("New")]
    New = 1,
    [Description("Contacted")]
    Contacted = 2,
    [Description("Response Required")]
    ResponseRequired = 3,
    [Description("Live")]
    Live = 4,
    [Description("Follow up")]
    Followup = 5,
    [Description("Analysis")]
    Analysis = 6,
    [Description("On Hold")]
    OnHold = 7,
    [Description("Qualified")]
    Qualified = 8,
    [Description("Dead")]
    Dead = 9,
    [Description("Junk")]
    Junk = 10

}

public enum OpportunityStatus
{
    [Description("Open")]
    Open = 1,
    [Description("In Progress")]
    InProgress = 2,
    [Description("On Hold")]
    OnHold = 3,
    [Description("Won")]
    Won = 4,
    [Description("Lost")]
    Lost = 5
}


public enum AccountStatus
{
    [Description("New")]
    New = 1,
    [Description("Contacted")]
    Contacted = 2,
    [Description("Response Required")]
    ResponseRequired = 3,
    [Description("Live")]
    Live = 4,
    [Description("Follow up")]
    Followup = 5,
    [Description("Analysis")]
    Analysis = 6,
    [Description("On Hold")]
    OnHold = 7,
    [Description("Qualified")]
    Qualified = 8,
    [Description("Dead")]
    Dead = 9,
    [Description("Junk")]
    Junk = 10

}
public enum PreferredContactMethod
{
    [Description("Team")]
    Team = 1,
    [Description("Zoom")]
    Zoom = 2,
    [Description("slack")]
    slack = 3,
    [Description("Other")]
    Other = 4
}
public enum ActivityType
{
    [Description("Welcome Email")]
    WelcomeEmail = 1,

    [Description("Meeting with Client")]
    MeetingwithClient,

    [Description("Share Proposal + Resume")]
    ShareProposalResume,

    [Description("Reply Client Query")]
    ReplyClientQuery,

    [Description("Follow-up")]
    Followup
}
public enum TasksStatus
{
    [Description("Pending")]
    Pending = 1,

    [Description("InProgress")]
    InProgress = 2,

    [Description("Completed")]
    Completed = 3,

}

public static class EnumHelper
{
    public static string GetDescription(Enum value)
    {
        FieldInfo field = value.GetType().GetField(value.ToString());

        if (field != null)
        {
            DescriptionAttribute attribute = (DescriptionAttribute)field.GetCustomAttribute(typeof(DescriptionAttribute));

            if (attribute != null)
            {
                return attribute.Description;
            }
        }

        return value.ToString(); // Return the enum value itself if no description is found.
    }
}

public partial class UpdateSubSkillsRequest
{
    [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Guid Id { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("subSkillName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string SubSkillName { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("skillId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Guid SkillId { get; set; } = default!;

}

public partial class SubSkillsDto
{
    [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Guid Id { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("skillId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Guid? SkillId { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("skillName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string SkillName { get; set; } = default!;

}

public partial class PaginationResponseOfAccountSourcesDto
{
    [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<AccountSourcesDto> Data { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("currentPage", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int CurrentPage { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("totalPages", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int TotalPages { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("totalCount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int TotalCount { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("pageSize", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int PageSize { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("hasPreviousPage", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool HasPreviousPage { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("hasNextPage", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool HasNextPage { get; set; } = default!;

}

public partial class AccountSourcesDto
{
    [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Guid? Id { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("sourceName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Name { get; set; } = default!;

}

public partial class PaginationResponseOfLeadSourcesDto
{
    [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<LeadSourcesDto> Data { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("currentPage", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int CurrentPage { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("totalPages", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int TotalPages { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("totalCount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int TotalCount { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("pageSize", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int PageSize { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("hasPreviousPage", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool HasPreviousPage { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("hasNextPage", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool HasNextPage { get; set; } = default!;

}

public partial class LeadSourcesDto
{
    [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Guid? Id { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("sourceName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Name { get; set; } = default!;

}
public partial interface IAccountSourcesClient : IApiService
{
    System.Threading.Tasks.Task<PaginationResponseOfAccountSourcesDto> SearchAsync(SearchAccountSourceRequest request);

    System.Threading.Tasks.Task<PaginationResponseOfAccountSourcesDto> SearchAsync(SearchAccountSourceRequest request, System.Threading.CancellationToken cancellationToken);

}

public partial interface ILeadActivitiesClient : IApiService
{
    /// <summary>
    /// Search Lead Activity using available filters.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    System.Threading.Tasks.Task<PaginationResponseOfLeadActivityDto> SearchAsync(SearchLeadAcitivityRequest request);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Search Lead Activity using available filters.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    System.Threading.Tasks.Task<PaginationResponseOfLeadActivityDto> SearchAsync(SearchLeadAcitivityRequest request, System.Threading.CancellationToken cancellationToken);

    /// <summary>
    /// Get Lead Activity details.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    System.Threading.Tasks.Task<LeadActivityDto> GetAsync(System.Guid id);

    ///// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    ///// <summary>
    ///// Get Lead Activity details.
    ///// </summary>
    ///// <exception cref="ApiException">A server side error occurred.</exception>
    System.Threading.Tasks.Task<LeadActivityDto> GetAsync(System.Guid id, System.Threading.CancellationToken cancellationToken);

    /// <summary>
    /// Update a Lead Activity.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    System.Threading.Tasks.Task<System.Guid> UpdateAsync(System.Guid id, UpdateLeadActivityRequest request);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Update a Lead Activity.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    ///
    System.Threading.Tasks.Task<System.Guid> UpdateTaskAsync(System.Guid id, UpdateLeadActivityTaskRequest request);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Update a Lead Activity.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    /// 
    System.Threading.Tasks.Task<System.Guid> UpdateAsync(System.Guid id, UpdateLeadActivityRequest request, System.Threading.CancellationToken cancellationToken);

    System.Threading.Tasks.Task<System.Guid> DeleteAsync(System.Guid id);

    System.Threading.Tasks.Task<System.Guid> DeleteAsync(System.Guid id, System.Threading.CancellationToken cancellationToken);

    System.Threading.Tasks.Task<System.Guid> CreateAsync(CreateLeadActivityRequest request);

    System.Threading.Tasks.Task<System.Guid> CreateAsync(CreateLeadActivityRequest request, System.Threading.CancellationToken cancellationToken);

    System.Threading.Tasks.Task<PaginationResponseOfLeadActivityTaskDto> GetAsyncUserTask(SearchLeadAcitivityTaskRequest request);
}

public partial interface ISkillsClient : IApiService
{
    System.Threading.Tasks.Task<PaginationResponsesOfSkillDto> SearchAsync(SearchSkillRequest request);

    System.Threading.Tasks.Task<PaginationResponsesOfSkillDto> SearchAsync(SearchSkillRequest request, System.Threading.CancellationToken cancellationToken);

    System.Threading.Tasks.Task<SkillDto> GetAsync(System.Guid id);

    System.Threading.Tasks.Task<SkillDto> GetAsync(System.Guid id, System.Threading.CancellationToken cancellationToken);

    System.Threading.Tasks.Task<System.Guid> UpdateAsync(System.Guid id, UpdateSkillRequest request);

    System.Threading.Tasks.Task<System.Guid> UpdateAsync(System.Guid id, UpdateSkillRequest request, System.Threading.CancellationToken cancellationToken);

    System.Threading.Tasks.Task<System.Guid> DeleteAsync(System.Guid id);

    System.Threading.Tasks.Task<System.Guid> DeleteAsync(System.Guid id, System.Threading.CancellationToken cancellationToken);

    System.Threading.Tasks.Task<System.Guid> CreateAsync(CreateSkillRequest request);

    System.Threading.Tasks.Task<System.Guid> CreateAsync(CreateSkillRequest request, System.Threading.CancellationToken cancellationToken);
}

public partial interface IUserClient : IApiService
{
    System.Threading.Tasks.Task<List<UserDto>> GetUserSearchAsync(SearchUserRequest request);
    System.Threading.Tasks.Task<List<UsersRolesViewModel>> GetUserByRole(string role);
}

public partial interface ISubSkillsClient : IApiService
{
    System.Threading.Tasks.Task<PaginationResponseOfSubSkillDto> SearchAsync(SearchSubSkillsRequest request);

    System.Threading.Tasks.Task<PaginationResponseOfSubSkillDto> SearchAsync(SearchSubSkillsRequest request, System.Threading.CancellationToken cancellationToken);

    System.Threading.Tasks.Task<SubSkillDto> GetAsync(System.Guid id);

    System.Threading.Tasks.Task<SubSkillDto> GetAsync(System.Guid id, System.Threading.CancellationToken cancellationToken);

    System.Threading.Tasks.Task<System.Guid> UpdateAsync(System.Guid id, UpdateSubSkillsRequest request);

    System.Threading.Tasks.Task<System.Guid> UpdateAsync(System.Guid id, UpdateSubSkillsRequest request, System.Threading.CancellationToken cancellationToken);

    System.Threading.Tasks.Task<System.Guid> DeleteAsync(System.Guid id);

    System.Threading.Tasks.Task<System.Guid> DeleteAsync(System.Guid id, System.Threading.CancellationToken cancellationToken);

    System.Threading.Tasks.Task<System.Guid> CreateAsync(CreateSubSkillRequest request);

    System.Threading.Tasks.Task<System.Guid> CreateAsync(CreateSubSkillRequest request, System.Threading.CancellationToken cancellationToken);
}

public interface ILeadSourcesClient : IApiService
{
    System.Threading.Tasks.Task<PaginationResponseOfLeadSourcesDto> SearchAsync(SearchLeadSourceRequest request);

    System.Threading.Tasks.Task<PaginationResponseOfLeadSourcesDto> SearchAsync(SearchLeadSourceRequest request, System.Threading.CancellationToken cancellationToken);

}

public interface IMediasClient : IApiService
{
    System.Threading.Tasks.Task<System.Guid> CreateAsync(CreateMediaRequest request);

    System.Threading.Tasks.Task<System.Guid> CreateAsync(CreateMediaRequest request, System.Threading.CancellationToken cancellationToken);
}

public interface ILeadsClient : IApiService
{
    Task<PaginationResponseOfLeadDto> SearchAsync(SearchLeadsRequest request);

    Task<PaginationResponseOfLeadDto> SearchAsync(SearchLeadsRequest request, System.Threading.CancellationToken cancellationToken);

    Task<LeadDto> GetAsync(System.Guid id);

    Task<LeadDto> GetAsync(System.Guid id, System.Threading.CancellationToken cancellationToken);

    Task<System.Guid> UpdateAsync(System.Guid id, UpdateLeadRequest request);

    Task<System.Guid> UpdateAsync(System.Guid id, UpdateLeadRequest request, System.Threading.CancellationToken cancellationToken);

    Task<System.Guid> DeleteAsync(System.Guid id);

    Task<System.Guid> DeleteAsync(System.Guid id, System.Threading.CancellationToken cancellationToken);

    Task<System.Guid> CreateAsync(CreateLeadRequest request);

    Task<System.Guid> CreateAsync(CreateLeadRequest request, System.Threading.CancellationToken cancellationToken);

    Task<List<LeadStatusDto>> LeadStatusAsync();

    Task<List<LeadStatusDto>> LeadStatusAsync(System.Threading.CancellationToken cancellationToken);

    Task<List<PreferredShiftTimingDto>> PreferredShiftTimingAsync();

    Task<List<PreferredShiftTimingDto>> PreferredShiftTimingAsync(System.Threading.CancellationToken cancellationToken);

    Task<List<LeadTypeDto>> LeadTypeAsync();

    Task<List<LeadTypeDto>> LeadTypeAsync(System.Threading.CancellationToken cancellationToken);

    Task<List<LeadYearDto>> LeadYearAsync();

    Task<List<LeadYearDto>> LeadYearAsync(System.Threading.CancellationToken cancellationToken);

    Task<List<LeadMonthDto>> GetLeadCountMonthWiseAsync(int year);

    Task<List<LeadMonthDto>> GetLeadCountMonthWiseAsync(int year, System.Threading.CancellationToken cancellationToken);

    Task<List<LeadDayDto>> GetLeadCountDayWiseAsync(int year, int month);

    Task<List<LeadDayDto>> GetLeadCountDayWiseAsync(int year, int month, System.Threading.CancellationToken cancellationToken);
}

public interface IAccountsClient : IApiService
{
    Task<PaginationResponseOfAccountDto> SearchAsync(SearchAccountRequest request);

    Task<PaginationResponseOfAccountDto> SearchAsync(SearchAccountRequest request, CancellationToken cancellationToken);

    Task<AccountDto> GetAsync(Guid id);

    Task<AccountDto> GetAsync(Guid id, CancellationToken cancellationToken);

    Task<Guid> UpdateAsync(Guid id, UpdateAccountRequest request);

    Task<Guid> UpdateAsync(Guid id, UpdateAccountRequest request, CancellationToken cancellationToken);

    Task<Guid> DeleteAsync(Guid id);

    Task<Guid> DeleteAsync(Guid id, CancellationToken cancellationToken);

    Task<Guid> CreateAsync(CreateAccountRequest request);

    Task<Guid> CreateAsync(CreateAccountRequest request, CancellationToken cancellationToken);

    Task<List<AccountStatusDto>> AccountStatusAsync();

    Task<List<PreferredShiftTimingDto>> PreferredShiftTimingAsync();

    Task<List<PreferredShiftTimingDto>> PreferredShiftTimingAsync(CancellationToken cancellationToken);

    Task<List<AccountTypeDto>> AccountTypeAsync();

    Task<List<AccountTypeDto>> AccountTypeAsync(CancellationToken cancellationToken);

    Task<List<AccountYearDto>> AccountYearAsync();

    Task<List<AccountYearDto>> AccountYearAsync(CancellationToken cancellationToken);

    Task<List<AccountMonthDto>> GetAccountCountMonthWiseAsync(int year);

    Task<List<AccountMonthDto>> GetAccountCountMonthWiseAsync(int year, CancellationToken cancellationToken);

    Task<List<AccountDayDto>> GetAccountCountDayWiseAsync(int year, int month);

    Task<List<AccountDayDto>> GetAccountCountDayWiseAsync(int year, int month, CancellationToken cancellationToken);
}

public partial interface IAccountActivitiesClient : IApiService
{
    System.Threading.Tasks.Task<PaginationResponseOfAccountActivityDto> SearchAsync(SearchAccountAcitivityRequest request);

    System.Threading.Tasks.Task<PaginationResponseOfAccountActivityDto> SearchAsync(SearchAccountAcitivityRequest request, System.Threading.CancellationToken cancellationToken);

    System.Threading.Tasks.Task<AccountActivityDto> GetAsync(System.Guid id);

    System.Threading.Tasks.Task<AccountActivityDto> GetAsync(System.Guid id, System.Threading.CancellationToken cancellationToken);

    System.Threading.Tasks.Task<System.Guid> UpdateAsync(System.Guid id, UpdateAccountActivityRequest request);

    System.Threading.Tasks.Task<System.Guid> UpdateTaskAsync(System.Guid id, UpdateAccountActivityTaskRequest request);

    System.Threading.Tasks.Task<System.Guid> UpdateAsync(System.Guid id, UpdateAccountActivityRequest request, System.Threading.CancellationToken cancellationToken);

    System.Threading.Tasks.Task<System.Guid> DeleteAsync(System.Guid id);

    System.Threading.Tasks.Task<System.Guid> DeleteAsync(System.Guid id, System.Threading.CancellationToken cancellationToken);

    System.Threading.Tasks.Task<System.Guid> CreateAsync(CreateAccountActivityRequest request);

    System.Threading.Tasks.Task<System.Guid> CreateAsync(CreateAccountActivityRequest request, System.Threading.CancellationToken cancellationToken);

    System.Threading.Tasks.Task<PaginationResponseOfAccountActivityTaskDto> GetAsyncUserTask(SearchAccountAcitivityTaskRequest request);
}

public partial class UpdateAccountActivityTaskRequest
{
    [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public Guid Id { get; set; }

    [Newtonsoft.Json.JsonProperty("accountId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public Guid? AccountId { get; set; }

    [Newtonsoft.Json.JsonProperty("activityType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int ActivityType { get; set; }

    [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.Required]
    public string? Title { get; set; }

    [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Description { get; set; }

    [Newtonsoft.Json.JsonProperty("markAsTask", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool MarkAsTask { get; set; }

    [Newtonsoft.Json.JsonProperty("taskStartDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.Required]
    public DateTime? TaskStartDate { get; set; }

    [Newtonsoft.Json.JsonProperty("taskDueDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.Required]
    public DateTime? TaskDueDate { get; set; }

    [Newtonsoft.Json.JsonProperty("taskStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int TaskStatus { get; set; }

    [Newtonsoft.Json.JsonProperty("taskCompletedOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public DateTime? TaskCompletedOn { get; set; }

    [Newtonsoft.Json.JsonProperty("activityMedia", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public Guid[]? ActivityMedia { get; set; }

    [Newtonsoft.Json.JsonProperty("assignTo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public Guid? AssignTo { get; set; }
}

public partial class SearchUserRequest : PaginationFilter
{

}

public partial class SearchAccountAcitivityRequest : PaginationFilter
{
    [Newtonsoft.Json.JsonProperty("accountId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public Guid AccountId { get; set; } = default!;
}

public partial class SkillDto
{
    [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Guid Id { get; set; } = default!;
}

public partial class PaginationResponsesOfSkillDto
{
    [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<SkillDto> Data { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("currentPage", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int CurrentPage { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("totalPages", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int TotalPages { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("totalCount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int TotalCount { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("pageSize", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int PageSize { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("hasPreviousPage", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool HasPreviousPage { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("hasNextPage", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool HasNextPage { get; set; } = default!;

}

public partial class SearchLeadsRequest : PaginationFilter
{
    [Newtonsoft.Json.JsonProperty("countryId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Guid? CountryId { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("stateId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Guid? StateId { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("cityId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Guid? CityId { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("leadSourceId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Guid? LeadSourceId { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("year", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? Year { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("month", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? Month { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("day", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? Day { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("createdOnOrder", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool CreatedOnOrder { get; set; }

    [Newtonsoft.Json.JsonProperty("MarkAsQualified", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? MarkAsQualified { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Guid? UserId { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("userRole", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string UserRole { get; set; } = default!;
}

public partial class UpdateLeadActivityTaskRequest
{
    [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public Guid Id { get; set; }

    [Newtonsoft.Json.JsonProperty("leadId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public Guid? LeadId { get; set; }

    [Newtonsoft.Json.JsonProperty("activityType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int ActivityType { get; set; }

    [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.Required]
    public string? Title { get; set; }

    [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Description { get; set; }

    [Newtonsoft.Json.JsonProperty("markAsTask", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool MarkAsTask { get; set; }

    [Newtonsoft.Json.JsonProperty("taskStartDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.Required]
    public DateTime? TaskStartDate { get; set; }

    [Newtonsoft.Json.JsonProperty("taskDueDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.Required]
    public DateTime? TaskDueDate { get; set; }

    [Newtonsoft.Json.JsonProperty("taskStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int TaskStatus { get; set; }

    [Newtonsoft.Json.JsonProperty("taskCompletedOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public DateTime? TaskCompletedOn { get; set; }

    [Newtonsoft.Json.JsonProperty("activityMedia", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public Guid[]? ActivityMedia { get; set; }

    [Newtonsoft.Json.JsonProperty("assignTo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public Guid? AssignTo { get; set; }
}

public partial class UserDto
{
    [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Guid Id { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("userName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? UserName { get; set; } = default!;
}

public class PreferredShiftTimingDto
{
    [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int Id { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Name { get; set; } = default!;

}

public class SearchSubSkillsRequest : PaginationFilter
{
    [Newtonsoft.Json.JsonProperty("skillId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Guid? SkillId { get; set; } = default!;
}

public partial class LeadActivitiesClient : ILeadActivitiesClient
{
    private System.Net.Http.HttpClient _httpClient;
    private System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;

    public LeadActivitiesClient(System.Net.Http.HttpClient httpClient)
    {
        _httpClient = httpClient;
        _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(CreateSerializerSettings);
    }

    private Newtonsoft.Json.JsonSerializerSettings CreateSerializerSettings()
    {
        var settings = new Newtonsoft.Json.JsonSerializerSettings();
        UpdateJsonSerializerSettings(settings);
        return settings;
    }

    protected Newtonsoft.Json.JsonSerializerSettings JsonSerializerSettings { get { return _settings.Value; } }

    partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);

    partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, string url);
    partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, System.Text.StringBuilder urlBuilder);
    partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);


    /// <summary>
    /// Search lead activity using available filters.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual System.Threading.Tasks.Task<PaginationResponseOfLeadActivityDto> SearchAsync(SearchLeadAcitivityRequest request)
    {
        return SearchAsync(request, System.Threading.CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Search lead activity using available filters.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async System.Threading.Tasks.Task<PaginationResponseOfLeadActivityDto> SearchAsync(SearchLeadAcitivityRequest request, System.Threading.CancellationToken cancellationToken)
    {
        if (request == null)
            throw new System.ArgumentNullException("request");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/leadactivity/search");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, _settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("POST");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<PaginationResponseOfLeadActivityDto>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// Get lead acitivity using available filters.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>

    public virtual System.Threading.Tasks.Task<LeadActivityDto> GetAsync(System.Guid id)
    {
        return GetAsync(id, System.Threading.CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Get lead acitivity details.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async System.Threading.Tasks.Task<LeadActivityDto> GetAsync(System.Guid id, System.Threading.CancellationToken cancellationToken)
    {
        if (id == null)
            throw new System.ArgumentNullException("id");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/leadactivity/{id}");
        urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                request_.Method = new System.Net.Http.HttpMethod("GET");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<LeadActivityDto>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// Update a lead.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual System.Threading.Tasks.Task<System.Guid> UpdateAsync(System.Guid id, UpdateLeadActivityRequest request)
    {
        return UpdateAsync(id, request, System.Threading.CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Update a lead.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async System.Threading.Tasks.Task<System.Guid> UpdateAsync(System.Guid id, UpdateLeadActivityRequest request, System.Threading.CancellationToken cancellationToken)
    {
        if (id == null)
            throw new System.ArgumentNullException("id");

        if (request == null)
            throw new System.ArgumentNullException("request");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/leadactivity/{id}");
        urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, _settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("PUT");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<System.Guid>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }


    public virtual System.Threading.Tasks.Task<System.Guid> UpdateTaskAsync(System.Guid id, UpdateLeadActivityTaskRequest request)
    {
        return UpdateTaskAsync(id, request, System.Threading.CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Update a lead.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async System.Threading.Tasks.Task<System.Guid> UpdateTaskAsync(System.Guid id, UpdateLeadActivityTaskRequest request, System.Threading.CancellationToken cancellationToken)
    {
        if (id == null)
            throw new System.ArgumentNullException("id");

        if (request == null)
            throw new System.ArgumentNullException("request");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/leadactivity/{id}");
        urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, _settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("PUT");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<System.Guid>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// Delete a lead activity.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual System.Threading.Tasks.Task<System.Guid> DeleteAsync(System.Guid id)
    {
        return DeleteAsync(id, System.Threading.CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Delete a lead activity.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async System.Threading.Tasks.Task<System.Guid> DeleteAsync(System.Guid id, System.Threading.CancellationToken cancellationToken)
    {
        if (id == null)
            throw new System.ArgumentNullException("id");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/leadactivity/{id}");
        urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                request_.Method = new System.Net.Http.HttpMethod("DELETE");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<System.Guid>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// Create a new lead activity.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual System.Threading.Tasks.Task<System.Guid> CreateAsync(CreateLeadActivityRequest request)
    {
        return CreateAsync(request, System.Threading.CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Create a new lead activity.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async System.Threading.Tasks.Task<System.Guid> CreateAsync(CreateLeadActivityRequest request, System.Threading.CancellationToken cancellationToken)
    {
        if (request == null)
            throw new System.ArgumentNullException("request");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/leadactivity");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, _settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("POST");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<System.Guid>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }


    public virtual System.Threading.Tasks.Task<PaginationResponseOfLeadActivityTaskDto> GetAsyncUserTask(SearchLeadAcitivityTaskRequest request)
    {
        return GetAsyncUserTask(request, System.Threading.CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Search lead activity using available filters.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async System.Threading.Tasks.Task<PaginationResponseOfLeadActivityTaskDto> GetAsyncUserTask(SearchLeadAcitivityTaskRequest request, System.Threading.CancellationToken cancellationToken)
    {
        if (request == null)
            throw new System.ArgumentNullException("request");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/leadactivity/assignTask");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, _settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("POST");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<PaginationResponseOfLeadActivityTaskDto>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// Get lead acitivity using available filters.

    protected struct ObjectResponseResult<T>
    {
        public ObjectResponseResult(T responseObject, string responseText)
        {
            this.Object = responseObject;
            this.Text = responseText;
        }

        public T Object { get; }

        public string Text { get; }
    }

    public bool ReadResponseAsString { get; set; }

    protected virtual async System.Threading.Tasks.Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(System.Net.Http.HttpResponseMessage response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Threading.CancellationToken cancellationToken)
    {
        if (response == null || response.Content == null)
        {
            return new ObjectResponseResult<T>(default(T)!, string.Empty);
        }

        if (ReadResponseAsString)
        {
            var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            try
            {
                var typedBody = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseText, JsonSerializerSettings);
                return new ObjectResponseResult<T>(typedBody!, responseText);
            }
            catch (Newtonsoft.Json.JsonException exception)
            {
                var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                throw new ApiException(message, (int)response.StatusCode, responseText, headers, exception);
            }
        }
        else
        {
            try
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                using (var streamReader = new System.IO.StreamReader(responseStream))
                using (var jsonTextReader = new Newtonsoft.Json.JsonTextReader(streamReader))
                {
                    var serializer = Newtonsoft.Json.JsonSerializer.Create(JsonSerializerSettings);
                    var typedBody = serializer.Deserialize<T>(jsonTextReader);
                    return new ObjectResponseResult<T>(typedBody!, string.Empty);
                }
            }
            catch (Newtonsoft.Json.JsonException exception)
            {
                var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                throw new ApiException(message, (int)response.StatusCode, string.Empty, headers, exception);
            }
        }
    }

    private string ConvertToString(object? value, System.Globalization.CultureInfo cultureInfo)
    {
        if (value == null)
        {
            return "";
        }

        if (value is System.Enum)
        {
            var name = System.Enum.GetName(value.GetType(), value);
            if (name != null)
            {
                var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                if (field != null)
                {
                    var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute))
                        as System.Runtime.Serialization.EnumMemberAttribute;
                    if (attribute != null)
                    {
                        return attribute.Value != null ? attribute.Value : name;
                    }
                }

                var converted = System.Convert.ToString(System.Convert.ChangeType(value, System.Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                return converted == null ? string.Empty : converted;
            }
        }
        else if (value is bool)
        {
            return System.Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
        }
        else if (value is byte[])
        {
            return System.Convert.ToBase64String((byte[])value);
        }
        else if (value.GetType().IsArray)
        {
            var array = System.Linq.Enumerable.OfType<object>((System.Array)value);
            return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
        }

        var result = System.Convert.ToString(value, cultureInfo);
        return result == null ? "" : result;
    }
}

public partial class AccountActivitiesClient : IAccountActivitiesClient
{
    private System.Net.Http.HttpClient _httpClient;
    private System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;

    public AccountActivitiesClient(System.Net.Http.HttpClient httpClient)
    {
        _httpClient = httpClient;
        _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(CreateSerializerSettings);
    }

    private Newtonsoft.Json.JsonSerializerSettings CreateSerializerSettings()
    {
        var settings = new Newtonsoft.Json.JsonSerializerSettings();
        UpdateJsonSerializerSettings(settings);
        return settings;
    }

    protected Newtonsoft.Json.JsonSerializerSettings JsonSerializerSettings { get { return _settings.Value; } }

    partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);

    partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, string url);
    partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, System.Text.StringBuilder urlBuilder);
    partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);


    /// <summary>
    /// Search lead activity using available filters.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual System.Threading.Tasks.Task<PaginationResponseOfAccountActivityDto> SearchAsync(SearchAccountAcitivityRequest request)
    {
        return SearchAsync(request, System.Threading.CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Search lead activity using available filters.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async System.Threading.Tasks.Task<PaginationResponseOfAccountActivityDto> SearchAsync(SearchAccountAcitivityRequest request, System.Threading.CancellationToken cancellationToken)
    {
        if (request == null)
            throw new System.ArgumentNullException("request");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/accountactivity/search");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, _settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("POST");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<PaginationResponseOfAccountActivityDto>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// Get lead acitivity using available filters.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>

    public virtual System.Threading.Tasks.Task<AccountActivityDto> GetAsync(System.Guid id)
    {
        return GetAsync(id, System.Threading.CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Get lead acitivity details.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async System.Threading.Tasks.Task<AccountActivityDto> GetAsync(System.Guid id, System.Threading.CancellationToken cancellationToken)
    {
        if (id == null)
            throw new System.ArgumentNullException("id");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/accountactivity/{id}");
        urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                request_.Method = new System.Net.Http.HttpMethod("GET");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<AccountActivityDto>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// Update a lead.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual System.Threading.Tasks.Task<System.Guid> UpdateAsync(System.Guid id, UpdateAccountActivityRequest request)
    {
        return UpdateAsync(id, request, System.Threading.CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Update a lead.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async System.Threading.Tasks.Task<System.Guid> UpdateAsync(System.Guid id, UpdateAccountActivityRequest request, System.Threading.CancellationToken cancellationToken)
    {
        if (id == null)
            throw new System.ArgumentNullException("id");

        if (request == null)
            throw new System.ArgumentNullException("request");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/accountactivity/{id}");
        urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, _settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("PUT");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<System.Guid>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }


    public virtual System.Threading.Tasks.Task<System.Guid> UpdateTaskAsync(System.Guid id, UpdateAccountActivityTaskRequest request)
    {
        return UpdateTaskAsync(id, request, System.Threading.CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Update a lead.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async System.Threading.Tasks.Task<System.Guid> UpdateTaskAsync(System.Guid id, UpdateAccountActivityTaskRequest request, System.Threading.CancellationToken cancellationToken)
    {
        if (id == null)
            throw new System.ArgumentNullException("id");

        if (request == null)
            throw new System.ArgumentNullException("request");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/accountactivity/{id}");
        urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, _settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("PUT");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<System.Guid>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// Delete a lead activity.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual System.Threading.Tasks.Task<System.Guid> DeleteAsync(System.Guid id)
    {
        return DeleteAsync(id, System.Threading.CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Delete a lead activity.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async System.Threading.Tasks.Task<System.Guid> DeleteAsync(System.Guid id, System.Threading.CancellationToken cancellationToken)
    {
        if (id == null)
            throw new System.ArgumentNullException("id");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/accountactivity/{id}");
        urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                request_.Method = new System.Net.Http.HttpMethod("DELETE");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<System.Guid>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// Create a new lead activity.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual System.Threading.Tasks.Task<System.Guid> CreateAsync(CreateAccountActivityRequest request)
    {
        return CreateAsync(request, System.Threading.CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Create a new lead activity.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async System.Threading.Tasks.Task<System.Guid> CreateAsync(CreateAccountActivityRequest request, System.Threading.CancellationToken cancellationToken)
    {
        if (request == null)
            throw new System.ArgumentNullException("request");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/accountactivity");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, _settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("POST");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<System.Guid>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }


    public virtual System.Threading.Tasks.Task<PaginationResponseOfAccountActivityTaskDto> GetAsyncUserTask(SearchAccountAcitivityTaskRequest request)
    {
        return GetAsyncUserTask(request, System.Threading.CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Search lead activity using available filters.
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async System.Threading.Tasks.Task<PaginationResponseOfAccountActivityTaskDto> GetAsyncUserTask(SearchAccountAcitivityTaskRequest request, System.Threading.CancellationToken cancellationToken)
    {
        if (request == null)
            throw new System.ArgumentNullException("request");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/accountactivity/assignTask");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, _settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("POST");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<PaginationResponseOfAccountActivityTaskDto>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// Get lead acitivity using available filters.

    protected struct ObjectResponseResult<T>
    {
        public ObjectResponseResult(T responseObject, string responseText)
        {
            this.Object = responseObject;
            this.Text = responseText;
        }

        public T Object { get; }

        public string Text { get; }
    }

    public bool ReadResponseAsString { get; set; }

    protected virtual async System.Threading.Tasks.Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(System.Net.Http.HttpResponseMessage response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Threading.CancellationToken cancellationToken)
    {
        if (response == null || response.Content == null)
        {
            return new ObjectResponseResult<T>(default(T)!, string.Empty);
        }

        if (ReadResponseAsString)
        {
            var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            try
            {
                var typedBody = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseText, JsonSerializerSettings);
                return new ObjectResponseResult<T>(typedBody!, responseText);
            }
            catch (Newtonsoft.Json.JsonException exception)
            {
                var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                throw new ApiException(message, (int)response.StatusCode, responseText, headers, exception);
            }
        }
        else
        {
            try
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                using (var streamReader = new System.IO.StreamReader(responseStream))
                using (var jsonTextReader = new Newtonsoft.Json.JsonTextReader(streamReader))
                {
                    var serializer = Newtonsoft.Json.JsonSerializer.Create(JsonSerializerSettings);
                    var typedBody = serializer.Deserialize<T>(jsonTextReader);
                    return new ObjectResponseResult<T>(typedBody!, string.Empty);
                }
            }
            catch (Newtonsoft.Json.JsonException exception)
            {
                var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                throw new ApiException(message, (int)response.StatusCode, string.Empty, headers, exception);
            }
        }
    }

    private string ConvertToString(object? value, System.Globalization.CultureInfo cultureInfo)
    {
        if (value == null)
        {
            return "";
        }

        if (value is System.Enum)
        {
            var name = System.Enum.GetName(value.GetType(), value);
            if (name != null)
            {
                var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                if (field != null)
                {
                    var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute))
                        as System.Runtime.Serialization.EnumMemberAttribute;
                    if (attribute != null)
                    {
                        return attribute.Value != null ? attribute.Value : name;
                    }
                }

                var converted = System.Convert.ToString(System.Convert.ChangeType(value, System.Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                return converted == null ? string.Empty : converted;
            }
        }
        else if (value is bool)
        {
            return System.Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
        }
        else if (value is byte[])
        {
            return System.Convert.ToBase64String((byte[])value);
        }
        else if (value.GetType().IsArray)
        {
            var array = System.Linq.Enumerable.OfType<object>((System.Array)value);
            return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
        }

        var result = System.Convert.ToString(value, cultureInfo);
        return result == null ? "" : result;
    }
}

public partial class AccountSourcesClient : IAccountSourcesClient
{
    private System.Net.Http.HttpClient _httpClient;
    private System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;

    public AccountSourcesClient(System.Net.Http.HttpClient httpClient)
    {
        _httpClient = httpClient;
        _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(CreateSerializerSettings);
    }
    private Newtonsoft.Json.JsonSerializerSettings CreateSerializerSettings()
    {
        var settings = new Newtonsoft.Json.JsonSerializerSettings();
        UpdateJsonSerializerSettings(settings);
        return settings;
    }
    protected Newtonsoft.Json.JsonSerializerSettings JsonSerializerSettings { get { return _settings.Value; } }

    partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);

    partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, string url);
    partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, System.Text.StringBuilder urlBuilder);
    partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);
    protected virtual async System.Threading.Tasks.Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(System.Net.Http.HttpResponseMessage response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Threading.CancellationToken cancellationToken)
    {
        if (response == null || response.Content == null)
        {
            return new ObjectResponseResult<T>(default(T)!, string.Empty);
        }

        if (ReadResponseAsString)
        {
            var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            try
            {
                var typedBody = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseText, JsonSerializerSettings);
                return new ObjectResponseResult<T>(typedBody!, responseText);
            }
            catch (Newtonsoft.Json.JsonException exception)
            {
                var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                throw new ApiException(message, (int)response.StatusCode, responseText, headers, exception);
            }
        }
        else
        {
            try
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                using (var streamReader = new System.IO.StreamReader(responseStream))
                using (var jsonTextReader = new Newtonsoft.Json.JsonTextReader(streamReader))
                {
                    var serializer = Newtonsoft.Json.JsonSerializer.Create(JsonSerializerSettings);
                    var typedBody = serializer.Deserialize<T>(jsonTextReader);
                    return new ObjectResponseResult<T>(typedBody!, string.Empty);
                }
            }
            catch (Newtonsoft.Json.JsonException exception)
            {
                var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                throw new ApiException(message, (int)response.StatusCode, string.Empty, headers, exception);
            }
        }
    }
    protected struct ObjectResponseResult<T>
    {
        public ObjectResponseResult(T responseObject, string responseText)
        {
            this.Object = responseObject;
            this.Text = responseText;
        }

        public T Object { get; }

        public string Text { get; }
    }

    public bool ReadResponseAsString { get; set; }

    private string ConvertToString(object? value, System.Globalization.CultureInfo cultureInfo)
    {
        if (value == null)
        {
            return "";
        }

        if (value is System.Enum)
        {
            var name = System.Enum.GetName(value.GetType(), value);
            if (name != null)
            {
                var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                if (field != null)
                {
                    var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute))
                        as System.Runtime.Serialization.EnumMemberAttribute;
                    if (attribute != null)
                    {
                        return attribute.Value != null ? attribute.Value : name;
                    }
                }

                var converted = System.Convert.ToString(System.Convert.ChangeType(value, System.Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                return converted == null ? string.Empty : converted;
            }
        }
        else if (value is bool)
        {
            return System.Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
        }
        else if (value is byte[])
        {
            return System.Convert.ToBase64String((byte[])value);
        }
        else if (value.GetType().IsArray)
        {
            var array = System.Linq.Enumerable.OfType<object>((System.Array)value);
            return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
        }

        var result = System.Convert.ToString(value, cultureInfo);
        return result == null ? "" : result;
    }
  
    public virtual System.Threading.Tasks.Task<PaginationResponseOfAccountSourcesDto> SearchAsync(SearchAccountSourceRequest request)
    {
        return SearchAsync(request, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<PaginationResponseOfAccountSourcesDto> SearchAsync(SearchAccountSourceRequest request, System.Threading.CancellationToken cancellationToken)
    {
        if (request == null)
            throw new System.ArgumentNullException("request");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/accountsource/search");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, _settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("POST");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<PaginationResponseOfAccountSourcesDto>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }
}

public partial class SkillsClient : ISkillsClient
{
    private System.Net.Http.HttpClient _httpClient;
    private System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;

    public SkillsClient(System.Net.Http.HttpClient httpClient)
    {
        _httpClient = httpClient;
        _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(CreateSerializerSettings);
    }

    private Newtonsoft.Json.JsonSerializerSettings CreateSerializerSettings()
    {
        var settings = new Newtonsoft.Json.JsonSerializerSettings();
        UpdateJsonSerializerSettings(settings);
        return settings;
    }

    protected Newtonsoft.Json.JsonSerializerSettings JsonSerializerSettings { get { return _settings.Value; } }

    partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);

    partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, string url);
    partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, System.Text.StringBuilder urlBuilder);
    partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);

    public virtual System.Threading.Tasks.Task<PaginationResponsesOfSkillDto> SearchAsync(SearchSkillRequest request)
    {
        return SearchAsync(request, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<PaginationResponsesOfSkillDto> SearchAsync(SearchSkillRequest request, System.Threading.CancellationToken cancellationToken)
    {
        if (request == null)
            throw new System.ArgumentNullException("request");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/skill/search");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, _settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("POST");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<PaginationResponsesOfSkillDto>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<SkillDto> GetAsync(System.Guid id)
    {
        return GetAsync(id, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<SkillDto> GetAsync(System.Guid id, System.Threading.CancellationToken cancellationToken)
    {
        if (id == null)
            throw new System.ArgumentNullException("id");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/skill/{id}");
        urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                request_.Method = new System.Net.Http.HttpMethod("GET");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<SkillDto>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<System.Guid> UpdateAsync(System.Guid id, UpdateSkillRequest request)
    {
        return UpdateAsync(id, request, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<System.Guid> UpdateAsync(System.Guid id, UpdateSkillRequest request, System.Threading.CancellationToken cancellationToken)
    {
        if (id == null)
            throw new System.ArgumentNullException("id");

        if (request == null)
            throw new System.ArgumentNullException("request");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/skill/{id}");
        urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, _settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("PUT");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<System.Guid>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<System.Guid> DeleteAsync(System.Guid id)
    {
        return DeleteAsync(id, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<System.Guid> DeleteAsync(System.Guid id, System.Threading.CancellationToken cancellationToken)
    {
        if (id == null)
            throw new System.ArgumentNullException("id");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/skill/{id}");
        urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                request_.Method = new System.Net.Http.HttpMethod("DELETE");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<System.Guid>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<System.Guid> CreateAsync(CreateSkillRequest request)
    {
        return CreateAsync(request, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<System.Guid> CreateAsync(CreateSkillRequest request, System.Threading.CancellationToken cancellationToken)
    {
        if (request == null)
            throw new System.ArgumentNullException("request");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/skill");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, _settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("POST");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<System.Guid>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    protected struct ObjectResponseResult<T>
    {
        public ObjectResponseResult(T responseObject, string responseText)
        {
            this.Object = responseObject;
            this.Text = responseText;
        }

        public T Object { get; }

        public string Text { get; }
    }

    public bool ReadResponseAsString { get; set; }

    protected virtual async System.Threading.Tasks.Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(System.Net.Http.HttpResponseMessage response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Threading.CancellationToken cancellationToken)
    {
        if (response == null || response.Content == null)
        {
            return new ObjectResponseResult<T>(default(T)!, string.Empty);
        }

        if (ReadResponseAsString)
        {
            var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            try
            {
                var typedBody = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseText, JsonSerializerSettings);
                return new ObjectResponseResult<T>(typedBody!, responseText);
            }
            catch (Newtonsoft.Json.JsonException exception)
            {
                var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                throw new ApiException(message, (int)response.StatusCode, responseText, headers, exception);
            }
        }
        else
        {
            try
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                using (var streamReader = new System.IO.StreamReader(responseStream))
                using (var jsonTextReader = new Newtonsoft.Json.JsonTextReader(streamReader))
                {
                    var serializer = Newtonsoft.Json.JsonSerializer.Create(JsonSerializerSettings);
                    var typedBody = serializer.Deserialize<T>(jsonTextReader);
                    return new ObjectResponseResult<T>(typedBody!, string.Empty);
                }
            }
            catch (Newtonsoft.Json.JsonException exception)
            {
                var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                throw new ApiException(message, (int)response.StatusCode, string.Empty, headers, exception);
            }
        }
    }

    private string ConvertToString(object? value, System.Globalization.CultureInfo cultureInfo)
    {
        if (value == null)
        {
            return "";
        }

        if (value is System.Enum)
        {
            var name = System.Enum.GetName(value.GetType(), value);
            if (name != null)
            {
                var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                if (field != null)
                {
                    var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute))
                        as System.Runtime.Serialization.EnumMemberAttribute;
                    if (attribute != null)
                    {
                        return attribute.Value != null ? attribute.Value : name;
                    }
                }

                var converted = System.Convert.ToString(System.Convert.ChangeType(value, System.Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                return converted == null ? string.Empty : converted;
            }
        }
        else if (value is bool)
        {
            return System.Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
        }
        else if (value is byte[])
        {
            return System.Convert.ToBase64String((byte[])value);
        }
        else if (value.GetType().IsArray)
        {
            var array = System.Linq.Enumerable.OfType<object>((System.Array)value);
            return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
        }

        var result = System.Convert.ToString(value, cultureInfo);
        return result == null ? "" : result;
    }
}

public partial class UserClient : IUserClient
{
    private System.Net.Http.HttpClient _httpClient;
    private System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;

    public UserClient(System.Net.Http.HttpClient httpClient)
    {
        _httpClient = httpClient;
        _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(CreateSerializerSettings);
    }

    private Newtonsoft.Json.JsonSerializerSettings CreateSerializerSettings()
    {
        var settings = new Newtonsoft.Json.JsonSerializerSettings();
        UpdateJsonSerializerSettings(settings);
        return settings;
    }

    protected Newtonsoft.Json.JsonSerializerSettings JsonSerializerSettings { get { return _settings.Value; } }

    partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);

    partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, string url);
    partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, System.Text.StringBuilder urlBuilder);
    partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);

    public virtual System.Threading.Tasks.Task<List<UserDto>> GetUserSearchAsync(SearchUserRequest request)
    {
        return GetUserSearchAsync(request, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<List<UserDto>> GetUserSearchAsync(SearchUserRequest request, System.Threading.CancellationToken cancellationToken)
    {

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/users/getUserSearchAsync");
        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(_settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("POST");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<List<UserDto>>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }


    public virtual System.Threading.Tasks.Task<List<UsersRolesViewModel>> GetUserByRole(string role)
    {
        return GetUserByRole(role, System.Threading.CancellationToken.None);
    }
    public virtual async System.Threading.Tasks.Task<List<UsersRolesViewModel>> GetUserByRole(string role, System.Threading.CancellationToken cancellationToken)
    {

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/users/{role}/getUserByRole");
        // urlBuilder_.Append("api/users/getUserByRole");
        urlBuilder_.Replace("{role}", System.Uri.EscapeDataString(ConvertToString(role, System.Globalization.CultureInfo.InvariantCulture)));
        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(_settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("POST");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<List<UsersRolesViewModel>>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }
    /// <summary>
    /// Get Lead Day Wise Co

    protected struct ObjectResponseResult<T>
    {
        public ObjectResponseResult(T responseObject, string responseText)
        {
            this.Object = responseObject;
            this.Text = responseText;
        }

        public T Object { get; }

        public string Text { get; }
    }

    public bool ReadResponseAsString { get; set; }

    protected virtual async System.Threading.Tasks.Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(System.Net.Http.HttpResponseMessage response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Threading.CancellationToken cancellationToken)
    {
        if (response == null || response.Content == null)
        {
            return new ObjectResponseResult<T>(default(T)!, string.Empty);
        }

        if (ReadResponseAsString)
        {
            var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            try
            {
                var typedBody = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseText, JsonSerializerSettings);
                return new ObjectResponseResult<T>(typedBody!, responseText);
            }
            catch (Newtonsoft.Json.JsonException exception)
            {
                var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                throw new ApiException(message, (int)response.StatusCode, responseText, headers, exception);
            }
        }
        else
        {
            try
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                using (var streamReader = new System.IO.StreamReader(responseStream))
                using (var jsonTextReader = new Newtonsoft.Json.JsonTextReader(streamReader))
                {
                    var serializer = Newtonsoft.Json.JsonSerializer.Create(JsonSerializerSettings);
                    var typedBody = serializer.Deserialize<T>(jsonTextReader);
                    return new ObjectResponseResult<T>(typedBody!, string.Empty);
                }
            }
            catch (Newtonsoft.Json.JsonException exception)
            {
                var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                throw new ApiException(message, (int)response.StatusCode, string.Empty, headers, exception);
            }
        }
    }

    private string ConvertToString(object? value, System.Globalization.CultureInfo cultureInfo)
    {
        if (value == null)
        {
            return "";
        }

        if (value is System.Enum)
        {
            var name = System.Enum.GetName(value.GetType(), value);
            if (name != null)
            {
                var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                if (field != null)
                {
                    var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute))
                        as System.Runtime.Serialization.EnumMemberAttribute;
                    if (attribute != null)
                    {
                        return attribute.Value != null ? attribute.Value : name;
                    }
                }

                var converted = System.Convert.ToString(System.Convert.ChangeType(value, System.Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                return converted == null ? string.Empty : converted;
            }
        }
        else if (value is bool)
        {
            return System.Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
        }
        else if (value is byte[])
        {
            return System.Convert.ToBase64String((byte[])value);
        }
        else if (value.GetType().IsArray)
        {
            var array = System.Linq.Enumerable.OfType<object>((System.Array)value);
            return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
        }

        var result = System.Convert.ToString(value, cultureInfo);
        return result == null ? "" : result;
    }
}

public partial class SubSkillsClient : ISubSkillsClient
{
    private System.Net.Http.HttpClient _httpClient;
    private System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;

    public SubSkillsClient(System.Net.Http.HttpClient httpClient)
    {
        _httpClient = httpClient;
        _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(CreateSerializerSettings);
    }

    private Newtonsoft.Json.JsonSerializerSettings CreateSerializerSettings()
    {
        var settings = new Newtonsoft.Json.JsonSerializerSettings();
        UpdateJsonSerializerSettings(settings);
        return settings;
    }

    protected Newtonsoft.Json.JsonSerializerSettings JsonSerializerSettings { get { return _settings.Value; } }

    partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);

    partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, string url);
    partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, System.Text.StringBuilder urlBuilder);
    partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);

    public virtual System.Threading.Tasks.Task<PaginationResponseOfSubSkillDto> SearchAsync(SearchSubSkillsRequest request)
    {
        return SearchAsync(request, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<PaginationResponseOfSubSkillDto> SearchAsync(SearchSubSkillsRequest request, System.Threading.CancellationToken cancellationToken)
    {
        if (request == null)
            throw new System.ArgumentNullException("request");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/subskill/search");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, _settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("POST");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<PaginationResponseOfSubSkillDto>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<SubSkillDto> GetAsync(System.Guid id)
    {
        return GetAsync(id, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<SubSkillDto> GetAsync(System.Guid id, System.Threading.CancellationToken cancellationToken)
    {
        if (id == null)
            throw new System.ArgumentNullException("id");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/subskill/{id}");
        urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                request_.Method = new System.Net.Http.HttpMethod("GET");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<SubSkillDto>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<System.Guid> UpdateAsync(System.Guid id, UpdateSubSkillsRequest request)
    {
        return UpdateAsync(id, request, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<System.Guid> UpdateAsync(System.Guid id, UpdateSubSkillsRequest request, System.Threading.CancellationToken cancellationToken)
    {
        if (id == null)
            throw new System.ArgumentNullException("id");

        if (request == null)
            throw new System.ArgumentNullException("request");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/subskill/{id}");
        urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, _settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("PUT");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<System.Guid>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<System.Guid> DeleteAsync(System.Guid id)
    {
        return DeleteAsync(id, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<System.Guid> DeleteAsync(System.Guid id, System.Threading.CancellationToken cancellationToken)
    {
        if (id == null)
            throw new System.ArgumentNullException("id");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/subskill/{id}");
        urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                request_.Method = new System.Net.Http.HttpMethod("DELETE");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<System.Guid>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<System.Guid> CreateAsync(CreateSubSkillRequest request)
    {
        return CreateAsync(request, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<System.Guid> CreateAsync(CreateSubSkillRequest request, System.Threading.CancellationToken cancellationToken)
    {
        if (request == null)
            throw new System.ArgumentNullException("request");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/subskill");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, _settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("POST");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<System.Guid>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    protected struct ObjectResponseResult<T>
    {
        public ObjectResponseResult(T responseObject, string responseText)
        {
            this.Object = responseObject;
            this.Text = responseText;
        }

        public T Object { get; }

        public string Text { get; }
    }

    public bool ReadResponseAsString { get; set; }

    protected virtual async System.Threading.Tasks.Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(System.Net.Http.HttpResponseMessage response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Threading.CancellationToken cancellationToken)
    {
        if (response == null || response.Content == null)
        {
            return new ObjectResponseResult<T>(default(T)!, string.Empty);
        }

        if (ReadResponseAsString)
        {
            var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            try
            {
                var typedBody = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseText, JsonSerializerSettings);
                return new ObjectResponseResult<T>(typedBody!, responseText);
            }
            catch (Newtonsoft.Json.JsonException exception)
            {
                var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                throw new ApiException(message, (int)response.StatusCode, responseText, headers, exception);
            }
        }
        else
        {
            try
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                using (var streamReader = new System.IO.StreamReader(responseStream))
                using (var jsonTextReader = new Newtonsoft.Json.JsonTextReader(streamReader))
                {
                    var serializer = Newtonsoft.Json.JsonSerializer.Create(JsonSerializerSettings);
                    var typedBody = serializer.Deserialize<T>(jsonTextReader);
                    return new ObjectResponseResult<T>(typedBody!, string.Empty);
                }
            }
            catch (Newtonsoft.Json.JsonException exception)
            {
                var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                throw new ApiException(message, (int)response.StatusCode, string.Empty, headers, exception);
            }
        }
    }

    private string ConvertToString(object? value, System.Globalization.CultureInfo cultureInfo)
    {
        if (value == null)
        {
            return "";
        }

        if (value is System.Enum)
        {
            var name = System.Enum.GetName(value.GetType(), value);
            if (name != null)
            {
                var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                if (field != null)
                {
                    var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute))
                        as System.Runtime.Serialization.EnumMemberAttribute;
                    if (attribute != null)
                    {
                        return attribute.Value != null ? attribute.Value : name;
                    }
                }

                var converted = System.Convert.ToString(System.Convert.ChangeType(value, System.Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                return converted == null ? string.Empty : converted;
            }
        }
        else if (value is bool)
        {
            return System.Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
        }
        else if (value is byte[])
        {
            return System.Convert.ToBase64String((byte[])value);
        }
        else if (value.GetType().IsArray)
        {
            var array = System.Linq.Enumerable.OfType<object>((System.Array)value);
            return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
        }

        var result = System.Convert.ToString(value, cultureInfo);
        return result == null ? "" : result;
    }
}

public partial class LeadSourcesClient : ILeadSourcesClient
{
    private System.Net.Http.HttpClient _httpClient;
    private System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;

    public LeadSourcesClient(System.Net.Http.HttpClient httpClient)
    {
        _httpClient = httpClient;
        _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(CreateSerializerSettings);
    }
    private Newtonsoft.Json.JsonSerializerSettings CreateSerializerSettings()
    {
        var settings = new Newtonsoft.Json.JsonSerializerSettings();
        UpdateJsonSerializerSettings(settings);
        return settings;
    }
    protected Newtonsoft.Json.JsonSerializerSettings JsonSerializerSettings { get { return _settings.Value; } }

    partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);

    partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, string url);
    partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, System.Text.StringBuilder urlBuilder);
    partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);
    protected virtual async System.Threading.Tasks.Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(System.Net.Http.HttpResponseMessage response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Threading.CancellationToken cancellationToken)
    {
        if (response == null || response.Content == null)
        {
            return new ObjectResponseResult<T>(default(T)!, string.Empty);
        }

        if (ReadResponseAsString)
        {
            var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            try
            {
                var typedBody = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseText, JsonSerializerSettings);
                return new ObjectResponseResult<T>(typedBody!, responseText);
            }
            catch (Newtonsoft.Json.JsonException exception)
            {
                var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                throw new ApiException(message, (int)response.StatusCode, responseText, headers, exception);
            }
        }
        else
        {
            try
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                using (var streamReader = new System.IO.StreamReader(responseStream))
                using (var jsonTextReader = new Newtonsoft.Json.JsonTextReader(streamReader))
                {
                    var serializer = Newtonsoft.Json.JsonSerializer.Create(JsonSerializerSettings);
                    var typedBody = serializer.Deserialize<T>(jsonTextReader);
                    return new ObjectResponseResult<T>(typedBody!, string.Empty);
                }
            }
            catch (Newtonsoft.Json.JsonException exception)
            {
                var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                throw new ApiException(message, (int)response.StatusCode, string.Empty, headers, exception);
            }
        }
    }
    protected struct ObjectResponseResult<T>
    {
        public ObjectResponseResult(T responseObject, string responseText)
        {
            this.Object = responseObject;
            this.Text = responseText;
        }

        public T Object { get; }

        public string Text { get; }
    }

    public bool ReadResponseAsString { get; set; }

    private string ConvertToString(object? value, System.Globalization.CultureInfo cultureInfo)
    {
        if (value == null)
        {
            return "";
        }

        if (value is System.Enum)
        {
            var name = System.Enum.GetName(value.GetType(), value);
            if (name != null)
            {
                var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                if (field != null)
                {
                    var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute))
                        as System.Runtime.Serialization.EnumMemberAttribute;
                    if (attribute != null)
                    {
                        return attribute.Value != null ? attribute.Value : name;
                    }
                }

                var converted = System.Convert.ToString(System.Convert.ChangeType(value, System.Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                return converted == null ? string.Empty : converted;
            }
        }
        else if (value is bool)
        {
            return System.Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
        }
        else if (value is byte[])
        {
            return System.Convert.ToBase64String((byte[])value);
        }
        else if (value.GetType().IsArray)
        {
            var array = System.Linq.Enumerable.OfType<object>((System.Array)value);
            return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
        }

        var result = System.Convert.ToString(value, cultureInfo);
        return result == null ? "" : result;
    }

    public virtual System.Threading.Tasks.Task<PaginationResponseOfLeadSourcesDto> SearchAsync(SearchLeadSourceRequest request)
    {
        return SearchAsync(request, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<PaginationResponseOfLeadSourcesDto> SearchAsync(SearchLeadSourceRequest request, System.Threading.CancellationToken cancellationToken)
    {
        if (request == null)
            throw new System.ArgumentNullException("request");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/leadsource/search");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, _settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("POST");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<PaginationResponseOfLeadSourcesDto>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }
}

public partial class MediasClient : IMediasClient
{
    private System.Net.Http.HttpClient _httpClient;
    private System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;

    public MediasClient(System.Net.Http.HttpClient httpClient)
    {
        _httpClient = httpClient;
        _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(CreateSerializerSettings);
    }

    private Newtonsoft.Json.JsonSerializerSettings CreateSerializerSettings()
    {
        var settings = new Newtonsoft.Json.JsonSerializerSettings();
        UpdateJsonSerializerSettings(settings);
        return settings;
    }

    protected Newtonsoft.Json.JsonSerializerSettings JsonSerializerSettings { get { return _settings.Value; } }

    partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);

    partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, string url);
    partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, System.Text.StringBuilder urlBuilder);
    partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);

    public virtual System.Threading.Tasks.Task<System.Guid> CreateAsync(CreateMediaRequest request)
    {
        return CreateAsync(request, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<System.Guid> CreateAsync(CreateMediaRequest request, System.Threading.CancellationToken cancellationToken)
    {
        if (request == null)
            throw new System.ArgumentNullException("request");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/media");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, _settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("POST");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<System.Guid>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    protected struct ObjectResponseResult<T>
    {
        public ObjectResponseResult(T responseObject, string responseText)
        {
            this.Object = responseObject;
            this.Text = responseText;
        }

        public T Object { get; }

        public string Text { get; }
    }

    public bool ReadResponseAsString { get; set; }

    protected virtual async System.Threading.Tasks.Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(System.Net.Http.HttpResponseMessage response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Threading.CancellationToken cancellationToken)
    {
        if (response == null || response.Content == null)
        {
            return new ObjectResponseResult<T>(default(T)!, string.Empty);
        }

        if (ReadResponseAsString)
        {
            var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            try
            {
                var typedBody = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseText, JsonSerializerSettings);
                return new ObjectResponseResult<T>(typedBody!, responseText);
            }
            catch (Newtonsoft.Json.JsonException exception)
            {
                var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                throw new ApiException(message, (int)response.StatusCode, responseText, headers, exception);
            }
        }
        else
        {
            try
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                using (var streamReader = new System.IO.StreamReader(responseStream))
                using (var jsonTextReader = new Newtonsoft.Json.JsonTextReader(streamReader))
                {
                    var serializer = Newtonsoft.Json.JsonSerializer.Create(JsonSerializerSettings);
                    var typedBody = serializer.Deserialize<T>(jsonTextReader);
                    return new ObjectResponseResult<T>(typedBody!, string.Empty);
                }
            }
            catch (Newtonsoft.Json.JsonException exception)
            {
                var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                throw new ApiException(message, (int)response.StatusCode, string.Empty, headers, exception);
            }
        }
    }

    private string ConvertToString(object? value, System.Globalization.CultureInfo cultureInfo)
    {
        if (value == null)
        {
            return "";
        }

        if (value is System.Enum)
        {
            var name = System.Enum.GetName(value.GetType(), value);
            if (name != null)
            {
                var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                if (field != null)
                {
                    var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute))
                        as System.Runtime.Serialization.EnumMemberAttribute;
                    if (attribute != null)
                    {
                        return attribute.Value != null ? attribute.Value : name;
                    }
                }

                var converted = System.Convert.ToString(System.Convert.ChangeType(value, System.Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                return converted == null ? string.Empty : converted;
            }
        }
        else if (value is bool)
        {
            return System.Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
        }
        else if (value is byte[])
        {
            return System.Convert.ToBase64String((byte[])value);
        }
        else if (value.GetType().IsArray)
        {
            var array = System.Linq.Enumerable.OfType<object>((System.Array)value);
            return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
        }

        var result = System.Convert.ToString(value, cultureInfo);
        return result == null ? "" : result;
    }
}

public partial class AccountsClient : IAccountsClient
{ 
    private HttpClient _httpClient;
    private Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;

    public AccountsClient(System.Net.Http.HttpClient httpClient)
    {
        _httpClient = httpClient;
        _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(CreateSerializerSettings);
    }

    private Newtonsoft.Json.JsonSerializerSettings CreateSerializerSettings()
    {
        var settings = new Newtonsoft.Json.JsonSerializerSettings();
        UpdateJsonSerializerSettings(settings);
        return settings;
    }

    protected Newtonsoft.Json.JsonSerializerSettings JsonSerializerSettings { get { return _settings.Value; } }

    partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);

    partial void PrepareRequest(HttpClient client, HttpRequestMessage request, string url);
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request, StringBuilder urlBuilder);
    partial void ProcessResponse(HttpClient client, HttpResponseMessage response);

    public virtual Task<PaginationResponseOfAccountDto> SearchAsync(SearchAccountRequest request)
    {
        return SearchAsync(request, CancellationToken.None);
    }

    public virtual async Task<PaginationResponseOfAccountDto> SearchAsync(SearchAccountRequest request, CancellationToken cancellationToken)
    {
        if (request == null)
            throw new ArgumentNullException("request");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append("api/v1/account/search");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, _settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("POST");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<PaginationResponseOfAccountDto>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<AccountDto> GetAsync(System.Guid id)
    {
        return GetAsync(id, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<AccountDto> GetAsync(System.Guid id, System.Threading.CancellationToken cancellationToken)
    {
        if (id == null)
            throw new System.ArgumentNullException("id");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/account/{id}");
        urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                request_.Method = new System.Net.Http.HttpMethod("GET");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<AccountDto>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<System.Guid> UpdateAsync(System.Guid id, UpdateAccountRequest request)
    {
        return UpdateAsync(id, request, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<System.Guid> UpdateAsync(System.Guid id, UpdateAccountRequest request, System.Threading.CancellationToken cancellationToken)
    {
        if (id == null)
            throw new System.ArgumentNullException("id");

        if (request == null)
            throw new System.ArgumentNullException("request");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/account/{id}");
        urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, _settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("PUT");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<System.Guid>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<System.Guid> DeleteAsync(System.Guid id)
    {
        return DeleteAsync(id, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<System.Guid> DeleteAsync(System.Guid id, System.Threading.CancellationToken cancellationToken)
    {
        if (id == null)
            throw new System.ArgumentNullException("id");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/account/{id}");
        urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                request_.Method = new System.Net.Http.HttpMethod("DELETE");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<System.Guid>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<System.Guid> CreateAsync(CreateAccountRequest request)
    {
        return CreateAsync(request, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<System.Guid> CreateAsync(CreateAccountRequest request, System.Threading.CancellationToken cancellationToken)
    {
        if (request == null)
            throw new System.ArgumentNullException("request");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/account");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, _settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("POST");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<System.Guid>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<List<AccountStatusDto>> AccountStatusAsync()
    {
        return AccountStatusAsync(System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<List<AccountStatusDto>> AccountStatusAsync(System.Threading.CancellationToken cancellationToken)
    {

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/account/accountstatus");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(_settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                
                request_.Method = new System.Net.Http.HttpMethod("GET");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<List<AccountStatusDto>>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<List<PreferredShiftTimingDto>> PreferredShiftTimingAsync()
    {
        return PreferredShiftTimingAsync(System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<List<PreferredShiftTimingDto>> PreferredShiftTimingAsync(System.Threading.CancellationToken cancellationToken)
    {

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/account/preferredshifttiming");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(_settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                
                request_.Method = new System.Net.Http.HttpMethod("GET");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<List<PreferredShiftTimingDto>>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<List<AccountTypeDto>> AccountTypeAsync()
    {
        return AccountTypeAsync(System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<List<AccountTypeDto>> AccountTypeAsync(System.Threading.CancellationToken cancellationToken)
    {

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/account/accounttype");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(_settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                //  request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("GET");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<List<AccountTypeDto>>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<List<AccountYearDto>> AccountYearAsync()
    {
        return AccountYearAsync(System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<List<AccountYearDto>> AccountYearAsync(System.Threading.CancellationToken cancellationToken)
    {

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/account/yearstats");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(_settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                //  request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("GET");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<List<AccountYearDto>>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<List<AccountMonthDto>> GetAccountCountMonthWiseAsync(int year)
    {
        return GetAccountCountMonthWiseAsync(year, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<List<AccountMonthDto>> GetAccountCountMonthWiseAsync(int year, System.Threading.CancellationToken cancellationToken)
    {
        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/account/monthsstatsbyyear?year=" + year);

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(_settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                //  request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("GET");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<List<AccountMonthDto>>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<List<AccountDayDto>> GetAccountCountDayWiseAsync(int year, int month)
    {
        return GetAccountCountDayWiseAsync(year, month, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<List<AccountDayDto>> GetAccountCountDayWiseAsync(int year, int month, System.Threading.CancellationToken cancellationToken)
    {

        var urlBuilder_ = new System.Text.StringBuilder();

        urlBuilder_.Append("api/v1/account/daystatsbymonth?year=" + year + "&month=" + month);

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(_settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                //  request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("GET");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<List<AccountDayDto>>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }


    protected struct ObjectResponseResult<T>
    {
        public ObjectResponseResult(T responseObject, string responseText)
        {
            this.Object = responseObject;
            this.Text = responseText;
        }

        public T Object { get; }

        public string Text { get; }
    }

    public bool ReadResponseAsString { get; set; }

    protected virtual async System.Threading.Tasks.Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(System.Net.Http.HttpResponseMessage response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Threading.CancellationToken cancellationToken)
    {
        if (response == null || response.Content == null)
        {
            return new ObjectResponseResult<T>(default(T)!, string.Empty);
        }

        if (ReadResponseAsString)
        {
            var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            try
            {
                var typedBody = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseText, JsonSerializerSettings);
                return new ObjectResponseResult<T>(typedBody!, responseText);
            }
            catch (Newtonsoft.Json.JsonException exception)
            {
                var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                throw new ApiException(message, (int)response.StatusCode, responseText, headers, exception);
            }
        }
        else
        {
            try
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                using (var streamReader = new System.IO.StreamReader(responseStream))
                using (var jsonTextReader = new Newtonsoft.Json.JsonTextReader(streamReader))
                {
                    var serializer = Newtonsoft.Json.JsonSerializer.Create(JsonSerializerSettings);
                    var typedBody = serializer.Deserialize<T>(jsonTextReader);
                    return new ObjectResponseResult<T>(typedBody!, string.Empty);
                }
            }
            catch (Newtonsoft.Json.JsonException exception)
            {
                var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                throw new ApiException(message, (int)response.StatusCode, string.Empty, headers, exception);
            }
        }
    }

    private string ConvertToString(object? value, System.Globalization.CultureInfo cultureInfo)
    {
        if (value == null)
        {
            return "";
        }

        if (value is System.Enum)
        {
            var name = System.Enum.GetName(value.GetType(), value);
            if (name != null)
            {
                var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                if (field != null)
                {
                    var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute))
                        as System.Runtime.Serialization.EnumMemberAttribute;
                    if (attribute != null)
                    {
                        return attribute.Value != null ? attribute.Value : name;
                    }
                }

                var converted = System.Convert.ToString(System.Convert.ChangeType(value, System.Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                return converted == null ? string.Empty : converted;
            }
        }
        else if (value is bool)
        {
            return System.Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
        }
        else if (value is byte[])
        {
            return System.Convert.ToBase64String((byte[])value);
        }
        else if (value.GetType().IsArray)
        {
            var array = System.Linq.Enumerable.OfType<object>((System.Array)value);
            return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
        }

        var result = System.Convert.ToString(value, cultureInfo);
        return result == null ? "" : result;
    }
}

public partial class LeadsClient : ILeadsClient
{
    private System.Net.Http.HttpClient _httpClient;
    private System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;

    public LeadsClient(System.Net.Http.HttpClient httpClient)
    {
        _httpClient = httpClient;
        _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(CreateSerializerSettings);
    }

    private Newtonsoft.Json.JsonSerializerSettings CreateSerializerSettings()
    {
        var settings = new Newtonsoft.Json.JsonSerializerSettings();
        UpdateJsonSerializerSettings(settings);
        return settings;
    }

    protected Newtonsoft.Json.JsonSerializerSettings JsonSerializerSettings { get { return _settings.Value; } }

    partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);

    partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, string url);
    partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, System.Text.StringBuilder urlBuilder);
    partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);

    public virtual System.Threading.Tasks.Task<PaginationResponseOfLeadDto> SearchAsync(SearchLeadsRequest request)
    {
        return SearchAsync(request, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<PaginationResponseOfLeadDto> SearchAsync(SearchLeadsRequest request, System.Threading.CancellationToken cancellationToken)
    {
        if (request == null)
            throw new System.ArgumentNullException("request");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/lead/search");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, _settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("POST");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<PaginationResponseOfLeadDto>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }


    public virtual async System.Threading.Tasks.Task<PaginationResponseOfLeadDto> SearchAsync(SearchAccountRequest request, System.Threading.CancellationToken cancellationToken)
    {
        if (request == null)
            throw new System.ArgumentNullException("request");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/account/search");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, _settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("POST");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<PaginationResponseOfLeadDto>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<LeadDto> GetAsync(System.Guid id)
    {
        return GetAsync(id, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<LeadDto> GetAsync(System.Guid id, System.Threading.CancellationToken cancellationToken)
    {
        if (id == null)
            throw new System.ArgumentNullException("id");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/lead/{id}");
        urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                request_.Method = new System.Net.Http.HttpMethod("GET");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<LeadDto>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<System.Guid> UpdateAsync(System.Guid id, UpdateLeadRequest request)
    {
        return UpdateAsync(id, request, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<System.Guid> UpdateAsync(System.Guid id, UpdateLeadRequest request, System.Threading.CancellationToken cancellationToken)
    {
        if (id == null)
            throw new System.ArgumentNullException("id");

        if (request == null)
            throw new System.ArgumentNullException("request");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/lead/{id}");
        urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, _settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("PUT");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<System.Guid>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<System.Guid> DeleteAsync(System.Guid id)
    {
        return DeleteAsync(id, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<System.Guid> DeleteAsync(System.Guid id, System.Threading.CancellationToken cancellationToken)
    {
        if (id == null)
            throw new System.ArgumentNullException("id");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/lead/{id}");
        urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                request_.Method = new System.Net.Http.HttpMethod("DELETE");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<System.Guid>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<System.Guid> CreateAsync(CreateLeadRequest request)
    {
        return CreateAsync(request, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<System.Guid> CreateAsync(CreateLeadRequest request, System.Threading.CancellationToken cancellationToken)
    {
        if (request == null)
            throw new System.ArgumentNullException("request");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/lead");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, _settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("POST");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<System.Guid>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<System.Guid> CreateAsync(CreateAccountRequest request)
    {
        return CreateAsync(request, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<System.Guid> CreateAsync(CreateAccountRequest request, System.Threading.CancellationToken cancellationToken)
    {
        if (request == null)
            throw new System.ArgumentNullException("request");

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/account");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, _settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("POST");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<System.Guid>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<List<LeadStatusDto>> LeadStatusAsync()
    {
        return LeadStatusAsync(System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<List<LeadStatusDto>> LeadStatusAsync(System.Threading.CancellationToken cancellationToken)
    {

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/lead/leadstatus");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(_settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                //  request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("GET");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<List<LeadStatusDto>>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<List<PreferredShiftTimingDto>> PreferredShiftTimingAsync()
    {
        return PreferredShiftTimingAsync(System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<List<PreferredShiftTimingDto>> PreferredShiftTimingAsync(System.Threading.CancellationToken cancellationToken)
    {

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/lead/preferredshifttiming");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(_settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                //  request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("GET");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<List<PreferredShiftTimingDto>>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<List<LeadTypeDto>> LeadTypeAsync()
    {
        return LeadTypeAsync(System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<List<LeadTypeDto>> LeadTypeAsync(System.Threading.CancellationToken cancellationToken)
    {

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/lead/leadtype");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(_settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                //  request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("GET");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<List<LeadTypeDto>>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<List<LeadYearDto>> LeadYearAsync()
    {
        return LeadYearAsync(System.Threading.CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Get Lead Years
    /// </summary>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async System.Threading.Tasks.Task<List<LeadYearDto>> LeadYearAsync(System.Threading.CancellationToken cancellationToken)
    {

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/lead/yearstats");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(_settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                //  request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("GET");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<List<LeadYearDto>>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<List<LeadMonthDto>> GetLeadCountMonthWiseAsync(int year)
    {
        return GetLeadCountMonthWiseAsync(year, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<List<LeadMonthDto>> GetLeadCountMonthWiseAsync(int year, System.Threading.CancellationToken cancellationToken)
    {

        var urlBuilder_ = new System.Text.StringBuilder();
        urlBuilder_.Append("api/v1/lead/monthsstatsbyyear?year=" + year);

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(_settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                //  request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("GET");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<List<LeadMonthDto>>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    public virtual System.Threading.Tasks.Task<List<LeadDayDto>> GetLeadCountDayWiseAsync(int year, int month)
    {
        return GetLeadCountDayWiseAsync(year, month, System.Threading.CancellationToken.None);
    }

    public virtual async System.Threading.Tasks.Task<List<LeadDayDto>> GetLeadCountDayWiseAsync(int year, int month, System.Threading.CancellationToken cancellationToken)
    {

        var urlBuilder_ = new System.Text.StringBuilder();

        urlBuilder_.Append("api/v1/lead/daystatsbymonth?year=" + year + "&month=" + month);

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(_settings.Value));
                content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                //  request_.Content = content_;
                request_.Method = new System.Net.Http.HttpMethod("GET");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<List<LeadDayDto>>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    if (status_ == 400)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<HttpValidationProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<HttpValidationProblemDetails>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ErrorResult>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        throw new ApiException<ErrorResult>("A server side error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }


    protected struct ObjectResponseResult<T>
    {
        public ObjectResponseResult(T responseObject, string responseText)
        {
            this.Object = responseObject;
            this.Text = responseText;
        }

        public T Object { get; }

        public string Text { get; }
    }

    public bool ReadResponseAsString { get; set; }

    protected virtual async System.Threading.Tasks.Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(System.Net.Http.HttpResponseMessage response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Threading.CancellationToken cancellationToken)
    {
        if (response == null || response.Content == null)
        {
            return new ObjectResponseResult<T>(default(T)!, string.Empty);
        }

        if (ReadResponseAsString)
        {
            var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            try
            {
                var typedBody = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseText, JsonSerializerSettings);
                return new ObjectResponseResult<T>(typedBody!, responseText);
            }
            catch (Newtonsoft.Json.JsonException exception)
            {
                var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                throw new ApiException(message, (int)response.StatusCode, responseText, headers, exception);
            }
        }
        else
        {
            try
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                using (var streamReader = new System.IO.StreamReader(responseStream))
                using (var jsonTextReader = new Newtonsoft.Json.JsonTextReader(streamReader))
                {
                    var serializer = Newtonsoft.Json.JsonSerializer.Create(JsonSerializerSettings);
                    var typedBody = serializer.Deserialize<T>(jsonTextReader);
                    return new ObjectResponseResult<T>(typedBody!, string.Empty);
                }
            }
            catch (Newtonsoft.Json.JsonException exception)
            {
                var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                throw new ApiException(message, (int)response.StatusCode, string.Empty, headers, exception);
            }
        }
    }

    private string ConvertToString(object? value, System.Globalization.CultureInfo cultureInfo)
    {
        if (value == null)
        {
            return "";
        }

        if (value is System.Enum)
        {
            var name = System.Enum.GetName(value.GetType(), value);
            if (name != null)
            {
                var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                if (field != null)
                {
                    var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute))
                        as System.Runtime.Serialization.EnumMemberAttribute;
                    if (attribute != null)
                    {
                        return attribute.Value != null ? attribute.Value : name;
                    }
                }

                var converted = System.Convert.ToString(System.Convert.ChangeType(value, System.Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                return converted == null ? string.Empty : converted;
            }
        }
        else if (value is bool)
        {
            return System.Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
        }
        else if (value is byte[])
        {
            return System.Convert.ToBase64String((byte[])value);
        }
        else if (value.GetType().IsArray)
        {
            var array = System.Linq.Enumerable.OfType<object>((System.Array)value);
            return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
        }

        var result = System.Convert.ToString(value, cultureInfo);
        return result == null ? "" : result;
    }
}