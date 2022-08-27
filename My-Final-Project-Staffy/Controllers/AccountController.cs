using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using My_Final_Project_Staffy.Models;
using My_Final_Project_Staffy.Utilities;
using My_Final_Project_Staffy.ViewModels;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace My_Final_Project_Staffy.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Register(EmployeeRegisterVM register)
        {

            if (!ModelState.IsValid) return View();
            AppUser user = new AppUser
            {
                FirstName = register.FirstName,
                LastName = register.LastName,
                Email = register.Email,
                UserName = register.UserName,
                IsEmpolyeer = false
            };

            IdentityResult result = await _userManager.CreateAsync(user, register.Password);
            if (!result.Succeeded)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                    return View();
                }

                return View();
            }

            string token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            string link = Url.Action(nameof(VerifyEmail), "Account", new { email = user.Email, token }, Request.Scheme, Request.Host.ToString());

            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("hamidzade.tural@gmail.com", "Staffy");
            mail.To.Add(new MailAddress(user.Email));

            mail.Subject = "Verify Email";

            string body = string.Empty;

            using (StreamReader reader = new StreamReader("wwwroot/assets/template/verifyemail.html"))
            {
                body = reader.ReadToEnd();
            }
            string about = $"Welcome <strong>{user.FirstName} {user.LastName}</strong> to our course,please click the link in below to verify your account";

            body = body.Replace("{{link}}", link);
            mail.Body = body.Replace("{{about}}", about);
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            smtp.Credentials = new NetworkCredential("hamidzade.tural@gmail.com", "plgfchvxupuobaaj");

            smtp.Send(mail);

            TempData["VerifyEmail"] = true;

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> VerifyEmail(string email, string token)
        {
            AppUser user = await _userManager.FindByEmailAsync(email);
            if (user == null) return BadRequest();

            await _userManager.ConfirmEmailAsync(user, token);
            await _signInManager.SignInAsync(user, true);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult EmployeerRegister()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> EmployeerRegister(RegisterVM register)
        {
            if (!ModelState.IsValid) return View();
            AppUser user = new AppUser
            {
                FirstName = register.FirstName,
                LastName = register.LastName,
                Email = register.Email,
                UserName = register.UserName,
                Company = register.Company,
                CompanyWebSite = register.CompanySite,
                PhoneNumber = register.PhoneNumber,
                IsEmpolyeer = true
            };

            IdentityResult result = await _userManager.CreateAsync(user, register.Password);
            if (!result.Succeeded)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                    return View();
                }

                return View();
            }

            string token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            string link = Url.Action(nameof(VerifyEmail), "Account", new { email = user.Email, token }, Request.Scheme, Request.Host.ToString());

            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("hamidzade.tural@gmail.com", "Staffy");
            mail.To.Add(new MailAddress(user.Email));

            mail.Subject = "Verify Email";

            string body = string.Empty;

            using (StreamReader reader = new StreamReader("wwwroot/assets/template/verifyemail.html"))
            {
                body = reader.ReadToEnd();
            }
            string about = $"Welcome <strong>{user.FirstName} {user.LastName}</strong> to our course,please click the link in below to verify your account";

            body = body.Replace("{{link}}", link);
            mail.Body = body.Replace("{{about}}", about);
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            smtp.Credentials = new NetworkCredential("hamidzade.tural@gmail.com", "plgfchvxupuobaaj");

            smtp.Send(mail);

            TempData["EmployeerVerify"] = true;

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid) return View();
            AppUser existed = await _userManager.FindByNameAsync(login.UserName);

            if (existed == null)
            {
                ModelState.AddModelError("", "Daxil etdiyiniz Username ve ya password yanlisdir");
                return View();
            }

            if (login.RememberMe == true)
            {
                Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(existed, login.Password, true, true);

                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", "Username or Password incorretc");
                    return View();
                }
            }
            else
            {
                Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(existed, login.Password, false, true);
                if (!result.Succeeded)
                {
                    if (result.IsLockedOut)
                    {
                        ModelState.AddModelError("", "Your are blocked for 5 minutes");
                        return View();
                    }

                    ModelState.AddModelError("", "Username or email incorrect");
                    return View();
                }
            }
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Edit()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user == null) return NotFound();

            EditUserVM edit = new EditUserVM
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Email = user.Email,
            };

            return View(edit);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(EditUserVM edit)
        {
            if (!ModelState.IsValid) return View();
            AppUser existed = await _userManager.FindByNameAsync(User.Identity.Name);

            EditUserVM editUserVM = new EditUserVM
            {
                FirstName = existed.FirstName,
                LastName = existed.LastName,
                UserName = existed.UserName,
                Email = existed.Email,
            };

            bool result = edit.Password != null && edit.NewPassword == null && edit.ConfirmPassword == null;

            if (edit.Email == null || edit.Email != existed.Email)
            {
                ModelState.AddModelError("", "You cannot change email address!");
                return View();
            }

            if (result)
            {
                existed.FirstName = edit.FirstName;
                existed.LastName = edit.LastName;
                existed.UserName = edit.UserName;
                await _userManager.UpdateAsync(existed);
            }
            else
            {
                existed.FirstName = edit.FirstName;
                existed.LastName = edit.LastName;
                existed.UserName = edit.UserName;

                if (edit.Password == edit.NewPassword)
                {
                    ModelState.AddModelError("", "You cannot change email address!");
                    return View();
                }
                IdentityResult resultEdit = await _userManager.ChangePasswordAsync(existed, edit.Password, edit.NewPassword);
                if (!resultEdit.Succeeded)
                {
                    foreach (IdentityError error in resultEdit.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View();
                };

            }

            return RedirectToAction("Index", "Home");
        }

        
        public async Task<IActionResult> EditEmployer()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user == null) return NotFound();

            EditUserEmployeerVM edit = new EditUserEmployeerVM
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Company = user.Company,
                CompanySite = user.CompanyWebSite,
                PhoneNumber = user.PhoneNumber,
                Email = user.Email
            };

            return View(edit);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> EditEmployer(EditUserEmployeerVM edit)
        {
            if (!ModelState.IsValid) return View();
            AppUser existed = await _userManager.FindByNameAsync(User.Identity.Name);

            EditUserEmployeerVM editUser = new EditUserEmployeerVM
            {
                FirstName = existed.FirstName,
                LastName = existed.LastName,
                UserName = existed.UserName,
                Company = existed.Company,
                Email = existed.Email,
                PhoneNumber = existed.PhoneNumber,
                CompanySite = existed.CompanyWebSite
            };

            bool result = edit.Password != null && edit.NewPassword == null && edit.ConfirmPassword == null;

            if(edit.Password == null || edit.Password != editUser.Password)
            {
                ModelState.AddModelError("", "You cannot change email address!");
                return View();
            }

            if (result)
            {
                existed.FirstName = edit.FirstName;
                existed.LastName = edit.LastName;
                existed.UserName = edit.UserName;
                existed.Company = edit.Company;
                existed.CompanyWebSite = edit.CompanySite;
                existed.PhoneNumber = edit.PhoneNumber;
                await _userManager.UpdateAsync(existed);
            }
            else
            {
                existed.FirstName = edit.FirstName;
                existed.LastName = edit.LastName;
                existed.UserName = edit.UserName;
                existed.Company = edit.Company;
                existed.CompanyWebSite = edit.CompanySite;
                existed.PhoneNumber = edit.PhoneNumber;

                IdentityResult identityResult = await _userManager.ChangePasswordAsync(existed, edit.Password, edit.NewPassword);
                if (!identityResult.Succeeded)
                {
                    foreach(IdentityError error in identityResult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                        return View();
                    }

                    return View();
                }
            }

            return RedirectToAction("Index", "Home");
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordVM forgot)
        {

            AppUser user = await _userManager.FindByEmailAsync(forgot.AppUser.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Please choose correct email address");
                return View();
                ;
            }

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            string link = Url.Action(nameof(ResetPassword), "Account", new { email = user.Email, token }, Request.Scheme, Request.Host.ToString());

            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("tu78rfrfu@code.edu.az", "LibSchool");
            mail.To.Add(new MailAddress(user.Email));

            mail.Subject = "Reset Password";
            mail.Body = $"<a href='{link}'>Please click here to reset your password</a>";
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();

            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            smtp.Credentials = new NetworkCredential("tu78rfrfu@code.edu.az", "rhkwgjvxkezppfxr");
            smtp.Send(mail);

            TempData["Forgot"] = true;

            return RedirectToAction("Index", "Home");

        }

        public async Task<IActionResult> ResetPassword(string email, string token)
        {
            AppUser user = await _userManager.FindByEmailAsync(email);
            if (user == null) return BadRequest();

            ForgotPasswordVM model = new ForgotPasswordVM
            {
                AppUser = user,
                Token = token,
            };
            return View(model);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> ResetPassword(ForgotPasswordVM forgot)
        {
            AppUser user = await _userManager.FindByEmailAsync(forgot.AppUser.Email);
            ForgotPasswordVM model = new ForgotPasswordVM
            {
                AppUser = user,
                Token = forgot.Token,
            };

            if (!ModelState.IsValid) return View(model);

            IdentityResult result = await _userManager.ResetPasswordAsync(user, forgot.Token, forgot.Password);

            if (!result.Succeeded)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            }
            return RedirectToAction("Index", "Home");

        }


        public async Task CreateRoles()
        {
            await _roleManager.CreateAsync(new IdentityRole { Name = Roles.Member.ToString() });
            await _roleManager.CreateAsync(new IdentityRole { Name = Roles.Admin.ToString() });
            await _roleManager.CreateAsync(new IdentityRole { Name = Roles.SuperAdmin.ToString() });
        }
    }
}

