// SPDX-License-Identifier: MIT
// Copyright 2026 Micah Makaiwi
// This source code is subject to the terms of the MIT license.
// If a copy of the license was not distributed with this file,
// you can obtain one at https://github.com/mmkiwi/AotDialogs/blob/main/LICENSE.md

namespace MMKiwi.AotDialogs.WindowsCom;

[Guid("2659B475-EEB8-48B7-8F07-B378810F48CF")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[GeneratedComInterface]
[SupportedOSPlatform("windows6.0.6000")]
internal partial interface IShellItemFilter
{
    /// <summary>Sets a given Shell item status to inclusion in the view.</summary>
    /// <param name="psi">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a>*</b> A pointer to the <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">Shell item</a> that is to be included in the view.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemfilter-includeitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> If this method succeeds, it returns <b>S_OK</b>. Otherwise, it returns an <b>HRESULT</b> error code.</para>
    /// </returns>
    /// <remarks>The host calls this method for each item in the folder. Returns S_OK to have the item enumerated for inclusion in the view. Returns S_FALSE to prevent the item from being enumerated for inclusion in the view.</remarks>
    void IncludeItem(IShellItem psi);

    /// <summary>Allows a client to specify which classes of objects in a Shell item should be enumerated for inclusion in the view.</summary>
    /// <param name="psi">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a>*</b> A pointer to the <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">Shell item</a> for which the <a href="https://docs.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-_shcontf">SHCONTF</a> enum flags are to be retrieved.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemfilter-getenumflagsforitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="pgrfFlags">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-_shcontf">SHCONTF</a>*</b> A pointer to the <a href="https://docs.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-_shcontf">SHCONTF</a> enum flags for the given <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">Shell item</a> that specifies which classes of objects to enumerate for inclusion in the view.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemfilter-getenumflagsforitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> If this method succeeds, it returns <b>S_OK</b>. Otherwise, it returns an <b>HRESULT</b> error code.</para>
    /// </returns>
    /// <remarks>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemfilter-getenumflagsforitem">Learn more about this API from learn.microsoft.com</see>.</para>
    /// </remarks>
    void GetEnumFlagsForItem(IShellItem psi, out uint pgrfFlags);
}