// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNet.Authorization
{
    /// <summary>
    /// Defines the set of data required to apply authorization rules to a resource.
    /// </summary>
    public interface IAuthorizeData
    {
        /// <summary>
        /// Gets or sets the policy name that determines access to the resource.
        /// </summary>
        string Policy { get; set; }

        /// <summary>
        /// Gets or sets a comma-separated list of roles that are allowed to access the resource.
        /// </summary>
        string Roles { get; set; }

        string ActiveAuthenticationSchemes { get; set; }
    }
}
