using System.Reflection;

namespace MMKiwi.AotDialogs.Gtk;

public class GtkDialogs : INativeDialog
{
    public static GtkDialogs TryLoad() => TryLoad([]);
    public static GtkDialogs TryLoad(string[] args)
    {
        ArgumentNullException.ThrowIfNull(args);
        
        nint gtkHandle = 0;
        nint glibHandle = 0;
        nint gobjectHandle = 0;
        
        NativeLibrary.SetDllImportResolver(Assembly.GetExecutingAssembly(), ResolveGtk);

        if (!NativeMethods.gtk_init_check(args.Length, args))
            throw new InvalidOperationException("Could not load gtk");
        
        NativeMethods.gtk_init(args.Length, args);
        
        var major = NativeMethods.gtk_get_major_version();
        var minor = NativeMethods.gtk_get_minor_version();
        var micro = NativeMethods.gtk_get_micro_version();
        if (major is not (3 or 4))
        {
            throw new NotSupportedException("GTK version not supported");
        }
        else
            Console.WriteLine($"Found GTK version {major}.{minor}.{micro}");
        
        return new GtkDialogs(major, minor, micro);
        
        IntPtr ResolveGtk(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
        {
            if (libraryName == "gtk")
            {
                if (gtkHandle != 0) return gtkHandle;
                if (NativeLibrary.TryLoad("gtk", assembly, searchPath ?? DllImportSearchPath.UserDirectories, out gtkHandle)) return gtkHandle;
                if (NativeLibrary.TryLoad("libgtk-4", assembly, searchPath ?? DllImportSearchPath.UserDirectories, out gtkHandle)) return gtkHandle;
                if (NativeLibrary.TryLoad("libgtk-3", assembly, searchPath ?? DllImportSearchPath.UserDirectories, out gtkHandle)) return gtkHandle;
            }
            if (libraryName == "glib")
            {
                if (glibHandle != 0) return glibHandle;
                if (NativeLibrary.TryLoad("glib", out glibHandle)) return glibHandle;
                if (NativeLibrary.TryLoad("libglib", out glibHandle)) return glibHandle;
                if (NativeLibrary.TryLoad("libglib-2", out glibHandle)) return glibHandle;
                if (NativeLibrary.TryLoad("libglib-2.0", out glibHandle)) return glibHandle;
            }
            
            if (libraryName == "gobject")
            {
                if (gobjectHandle != 0) return gobjectHandle;
                if (NativeLibrary.TryLoad("gobject", out gobjectHandle)) return gobjectHandle;
                if (NativeLibrary.TryLoad("gobject", out gobjectHandle)) return gobjectHandle;
                if (NativeLibrary.TryLoad("libgobject-2", out gobjectHandle)) return gobjectHandle;
                if (NativeLibrary.TryLoad("libgobject-2.0", out gobjectHandle)) return gobjectHandle;
            }
            return 0;
        }
    }


    private GtkDialogs(int major, int minor, int micro)
    {
        GtkVersion = new(major, minor, micro);
    }

    public Version GtkVersion { get; }
    

    public async Task<DialogButton> ShowMessageBoxAsync(MessageBoxSettings settings)
    {
        throw new NotImplementedException();
    }

    public DialogButton ShowMessageBox(MessageBoxSettings settings)
    {
        throw new NotImplementedException();
    }

    public string? BrowseForOpenFile(FileOpenSettings settings)
    {
        var dialog = GtkFileChooserNative.Create(settings.Title, NativeEnums.GtkFileChooserAction.Open);
        foreach (var filter in settings.Filters)
        {
            GtkFileFilter gtkFilter = GtkFileFilter.Create();
            gtkFilter.Name = filter.Name;
            foreach (var pattern in filter.Extensions)
            {
                gtkFilter.AddPattern(pattern);
            }

            dialog.AddFilter(gtkFilter);
        }
        
        if (dialog.Run() == NativeEnums.GtkResponse.Accept)
        {
            return dialog.FileName;
        }

        return null;
    }

    public async Task<string?> BrowseForOpenFileAsync(FileOpenSettings settings)
    { 
        var dialog = GtkFileChooserNative.Create(settings.Title, NativeEnums.GtkFileChooserAction.Open);
        foreach (var filter in settings.Filters)
        {
            GtkFileFilter gtkFilter = GtkFileFilter.Create();
            gtkFilter.Name = filter.Name;
            foreach (var pattern in filter.Extensions)
            {
                gtkFilter.AddPattern(pattern);
            }

            dialog.AddFilter(gtkFilter);
        }
        
        if (await dialog.ShowAsync() == NativeEnums.GtkResponse.Accept)
        {
            return dialog.FileName;
        }

        return null;
    }

    public string[] BrowseForOpenFiles(FileOpenSettings settings)
    {
        throw new NotImplementedException();
    }

    public Task<string[]> BrowseForOpenFilesAsync(FileOpenSettings settings)
        => Task.Factory.StartNew(() => BrowseForOpenFiles(settings), TaskCreationOptions.LongRunning);

    public string? BrowseForOpenFolder(FolderOpenSettings settings)
    {
        throw new NotImplementedException();
    }

    public async Task<string?> BrowseForOpenFolderAsync(FolderOpenSettings settings)
    {
        throw new NotImplementedException();
    }

    public string? BrowseForSaveFile(FileSaveSettings settings)
    {
        throw new NotImplementedException();
    }

    public async Task<string?> BrowseForSaveFileAsync(FileSaveSettings settings)
    {
        throw new NotImplementedException();
    }
}