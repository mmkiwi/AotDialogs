// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

namespace MMKiwi.AotDialogs;

public record FileFilter(string Name, params IEnumerable<string> Extensions)
{
    public static FileFilter AllFiles => new FileFilter("All Files", "*.*");
}