using AutoMapper;
using BM2.DataAccess;
using BM2.DataAccess.IdentityEntities;
using BM2.Models.IdentityModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BM2.Controllers.Identity
{
    public class AccountsController : Controller
    {
        private IMapper _mapper;
        private UserManager<AppUser> _userManager;
        private LoginContext _identityContext;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="userManager"></param>
        /// <param name="context"></param>
        public AccountsController(IMapper mapper, UserManager<AppUser> userManager, LoginContext context)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _identityContext = context ?? throw new ArgumentNullException(nameof(context));
        }

        /// <summary>
        /// Used to create a new account - only admins can perform this action
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("[controller]")]
        //[Authorize(Policy = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]RegistrationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userIdentity = _mapper.Map<AppUser>(model);
            var result = await _userManager.CreateAsync(userIdentity, model.Password);

            if (!result.Succeeded) throw new NotImplementedException();

            var customer = new DataAccess.IdentityEntities.Customer()
            {
                IdentityId = userIdentity.Id,
                Naam = model.UserName
            };
            await _identityContext.AddAsync(customer);
            await _identityContext.SaveChangesAsync();

            return new OkResult();
        }
    }
}
