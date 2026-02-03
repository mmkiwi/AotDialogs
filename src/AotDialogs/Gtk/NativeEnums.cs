namespace MMKiwi.AotDialogs.Gtk;

internal static class NativeEnums
{
    public enum GtkFileChooserAction: uint
    {
        Open = 0,
        Save = 1,
        Folder = 2
    }

    public enum GtkResponse
    {
        None = -1,
        Reject = -2,
        Accept = -3,
        DeleteEvent = -4,
        Ok = -5,
        Cancel = -6,
        Close = -7,
        Yes = -8,
        No = -9,
        Apply = -10,
        Help = -11
    }
}