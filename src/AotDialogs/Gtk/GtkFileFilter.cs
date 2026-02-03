namespace MMKiwi.AotDialogs.Gtk;

internal class GtkFileFilter : GObjectHandle
{
    public static GtkFileFilter Create()
    {
        return NativeMethods.gtk_file_filter_new();
    }

    public string Name
    {
        get => NativeMethods.gtk_file_filter_get_name(this);
        set => NativeMethods.gtk_file_filter_set_name(this, value);
    }
    
    public void AddPattern(string pattern) => NativeMethods.gtk_file_filter_add_pattern(this, pattern);
}