﻿// =========================================================================
// Copyright 2019 EPAM Systems, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// =========================================================================

using UIKit;

namespace FlexiMvvm.Navigation
{
    /// <summary>
    /// Provides strategies for the <see cref="UIViewController"/> forward and backward navigation.
    /// </summary>
    public static class ViewControllerNavigationStrategy
    {
        /// <summary>
        /// Gets the forward navigation strategy.
        /// </summary>
        public static ViewControllerForwardNavigationStrategy Forward { get; } = new ViewControllerForwardNavigationStrategy();

        /// <summary>
        /// Gets the backward navigation strategy.
        /// </summary>
        public static ViewControllerBackwardNavigationStrategy Backward { get; } = new ViewControllerBackwardNavigationStrategy();
    }
}
