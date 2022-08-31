﻿using Microsoft.AspNetCore.Mvc;
using Com.Anqa.Service.Core.Lib;
using Com.Anqa.Service.Core.Lib.Services;
using Com.Anqa.Service.Core.WebApi.Helpers;
using Com.Anqa.Service.Core.Lib.Models;
using Com.Anqa.Service.Core.Lib.ViewModels;

namespace Com.Anqa.Service.Core.WebApi.Controllers.v1.UploadControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/upload-budgets")]
    public class BudgetsUploadController : BasicUploadController<BudgetService, Budget, BudgetViewModel, BudgetService.BudgetMap, CoreDbContext>
    {
        private static readonly string ApiVersion = "1.0";

        public BudgetsUploadController(BudgetService service) : base(service, ApiVersion)
        {
        }
    }
}