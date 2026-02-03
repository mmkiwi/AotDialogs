namespace MMKiwi.AotDialogs.WindownCom;

[Guid("1F9FC1D0-C39B-4B26-817F-011967D3440E")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[GeneratedComInterface]
[SupportedOSPlatform("windows6.0.6000")]
internal unsafe partial interface IPropertyDescriptionList
{
    /// <summary>Gets the number of properties included in the property list.</summary>
    /// <param name="pcElem">
    /// <para>Type: <b>UINT*</b> When this method returns, contains a pointer to the count of properties.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescriptionlist-getcount#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> If this method succeeds, it returns <b>S_OK</b>. Otherwise, it returns an <b>HRESULT</b> error code.</para>
    /// </returns>
    /// <remarks>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescriptionlist-getcount">Learn more about this API from learn.microsoft.com</see>.</para>
    /// </remarks>
    void GetCount(out uint pcElem);

    /// <summary>Gets the property description at the specified index in a property description list.</summary>
    /// <param name="iElem">
    /// <para>Type: <b>UINT</b> The number of the property in the list string.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescriptionlist-getat#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="riid">
    /// <para>Type: <b>REFIID</b> A reference to the IID of the requested property description interface, typically IID_IPropertyDescription.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescriptionlist-getat#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="ppv">
    /// <para>Type: <b>void**</b> When this method returns, contains the interface pointer requested in <i>riid</i>. Typically, this is <a href="https://docs.microsoft.com/windows/desktop/api/propsys/nn-propsys-ipropertydescription">IPropertyDescription</a>.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescriptionlist-getat#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> If this method succeeds, it returns <b>S_OK</b>. Otherwise, it returns an <b>HRESULT</b> error code.</para>
    /// </returns>
    /// <remarks>It is recommended that you use the IID_PPV_ARGS macro, defined in objbase.h, to package the <i>riid</i> and <i>ppv</i> parameters. This macro provides the correct IID based on the interface pointed to by the value in <i>ppv</i>, eliminating the possibility of a coding error.</remarks>
    void GetAt(uint iElem, global::System.Guid* riid, [MarshalAs(UnmanagedType.Interface)] out object ppv);
}