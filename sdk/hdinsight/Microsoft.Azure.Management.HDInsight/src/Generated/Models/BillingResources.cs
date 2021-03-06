// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The billing resources.
    /// </summary>
    public partial class BillingResources
    {
        /// <summary>
        /// Initializes a new instance of the BillingResources class.
        /// </summary>
        public BillingResources()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BillingResources class.
        /// </summary>
        /// <param name="region">The region or location.</param>
        /// <param name="billingMeters">The billing meter information.</param>
        /// <param name="diskBillingMeters">The managed disk billing
        /// information.</param>
        public BillingResources(string region = default(string), IList<BillingMeters> billingMeters = default(IList<BillingMeters>), IList<DiskBillingMeters> diskBillingMeters = default(IList<DiskBillingMeters>))
        {
            Region = region;
            BillingMeters = billingMeters;
            DiskBillingMeters = diskBillingMeters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the region or location.
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the billing meter information.
        /// </summary>
        [JsonProperty(PropertyName = "billingMeters")]
        public IList<BillingMeters> BillingMeters { get; set; }

        /// <summary>
        /// Gets or sets the managed disk billing information.
        /// </summary>
        [JsonProperty(PropertyName = "diskBillingMeters")]
        public IList<DiskBillingMeters> DiskBillingMeters { get; set; }

    }
}
