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
using CoreGraphics;

namespace FlexiMvvm.Views
{
    public class StyledLayoutView<TTheme> : LayoutViewBase
    {
        public StyledLayoutView(TTheme theme)
        {
            Theme = theme ?? throw new ArgumentNullException(nameof(theme));

            Initialize();
        }

        public StyledLayoutView(TTheme theme, CGRect frame)
            : base(frame)
        {
            Theme = theme ?? throw new ArgumentNullException(nameof(theme));

            Initialize();
        }

        public TTheme Theme { get; }

        protected override void SetupLayout()
        {
            LayoutViewSetup.SetupNonScrollableLayout(this, ContentView, ContentOverlayView);
        }

        protected override void SetupLayoutConstraints()
        {
            AllSubviewsDoNotTranslateAutoresizingMaskIntoConstraints(this);

            LayoutViewSetup.SetupNonScrollableLayoutConstraints(this, ContentView, ContentOverlayView);
        }
    }

    public class StyledLayoutView<TTheme, TConfig> : LayoutViewBase<TConfig>
    {
        public StyledLayoutView(TTheme theme, TConfig config)
            : base(config)
        {
            Theme = theme ?? throw new ArgumentNullException(nameof(theme));

            Initialize();
        }

        public StyledLayoutView(TTheme theme, TConfig config, CGRect frame)
            : base(config, frame)
        {
            Theme = theme ?? throw new ArgumentNullException(nameof(theme));

            Initialize();
        }

        public TTheme Theme { get; }

        protected override void SetupLayout()
        {
            LayoutViewSetup.SetupNonScrollableLayout(this, ContentView, ContentOverlayView);
        }

        protected override void SetupLayoutConstraints()
        {
            AllSubviewsDoNotTranslateAutoresizingMaskIntoConstraints(this);

            LayoutViewSetup.SetupNonScrollableLayoutConstraints(this, ContentView, ContentOverlayView);
        }
    }
}