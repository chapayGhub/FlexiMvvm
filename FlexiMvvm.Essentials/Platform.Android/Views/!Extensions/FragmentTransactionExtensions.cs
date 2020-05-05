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
#if __ANDROID_29__
using AndroidX.Fragment.App;
#else
using Android.Support.V4.App;
#endif
using JetBrains.Annotations;

namespace FlexiMvvm.Views
{
    public static class FragmentTransactionExtensions
    {
        [NotNull]
        public static FragmentTransaction AddToBackStackIf([NotNull] this FragmentTransaction fragmentTransaction, bool condition, [CanBeNull] string name)
        {
            if (fragmentTransaction == null)
                throw new ArgumentNullException(nameof(fragmentTransaction));

            if (condition)
            {
                fragmentTransaction.AddToBackStack(name);
            }

            return fragmentTransaction;
        }
    }
}
