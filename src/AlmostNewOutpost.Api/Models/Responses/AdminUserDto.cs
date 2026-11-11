namespace AlmostNewOutpost.Api.Models.Responses;

/// <summary>
/// A user account returned by the admin user endpoints without password information.
/// </summary>

public class AdminUserDto{
public int Id { get; set; }
public string Username { get; set; } = string.Empty;
public int RoleId { get; set; }
public string Role { get; set; } = string.Empty;
public DateTime? ArchivedAtUtc { get; set; }
}