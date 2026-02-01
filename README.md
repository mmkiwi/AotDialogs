# AOT Dialogs Package

This is a simple package for .NET (8.0 or later) that allows for simple dialogs (for instance from command line or
macro) programs. This package is AOT-safe and less than 200kb trimmed.

The following dialogs are available:

* Message Box
* File Open Picker (single and multiple)
* File Save Picker
* Folder Picker

Currently, only Windows is supported. The file pickers use COM bindings
to [IFileOpenDialog](https://learn.microsoft.com/en-us/windows/win32/api/shobjidl_core/nn-shobjidl_core-ifileopendialog)
and [IFileSaveDialog](https://learn.microsoft.com/en-us/windows/win32/api/shobjidl_core/nn-shobjidl_core-ifilesavedialog).
Message boxes use the [MessageBoxW](https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-messageboxw)
Win32 method.

Example usage:

```C#
// File Picker for Multiple Files
string[] fileList = await AotDialogFactory.Instance.BrowseForOpenFilesAsync(
    new FileOpenSettings()
        {
            Title = "Test Title",
            Filters = [new FileFilter("Excel files", ["*.xlsx;*.xlsm"]), FileFilter.AllFiles]
        });

DialogButton button = await instance.ShowMessageBoxAsync(new MessageBoxSettings()
{
    Title = "",
    Message ="Open these files?\n" + string.Join("\r\n",browseForOpenFilesAsync),
    Buttons = DialogButtons.YesNo,
    Icon = DialogIcon.Question
}));
```