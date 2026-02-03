// SPDX-License-Identifier: MIT
// Copyright 2026 Micah Makaiwi
// This source code is subject to the terms of the MIT license.
// If a copy of the license was not distributed with this file,
// you can obtain one at https://github.com/mmkiwi/AotDialogs/blob/main/LICENSE.md

using System.Diagnostics.CodeAnalysis;

namespace MMKiwi.AotDialogs.WindowsCom;

[SuppressMessage("ReSharper", "InconsistentNaming", Justification = "Matching windows API")]
internal partial class NativeMethods
{
    [LibraryImport("shell32.dll")]
    [SupportedOSPlatform("windows6.0.6000")]
    public static unsafe partial void SHCreateItemFromParsingName(
        [MarshalAs(UnmanagedType.LPWStr)] string pszPath, /* IBindCtx */ nint pbc, in Guid riid, out IShellItem ppv);

    [SupportedOSPlatform("windows5.1.2600")]
    internal static NativeStructs.HRESULT CoCreateInstance<T>(Guid rclsid, object? pUnkOuter,
        NativeEnums.CLSCTX dwClsContext, out T ppv)
        where T : class
    {
        NativeStructs.HRESULT hr = CoCreateInstance(rclsid, pUnkOuter, dwClsContext, typeof(T).GUID, out object o);
        ppv = (T)o;
        return hr;
    }

    [LibraryImport("user32.dll", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.1.2600")]
    internal static partial DialogButton MessageBoxW(nint hwnd, string? lpText, string? lpCaption, uint uType);

    [LibraryImport("OLE32.dll"), DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
    [SupportedOSPlatform("windows5.0")]
    private static unsafe partial NativeStructs.HRESULT CoCreateInstance(in Guid rclsid,
        [Optional] [MarshalAs(UnmanagedType.Interface)]
        object? pUnkOuter, NativeEnums.CLSCTX dwClsContext,
        in Guid riid, [MarshalAs(UnmanagedType.Interface)] out object ppv);

    [LibraryImport("OLE32.dll"), DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
    [SupportedOSPlatform("windows5.0")]
    internal static unsafe partial void CoTaskMemFree([Optional] void* pv);
}