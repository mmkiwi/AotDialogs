using System.Runtime.CompilerServices;

namespace MMKiwi.AotDialogs.WindowsCom;


internal partial class NativeMethods
{
    [LibraryImport("shell32.dll")]
    [SupportedOSPlatform("windows6.0.6000")]
    public static unsafe partial void SHCreateItemFromParsingName(
        [MarshalAs(UnmanagedType.LPWStr)] string pszPath, /* IBindCtx */ nint pbc, in Guid riid, out IShellItem ppv);

    /// <inheritdoc cref="CoCreateInstance(in Guid, object, NativeEnums.CLSCTX, in Guid, out object)"/>
    [SupportedOSPlatform("windows5.1.2600")]
    internal static NativeStructs.HRESULT CoCreateInstance<T>(Guid rclsid, [Optional] object? pUnkOuter,
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

    /// <summary>Creates a single uninitialized object of the class associated with a specified CLSID.</summary>
    /// <param name="rclsid">The CLSID associated with the data and code that will be used to create the object.</param>
    /// <param name="pUnkOuter">If <b>NULL</b>, indicates that the object is not being created as part of an aggregate. If non-<b>NULL</b>, pointer to the aggregate object's <a href="https://docs.microsoft.com/windows/desktop/api/unknwn/nn-unknwn-iunknown">IUnknown</a> interface (the controlling <b>IUnknown</b>).</param>
    /// <param name="dwClsContext">Context in which the code that manages the newly created object will run. The values are taken from the enumeration <a href="https://docs.microsoft.com/windows/desktop/api/wtypesbase/ne-wtypesbase-clsctx">CLSCTX</a>.</param>
    /// <param name="riid">A reference to the identifier of the interface to be used to communicate with the object.</param>
    /// <param name="ppv">Address of pointer variable that receives the interface pointer requested in <i>riid</i>. Upon successful return, *<i>ppv</i> contains the requested interface pointer. Upon failure, *<i>ppv</i> contains <b>NULL</b>.</param>
    /// <returns>
    /// <para>This function can return the following values. </para>
    /// <para>This doc was truncated.</para>
    /// </returns>
    /// <remarks>
    /// <para>The <b>CoCreateInstance</b> function provides a convenient shortcut by connecting to the class object associated with the specified CLSID, creating a default-initialized instance, and releasing the class object. As such, it encapsulates the following functionality:</para>
    /// <para></para>
    /// <para>This doc was truncated.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/combaseapi/nf-combaseapi-cocreateinstance#">Read more on learn.microsoft.com</see>.</para>
    /// </remarks>
    [LibraryImport("OLE32.dll"), DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
    [SupportedOSPlatform("windows5.0")]
    internal static unsafe partial NativeStructs.HRESULT CoCreateInstance(in Guid rclsid,
        [Optional] [MarshalAs(UnmanagedType.Interface)]
        object? pUnkOuter, NativeEnums.CLSCTX dwClsContext,
        in Guid riid, [MarshalAs(UnmanagedType.Interface)] out object ppv);

    /// <summary>Frees a block of task memory previously allocated through a call to the CoTaskMemAlloc or CoTaskMemRealloc function.</summary>
    /// <param name="pv">A pointer to the memory block to be freed. If this parameter is <b>NULL</b>, the function has no effect.</param>
    /// <remarks>
    /// <para>The <b>CoTaskMemFree</b> function uses the default OLE allocator. The number of bytes freed equals the number of bytes that were originally allocated or reallocated. After the call, the memory block pointed to by pv is invalid and can no longer be used.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/combaseapi/nf-combaseapi-cotaskmemfree#">Read more on learn.microsoft.com</see>.</para>
    /// </remarks>
    [LibraryImport("OLE32.dll"), DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
    [SupportedOSPlatform("windows5.0")]
    internal static unsafe partial void CoTaskMemFree([Optional] void* pv);
}