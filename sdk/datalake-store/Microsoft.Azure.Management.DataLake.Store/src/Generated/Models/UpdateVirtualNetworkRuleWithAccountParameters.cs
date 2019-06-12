// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters used to update a virtual network rule while updating a
    /// Data Lake Store account.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class UpdateVirtualNetworkRuleWithAccountParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// UpdateVirtualNetworkRuleWithAccountParameters class.
        /// </summary>
        public UpdateVirtualNetworkRuleWithAccountParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// UpdateVirtualNetworkRuleWithAccountParameters class.
        /// </summary>
        /// <param name="name">The unique name of the virtual network rule to
        /// update.</param>
        /// <param name="subnetId">The resource identifier for the
        /// subnet.</param>
        public UpdateVirtualNetworkRuleWithAccountParameters(string name, string subnetId = default(string))
        {
            Name = name;
            SubnetId = subnetId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the unique name of the virtual network rule to update.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the resource identifier for the subnet.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnetId")]
        public string SubnetId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}