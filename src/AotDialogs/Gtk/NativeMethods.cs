// SPDX-License-Identifier: MIT
// Copyright 2026 Micah Makaiwi
// This source code is subject to the terms of the MIT license.
// If a copy of the license was not distributed with this file,
// you can obtain one at https://github.com/mmkiwi/AotDialogs/blob/main/LICENSE.md

namespace MMKiwi.AotDialogs.Gtk;

internal static partial class NativeMethods
{
    [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
    public static partial string? gtk_check_version(uint required_major, uint required_minor, uint required_micro);

    [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
    public static partial int gtk_get_major_version();

    [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
    public static partial int gtk_get_minor_version();

    [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
    public static partial int gtk_get_micro_version();

    [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
    public static partial void gtk_widget_destroy(nint widget);
    
    [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool gtk_init_check(in int args, in string[] argv);

    [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
    public static partial void gtk_init(in int args, in string[] argv);
    
    [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
    public static partial GtkFileFilter gtk_file_filter_new();

    [LibraryImport("glib", StringMarshalling = StringMarshalling.Utf8)]
    public static partial void g_object_unref(GObjectHandle obj);
    
    [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
    public static partial string gtk_file_filter_get_name(GtkFileFilter filter);

    [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
    public static partial void gtk_file_filter_set_name(GtkFileFilter filter, string name);

    [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
    public static partial void gtk_file_filter_add_pattern(GtkFileFilter filter, string pattern);
    
    [LibraryImport("gobject", StringMarshalling = StringMarshalling.Utf8)]
    public static partial uint g_signal_connect_object(GObjectHandle handle, string detailed_signal,
        signal_dialog_response callback, nint userData, NativeEnums.ConnectFlags flags);
    
    [LibraryImport("gobject", StringMarshalling = StringMarshalling.Utf8)]
    public static partial void g_signal_handler_disconnect(GObjectHandle handle, uint handler_id);

    public delegate void signal_generic(GObjectHandle sender, nint userData);

    public delegate void signal_dialog_response(GObjectHandle sender, NativeEnums.GtkResponse response,
        nint userData);

}