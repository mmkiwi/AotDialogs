namespace MMKiwi.AotDialogs;

public record FileOpenSettings
{
    public string? Title { get; init; }
    public IEnumerable<FileFilter> Filters { get; init; } = [FileFilter.AllFiles];
    public string? DefaultDirectory { get; init; }
    public string? DefaultFileName { get; init; }
}