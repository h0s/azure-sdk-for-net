// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the parameters for RequestMethod match conditions
    /// </summary>
    public partial class RequestMethodMatchConditionParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RequestMethodMatchConditionParameters class.
        /// </summary>
        public RequestMethodMatchConditionParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RequestMethodMatchConditionParameters class.
        /// </summary>
        /// <param name="negateCondition">Describes if this is negate condition
        /// or not</param>
        /// <param name="matchValues">The match value for the condition of the
        /// delivery rule</param>
        public RequestMethodMatchConditionParameters(bool? negateCondition = default(bool?), IList<string> matchValues = default(IList<string>))
        {
            NegateCondition = negateCondition;
            MatchValues = matchValues;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for RequestMethodMatchConditionParameters class.
        /// </summary>
        static RequestMethodMatchConditionParameters()
        {
            Odatatype = "#Microsoft.Azure.Cdn.Models.DeliveryRuleRequestMethodConditionParameters";
            OperatorProperty = "Equal";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets describes if this is negate condition or not
        /// </summary>
        [JsonProperty(PropertyName = "negateCondition")]
        public bool? NegateCondition { get; set; }

        /// <summary>
        /// Gets or sets the match value for the condition of the delivery rule
        /// </summary>
        [JsonProperty(PropertyName = "matchValues")]
        public IList<string> MatchValues { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "@odata.type")]
        public static string Odatatype { get; private set; }

        /// <summary>
        /// Describes operator to be matched
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        public static string OperatorProperty { get; private set; }

    }
}
