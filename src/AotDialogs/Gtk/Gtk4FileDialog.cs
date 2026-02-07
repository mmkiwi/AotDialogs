// SPDX-License-Identifier: MIT
// Copyright 2026 Micah Makaiwi
// This source code is subject to the terms of the MIT license.
// If a copy of the license was not distributed with this file,
// you can obtain one at https://github.com/mmkiwi/AotDialogs/blob/main/LICENSE.md

namespace MMKiwi.AotDialogs.Gtk;

/// <summary>
/// A file chooser using the Gtk.FileChooserDialog class.
/// </summary>
/// <remarks>Introduced in GTK 4.10</remarks>
internal class Gtk4FileDialog : GObjectHandle, IGtkFileChooserDialog<Gtk4FileDialog>
{
    public Gtk4FileDialog()
    {
        Store = NativeMethods.Gtk4.g_list_store_new(NativeMethods.Gtk4.gtk_file_filter_get_type());
        
    }

    public GListStore Store { get; set; }

    private NativeEnums.GtkFileChooserAction Action { get; set; }
    public static Gtk4FileDialog Create(string? title, NativeEnums.GtkFileChooserAction action)
    {
        var dialog = NativeMethods.Gtk4.gtk_file_dialog_new();
        dialog.Action = action;
        dialog.Title = title;
        return dialog;
    }

    public string? Title
    {
        get => NativeMethods.Gtk4.gtk_file_dialog_get_title (this);
        set => NativeMethods.Gtk4.gtk_file_dialog_set_title (this, value);
    }

    public NativeEnums.GtkResponse Run()
    {
        return ShowAsync(CancellationToken.None).Result;
    }

    public Task<NativeEnums.GtkResponse> ShowAsync(CancellationToken token)
    {
        NativeMethods.Gtk4.gtk_file_dialog_set_filters(this, Store);
        
        TaskCompletionSource<NativeEnums.GtkResponse> taskCompletionSource = new();
        if (Action == NativeEnums.GtkFileChooserAction.Open)
        {
            NativeMethods.Gtk4.gtk_file_dialog_open (this, 0, token.ToGCancellable(), Callback, 0);
        }
        
        return taskCompletionSource.Task;
        
        void Callback(Gtk4FileDialog source, GAsyncResult result, IntPtr userData)
        {
            var file = NativeMethods.Gtk4.gtk_file_dialog_open_finish(source, result, out GError? error);
            if (error is not null)
            {
                taskCompletionSource.SetResult(NativeEnums.GtkResponse.Accept);
                FileName = null!;
            }
        }        
    }

    public string? FileName { get; set; }
    public void AddFilter(GtkFileFilter filter)
    {
        NativeMethods.Gtk4.g_list_store_append(Store, filter);
    }
}