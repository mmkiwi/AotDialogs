// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

namespace MMKiwi.AotDialogs;

public record FileSaveSettings
{
    public string? Title { get; init; }
    public IEnumerable<FileFilter> Filters { get; init; } = [FileFilter.AllFiles];
    public string? DefaultDirectory { get; init; }
    public string? DefaultFileName { get; init; }
}