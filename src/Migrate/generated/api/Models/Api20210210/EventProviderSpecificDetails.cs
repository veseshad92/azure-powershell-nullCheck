// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Model class for provider specific details for an event.</summary>
    public partial class EventProviderSpecificDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEventProviderSpecificDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEventProviderSpecificDetailsInternal
    {

        /// <summary>Backing field for <see cref="InstanceType" /> property.</summary>
        private string _instanceType;

        /// <summary>Gets the class type. Overridden in derived classes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string InstanceType { get => this._instanceType; }

        /// <summary>Internal Acessors for InstanceType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEventProviderSpecificDetailsInternal.InstanceType { get => this._instanceType; set { {_instanceType = value;} } }

        /// <summary>Creates an new <see cref="EventProviderSpecificDetails" /> instance.</summary>
        public EventProviderSpecificDetails()
        {

        }
    }
    /// Model class for provider specific details for an event.
    public partial interface IEventProviderSpecificDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>Gets the class type. Overridden in derived classes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the class type. Overridden in derived classes.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceType { get;  }

    }
    /// Model class for provider specific details for an event.
    internal partial interface IEventProviderSpecificDetailsInternal

    {
        /// <summary>Gets the class type. Overridden in derived classes.</summary>
        string InstanceType { get; set; }

    }
}