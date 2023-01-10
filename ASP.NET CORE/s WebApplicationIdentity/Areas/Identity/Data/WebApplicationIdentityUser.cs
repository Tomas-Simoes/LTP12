using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace s_WebApplicationIdentity.Areas.Identity.Data;

// Add profile data for application users by adding properties to the WebApplicationIdentityUser class
public class WebApplicationIdentityUser : IdentityUser
{
    public string Nome { get; set; }
    public string Apelido { get; set; }
}

