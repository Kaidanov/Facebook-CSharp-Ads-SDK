﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FacebookAds.Interfaces;

/// <summary>
/// The MIT License (MIT)
///
/// Copyright (c) 2016 - Luke Paris (Paradoxis) | Searchresult Performancemarketing
///
/// Permission is hereby granted, free of charge, to any person obtaining a copy
/// of this software and associated documentation files (the "Software"), to deal
/// in the Software without restriction, including without limitation the rights
/// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
/// copies of the Software, and to permit persons to whom the Software is
/// furnished to do so, subject to the following conditions:
///
/// The above copyright notice and this permission notice shall be included in all
/// copies or substantial portions of the Software.
///
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
/// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
/// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
/// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
/// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
/// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
/// SOFTWARE.
/// </summary>
namespace FacebookAds.Object
{
    /// <summary>
    /// Allows for Ad Campagin functionality via simple to use methods
    /// </summary>
    /// <seealso cref="FacebookAds.Interfaces.AbstractCrudObject" />
    public class Campaign : AbstractCrudObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Campaign"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public Campaign(string id) : base(id) { }

        /// <summary>
        /// Gets the endpoint of the API call.
        /// </summary>
        /// <returns>string</returns>
        protected override string GetEndpoint()
        {
            return "campaigns";
        }

        /// <summary>
        /// Gets the ad sets.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public object GetAdSets(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection(typeof(AdSet), fields, parameters);
        }

        /// <summary>
        /// Gets the ads.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public object GetAds(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection(typeof(Ad), fields, parameters);
        }

        /// <summary>
        /// Gets the insights.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public object GetInsights(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("insights", fields, parameters);
        }

        /// <summary>
        /// Gets the insights asynchronously.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public object GetInsightsAsync(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnectionAsync("insights", fields, parameters);
        }
    }
}
