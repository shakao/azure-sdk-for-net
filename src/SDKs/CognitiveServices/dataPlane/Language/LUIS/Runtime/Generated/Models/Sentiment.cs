// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Runtime.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Sentiment of the input utterance.
    /// </summary>
    public partial class Sentiment
    {
        /// <summary>
        /// Initializes a new instance of the Sentiment class.
        /// </summary>
        public Sentiment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Sentiment class.
        /// </summary>
        /// <param name="label">The polarity of the sentiment, can be positive,
        /// neutral or negative.</param>
        /// <param name="score">Score of the sentiment, ranges from 0 (most
        /// negative) to 1 (most positive).</param>
        public Sentiment(string label = default(string), double? score = default(double?))
        {
            Label = label;
            Score = score;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the polarity of the sentiment, can be positive,
        /// neutral or negative.
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets score of the sentiment, ranges from 0 (most negative)
        /// to 1 (most positive).
        /// </summary>
        [JsonProperty(PropertyName = "score")]
        public double? Score { get; set; }

    }
}
