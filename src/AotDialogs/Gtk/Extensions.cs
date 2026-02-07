// SPDX-License-Identifier: MIT
// Copyright 2026 Micah Makaiwi
// This source code is subject to the terms of the MIT license.
// If a copy of the license was not distributed with this file,
// you can obtain one at https://github.com/mmkiwi/AotDialogs/blob/main/LICENSE.md

namespace MMKiwi.AotDialogs.Gtk;

internal static class Extensions
{
    public static GCancellable? ToGCancellable(this CancellationToken token)
    {
        GCancellable gCancellable = NativeMethods.Gtk4.g_cancellable_new();
        token.Register(() =>
        {
            NativeMethods.Gtk4.g_cancellable_cancel(gCancellable);
        });
        return gCancellable;
    }
}