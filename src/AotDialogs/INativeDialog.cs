// SPDX-License-Identifier: MIT
// Copyright 2026 Micah Makaiwi
// This source code is subject to the terms of the MIT license.
// If a copy of the license was not distributed with this file,
// you can obtain one at https://github.com/mmkiwi/AotDialogs/blob/main/LICENSE.md

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