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