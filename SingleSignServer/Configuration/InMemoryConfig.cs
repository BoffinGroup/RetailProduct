using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Test;
using System.Security.Claims;
using IdentityServer4;

namespace SingleSignServer.Configuration
{
    public class InMemoryConfig
    {
        public static IEnumerable<IdentityResource> GetIdentityResources() =>
         new List<IdentityResource>
         {
              new IdentityResources.OpenId(),
              new IdentityResources.Profile()
         };


        public static IEnumerable<Client> GetClients() =>
        new List<Client>
        {
           new Client
           {
                ClientId = "retail-product",
                ClientSecrets = new [] { new Secret("productsecret".Sha512()) },
                AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                AllowedScopes = { IdentityServerConstants.StandardScopes.OpenId, "stockManagement" }
            }
        };


        public static List<TestUser> GetUsers() =>
          new List<TestUser>
          {
              new TestUser
              {
                  SubjectId = "1",
                  Username = "user",
                  Password = "password",
                  Claims = new List<Claim>
                  {
                      new Claim("given_name", "John"),
                      new Claim("family_name", "Doe")
                  }
              },
              new TestUser
              {
                  SubjectId = "2",
                  Username = "user2",
                  Password = "password1",
                  Claims = new List<Claim>
                  {
                      new Claim("given_name", "Jane"),
                      new Claim("family_name", "Doe")
                  }
              }
          };
        public static IEnumerable<ApiScope> GetApiScopes() =>
        new List<ApiScope> { new ApiScope("stockManagement", "StockManagement API") };

        public static IEnumerable<ApiResource> GetApiResources() =>
            new List<ApiResource>
            {
                new ApiResource("stockManagement", "StockManagement API")
                {
                    Scopes = { "stockManagement" }
                }
            };
    }
}
