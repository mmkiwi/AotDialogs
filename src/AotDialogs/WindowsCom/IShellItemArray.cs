using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Versioning;

namespace MMKiwi.AotDialogs.WindowsCom;

[Guid("B63EA76D-1F85-456F-A19C-48159EFA858B")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[GeneratedComInterface]
[SupportedOSPlatform("windows6.0.6000")]
internal partial interface IShellItemArray
{
    unsafe void BindToHandler( /*winmdroot.System.Com.IBindCtx*/ void* pbc, in Guid bhid, in Guid riid,
        out nint ppvOut);

    void GetPropertyStore(int /* NativeEnums.GETPROPERTYSTOREFLAGS */ flags, in Guid riid,
        out nint ppv);

    void GetPropertyDescriptionList(nint /* in NativeStructs.PROPERTYKEY*/ keyType, in Guid riid,
        out nint ppv);

    void GetAttributes(int /* NativeEnums.SIATTRIBFLAGS */ AttribFlags, int /* ativeEnums.SFGAO_FLAGS */ sfgaoMask,
        out int /* NativeEnums.SFGAO_FLAGS */ psfgaoAttribs);
    
    void GetCount(out uint pdwNumItems);

    void GetItemAt(uint dwIndex, out IShellItem ppsi);

    /// <summary>Gets an enumerator of the items in the array.</summary>
    /// <param name="ppenumShellItems">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ienumshellitems">IEnumShellItems</a>**</b> When this method returns, contains an <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ienumshellitems">IEnumShellItems</a> pointer that enumerates the <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">shell items</a> that are in the array.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-enumitems#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> If this method succeeds, it returns <b>S_OK</b>. Otherwise, it returns an <b>HRESULT</b> error code.</para>
    /// </returns>
    /// <remarks>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-enumitems">Learn more about this API from learn.microsoft.com</see>.</para>
    /// </remarks>
    void EnumItems(out nint /*IEnumShellItems*/ ppenumShellItems);
}