﻿// <auto-generated />
// =========================================================================
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
using FlexiMvvm.Bindings;
using FlexiMvvm.Persistence.Core;
using FlexiMvvm.ViewModels;
using FlexiMvvm.ViewModels.Core;
using FlexiMvvm.Views.Core;

namespace FlexiMvvm.Views
{
    public partial class BindableAppCompatActivity<TViewModel> : FlexiMvvm.Views.AppCompatActivity<TViewModel>, IBindableView<TViewModel>, IBindingSetOwner
        where TViewModel : class, IViewModel, IStateOwner
    {
        public IDisposable BindingSet { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new BindableViewLifecycleDelegate<BindableAppCompatActivity<TViewModel>, TViewModel>(this);
        }

        public virtual void Bind(BindingSet<TViewModel> bindingSet)
        {
        }

        void IBindingSetOwner.SetBindingSet(IDisposable bindingSet)
        {
            BindingSet = bindingSet;
        }
    }

    public partial class BindableAppCompatActivity<TViewModel, TParameters> : FlexiMvvm.Views.AppCompatActivity<TViewModel, TParameters>, IBindableView<TViewModel>, IBindingSetOwner
        where TViewModel : class, IViewModelWithParameters<TParameters>, IParametersOwner<TParameters>, IStateOwner
        where TParameters : Parameters
    {
        public IDisposable BindingSet { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new BindableViewLifecycleDelegate<BindableAppCompatActivity<TViewModel, TParameters>, TViewModel>(this);
        }

        public virtual void Bind(BindingSet<TViewModel> bindingSet)
        {
        }

        void IBindingSetOwner.SetBindingSet(IDisposable bindingSet)
        {
            BindingSet = bindingSet;
        }
    }
}

namespace FlexiMvvm.Views
{
    public partial class BindableDialogFragment<TViewModel> : FlexiMvvm.Views.DialogFragment<TViewModel>, IBindableView<TViewModel>, IBindingSetOwner
        where TViewModel : class, IViewModel, IStateOwner
    {
        public IDisposable BindingSet { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new BindableViewLifecycleDelegate<BindableDialogFragment<TViewModel>, TViewModel>(this);
        }

        public virtual void Bind(BindingSet<TViewModel> bindingSet)
        {
        }

        void IBindingSetOwner.SetBindingSet(IDisposable bindingSet)
        {
            BindingSet = bindingSet;
        }
    }

    public partial class BindableDialogFragment<TViewModel, TParameters> : FlexiMvvm.Views.DialogFragment<TViewModel, TParameters>, IBindableView<TViewModel>, IBindingSetOwner
        where TViewModel : class, IViewModelWithParameters<TParameters>, IParametersOwner<TParameters>, IStateOwner
        where TParameters : Parameters
    {
        public IDisposable BindingSet { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new BindableViewLifecycleDelegate<BindableDialogFragment<TViewModel, TParameters>, TViewModel>(this);
        }

        public virtual void Bind(BindingSet<TViewModel> bindingSet)
        {
        }

        void IBindingSetOwner.SetBindingSet(IDisposable bindingSet)
        {
            BindingSet = bindingSet;
        }
    }
}

namespace FlexiMvvm.Views
{
    public partial class BindableFragment<TViewModel> : FlexiMvvm.Views.Fragment<TViewModel>, IBindableView<TViewModel>, IBindingSetOwner
        where TViewModel : class, IViewModel, IStateOwner
    {
        public IDisposable BindingSet { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new BindableViewLifecycleDelegate<BindableFragment<TViewModel>, TViewModel>(this);
        }

        public virtual void Bind(BindingSet<TViewModel> bindingSet)
        {
        }

        void IBindingSetOwner.SetBindingSet(IDisposable bindingSet)
        {
            BindingSet = bindingSet;
        }
    }

    public partial class BindableFragment<TViewModel, TParameters> : FlexiMvvm.Views.Fragment<TViewModel, TParameters>, IBindableView<TViewModel>, IBindingSetOwner
        where TViewModel : class, IViewModelWithParameters<TParameters>, IParametersOwner<TParameters>, IStateOwner
        where TParameters : Parameters
    {
        public IDisposable BindingSet { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new BindableViewLifecycleDelegate<BindableFragment<TViewModel, TParameters>, TViewModel>(this);
        }

        public virtual void Bind(BindingSet<TViewModel> bindingSet)
        {
        }

        void IBindingSetOwner.SetBindingSet(IDisposable bindingSet)
        {
            BindingSet = bindingSet;
        }
    }
}

