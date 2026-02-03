// SPDX-License-Identifier: MIT
// Copyright 2026 Micah Makaiwi
// This source code is subject to the terms of the MIT license.
// If a copy of the license was not distributed with this file,
// you can obtain one at https://github.com/mmkiwi/AotDialogs/blob/main/LICENSE.md

namespace MMKiwi.AotDialogs;

public record FileOpenSettings
{
    public string? Title { get; init; }
    public IEnumerable<FileFilter> Filters { get; init; } = [FileFilter.AllFiles];
    public string? DefaultDirectory { get; init; }
    public string? DefaultFileName { get; init; }
}