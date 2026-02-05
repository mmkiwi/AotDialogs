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

    [LibraryImport("gtk", StringMarshalling =  StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial nint gtk_file_chooser_dialog_new(string title, nint parent,
        NativeEnums.GtkFileChooserAction action, string test, int test1, string test2, int test3, nint ptr);
    
    /*
     * GtkWidget *gtk_file_chooser_dialog_new              (const gchar          *title,
       GtkWindow            *parent,
       GtkFileChooserAction  action,
       const gchar          *first_button_text,
       ...) G_GNUC_NULL_TERMINATED;
     */
    
    [DllImport("gtk", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr gtk_file_dialog_new();
    
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