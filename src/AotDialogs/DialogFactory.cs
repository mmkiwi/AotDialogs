using System.Runtime.CompilerServices;

using MMKiwi.AotDialogs.WindowsCom;

namespace MMKiwi.AotDialogs;

public class AotDialogFactory
{
    private static readonly Lazy<INativeDialog> s_instance = new(() =>
    {
        if (OperatingSystem.IsWindowsVersionAtLeast(6, 0, 6000))
            return new WindowsComFilePicker();
        throw new NotSupportedException($"Operating System Not Supported: {Environment.OSVersion}");
    });

    public static INativeDialog Instance => s_instance.Value;
}