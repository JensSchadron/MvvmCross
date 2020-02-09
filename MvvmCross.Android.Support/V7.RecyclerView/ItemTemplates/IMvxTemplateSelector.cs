﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

namespace MvvmCross.AndroidXSupport.RecyclerView.ItemTemplates
{
    public interface IMvxTemplateSelector
    {
        int ItemTemplateId { get; set; }
        int GetItemViewType(object forItemObject);

        int GetItemLayoutId(int fromViewType);
    }
}
