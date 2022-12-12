using Duende.IdentityServer.Models;

namespace AuthServer;

public class Config
{
    public static IEnumerable<Client> GetClients()
    {
        return new List<Client>
        {
            new Client
            {
                ClientId = "client",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets =
                {
                    new Secret("secret".Sha256())
                },
                AllowedScopes = { "smallApi.read", "smallApi.write" }
            },
            new Client
            {
                ClientId = "ro_client",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets =
                {
                    new Secret("secret".Sha256())
                },
                AllowedScopes = { "smallApi.read" }
            }
        };
    }
    public static IEnumerable<ApiScope> GetApiScopes()
    {
        return new List<ApiScope>
        {
            new ApiScope("smallApi.read", "Allows read access to the smallApi"),
            new ApiScope("smallApi.write", "Allows write access to the smallApi")
        };
    }
}
