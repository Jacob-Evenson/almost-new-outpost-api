namespace AlmostNewOutpost.Api.Models.Responses;

/// <summary>
/// A role id and name returned by the admin roles endpoint.
/// </summary>

public class RoleDto{
public int RoleId { get; set; }
public string RoleName {get; set; } = string.Empty;
}