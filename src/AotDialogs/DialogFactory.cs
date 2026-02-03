// SPDX-License-Identifier: MIT
// Copyright 2026 Micah Makaiwi
// This source code is subject to the terms of the MIT license.
// If a copy of the license was not distributed with this file,
// you can obtain one at https://github.com/mmkiwi/AotDialogs/blob/main/LICENSE.md

using System.Runtime.CompilerServices;

using MMKiwi.AotDialogs.WindowsCom;

namespace MMKiwi.AotDialogs;

public class AotDialogFactory
{
    private static readonly Lazy<INativeDialog> s_instance = new(() =>
    {
        if (OperatingSystem.IsWindowsVersionAtLeast(6, 0, 6000))
            return new WindowsComFilePicker();
        throw new NotSupportedException($"Operating System Not Supported: {Environment.OSVersion}");
    });

    public static INativeDialog Instance => s_instance.Value;
}