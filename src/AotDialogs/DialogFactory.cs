using System.Runtime.CompilerServices;

using MMKiwi.AotDialogs.Win32;

namespace MMKiwi.AotDialogs;

public class AotDialogFactory
{
    private static Lazy<INativeDialog> _instance = new Lazy<INativeDialog>(() =>
    {
        if (OperatingSystem.IsWindowsVersionAtLeast(6, 0, 6000))
            return new WindowsComFilePicker();
        throw new NotSupportedException($"Operating System Not Supported: {Environment.OSVersion}");
    });

    public static INativeDialog Instance => _instance.Value;
}