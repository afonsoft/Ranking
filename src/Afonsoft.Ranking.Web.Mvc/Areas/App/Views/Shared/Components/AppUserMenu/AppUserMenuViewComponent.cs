﻿using System.Threading.Tasks;
using Abp.Configuration.Startup;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc;
using Afonsoft.Ranking.Authorization;
using Afonsoft.Ranking.Web.Areas.App.Models.Layout;
using Afonsoft.Ranking.Web.Session;
using Afonsoft.Ranking.Web.Views;

namespace Afonsoft.Ranking.Web.Areas.App.Views.Shared.Components.AppUserMenu
{
    public class AppUserMenuViewComponent : RankingViewComponent
    {
        private readonly IMultiTenancyConfig _multiTenancyConfig;
        private readonly IAbpSession _abpSession;
        private readonly IPerRequestSessionCache _sessionCache;

        public AppUserMenuViewComponent(
            IPerRequestSessionCache sessionCache, 
            IMultiTenancyConfig multiTenancyConfig, 
            IAbpSession abpSession)
        {
            _sessionCache = sessionCache;
            _multiTenancyConfig = multiTenancyConfig;
            _abpSession = abpSession;
        }

        public async Task<IViewComponentResult> InvokeAsync(
            string togglerCssClass, 
            string textCssClass, 
            string symbolCssClass,
            string symbolTextCssClas,
            bool renderOnlyIcon = false)
        {
            return View(new UserMenuViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync(),
                IsMultiTenancyEnabled = _multiTenancyConfig.IsEnabled,
                IsImpersonatedLogin = _abpSession.ImpersonatorUserId.HasValue,
                HasUiCustomizationPagePermission = await PermissionChecker.IsGrantedAsync(AppPermissions.Pages_Administration_UiCustomization),
                TogglerCssClass = togglerCssClass,
                TextCssClass = textCssClass,
                SymbolCssClass = symbolCssClass,
                SymbolTextCssClass = symbolTextCssClas,
                RenderOnlyIcon = renderOnlyIcon
            });
        }
    }
}
