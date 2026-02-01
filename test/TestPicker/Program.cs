// See https://aka.ms/new-console-template for more information

using MMKiwi.AotDialogs;

internal class Program
{
    [STAThread]
    public static async Task Main(string[] args)
    {
        var instance = AotDialogFactory.Instance;
        await TestAsync(instance);
        TestSync(instance);
    }

    private static async Task TestAsync(INativeDialog instance)
    {
        var browseForOpenFileAsync= await instance.BrowseForOpenFileAsync(new FileOpenSettings()
        {
            Title = "Test Title", Filters = [new FileFilter("Excel files", ["*.xlsx;*.xlsm"]), FileFilter.AllFiles]
        });
        Console.WriteLine(await instance.ShowMessageBoxAsync(new MessageBoxSettings()
        {
            Title = "BrowseForOpenFileAsync", Message = browseForOpenFileAsync,
        }));
        
        var browseForOpenFilesAsync= await instance.BrowseForOpenFilesAsync(new FileOpenSettings()
        {
            Title = "Test Title", Filters = [new FileFilter("Excel files", ["*.xlsx;*.xlsm"]), FileFilter.AllFiles]
        });
        Console.WriteLine(await instance.ShowMessageBoxAsync(new MessageBoxSettings()
        {
            Title = "BrowseForOpenFilesAsync", Message =string.Join("\r\n",browseForOpenFilesAsync),
        }));
        
        var browseForOpenFolderAsync= await instance.BrowseForOpenFolderAsync(new FolderOpenSettings()
        {
            Title = "Test Title"
        });
        Console.WriteLine(await instance.ShowMessageBoxAsync(new MessageBoxSettings()
        {
            Title = "BrowseForOpenFolderAsync", Message = browseForOpenFolderAsync,
        }));
        
        var browseForSaveFileAsync= await instance.BrowseForSaveFileAsync(new FileSaveSettings()
        {
            Title = "Test Title", Filters = [new FileFilter("Excel files", ["*.xlsx;*.xlsm"]), FileFilter.AllFiles]
        });
        Console.WriteLine(await instance.ShowMessageBoxAsync(new MessageBoxSettings()
        {
            Title = "BrowseForSaveFileAsync", Message = browseForSaveFileAsync,
        }));
    }

    private static void TestSync(INativeDialog instance)
    {
        var browseForOpenFile= instance.BrowseForOpenFile(new FileOpenSettings()
        {
            Title = "Test Title", Filters = [new FileFilter("Excel files", ["*.xlsx;*.xlsm"]), FileFilter.AllFiles]
        });
        Console.WriteLine(instance.ShowMessageBox(new MessageBoxSettings()
        {
            Title = "BrowseForOpenFile", Message = browseForOpenFile,
        }));
        
        var browseForOpenFiles= instance.BrowseForOpenFiles(new FileOpenSettings()
        {
            Title = "Test Title", Filters = [new FileFilter("Excel files", ["*.xlsx;*.xlsm"]), FileFilter.AllFiles]
        });
        Console.WriteLine( instance.ShowMessageBox(new MessageBoxSettings()
        {
            Title = "BrowseForOpenFiles", Message =string.Join("\r\n",browseForOpenFiles),
        }));
        
        var browseForOpenFolder= instance.BrowseForOpenFolder(new FolderOpenSettings()
        {
            Title = "Test Title"
        });
        Console.WriteLine(instance.ShowMessageBox(new MessageBoxSettings()
        {
            Title = "BrowseForOpenFolder", Message = browseForOpenFolder,
        }));
        
        var browseForSaveFile= instance.BrowseForSaveFile(new FileSaveSettings()
        {
            Title = "Test Title", Filters = [new FileFilter("Excel files", ["*.xlsx;*.xlsm"]), FileFilter.AllFiles]
        });
        Console.WriteLine(instance.ShowMessageBox(new MessageBoxSettings()
        {
            Title = "BrowseForSaveFile", Message = browseForSaveFile,
        }));
    }
}