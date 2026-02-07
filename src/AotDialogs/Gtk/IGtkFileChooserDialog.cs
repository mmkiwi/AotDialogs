// SPDX-License-Identifier: MIT
// Copyright 2026 Micah Makaiwi
// This source code is subject to the terms of the MIT license.
// If a copy of the license was not distributed with this file,
// you can obtain one at https://github.com/mmkiwi/AotDialogs/blob/main/LICENSE.md

namespace MMKiwi.AotDialogs.Gtk;

internal interface IGtkFileChooserDialog
{
    NativeEnums.GtkResponse Run();
    Task<NativeEnums.GtkResponse> ShowAsync(CancellationToken token);
    string? FileName { get; set; }
    void AddFilter(GtkFileFilter filter);
}

internal interface IGtkFileChooserDialog<out T> : IGtkFileChooserDialog where T : IGtkFileChooserDialog<T>
{
    static abstract T Create(string? title, NativeEnums.GtkFileChooserAction action);
}