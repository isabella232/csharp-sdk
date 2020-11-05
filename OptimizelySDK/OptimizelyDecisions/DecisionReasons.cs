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

using System.Collections.Generic;

namespace OptimizelySDK.OptimizelyDecisions
{
    /// <summary>
    /// Interface implemented by all condition classes for audience evaluation.
    /// </summary>
    public interface IDecisionReasons
    {
        void AddError(string format, params object[] args);
        string AddInfo(string format, params object[] args);
        List<string> ToReport();
    }

}
