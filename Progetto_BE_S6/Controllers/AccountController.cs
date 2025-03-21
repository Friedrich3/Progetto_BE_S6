using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using Microsoft.EntityFrameworkCore;
using Progetto_BE_S6.Models;
using Progetto_BE_S6.ViewModel;

namespace Progetto_BE_S6.Controllers
{
    [Authorize]
    [OutputCache(NoStore = true, Duration = 0)]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> Register()
        {
            ViewBag.Ruoli = await _roleManager.Roles.ToListAsync();
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        
        public async Task<IActionResult> Register(RegisterDipendenteViewModel dipendentViewModel)
        {
            if (!ModelState.IsValid) 
            {
                TempData["Error"] = "Errore nell' inserimento del dipendente";
                return RedirectToAction("Register");
            }
            var newDipendente = new ApplicationUser()
            {
                FirstName = dipendentViewModel.FirstName,
                LastName = dipendentViewModel.LastName,
                Email = dipendentViewModel.Email,
                UserName = $"{dipendentViewModel.LastName}{dipendentViewModel.FirstName}".ToUpper(),
                BirthDate = dipendentViewModel.BirthDate,
            };
            var result = await _userManager.CreateAsync(newDipendente, dipendentViewModel.Password);
            if (!result.Succeeded)
            {
                TempData["Error"] = "Errore in fase di registrazione";
                return RedirectToAction("Register");
            }

            var user = await  _userManager.FindByEmailAsync(newDipendente.Email);
            if (user == null) 
            {
                TempData["Error"] = "Errore in fase di assegnazione ruolo";
                return RedirectToAction("Register");
            }
            await _userManager.AddToRoleAsync(user,dipendentViewModel.Role);
            return RedirectToAction("Index");
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {

            return View();
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid) 
            {
                TempData["Error"] = "Errore in fase di login";
                return RedirectToAction("Login");
            }
             var dipendente = await _userManager.FindByEmailAsync(loginViewModel.Email);
            if (dipendente == null)
            {
                TempData["Error"] = "Email o Password Errate";
                return RedirectToAction("Login");
            }
            var result = await _signInManager.PasswordSignInAsync(dipendente, loginViewModel.Password, true, false);
            if (!result.Succeeded)
            {
                TempData["Error"] = "Email o Password Errate";
                return RedirectToAction("Login");
            }
            var roles = await _signInManager.UserManager.GetRolesAsync(dipendente);
            if (roles == null)
            {
                TempData["Error"] = "Non sei ancora stato Autorizzato";
                return RedirectToAction("Login");
            }
            List<Claim> claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.Email, dipendente.Email ));
            claims.Add(new Claim(ClaimTypes.Name, dipendente.UserName ));
            claims.Add(new Claim(ClaimTypes.GivenName, $"{dipendente.LastName} {dipendente.FirstName}"));
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

            return RedirectToAction("Index");
        }

        
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Login");
        }

        [AllowAnonymous]
        public IActionResult Denied()
        {
            return View();
        }

        }
    }
