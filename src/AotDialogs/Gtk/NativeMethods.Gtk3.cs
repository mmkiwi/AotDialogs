using System.Runtime.CompilerServices;

namespace MMKiwi.AotDialogs.Gtk;

internal static partial class NativeMethods
{
    internal static partial class Gtk3
    {
        [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial Gtk3FileChooserNative gtk_file_chooser_native_new(string? title, nint parent,
            NativeEnums.GtkFileChooserAction action, string? accept_label, string? cancel_label);

        [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial Gtk3FileChooserDialog gtk_file_chooser_dialog_new(string? title, nint parent,
            NativeEnums.GtkFileChooserAction action, nint text_pairs);

        [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
        public static partial string gtk_file_chooser_get_filename(Gtk3FileChooserDialog dialog);

        [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
        public static partial string gtk_file_chooser_get_filename(Gtk3FileChooserNative dialog);

        [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void gtk_file_chooser_add_filter(Gtk3FileChooserDialog chooser, GtkFileFilter filter);

        [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void gtk_file_chooser_add_filter(Gtk3FileChooserNative chooser, GtkFileFilter filter);

        [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
        public static partial NativeEnums.GtkResponse gtk_dialog_run(GtkDialog dialog);
        
        [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool gtk_file_chooser_set_filename(Gtk3FileChooserDialog dialog, string? filename);
        
        [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool gtk_file_chooser_set_filename(Gtk3FileChooserNative dialog, string? filename);

        [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void gtk_native_dialog_show(Gtk3FileChooserNative dialog);
        
        [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void gtk_native_dialog_hide(Gtk3FileChooserNative dialog);

        [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void gtk_widget_show_all(Gtk3FileChooserDialog dialog);

        [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
        public static partial NativeEnums.GtkResponse gtk_native_dialog_run(Gtk3FileChooserNative dialog);
    }
}