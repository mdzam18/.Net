using Forum.Application.Accounts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Forum.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Login([FromForm] LoginRequestModel model)
        {
            if (!ModelState.IsValid)
                return View();

            var user = await _userManager.FindByNameAsync(model.Username);

            if (user != null)
            {
                var signInResult = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, false);

                if (signInResult.Succeeded)
                {
                    var a = _signInManager.IsSignedIn(User);
                    var name = User.Identity!.Name;
                    //await _userManager.AddClaimAsync(user, new Claim("Name", "Lasha"));

                    return RedirectToAction("GetAll", "Person");
                }

            }
            ModelState.AddModelError("", "Username or password is incorrect");

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromForm] RegistrationRequestModel model)
        {
            if (!ModelState.IsValid)
                return View();

            var user = new IdentityUser { UserName = model.Username, Email = model.Username };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                foreach (var err in result.Errors)
                {
                    ModelState.AddModelError("", err.Description);

                    return View();
                }
            }

            //დამოკიდებულია იმაზე გვსურს თუ არა დარეგისტრირებული მომხმარებელი ავტომატურად დალოგინდეს
            //if (result.Succeeded)
            //{
            //    //todo: 
            //}

            return RedirectToAction(nameof(Login));
        }


    }
}