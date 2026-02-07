// SPDX-License-Identifier: MIT
// Copyright 2026 Micah Makaiwi
// This source code is subject to the terms of the MIT license.
// If a copy of the license was not distributed with this file,
// you can obtain one at https://github.com/mmkiwi/AotDialogs/blob/main/LICENSE.md

namespace MMKiwi.AotDialogs.Gtk;

/// <summary>
/// A file chooser using the Gtk.FileChooserDialog class.
/// </summary>
/// <remarks>Introduced in GTK 3.2, deprecated in GTK 4.1</remarks>
internal class Gtk4FileChooserNative : GObjectHandle, IGtkFileChooserDialog<Gtk4FileChooserNative>
{
    public static Gtk4FileChooserNative Create(string? title, NativeEnums.GtkFileChooserAction action) 
        => NativeMethods.Gtk4.gtk_file_chooser_native_new(title, 0, action,  null, null);

    public Task<NativeEnums.GtkResponse> ShowAsync(CancellationToken token)
    {
        TaskCompletionSource<NativeEnums.GtkResponse> taskCompletionSource = new();
        uint signalHandle = NativeMethods.g_signal_connect_object(this, "response", (_, response, _) =>
        {
            taskCompletionSource.TrySetResult(response);
        }, 0, NativeEnums.ConnectFlags.G_CONNECT_DEFAULT);
        if (signalHandle == 0)
        {
            throw new InvalidOperationException("could not set handle");
        }
        try
        {
            NativeMethods.Gtk4.gtk_native_dialog_show(this);
        }
        finally
        {
            NativeMethods.g_signal_handler_disconnect(this, signalHandle);
        }
        return taskCompletionSource.Task;
    }

    public NativeEnums.GtkResponse Run()
    {
        return ShowAsync(CancellationToken.None).Result;
    }
    
    
    public void AddFilter(GtkFileFilter filter) => NativeMethods.Gtk4.gtk_file_chooser_add_filter(this, filter);

    public string? FileName
    {
        get => NativeMethods.Gtk4.gtk_file_chooser_get_filename(this);
        set => NativeMethods.Gtk4.gtk_file_chooser_set_filename(this, value);
    }
}