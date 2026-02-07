// SPDX-License-Identifier: MIT
// Copyright 2026 Micah Makaiwi
// This source code is subject to the terms of the MIT license.
// If a copy of the license was not distributed with this file,
// you can obtain one at https://github.com/mmkiwi/AotDialogs/blob/main/LICENSE.md

using System.Runtime.CompilerServices;

namespace MMKiwi.AotDialogs.Gtk;

internal static partial class NativeMethods
{
    internal static partial class Gtk4
    {
        [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial Gtk4FileChooserNative gtk_file_chooser_native_new(string? title, nint parent,
            NativeEnums.GtkFileChooserAction action, string? accept_label, string? cancel_label);

        [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void gtk_file_chooser_add_filter(Gtk4FileChooserNative chooser, GtkFileFilter filter);

        [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool gtk_file_chooser_set_filename(Gtk4FileChooserNative dialog, string? filename);

        [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
        public static partial string gtk_file_chooser_get_filename(Gtk4FileChooserNative dialog);

        [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void gtk_native_dialog_show(Gtk4FileChooserNative dialog);

        [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
        public static unsafe partial Gtk4FileDialog gtk_file_dialog_new();

        [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void gtk_file_dialog_set_title(Gtk4FileDialog dialog, string? title);

        [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
        public static partial string? gtk_file_dialog_get_title(Gtk4FileDialog gtk4FileDialog);

        [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
        public static partial GCancellable g_cancellable_new();

        [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void g_cancellable_cancel(GCancellable cancellable);

        [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void gtk_file_dialog_open(Gtk4FileDialog self, nint parent, GCancellable? cancellable,
            GAsyncReadyCallback callback, nint user_data);

        public delegate void GAsyncReadyCallback(Gtk4FileDialog source, GAsyncResult result, nint user_data);

        [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
        public static partial GFile gtk_file_dialog_open_finish(Gtk4FileDialog self, GAsyncResult result,
            out GError? error);

        [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void gtk_file_dialog_set_filters(Gtk4FileDialog dialog, GListStore filters);

        [LibraryImport("glib", StringMarshalling = StringMarshalling.Utf8)]
        public static partial string g_quark_to_string(uint quark);

        [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
        public static partial nint gtk_file_filter_get_type();

        [LibraryImport("gio", StringMarshalling = StringMarshalling.Utf8)]
        public static partial GListStore g_list_store_new(nint type);
        
        [LibraryImport("gio", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void g_list_store_append(GListStore store, GtkFileFilter item);
    }
}

internal partial class GListStore : GObjectHandle
{
    
}