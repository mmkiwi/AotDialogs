// SPDX-License-Identifier: MIT
// Copyright 2026 Micah Makaiwi
// This source code is subject to the terms of the MIT license.
// If a copy of the license was not distributed with this file,
// you can obtain one at https://github.com/mmkiwi/AotDialogs/blob/main/LICENSE.md

namespace MMKiwi.AotDialogs.WindowsCom;

public static class Extensions
{
    [SupportedOSPlatform("windows6.0.6000")]
    internal static NativeStructs.COMDLG_FILTERSPEC ToNative(this FileFilter filter)
    {
        return new NativeStructs.COMDLG_FILTERSPEC()
        {
            pszName = filter.Name, pszSpec = string.Join(";", filter.Extensions)
        };
    }
}