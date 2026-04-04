namespace BlazorWeb.Services.Admins;

public interface IAuthService
{
    Task<bool> ValidateAdminAuthAsync(string email, string password);
}