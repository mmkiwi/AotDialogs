namespace MMKiwi.AotDialogs.WindowsCom;

public static class Extensions
{
    [SupportedOSPlatform("windows6.0.6000")]
    internal static NativeStructs.COMDLG_FILTERSPEC ToNative(this FileFilter filter)
    {
        return new NativeStructs.COMDLG_FILTERSPEC()
        {
            pszName = filter.Name, pszSpec = string.Join(";", filter.Extensions)
        };
    }
}