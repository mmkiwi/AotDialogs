using Microsoft.Win32.SafeHandles;

namespace MMKiwi.AotDialogs.Gtk;

public abstract class GObjectHandle() : SafeHandleZeroOrMinusOneIsInvalid(true)
{
    protected override bool ReleaseHandle()
    {
        NativeMethods.gtk_widget_destroy(handle);
        return true;
    }
    
}