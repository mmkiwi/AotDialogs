using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Versioning;

namespace MMKiwi.AotDialogs.WindownCom;

[Guid("B63EA76D-1F85-456F-A19C-48159EFA858B")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[GeneratedComInterface]
[SupportedOSPlatform("windows6.0.6000")]
internal partial interface IShellItemArray
{
    /// <summary>Binds to an object by means of the specified handler.</summary>
    /// <param name="pbc">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/objidl/nn-objidl-ibindctx">IBindCtx</a>*</b> A pointer to an <a href="https://docs.microsoft.com/windows/desktop/api/objidl/nn-objidl-ibindctx">IBindCtx</a> interface on a bind context object.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-bindtohandler#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="bhid">Type: <b>REFGUID</b></param>
    /// <param name="riid">
    /// <para>Type: <b>REFIID</b> The IID of the object type to retrieve.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-bindtohandler#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="ppvOut">
    /// <para>Type: <b>void**</b> When this methods returns, contains the object specified in <i>riid</i> that is returned by the handler specified by <i>rbhid</i>.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-bindtohandler#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> If this method succeeds, it returns <b>S_OK</b>. Otherwise, it returns an <b>HRESULT</b> error code.</para>
    /// </returns>
    /// <remarks>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-bindtohandler">Learn more about this API from learn.microsoft.com</see>.</para>
    /// </remarks>
    unsafe void BindToHandler( /*winmdroot.System.Com.IBindCtx*/ void* pbc, in Guid bhid, in Guid riid,
        [MarshalAs(UnmanagedType.Interface)] out object ppvOut);

    /// <summary>Gets a property store.</summary>
    /// <param name="flags">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/propsys/ne-propsys-getpropertystoreflags">GETPROPERTYSTOREFLAGS</a></b> One of the <a href="https://docs.microsoft.com/windows/desktop/api/propsys/ne-propsys-getpropertystoreflags">GETPROPERTYSTOREFLAGS</a> constants.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-getpropertystore#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="riid">
    /// <para>Type: <b>REFIID</b> The IID of the object type to retrieve.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-getpropertystore#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="ppv">
    /// <para>Type: <b>void**</b> When this method returns, contains interface pointer requested in riid.  This is typically <a href="https://docs.microsoft.com/windows/desktop/api/propsys/nn-propsys-ipropertystore">IPropertyStore</a> or <a href="https://docs.microsoft.com/windows/desktop/api/propsys/nn-propsys-ipropertystorecapabilities">IPropertyStoreCapabilities</a>.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-getpropertystore#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> If this method succeeds, it returns <b>S_OK</b>. Otherwise, it returns an <b>HRESULT</b> error code.</para>
    /// </returns>
    /// <remarks>
    /// <para>This method is used to obtain a read-only property store that aggregates properties gathered from all the items in the shell item array. If there is more than one item in the shell item array, then the resulting property store will aggregate the values from each item according to a set of rules determined by each property.   Values read from the property store will be coerced to a canonical form prior to aggregation as discussed at <a href="https://docs.microsoft.com/windows/desktop/api/propsys/nf-propsys-ipropertydescription-coercetocanonicalvalue">CoerceToCanonicalValue</a>.  The output from a call to <a href="https://docs.microsoft.com/previous-versions/windows/desktop/legacy/bb761473(v=vs.85)">IPropertyStore::GetValue</a> is computed as follows: </para>
    /// <para>This doc was truncated.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-getpropertystore#">Read more on learn.microsoft.com</see>.</para>
    /// </remarks>
    void GetPropertyStore(NativeEnums.GETPROPERTYSTOREFLAGS flags, in Guid riid,
        [MarshalAs(UnmanagedType.Interface)] out object ppv);

    /// <summary>Gets a property description list for the items in the shell item array.</summary>
    /// <param name="keyType">
    /// <para>Type: <b>REFPROPERTYKEY</b> A reference to the <a href="https://docs.microsoft.com/windows/desktop/api/wtypes/ns-wtypes-propertykey">PROPERTYKEY</a> structure specifying which property list to retrieve.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-getpropertydescriptionlist#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="riid">
    /// <para>Type: <b>REFIID</b> The IID of the object type to retrieve.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-getpropertydescriptionlist#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="ppv">
    /// <para>Type: <b>void**</b> When this method returns, contains the interface requested in riid.  This will typically be <a href="https://docs.microsoft.com/windows/desktop/api/propsys/nn-propsys-ipropertydescriptionlist">IPropertyDescriptionList</a>.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-getpropertydescriptionlist#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> If this method succeeds, it returns <b>S_OK</b>. Otherwise, it returns an <b>HRESULT</b> error code.</para>
    /// </returns>
    /// <remarks>
    /// <para>This function is used to determine a list of properties that are applicable to a set of shell items.  The type of list is specified by a <a href="https://docs.microsoft.com/windows/desktop/api/wtypes/ns-wtypes-propertykey">PROPERTYKEY</a> structure.  Supported list types include but are not limited to:</para>
    /// <para></para>
    /// <para>This doc was truncated.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-getpropertydescriptionlist#">Read more on learn.microsoft.com</see>.</para>
    /// </remarks>
    void GetPropertyDescriptionList(in NativeStructs.PROPERTYKEY keyType, in Guid riid,
        [MarshalAs(UnmanagedType.Interface)] out object ppv);

    /// <summary>Gets the attributes of the set of items contained in an IShellItemArray.</summary>
    /// <param name="AttribFlags">Type: <b>SIATTRIBFLAGS</b></param>
    /// <param name="sfgaoMask">
    /// <para>Type: <b>SFGAOF</b> A mask that specifies what particular attributes are being requested. A bitwise OR of one or more of the <a href="https://docs.microsoft.com/windows/desktop/shell/sfgao">SFGAO</a> values.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-getattributes#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="psfgaoAttribs">
    /// <para>Type: <b>SFGAOF*</b> A bitmap that, when this method returns successfully, contains the values of the requested attributes.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-getattributes#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> Returns S_OK if the attributes returned exactly match those requested in <i>sfgaoMask</i>, S_FALSE if the attributes do not exactly match, or a standard COM error value otherwise.</para>
    /// </returns>
    /// <remarks>
    /// <para>The Shell item array caches individual attributes after they have been determined. As this method passes through the array gathering attribute information, it normally stops looking at a particular attribute after that value is irrevocably set. For instance, if the SIATTRIBFLAGS_AND flag is set, after an attribute is found not to be set on an item (a value of 0), there is no need to continue examining that attribute value on other items because the result of the AND operation will always be 0. Therefore, the final set of attributes is commonly calculated by looking at only the first few items in the array, which is all that is needed to obtain the final value. If you have a need to examine all items in the array, set the SIATTRIBFLAGS_ALLITEMS flag. However, be aware that this can slow the method's return considerably, so do not do so without cause.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-getattributes#">Read more on learn.microsoft.com</see>.</para>
    /// </remarks>
    void GetAttributes(NativeEnums.SIATTRIBFLAGS AttribFlags, NativeEnums.SFGAO_FLAGS sfgaoMask,
        out NativeEnums.SFGAO_FLAGS psfgaoAttribs);

    /// <summary>Gets the number of items in the given IShellItem array.</summary>
    /// <param name="pdwNumItems">
    /// <para>Type: <b>DWORD*</b> When this method returns, contains the number of items in the <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitemarray">IShellItemArray</a>.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-getcount#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> If this method succeeds, it returns <b>S_OK</b>. Otherwise, it returns an <b>HRESULT</b> error code.</para>
    /// </returns>
    /// <remarks>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-getcount">Learn more about this API from learn.microsoft.com</see>.</para>
    /// </remarks>
    void GetCount(out uint pdwNumItems);

    /// <summary>Gets the item at the given index in the IShellItemArray.</summary>
    /// <param name="dwIndex">
    /// <para>Type: <b>DWORD</b> The index of the <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a> requested in the <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitemarray">IShellItemArray</a></para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-getitemat#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="ppsi">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a>**</b> When this method returns, contains the requested <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a> pointer.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-getitemat#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> If this method succeeds, it returns <b>S_OK</b>. Otherwise, it returns an <b>HRESULT</b> error code.</para>
    /// </returns>
    /// <remarks>This function returns E_FAIL if the requested index is out of bounds of the <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitemarray">IShellItemArray</a>.</remarks>
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
    void EnumItems(out IEnumShellItems ppenumShellItems);
}