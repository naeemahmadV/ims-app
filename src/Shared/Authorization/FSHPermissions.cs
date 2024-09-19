using System.Collections.ObjectModel;

namespace FSH.WebApi.Shared.Authorization;

public static class FSHAction
{
    public const string View = nameof(View);
    public const string Search = nameof(Search);
    public const string Create = nameof(Create);
    public const string Update = nameof(Update);
    public const string Delete = nameof(Delete);
    public const string Export = nameof(Export);
    public const string Generate = nameof(Generate);
    public const string Clean = nameof(Clean);
    public const string UpgradeSubscription = nameof(UpgradeSubscription);
}

public static class FSHResource
{
    public const string Tenants = nameof(Tenants);
    public const string Dashboard = nameof(Dashboard);
    public const string Hangfire = nameof(Hangfire);
    public const string Users = nameof(Users);
    public const string UserRoles = nameof(UserRoles);
    public const string Roles = nameof(Roles);
    public const string RoleClaims = nameof(RoleClaims);
    public const string Products = nameof(Products);
    public const string Brands = nameof(Brands);
    public const string SalesOrders = nameof(SalesOrders);
    public const string LabelTypes = nameof(LabelTypes);
    public const string PackageType = nameof(PackageType);
    public const string PackStep = nameof(PackStep);
    public const string ReportType = nameof(ReportType);
    public const string StepType = nameof(StepType);
    public const string PickList = nameof(PickList);
    public const string Account = nameof(Account);
    public const string AccountSource = nameof(AccountSource);
    public const string City = nameof(City);
    public const string Company = nameof(Company);
    public const string Country = nameof(Country);
    public const string Lead = nameof(Lead);
    public const string LeadSource = nameof(LeadSource);
    public const string Media = nameof(Media);
    public const string Skill = nameof(Skill);
    public const string SubSkill = nameof(SubSkill);
    public const string State = nameof(State);
    public const string Opportunity = nameof(Opportunity);
    public const string OpportunitySource = nameof(OpportunitySource);
}

public static class FSHPermissions
{
    private static readonly FSHPermission[] _all = new FSHPermission[]
    {
        new("View Dashboard", FSHAction.View, FSHResource.Dashboard),
        new("View Hangfire", FSHAction.View, FSHResource.Hangfire),
        new("View Users", FSHAction.View, FSHResource.Users),
        new("Search Users", FSHAction.Search, FSHResource.Users),
        new("Create Users", FSHAction.Create, FSHResource.Users),
        new("Update Users", FSHAction.Update, FSHResource.Users),
        new("Delete Users", FSHAction.Delete, FSHResource.Users),
        new("Export Users", FSHAction.Export, FSHResource.Users),
        new("View UserRoles", FSHAction.View, FSHResource.UserRoles),
        new("Update UserRoles", FSHAction.Update, FSHResource.UserRoles),
        new("View Roles", FSHAction.View, FSHResource.Roles),
        new("Create Roles", FSHAction.Create, FSHResource.Roles),
        new("Update Roles", FSHAction.Update, FSHResource.Roles),
        new("Delete Roles", FSHAction.Delete, FSHResource.Roles),
        new("View RoleClaims", FSHAction.View, FSHResource.RoleClaims),
        new("Update RoleClaims", FSHAction.Update, FSHResource.RoleClaims),
        new("View Products", FSHAction.View, FSHResource.Products, IsBasic: true),
        new("Search Products", FSHAction.Search, FSHResource.Products, IsBasic: true),
        new("Create Products", FSHAction.Create, FSHResource.Products),
        new("Update Products", FSHAction.Update, FSHResource.Products),
        new("Delete Products", FSHAction.Delete, FSHResource.Products),
        new("Export Products", FSHAction.Export, FSHResource.Products),
        new("View Brands", FSHAction.View, FSHResource.Brands, IsBasic: true),
        new("Search Brands", FSHAction.Search, FSHResource.Brands, IsBasic: true),
        new("Create Brands", FSHAction.Create, FSHResource.Brands),
        new("Update Brands", FSHAction.Update, FSHResource.Brands),
        new("Delete Brands", FSHAction.Delete, FSHResource.Brands),
        new("Generate Brands", FSHAction.Generate, FSHResource.Brands),
        new("Clean Brands", FSHAction.Clean, FSHResource.Brands),
        new("View Tenants", FSHAction.View, FSHResource.Tenants, IsRoot: true),
        new("View SalesOrder", FSHAction.View, FSHResource.SalesOrders, IsRoot: true),
        new("Create SalesOrder", FSHAction.Create, FSHResource.SalesOrders),
        new("Create Tenants", FSHAction.Create, FSHResource.Tenants, IsRoot: true),
        new("Update Tenants", FSHAction.Update, FSHResource.Tenants, IsRoot: true),
        new("Upgrade Tenant Subscription", FSHAction.UpgradeSubscription, FSHResource.Tenants, IsRoot: true),
        new("View LabelTypes", FSHAction.View, FSHResource.LabelTypes, IsBasic: true),
        new("Search LabelTypes", FSHAction.Search, FSHResource.LabelTypes, IsBasic: true),
        new("Create LabelTypes", FSHAction.Create, FSHResource.LabelTypes),
        new("Update LabelTypes", FSHAction.Update, FSHResource.LabelTypes),
        new("Delete LabelTypes", FSHAction.Delete, FSHResource.LabelTypes),
        new("Export LabelTypes", FSHAction.Export, FSHResource.LabelTypes),
        new("View PackageType", FSHAction.View, FSHResource.PackageType, IsBasic: true),
        new("Search PackageType", FSHAction.Search, FSHResource.PackageType, IsBasic: true),
        new("Create PackageType", FSHAction.Create, FSHResource.PackageType),
        new("Update PackageType", FSHAction.Update, FSHResource.PackageType),
        new("Delete PackageType", FSHAction.Delete, FSHResource.PackageType),
        new("Export PackageType", FSHAction.Export, FSHResource.PackageType),
        new("View PackStep", FSHAction.View, FSHResource.PackStep, IsBasic: true),
        new("Search PackStep", FSHAction.Search, FSHResource.PackStep, IsBasic: true),
        new("Create PackStep", FSHAction.Create, FSHResource.PackStep),
        new("Update PackStep", FSHAction.Update, FSHResource.PackStep),
        new("Delete PackStep", FSHAction.Delete, FSHResource.PackStep),
        new("Export PackStep", FSHAction.Export, FSHResource.PackStep),
        new("View ReportType", FSHAction.View, FSHResource.ReportType, IsBasic: true),
        new("Search ReportType", FSHAction.Search, FSHResource.ReportType, IsBasic: true),
        new("Create ReportType", FSHAction.Create, FSHResource.ReportType),
        new("Update ReportType", FSHAction.Update, FSHResource.ReportType),
        new("Delete ReportType", FSHAction.Delete, FSHResource.ReportType),
        new("Export ReportType", FSHAction.Export, FSHResource.ReportType),
        new("View StepType", FSHAction.View, FSHResource.StepType, IsBasic: true),
        new("Search StepType", FSHAction.Search, FSHResource.StepType, IsBasic: true),
        new("Create StepType", FSHAction.Create, FSHResource.StepType),
        new("Update StepType", FSHAction.Update, FSHResource.StepType),
        new("Delete StepType", FSHAction.Delete, FSHResource.StepType),
        new("Export StepType", FSHAction.Export, FSHResource.StepType),
        new("View PickList", FSHAction.View, FSHResource.PickList, IsBasic: true),
        new("Search PickList", FSHAction.Search, FSHResource.PickList, IsBasic: true),
        new("Create PickList", FSHAction.Create, FSHResource.PickList),
        new("Update PickList", FSHAction.Update, FSHResource.PickList),
        new("Delete PickList", FSHAction.Delete, FSHResource.PickList),
        new("Export PickList", FSHAction.Export, FSHResource.PickList),

        new("View Account", FSHAction.View, FSHResource.Account, IsBasic: true),
        new("Search Account", FSHAction.Search, FSHResource.Account, IsBasic: true),
        new("Create Account", FSHAction.Create, FSHResource.Account),
        new("Update Account", FSHAction.Update, FSHResource.Account),
        new("Delete Account", FSHAction.Delete, FSHResource.Account),
        new("Export Account", FSHAction.Export, FSHResource.Account),

        new("View Account Source", FSHAction.View, FSHResource.AccountSource, IsBasic: true),
        new("Search Account Source", FSHAction.Search, FSHResource.AccountSource, IsBasic: true),
        new("Create Account Source", FSHAction.Create, FSHResource.AccountSource),
        new("Update Account Source", FSHAction.Update, FSHResource.AccountSource),
        new("Delete Account Source", FSHAction.Delete, FSHResource.AccountSource),
        new("Export Account Source", FSHAction.Export, FSHResource.AccountSource),

        new("View City", FSHAction.View, FSHResource.City, IsBasic: true),
        new("Search City", FSHAction.Search, FSHResource.City, IsBasic: true),
        new("Create City", FSHAction.Create, FSHResource.City),
        new("Update City", FSHAction.Update, FSHResource.City),
        new("Delete City", FSHAction.Delete, FSHResource.City),
        new("Export City", FSHAction.Export, FSHResource.City),

        new("View Company", FSHAction.View, FSHResource.Company, IsBasic: true),
        new("Search Company", FSHAction.Search, FSHResource.Company, IsBasic: true),
        new("Create Company", FSHAction.Create, FSHResource.Company),
        new("Update Company", FSHAction.Update, FSHResource.Company),
        new("Delete Company", FSHAction.Delete, FSHResource.Company),
        new("Export Company", FSHAction.Export, FSHResource.Company),

        new("View Country", FSHAction.View, FSHResource.Country, IsBasic: true),
        new("Search Country", FSHAction.Search, FSHResource.Country, IsBasic: true),
        new("Create Country", FSHAction.Create, FSHResource.Country),
        new("Update Country", FSHAction.Update, FSHResource.Country),
        new("Delete Country", FSHAction.Delete, FSHResource.Country),
        new("Export Country", FSHAction.Export, FSHResource.Country),

        new("View Lead", FSHAction.View, FSHResource.Lead, IsBasic: true),
        new("Search Lead", FSHAction.Search, FSHResource.Lead, IsBasic: true),
        new("Create Lead", FSHAction.Create, FSHResource.Lead),
        new("Update Lead", FSHAction.Update, FSHResource.Lead),
        new("Delete Lead", FSHAction.Delete, FSHResource.Lead),
        new("Export Lead", FSHAction.Export, FSHResource.Lead),

        new("View Lead Source", FSHAction.View, FSHResource.LeadSource, IsBasic: true),
        new("Search Lead Source", FSHAction.Search, FSHResource.LeadSource, IsBasic: true),
        new("Create Lead Source", FSHAction.Create, FSHResource.LeadSource),
        new("Update Lead Source", FSHAction.Update, FSHResource.LeadSource),
        new("Delete Lead Source", FSHAction.Delete, FSHResource.LeadSource),
        new("Export Lead Source", FSHAction.Export, FSHResource.LeadSource),

        new("View Media", FSHAction.View, FSHResource.Media, IsBasic: true),
        new("Search Media", FSHAction.Search, FSHResource.Media, IsBasic: true),
        new("Create Media", FSHAction.Create, FSHResource.Media),
        new("Update Media", FSHAction.Update, FSHResource.Media),
        new("Delete Media", FSHAction.Delete, FSHResource.Media),
        new("Export Media", FSHAction.Export, FSHResource.Media),

        new("View Skill", FSHAction.View, FSHResource.Skill, IsBasic: true),
        new("Search Skill", FSHAction.Search, FSHResource.Skill, IsBasic: true),
        new("Create Skill", FSHAction.Create, FSHResource.Skill),
        new("Update Skill", FSHAction.Update, FSHResource.Skill),
        new("Delete Skill", FSHAction.Delete, FSHResource.Skill),
        new("Export Skill", FSHAction.Export, FSHResource.Skill),


        new("View SubSkill", FSHAction.View, FSHResource.SubSkill, IsBasic: true),
        new("Search SubSkill", FSHAction.Search, FSHResource.SubSkill, IsBasic: true),
        new("Create SubSkill", FSHAction.Create, FSHResource.SubSkill),
        new("Update SubSkill", FSHAction.Update, FSHResource.SubSkill),
        new("Delete SubSkill", FSHAction.Delete, FSHResource.SubSkill),
        new("Export SubSkill", FSHAction.Export, FSHResource.SubSkill),

        new("View State", FSHAction.View, FSHResource.State, IsBasic: true),
        new("Search State", FSHAction.Search, FSHResource.State, IsBasic: true),
        new("Create State", FSHAction.Create, FSHResource.State),
        new("Update State", FSHAction.Update, FSHResource.State),
        new("Delete State", FSHAction.Delete, FSHResource.State),
        new("Export State", FSHAction.Export, FSHResource.State),

        new("View Opportunity", FSHAction.View, FSHResource.Opportunity, IsBasic: true),
        new("Search Opportunity", FSHAction.Search, FSHResource.Opportunity, IsBasic: true),
        new("Create Opportunity", FSHAction.Create, FSHResource.Opportunity),
        new("Update Opportunity", FSHAction.Update, FSHResource.Opportunity),
        new("Delete Opportunity", FSHAction.Delete, FSHResource.Opportunity),
        new("Export Opportunity", FSHAction.Export, FSHResource.Opportunity),

        new("View Opportunity Source", FSHAction.View, FSHResource.OpportunitySource, IsBasic: true),
        new("Search Opportunity Source", FSHAction.Search, FSHResource.OpportunitySource, IsBasic: true),
        new("Create Opportunity Source", FSHAction.Create, FSHResource.OpportunitySource),
        new("Update Opportunity Source", FSHAction.Update, FSHResource.OpportunitySource),
        new("Delete Opportunity Source", FSHAction.Delete, FSHResource.OpportunitySource),
        new("Export Opportunity Source", FSHAction.Export, FSHResource.OpportunitySource),
    };

    public static IReadOnlyList<FSHPermission> All { get; } = new ReadOnlyCollection<FSHPermission>(_all);
    public static IReadOnlyList<FSHPermission> Root { get; } = new ReadOnlyCollection<FSHPermission>(_all.Where(p => p.IsRoot).ToArray());
    public static IReadOnlyList<FSHPermission> Admin { get; } = new ReadOnlyCollection<FSHPermission>(_all.Where(p => !p.IsRoot).ToArray());
    public static IReadOnlyList<FSHPermission> Basic { get; } = new ReadOnlyCollection<FSHPermission>(_all.Where(p => p.IsBasic).ToArray());
}

public record FSHPermission(string Description, string Action, string Resource, bool IsBasic = false, bool IsRoot = false)
{
    public string Name => NameFor(Action, Resource);
    public static string NameFor(string action, string resource) => $"Permissions.{resource}.{action}";
}