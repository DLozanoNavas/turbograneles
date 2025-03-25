﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable


using Italcol.Turbograneles.Adapters.Data;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Italcol.Turbograneles.Adapters.Areas.Identity.Pages.Account;

public class LogoutModel(SignInManager<ApplicationUser> signInManager, ILogger<LogoutModel> logger)
    : PageModel
{
    public async Task<IActionResult> OnPost(string returnUrl = null)
    {
        await signInManager.SignOutAsync();
        logger.LogInformation("User logged out.");
        if (returnUrl != null)
        {
            return LocalRedirect(returnUrl);
        }
        else
        {
            // This needs to be a redirect so that the browser performs a new
            // request and the identity for the user gets updated.
            return RedirectToPage();
        }
    }
}