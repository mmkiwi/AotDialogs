// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

namespace MMKiwi.AotDialogs;

public interface INativeDialog
{
    Task<DialogButton> ShowMessageBoxAsync(MessageBoxSettings settings);
    DialogButton ShowMessageBox(MessageBoxSettings settings);

    string? BrowseForOpenFile(FileOpenSettings settings);
    Task<string?> BrowseForOpenFileAsync(FileOpenSettings settings);
    
    string[] BrowseForOpenFiles(FileOpenSettings settings);
    Task<string[]> BrowseForOpenFilesAsync(FileOpenSettings settings);
    
    string? BrowseForOpenFolder(FolderOpenSettings settings);
    Task<string?> BrowseForOpenFolderAsync(FolderOpenSettings settings);
    
    string? BrowseForSaveFile(FileSaveSettings settings);
    Task<string?> BrowseForSaveFileAsync(FileSaveSettings settings);
}