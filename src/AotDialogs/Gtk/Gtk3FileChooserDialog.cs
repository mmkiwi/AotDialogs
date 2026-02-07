namespace MMKiwi.AotDialogs.Gtk;


/// <summary>
/// A file chooser using the Gtk.FileChooserDialog class.
/// </summary>
/// <remarks>Introduced in GTK 2.4, deprecated in GTK 4.1</remarks>
internal class Gtk3FileChooserDialog : GtkDialog, IGtkFileChooserDialog<Gtk3FileChooserDialog>
{
    public static Gtk3FileChooserDialog Create(string? title, NativeEnums.GtkFileChooserAction action) =>
        NativeMethods.Gtk3.gtk_file_chooser_dialog_new(title, 0, action, 0);

    public NativeEnums.GtkResponse Run()
    {
        throw new NotImplementedException();
    }

    public Task<NativeEnums.GtkResponse> ShowAsync(CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public void AddFilter(GtkFileFilter filter) => NativeMethods.Gtk3.gtk_file_chooser_add_filter(this, filter);

    public string? FileName
    {
        get => NativeMethods.Gtk3.gtk_file_chooser_get_filename(this);
        set => NativeMethods.Gtk3.gtk_file_chooser_set_filename(this, value);
    }
}

