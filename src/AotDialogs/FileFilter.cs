// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using MMKiwi.AotDialogs.WindownCom;

namespace MMKiwi.AotDialogs;

public record FileFilter(string Name, params IEnumerable<string> Extensions)
{
    [SupportedOSPlatform("windows6.0.6000")]
    internal NativeStructs.COMDLG_FILTERSPEC ToNative()
    {
        return new NativeStructs.COMDLG_FILTERSPEC() { pszName = Name, pszSpec = string.Join(";", Extensions) };
    }

    public static FileFilter AllFiles => new FileFilter("All Files", "*.*");
}