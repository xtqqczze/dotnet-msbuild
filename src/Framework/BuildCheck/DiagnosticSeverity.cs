﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.Build.Experimental.BuildCheck;

internal enum DiagnosticSeverity
{
    /// <summary>
    /// When set, the default value of the BuildCheck rule will be used.
    /// </summary>
    Default,

    /// <summary>
    /// When set to None the rule will not run.
    /// </summary>
    None,

    /// <summary>
    /// Information level message.
    /// </summary>
    Suggestion,

    /// <summary>
    /// Results a warning in build if the BuildCheck rule applied.
    /// </summary>
    Warning,

    /// <summary>
    /// Results an error in build if the BuildCheck rule applied.
    /// </summary>
    Error
}
