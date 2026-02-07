using Microsoft.Win32.SafeHandles;

namespace MMKiwi.AotDialogs.Gtk;

internal abstract class GtkWidgetHandle() : GObjectHandle
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
    public static unsafe GtkFileChooserDialog Create(string? title, NativeEnums.GtkFileChooserAction action)
    {
        return NativeMethods.gtk_file_chooser_dialog_new(title, 0, action,  0);
    }

    public void AddFilter(GtkFileFilter filter) => NativeMethods.gtk_file_chooser_add_filter(this, filter);

    
    public string FileName
    {
        get => NativeMethods.gtk_file_chooser_get_filename(this);
        set => NativeMethods.gtk_file_chooser_set_filename(this, value);
    }
}

internal class GtkFileChooserNative : GObjectHandle
{
    public static unsafe GtkFileChooserNative Create(string? title, NativeEnums.GtkFileChooserAction action)
    {
        return NativeMethods.gtk_file_chooser_native_new(title, 0, action,  null, null);
    }

    public Task<NativeEnums.GtkResponse> ShowAsync()
    {
        TaskCompletionSource<NativeEnums.GtkResponse> taskCompletionSource = new();
        uint handle = NativeMethods.g_signal_connect_object(this, "response", (_, response, _) =>
        {
                taskCompletionSource.TrySetResult(response);
        }, 0, NativeEnums.ConnectFlags.G_CONNECT_DEFAULT);
        if (handle == 0)
        {
            throw new InvalidOperationException("could not set handle");
        }

        try
        {
            NativeMethods.gtk_native_dialog_show(this);
        }
        finally
        {
            //NativeMethods.g_signal_handler_disconnect(this, handle);
        }
        return taskCompletionSource.Task;
    }

    public NativeEnums.GtkResponse Run()
    {
        return NativeMethods.gtk_native_dialog_run(this);
    }
    
    
    public void AddFilter(GtkFileFilter filter) => NativeMethods.gtk_file_chooser_add_filter(this, filter);

    public string FileName
    {
        get => NativeMethods.gtk_file_chooser_get_filename(this);
        set => NativeMethods.gtk_file_chooser_set_filename(this, value);
    }
}