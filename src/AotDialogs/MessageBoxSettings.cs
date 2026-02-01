// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

namespace MMKiwi.AotDialogs;

public record MessageBoxSettings
{
    public DialogButtons Buttons { get; init; } = DialogButtons.Ok;
    public DialogIcon Icon { get; init; } = DialogIcon.None;
    public string? Title { get; init; }
    public string? Message { get; init; }
}