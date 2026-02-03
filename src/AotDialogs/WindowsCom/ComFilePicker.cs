using MMKiwi.AotDialogs.WindowsCom;

namespace MMKiwi.AotDialogs.WindowsCom;

[SupportedOSPlatform("windows6.0.6000")]
internal class WindowsComFilePicker : INativeDialog
{
    private const int Cancelled = -0x7FF8FB39;
    private static Guid FileOpenDialogClsId => new("DC1C5A9C-E88A-4DDE-A5A1-60F82A20AEF7");
    private static Guid FileSaveDialogClsId => new("C0B4E2F3-BA21-4773-8DBA-335EC946EB8B");

    public DialogButton ShowMessageBox(MessageBoxSettings settings)
    {
        uint flags = (uint)settings.Buttons | (uint)settings.Icon;
        return NativeMethods.MessageBoxW(0, settings.Message, settings.Title, flags);
    }

    public Task<DialogButton> ShowMessageBoxAsync(MessageBoxSettings settings)
        => Task.Factory.StartNew(() => ShowMessageBox(settings));

    public string? BrowseForOpenFile(FileOpenSettings settings)
    {
        NativeMethods.CoCreateInstance(FileOpenDialogClsId, null,
            NativeEnums.CLSCTX.CLSCTX_ALL, out IFileOpenDialog dialog).ThrowOnFailure();

        if (settings.Title is not null)
            dialog.SetTitle(settings.Title);
        if (settings.DefaultDirectory is not null)
        {
            dialog.SetDefaultFolder(IShellItem.Create(settings.DefaultDirectory));
        }

        if (settings.DefaultFileName is not null)
        {
            dialog.SetFileName(settings.DefaultFileName);
        }

        if (settings.Filters.Any())
        {
            NativeStructs.COMDLG_FILTERSPEC[] transformed = settings.Filters.Select(f => f.ToNative()).ToArray();
            dialog.SetFileTypes(transformed.Length, transformed);
        }

        var resultCode = dialog.Show(0);

        if (resultCode == Cancelled)
            return null;
        if (resultCode.Failed)
            resultCode.ThrowOnFailure();

        dialog.GetResult(out IShellItem item);
        item.GetDisplayName(NativeEnums.SIGDN.SIGDN_FILESYSPATH, out string fileName);

        return fileName;
    }

    public Task<string?> BrowseForOpenFileAsync(FileOpenSettings settings)
        => Task.Factory.StartNew(() => BrowseForOpenFile(settings));

    public string[] BrowseForOpenFiles(FileOpenSettings settings)
    {
        NativeMethods.CoCreateInstance(FileOpenDialogClsId, null,
            NativeEnums.CLSCTX.CLSCTX_ALL, out IFileOpenDialog dialog).ThrowOnFailure();

        if (settings.Title is not null)
            dialog.SetTitle(settings.Title);
        if (settings.DefaultDirectory is not null)
        {
            dialog.SetDefaultFolder(IShellItem.Create(settings.DefaultDirectory));
        }

        if (settings.DefaultFileName is not null)
        {
            dialog.SetFileName(settings.DefaultFileName);
        }

        if (settings.Filters.Any())
        {
            NativeStructs.COMDLG_FILTERSPEC[] transformed = settings.Filters.Select(f => f.ToNative()).ToArray();
            dialog.SetFileTypes(transformed.Length, transformed);
        }

        dialog.SetOptions(NativeEnums.FILEOPENDIALOGOPTIONS.FOS_ALLOWMULTISELECT);

        var resultCode = dialog.Show(0);

        if (resultCode == Cancelled)
            return [];
        if (resultCode.Failed)
            resultCode.ThrowOnFailure();

        dialog.GetResults(out IShellItemArray array);
        array.GetCount(out uint count);
        var results = new string[count];

        for (uint i = 0; i < count; i++)
        {
            array.GetItemAt(i, out IShellItem item);
            item.GetDisplayName(NativeEnums.SIGDN.SIGDN_FILESYSPATH, out string fileName);
            results[i] = fileName;
        }

        return results;
    }

    public Task<string[]> BrowseForOpenFilesAsync(FileOpenSettings settings)
        => Task.Factory.StartNew(() => BrowseForOpenFiles(settings));

    public string? BrowseForOpenFolder(FolderOpenSettings settings)
    {
        NativeMethods.CoCreateInstance(FileOpenDialogClsId, null,
            NativeEnums.CLSCTX.CLSCTX_ALL, out IFileOpenDialog dialog).ThrowOnFailure();

        if (settings.Title is not null)
            dialog.SetTitle(settings.Title);
        if (settings.DefaultDirectory is not null)
        {
            dialog.SetDefaultFolder(IShellItem.Create(settings.DefaultDirectory));
        }

        dialog.SetOptions(NativeEnums.FILEOPENDIALOGOPTIONS.FOS_PICKFOLDERS);

        var resultCode = dialog.Show(0);

        if (resultCode == Cancelled)
            return null;
        if (resultCode.Failed)
            resultCode.ThrowOnFailure();

        dialog.GetResult(out IShellItem item);
        item.GetDisplayName(NativeEnums.SIGDN.SIGDN_FILESYSPATH, out string fileName);

        return fileName;
    }

    public Task<string?> BrowseForOpenFolderAsync(FolderOpenSettings settings)
        => Task.Factory.StartNew(() => BrowseForOpenFolder(settings));

    public string? BrowseForSaveFile(FileSaveSettings settings)
    {
        NativeMethods.CoCreateInstance(FileSaveDialogClsId, null,
            NativeEnums.CLSCTX.CLSCTX_ALL, out IFileSaveDialog dialog).ThrowOnFailure();

        if (settings.Title is not null)
            dialog.SetTitle(settings.Title);
        if (settings.DefaultDirectory is not null)
        {
            dialog.SetDefaultFolder(IShellItem.Create(settings.DefaultDirectory));
        }

        if (settings.DefaultFileName is not null)
        {
            dialog.SetFileName(settings.DefaultFileName);
        }

        if (settings.Filters.Any())
        {
            NativeStructs.COMDLG_FILTERSPEC[] transformed = settings.Filters.Select(f => f.ToNative()).ToArray();
            dialog.SetFileTypes(transformed.Length, transformed);
        }

        var resultCode = dialog.Show(0);

        if (resultCode == Cancelled)
            return null;
        if (resultCode.Failed)
            resultCode.ThrowOnFailure();

        dialog.GetResult(out IShellItem item);
        item.GetDisplayName(NativeEnums.SIGDN.SIGDN_FILESYSPATH, out string fileName);

        return fileName;
    }

    public Task<string?> BrowseForSaveFileAsync(FileSaveSettings settings)
        => Task.Factory.StartNew(() => BrowseForSaveFile(settings));
}