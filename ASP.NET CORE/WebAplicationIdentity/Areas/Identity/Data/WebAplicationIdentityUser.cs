using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebAplicationIdentity.Areas.Identity.Data;

// Add profile data for application users by adding properties to the WebAplicationIdentityUser class
public class WebAplicationIdentityUser : IdentityUser
{
    public string Ñome { get; set; }
    public string Apelido { get; set; }
}

