﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.Mvc;
using Microsoft.Framework.ConfigurationModel;
using Microsoft.Framework.DependencyInjection;

namespace Microsoft.AspNet.Builder
{
    public static class BuilderExtensions
    {
        public static Configuration GetTestConfiguration(this IApplicationBuilder app)
        {
            var configurationProvider = app.ApplicationServices.GetRequiredService<ITestConfigurationProvider>();
            var configuration = configurationProvider == null
                ? new Configuration()
                : configurationProvider.Configuration;

            return configuration;
        }
    }
}