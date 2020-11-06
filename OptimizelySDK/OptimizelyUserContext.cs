﻿/* 
 * Copyright 2020, Optimizely
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using OptimizelySDK.Logger;
using System.Collections.Generic;
using OptimizelySDK.ErrorHandler;
using OptimizelySDK.Entity;
using OptimizelySDK.OptimizelyDecisions;

namespace OptimizelySDK
{
    public class OptimizelyUserContext
    {
        private ILogger Logger;
        private IErrorHandler ErrorHandler;
        private string UserId { get; set; }
        private UserAttributes UserAttributes { get; set; }
        private Optimizely Optimizely { get; set; }

        public OptimizelyUserContext(Optimizely optimizely, string userId, UserAttributes userAttributes, IErrorHandler errorHandler, ILogger logger)
        {
            ErrorHandler = errorHandler;
            Logger = logger;
            Optimizely = optimizely;
            UserAttributes = userAttributes;
            UserId = userId;
        }

        /// <summary>
        /// Set an attribute for a given key.
        /// </summary>
        /// <param name="key">An attribute key</param>
        /// <param name="value">value An attribute value</param>
        public void SetAttribute(string key, object value)
        {
            UserAttributes.Add(key, value);
        }

        /// <summary>
        /// Returns a decision result ({@link OptimizelyDecision}) for a given flag key and a user context, which contains all data required to deliver the flag.
        /// <ul>
        /// <li>If the SDK finds an error, it’ll return a decision with <b>null</b> for <b>variationKey</b>. The decision will include an error message in <b>reasons</b>.
        /// </ul>
        /// </summary>
        /// <param name="key">A flag key for which a decision will be made.</param>
        /// <returns>A decision result.</returns>
        public OptimizelyDecision Decide(string key)
        {
            return Decide(key, new List<OptimizelyDecideOption>());
        }

        /// <summary>
        /// Returns a decision result ({@link OptimizelyDecision}) for a given flag key and a user context, which contains all data required to deliver the flag.
        /// <ul>
        /// <li>If the SDK finds an error, it’ll return a decision with <b>null</b> for <b>variationKey</b>. The decision will include an error message in <b>reasons</b>.
        /// </ul>
        /// </summary>
        /// <param name="key">A flag key for which a decision will be made.</param>
        /// <param name="options">A list of options for decision-making.</param>
        /// <returns>A decision result.</returns>
        public OptimizelyDecision Decide(string key,
            List<OptimizelyDecideOption> options)
        {
            return null;
        }
 
        /// <summary>
        /// Returns a key-map of decision results for multiple flag keys and a user context.
        /// </summary>
        /// <param name="keys">list of flag keys for which a decision will be made.</param>
        /// <returns>A dictionary of all decision results, mapped by flag keys.</returns>
        public Dictionary<string, OptimizelyDecision> DecideForKeys(List<string> keys)
        {
            return null;
        }

        /// <summary>
        /// Returns a key-map of decision results ({@link OptimizelyDecision}) for all active flag keys.
        /// </summary>
        /// <returns>A dictionary of all decision results, mapped by flag keys.</returns>
        public Dictionary<string, OptimizelyDecision> DecideAll()
        {
            return DecideAll(new List<OptimizelyDecideOption>());
        }


        /// <summary>
        /// Returns a key-map of decision results ({@link OptimizelyDecision}) for all active flag keys.
        /// </summary>
        /// <param name="options">A list of options for decision-making.</param>
        /// <returns>All decision results mapped by flag keys.</returns>
        public Dictionary<string, OptimizelyDecision> DecideAll(List<OptimizelyDecideOption> options)
        {
            return null;
        }

        /// <summary>
        /// Track an event.
        /// </summary>
        /// <param name="eventName">The event name.</param>
        public void TrackEvent(string eventName)
        {
            TrackEvent(eventName, new EventTags());
        }

        /// <summary>
        /// Track an event.
        /// </summary>
        /// <param name="eventName">The event name.</param>
        /// <param name="eventTags">A map of event tag names to event tag values.</param>
        public void TrackEvent(string eventName, 
            EventTags eventTags)
        {
            Optimizely.Track(eventName, UserId, UserAttributes, eventTags);
        }
    }
}