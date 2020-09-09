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

using CoreGraphics;

namespace FlexiMvvm.Views
{
    public class StylizedLayoutView<TTheme> : LayoutViewBase
    {
        public StylizedLayoutView(TTheme theme)
        {
            Theme = theme;

            Initialize();
        }

        public StylizedLayoutView(TTheme theme, CGRect frame)
            : base(frame)
        {
            Theme = theme;

            Initialize();
        }

        public TTheme Theme { get; }

        protected override void SetupLayout()
        {
            SetupLayoutAsNonScrollable();
        }

        protected override void SetupLayoutConstraints()
        {
            AllSubviewsDoNotTranslateAutoresizingMaskIntoConstraints(this);

            SetupLayoutConstraintsAsNonScrollable();
        }
    }

    public class StyledLayoutView<TTheme, TParameters> : LayoutViewBase<TParameters>
    {
        public StyledLayoutView(TTheme theme, TParameters parameters)
            : base(parameters)
        {
            Theme = theme;

            Initialize();
        }

        public StyledLayoutView(TTheme theme, TParameters parameters, CGRect frame)
            : base(parameters, frame)
        {
            Theme = theme;

            Initialize();
        }

        public TTheme Theme { get; }

        protected override void SetupLayout()
        {
            SetupLayoutAsNonScrollable();
        }

        protected override void SetupLayoutConstraints()
        {
            AllSubviewsDoNotTranslateAutoresizingMaskIntoConstraints(this);

            SetupLayoutConstraintsAsNonScrollable();
        }
    }
}