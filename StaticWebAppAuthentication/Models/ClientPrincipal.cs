using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticWebAppAuthentication.Models;
public record ClientPrincipal(
string? IdentityProvider,
string? UserId,
string? UserDetails,
IEnumerable<string>? UserRoles);