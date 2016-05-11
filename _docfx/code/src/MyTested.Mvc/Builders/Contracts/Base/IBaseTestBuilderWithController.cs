﻿namespace MyTested.Mvc.Builders.Contracts.Base
{
    using ShouldPassFor;

    /// <summary>
    /// Base class for all test builders with controller.
    /// </summary>
    public interface IBaseTestBuilderWithController : IBaseTestBuilder
    {
        /// <summary>
        /// Allows additional testing on various components.
        /// </summary>
        /// <returns>Test builder of <see cref="IShouldPassForTestBuilderWithController{object}"/> type.</returns>
        new IShouldPassForTestBuilderWithController<object> ShouldPassFor();
    }
}
