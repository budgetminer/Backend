﻿using AutoMapper;
using BudgetMiner.Business.Writers;
using BudgetMiner.DataAccess;
using BudgetMiner.DataAccess.IdentityEntities;
using BudgetMiner.DataAccess.BMEntities;
using BudgetMiner.Models.IdentityModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BudgetMiner.Controllers.Identity
{
    /// <summary>
    /// Used to log in and out.
    /// </summary>
    public class AccountsController : Controller
    {
        private UserManager<IdentityUser> _userManager;
        private IdentityContext _identityContext;
        private ICustomerWriter _customerWriter;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="userManager"></param>
        /// <param name="context"></param>
        /// <param name="customerWriter"></param>
        public AccountsController(UserManager<IdentityUser> userManager, IdentityContext context, ICustomerWriter customerWriter)
        {
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _identityContext = context ?? throw new ArgumentNullException(nameof(context));
            _customerWriter = customerWriter ?? throw new ArgumentNullException(nameof(customerWriter));
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

            var userIdentity = Mapper.Map<IdentityUser>(model);
            var result = await _userManager.CreateAsync(userIdentity, model.Password);

            if (!result.Succeeded) throw new NotImplementedException();
            if (model.IsAdmin)
            {
                var customer = new DataAccess.IdentityEntities.Customer()
                {
                    IdentityId = userIdentity.Id,
                    Naam = model.UserName
                };
                await _customerWriter.Add(new DataAccess.BMEntities.Customer() { Name = model.UserName });
                await _identityContext.AddAsync(customer);
            }
            else
            {
                var admin = new Admin()
                {
                    IdentityId = userIdentity.Id,
                };
                await _identityContext.AddAsync(admin);
            }
            await _identityContext.SaveChangesAsync();

            return new OkResult();
        }
    }
}
