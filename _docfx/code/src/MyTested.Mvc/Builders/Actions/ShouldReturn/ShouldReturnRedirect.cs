﻿namespace MyTested.Mvc.Builders.Actions.ShouldReturn
{
    using ActionResults.Redirect;
    using Contracts.ActionResults.Redirect;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Class containing methods for testing <see cref="RedirectResult"/>, <see cref="RedirectToActionResult"/> or <see cref="RedirectToRouteResult"/>.
    /// </summary>
    /// <typeparam name="TActionResult">Result from invoked action in ASP.NET Core MVC controller.</typeparam>
    public partial class ShouldReturnTestBuilder<TActionResult>
    {
        /// <inheritdoc />
        public IRedirectTestBuilder Redirect()
        {
            if (this.ActionResult is RedirectToRouteResult)
            {
                return this.ReturnRedirectTestBuilder<RedirectToRouteResult>();
            }

            if (this.ActionResult is RedirectToActionResult)
            {
                return this.ReturnRedirectTestBuilder<RedirectToActionResult>();
            }

            return this.ReturnRedirectTestBuilder<RedirectResult>();
        }

        private IRedirectTestBuilder ReturnRedirectTestBuilder<TRedirectResult>()
            where TRedirectResult : ActionResult
        {
            this.TestContext.ActionResult = this.GetReturnObject<TRedirectResult>();
            return new RedirectTestBuilder<TRedirectResult>(this.TestContext);
        }
    }
}