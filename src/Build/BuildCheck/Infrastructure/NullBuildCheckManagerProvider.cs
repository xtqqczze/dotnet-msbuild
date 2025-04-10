﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.Build.BackEnd;

namespace Microsoft.Build.Experimental.BuildCheck.Infrastructure;

internal class NullBuildCheckManagerProvider : IBuildCheckManagerProvider
{
    private readonly NullBuildCheckManager _instance = new NullBuildCheckManager();
    public IBuildCheckManager Instance => _instance;
    public IBuildEngineDataRouter BuildEngineDataRouter => _instance;

    public void InitializeComponent(IBuildComponentHost host) { }
    public void ShutdownComponent() { }
}
