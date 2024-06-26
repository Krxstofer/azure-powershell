﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System.Collections;
using System.Management.Automation;
using Microsoft.Azure.Commands.ResourceManager.Common.Tags;
using Microsoft.Rest.Azure;
using Microsoft.Azure.Commands.Sql.ElasticJobs.Model;
using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Commands.Sql.Common;

namespace Microsoft.Azure.Commands.Sql.ElasticJobs.Cmdlet
{
    /// <summary>
    /// Defines the Set-AzureRmSqlElasticJobAgent Cmdlet
    /// </summary>
    [Cmdlet(VerbsCommon.Set, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "SqlElasticJobAgent",
        SupportsShouldProcess = true,
        DefaultParameterSetName = DefaultParameterSet)]
    [OutputType(typeof(AzureSqlElasticJobAgentModel))]
    public class SetAzureSqlElasticJobAgent : AzureSqlElasticJobAgentCmdletBase<AzureSqlElasticJobAgentModel>
    {
        /// <summary>
        /// Gets or sets the resource group name
        /// </summary>
        [Parameter(
            Mandatory = true,
            ParameterSetName = DefaultParameterSet,
            Position = 0,
            HelpMessage = "The resource group name")]
        [ValidateNotNullOrEmpty]
        [ResourceGroupCompleter]
        public override string ResourceGroupName { get; set; }

        /// <summary>
        /// Gets or sets the agent input object
        /// </summary>
        [Parameter(
            Mandatory = true,
            ParameterSetName = InputObjectParameterSet,
            ValueFromPipeline = true,
            Position = 0,
            HelpMessage = "The agent input object")]
        [ValidateNotNullOrEmpty]
        public AzureSqlElasticJobAgentModel InputObject { get; set; }

        /// <summary>
        /// Gets or sets the agent resource id
        /// </summary>
        [Parameter(
            Mandatory = true,
            ParameterSetName = ResourceIdParameterSet,
            ValueFromPipelineByPropertyName = true,
            Position = 0,
            HelpMessage = "The agent resource id")]
        [ValidateNotNullOrEmpty]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the server name
        /// </summary>
        [Parameter(
            Mandatory = true,
            ParameterSetName = DefaultParameterSet,
            Position = 1,
            HelpMessage = "The server name")]
        [ValidateNotNullOrEmpty]
        public override string ServerName { get; set; }

        /// <summary>
        /// Gets or sets the agent name
        /// </summary>
        [Parameter(
            Mandatory = true,
            ParameterSetName = DefaultParameterSet,
            Position = 2,
            HelpMessage = "The agent name")]
        [ValidateNotNullOrEmpty]
        [Alias("AgentName")]
        public override string Name { get; set; }

        /// <summary>
        /// Gets or sets the Agent tags
        /// </summary>
        [Parameter(HelpMessage = "The agent tags", ParameterSetName = DefaultParameterSet)]
        [Parameter(HelpMessage = "The agent tags", ParameterSetName = InputObjectParameterSet)]
        [Parameter(HelpMessage = "The agent tags", ParameterSetName = ResourceIdParameterSet)]
        [ValidateNotNullOrEmpty]
        [Alias("Tags")]
        public Hashtable Tag { get; set; }

        /// <summary>
        /// List of user assigned identities.
        /// </summary>
        [Parameter(Mandatory = false,
            HelpMessage = "List of user assigned identities")]
        public string[] UserAssignedIdentityId { get; set; }

        /// <summary>
        /// Type of identity to be assigned to the server..
        /// </summary>
        [Parameter(Mandatory = false,
            HelpMessage = "Type of Identity to be used. Possible values are UserAssigned and None.")]
        [PSArgumentCompleter("UserAssigned", "None")]
        public string IdentityType { get; set; }

        /// <summary>
        /// Gets or sets the skuCapacity
        /// </summary>
        [Parameter(Mandatory = false,
            HelpMessage = "WorkerCount is the capacity of the Azure SQL Job Agent which controls the number of concurrent targets that can be executed.")]
        [PSArgumentCompleter("100", "200", "400", "800")]
        [Alias("Capacity")]
        public int? WorkerCount { get; set; }

        /// <summary>
        /// Gets or sets the name of the service objective to assign to the Azure SQL Job Agent. 
        /// </summary>
        [Parameter(Mandatory = false,
            HelpMessage = "The name of the service objective to assign to the Azure SQL Job Agent.")]
        [ValidateNotNullOrEmpty]
        [PSArgumentCompleter("JA100", "JA200", "JA400", "JA800")]
        [Alias("RequestedServiceObjectiveName")]
        public string SkuName { get; set; }

        /// <summary>
        /// Entry point for the cmdlet
        /// </summary>
        public override void ExecuteCmdlet()
        {
            InitializeInputObjectProperties(this.InputObject);
            InitializeResourceIdProperties(this.ResourceId);
            this.Name = this.Name ?? this.AgentName;
            base.ExecuteCmdlet();
            ClearProperties();
        }

        /// <summary>
        /// Check to see if the agent already exists in this resource group.
        /// </summary>
        /// <returns>Null if the agent doesn't exist. Otherwise throws exception</returns>
        protected override IEnumerable<AzureSqlElasticJobAgentModel> GetEntity()
        {
            try
            {
                WriteDebugWithTimestamp("AgentName: {0}", Name);
                return new List<AzureSqlElasticJobAgentModel> { ModelAdapter.GetAgent(this.ResourceGroupName, this.ServerName, this.Name) };
            }
            catch (CloudException ex)
            {
                if (ex.Response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    // The agent does not exist
                    throw new PSArgumentException(
                        string.Format(Properties.Resources.AzureElasticJobAgentNotExists, this.Name, this.ServerName),
                        "AgentName");
                }

                // Unexpected exception encountered
                throw;
            }
        }

        /// <summary>
        /// Generates the model from user input.
        /// </summary>
        /// <param name="model">This is null since the server doesn't exist yet</param>
        /// <returns>The generated model from user input</returns>
        protected override IEnumerable<AzureSqlElasticJobAgentModel> ApplyUserInputToModel(IEnumerable<AzureSqlElasticJobAgentModel> model)
        {
            AzureSqlElasticJobAgentModel newEntity = new AzureSqlElasticJobAgentModel
            {
                ResourceGroupName = model.FirstOrDefault().ResourceGroupName,
                ServerName = model.FirstOrDefault().ServerName,
                AgentName = model.FirstOrDefault().AgentName,
                DatabaseName = model.FirstOrDefault().DatabaseName, // Note: control database cannot be updated
                Location = model.FirstOrDefault().Location,
                Tags = this.Tag != null ? TagsConversionHelper.CreateTagDictionary(this.Tag, validate: true) : model.First().Tags,
                WorkerCount = this.WorkerCount,
                SkuName = this.SkuName,
                Identity = JobAgentIdentityHelper.GetJobAgentIdentity(this.IdentityType, this.UserAssignedIdentityId),
            };

            return new List<AzureSqlElasticJobAgentModel> { newEntity };
        }

        /// <summary>
        /// Sends the changes to the service -> Creates the agent
        /// </summary>
        /// <param name="entity">The agent to create</param>
        /// <returns>The created agent</returns>
        protected override IEnumerable<AzureSqlElasticJobAgentModel> PersistChanges(IEnumerable<AzureSqlElasticJobAgentModel> entity)
        {
            return new List<AzureSqlElasticJobAgentModel> { ModelAdapter.UpsertAgent(entity.First()) };
        }
    }
}