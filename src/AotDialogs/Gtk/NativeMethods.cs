using System.Runtime.CompilerServices;

namespace MMKiwi.AotDialogs.Gtk;

internal static partial class NativeMethods
{
    [LibraryImport("gtk", StringMarshalling =  StringMarshalling.Utf8)]
    public static partial string? gtk_check_version(uint required_major, uint required_minor, uint required_micro);

    [LibraryImport("gtk", StringMarshalling =  StringMarshalling.Utf8)]
    public static partial int gtk_get_major_version();
    
    [LibraryImport("gtk", StringMarshalling =  StringMarshalling.Utf8)]
    public static partial int gtk_get_minor_version();
    
    [LibraryImport("gtk", StringMarshalling =  StringMarshalling.Utf8)]
    public static partial int gtk_get_micro_version();
    
    [LibraryImport("gtk", StringMarshalling =  StringMarshalling.Utf8)]
    public static partial void gtk_widget_destroy (nint widget);

    [LibraryImport("gtk")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial GtkFileChooserDialog gtk_file_chooser_dialog_new([MarshalAs(UnmanagedType.LPUTF8Str)] string? title, nint parent,
        NativeEnums.GtkFileChooserAction action, nint buttons);
    
    [LibraryImport("gtk", StringMarshalling =  StringMarshalling.Utf8)]
    public static partial void gtk_file_chooser_add_filter (GtkFileChooserDialog chooser, GtkFileFilter filter);

    [LibraryImport("gtk", StringMarshalling =  StringMarshalling.Utf8)]
    public static partial GtkFileFilter gtk_file_filter_new();

    [LibraryImport("glib", StringMarshalling = StringMarshalling.Utf8)]
    public static partial void g_object_unref(GObjectHandle obj);

    [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
    public static partial string gtk_file_filter_get_name(GtkFileFilter filter);
    
    [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
    public static partial void gtk_file_filter_set_name(GtkFileFilter filter, string name);
    
    [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
    public static partial void gtk_file_filter_add_pattern(GtkFileFilter filter, string pattern);
    
    [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
    public static partial NativeEnums.GtkResponse gtk_dialog_run(GtkDialog dialog);

    [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
    public static partial string gtk_file_chooser_get_filename(GtkFileChooserDialog dialog);

    [LibraryImport("gtk", StringMarshalling = StringMarshalling.Utf8)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool gtk_file_chooser_set_filename(GtkFileChooserDialog dialog, string filename);
}