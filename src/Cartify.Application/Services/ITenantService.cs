using Cartify.Domain.Entities;

namespace Cartify.Application.Services;

public interface ITenantService
{
    Task<Tenant?> GetTenantByIdentifierAsync(string identifier);
    Task<Tenant?> GetTenantByIdAsync(Guid tenantId);
    Task<Tenant> CreateTenantAsync(Tenant tenant);
    Task<Tenant> UpdateTenantAsync(Tenant tenant);
    Task<bool> DeleteTenantAsync(Guid tenantId);
    Task<IEnumerable<Tenant>> GetAllTenantsAsync();
    Task<bool> IsTenantActiveAsync(string identifier);
}
