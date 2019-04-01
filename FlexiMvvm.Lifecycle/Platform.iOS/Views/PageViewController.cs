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

using System.Diagnostics.CodeAnalysis;
using FlexiMvvm.Views.Core;
using Foundation;
using UIKit;

namespace FlexiMvvm.Views
{
    [SuppressMessage(
        "StyleCop.CSharp.DocumentationRules",
        "SA1648:InheritDocMustBeUsedWithInheritingClass",
        Justification = "This rule doesn't work properly with a partial class.")]
    public partial class PageViewController
    {
        /// <inheritdoc />
        public PageViewController(
            UIPageViewControllerTransitionStyle style,
            UIPageViewControllerNavigationOrientation navigationOrientation)
            : base(style, navigationOrientation)
        {
            LifecycleDelegate = new ViewLifecycleDelegate<PageViewController>(this);
        }

        /// <inheritdoc />
        public PageViewController(
            UIPageViewControllerTransitionStyle style,
            UIPageViewControllerNavigationOrientation navigationOrientation,
            UIPageViewControllerSpineLocation spineLocation)
            : base(style, navigationOrientation, spineLocation)
        {
            LifecycleDelegate = new ViewLifecycleDelegate<PageViewController>(this);
        }

        /// <inheritdoc />
        public PageViewController(
            UIPageViewControllerTransitionStyle style,
            UIPageViewControllerNavigationOrientation navigationOrientation,
            NSDictionary options)
            : base(style, navigationOrientation, options)
        {
            LifecycleDelegate = new ViewLifecycleDelegate<PageViewController>(this);
        }

        /// <inheritdoc />
        public PageViewController(
            UIPageViewControllerTransitionStyle style,
            UIPageViewControllerNavigationOrientation navigationOrientation,
            UIPageViewControllerSpineLocation spineLocation,
            float interPageSpacing)
            : base(style, navigationOrientation, spineLocation, interPageSpacing)
        {
            LifecycleDelegate = new ViewLifecycleDelegate<PageViewController>(this);
        }
    }

    [SuppressMessage(
        "StyleCop.CSharp.DocumentationRules",
        "SA1648:InheritDocMustBeUsedWithInheritingClass",
        Justification = "This rule doesn't work properly with a partial class.")]
    public partial class PageViewController<TViewModel>
    {
        /// <inheritdoc />
        public PageViewController(
            UIPageViewControllerTransitionStyle style,
            UIPageViewControllerNavigationOrientation navigationOrientation)
            : base(style, navigationOrientation)
        {
            LifecycleDelegate = new ViewLifecycleDelegate<PageViewController<TViewModel>, TViewModel>(this);
        }

        /// <inheritdoc />
        public PageViewController(
            UIPageViewControllerTransitionStyle style,
            UIPageViewControllerNavigationOrientation navigationOrientation,
            UIPageViewControllerSpineLocation spineLocation)
            : base(style, navigationOrientation, spineLocation)
        {
            LifecycleDelegate = new ViewLifecycleDelegate<PageViewController<TViewModel>, TViewModel>(this);
        }

        /// <inheritdoc />
        public PageViewController(
            UIPageViewControllerTransitionStyle style,
            UIPageViewControllerNavigationOrientation navigationOrientation,
            NSDictionary options)
            : base(style, navigationOrientation, options)
        {
            LifecycleDelegate = new ViewLifecycleDelegate<PageViewController<TViewModel>, TViewModel>(this);
        }

        /// <inheritdoc />
        public PageViewController(
            UIPageViewControllerTransitionStyle style,
            UIPageViewControllerNavigationOrientation navigationOrientation,
            UIPageViewControllerSpineLocation spineLocation,
            float interPageSpacing)
            : base(style, navigationOrientation, spineLocation, interPageSpacing)
        {
            LifecycleDelegate = new ViewLifecycleDelegate<PageViewController<TViewModel>, TViewModel>(this);
        }
    }

    [SuppressMessage(
        "StyleCop.CSharp.DocumentationRules",
        "SA1648:InheritDocMustBeUsedWithInheritingClass",
        Justification = "This rule doesn't work properly with a partial class.")]
    public partial class PageViewController<TViewModel, TParameters>
    {
        /// <inheritdoc />
        public PageViewController(
            UIPageViewControllerTransitionStyle style,
            UIPageViewControllerNavigationOrientation navigationOrientation)
            : base(style, navigationOrientation)
        {
            LifecycleDelegate = new ViewLifecycleDelegate<PageViewController<TViewModel, TParameters>, TViewModel>(this);
        }

        /// <inheritdoc />
        public PageViewController(
            UIPageViewControllerTransitionStyle style,
            UIPageViewControllerNavigationOrientation navigationOrientation,
            UIPageViewControllerSpineLocation spineLocation)
            : base(style, navigationOrientation, spineLocation)
        {
            LifecycleDelegate = new ViewLifecycleDelegate<PageViewController<TViewModel, TParameters>, TViewModel>(this);
        }

        /// <inheritdoc />
        public PageViewController(
            UIPageViewControllerTransitionStyle style,
            UIPageViewControllerNavigationOrientation navigationOrientation,
            NSDictionary options)
            : base(style, navigationOrientation, options)
        {
            LifecycleDelegate = new ViewLifecycleDelegate<PageViewController<TViewModel, TParameters>, TViewModel>(this);
        }

        /// <inheritdoc />
        public PageViewController(
            UIPageViewControllerTransitionStyle style,
            UIPageViewControllerNavigationOrientation navigationOrientation,
            UIPageViewControllerSpineLocation spineLocation,
            float interPageSpacing)
            : base(style, navigationOrientation, spineLocation, interPageSpacing)
        {
            LifecycleDelegate = new ViewLifecycleDelegate<PageViewController<TViewModel, TParameters>, TViewModel>(this);
        }
    }
}