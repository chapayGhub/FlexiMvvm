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

using System;
using UIKit;

namespace FlexiMvvm.Navigation
{
    /// <summary>
    /// Defines the contract for forward navigation.
    /// </summary>
    /// <param name="navigationController">The source view navigation controller.</param>
    /// <param name="targetView">The target view for navigation.</param>
    /// <param name="animated">Determines if the transition is to be animated.</param>
    public delegate void ForwardNavigationDelegate(UINavigationController navigationController, UIViewController targetView, bool animated);

    /// <summary>
    /// Provides a set of forward navigation strategies.
    /// </summary>
    public sealed class ForwardNavigationStrategy
    {
        /// <summary>
        /// Forward navigation using <see cref="UINavigationController.PushViewController(UIViewController, bool)"/> method.
        /// </summary>
        /// <returns>The forward navigation delegate.</returns>
        public ForwardNavigationDelegate PushViewController()
        {
            return (navigationController, targetView, animated) =>
            {
                navigationController.PushViewController(targetView, animated);
            };
        }

        /// <summary>
        /// Forward navigation using <see cref="UIViewController.PresentViewController(UIViewController, bool, Action?)"/> method.
        /// </summary>
        /// <param name="completionHandler">The method to invoke when the animation completes. Can be <c>null</c>.</param>
        /// <returns>The forward navigation delegate.</returns>
        public ForwardNavigationDelegate PresentViewController(Action? completionHandler = null)
        {
            return (navigationController, targetView, animated) =>
            {
                navigationController.PresentViewController(targetView, animated, completionHandler);
            };
        }

        /// <summary>
        /// Forward navigation using <see cref="UINavigationController.SetViewControllers(UIViewController[], bool)"/> method. Target view delegate parameter is passed as a value.
        /// </summary>
        /// <returns>The forward navigation delegate.</returns>
        public ForwardNavigationDelegate SetViewControllers()
        {
            return (navigationController, targetView, animated) =>
            {
                navigationController.SetViewControllers(new UIViewController[] { targetView }, animated);
            };
        }

        /// <summary>
        /// Forward navigation using <see cref="UINavigationController.SetViewControllers(UIViewController[], bool)"/> method.
        /// </summary>
        /// <param name="viewControllers">The array of view controllers to be set. Target view delegate parameter will be ignored.</param>
        /// <returns>The forward navigation delegate.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="viewControllers"/> is <c>null</c>.</exception>
        public ForwardNavigationDelegate SetViewControllers(UIViewController[] viewControllers)
        {
            if (viewControllers == null)
                throw new ArgumentNullException(nameof(viewControllers));

            return (navigationController, targetView, animated) =>
            {
                navigationController.SetViewControllers(viewControllers, animated);
            };
        }
    }
}
