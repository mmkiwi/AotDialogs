using Microsoft.Win32.SafeHandles;

namespace MMKiwi.AotDialogs.Gtk;

internal abstract class GtkWidgetHandle() : SafeHandleZeroOrMinusOneIsInvalid(true)
{
    protected override bool ReleaseHandle()
    {
        NativeMethods.gtk_widget_destroy(handle);
        return true;
    }
}

internal abstract class GtkDialog : GtkWidgetHandle
{
    public NativeEnums.GtkResponse Run() => NativeMethods.gtk_dialog_run(this);
}

internal class GtkFileChooserDialog : GtkDialog
{
    public static GtkFileChooserDialog Create(string? title, NativeEnums.GtkFileChooserAction action) =>
        NativeMethods.gtk_file_chooser_dialog_new(title, 0, action, 0);

    public void AddFilter(GtkFileFilter filter) => NativeMethods.gtk_file_chooser_add_filter(this, filter);

    public string FileName
    {
        get => NativeMethods.gtk_file_chooser_get_filename(this);
        set => NativeMethods.gtk_file_chooser_set_filename(this, value);
    }
}