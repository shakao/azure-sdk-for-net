﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.Sql.Models;
using Microsoft.Azure.Management.Sql;
using Xunit;

namespace Sql.Tests
{
    public class ServiceObjectiveScenarioTests
    {
        [Fact]
        public void TestGetListServiceObjectives()
        {
            string testPrefix = "sqlcrudtest-";
            string suiteName = this.GetType().FullName;
            string serverName = SqlManagementTestUtilities.GenerateName(testPrefix);

            SqlManagementTestUtilities.RunTestInNewV12Server(suiteName, "TestGetListServiceObjectives", testPrefix, (resClient, sqlClient, resourceGroup, server) =>
            {
                var serviceObjectives = sqlClient.Servers.ListServiceObjectives(resourceGroup.Name, server.Name);

                foreach(ServiceObjective objective in serviceObjectives)
                {
                    Assert.NotNull(objective.ServiceObjectiveName);
                    Assert.NotNull(objective.IsDefault);
                    Assert.NotNull(objective.IsSystem);
                    Assert.NotNull(objective.Enabled);

                    // Assert Get finds the service objective from List
                    Assert.NotNull(sqlClient.Servers.GetServiceObjective(resourceGroup.Name, server.Name, objective.Name));
                }
            });
        }
    }
}
