namespace MMKiwi.AotDialogs.WindownCom;

[Guid("70629033-E363-4A28-A567-0DB78006E6D7")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[GeneratedComInterface]
[SupportedOSPlatform("windows6.0.6000")]
internal partial interface IEnumShellItems
{
    /// <summary>Gets an array of one or more IShellItem interfaces from the enumeration.</summary>
    /// <param name="celt">
    /// <para>Type: <b>ULONG</b> The number of elements in the array referenced by the <i>rgelt</i> parameter.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ienumshellitems-next#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="rgelt">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a>**</b> The address of an array of pointers to <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a> interfaces that receive the enumerated item or items. The calling application is responsible for freeing the <b>IShellItem</b> interfaces by calling the <a href="https://docs.microsoft.com/windows/desktop/api/unknwn/nf-unknwn-iunknown-release">IUnknown::Release</a> method.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ienumshellitems-next#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="pceltFetched">
    /// <para>Type: <b>ULONG*</b> A pointer to a value that receives the number of <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a> interfaces successfully retrieved. The count can be smaller than the value specified in the <i>celt</i> parameter. This parameter can be <b>NULL</b> on entry only if <i>celt</i> is one, because in that case the method can only retrieve one item and return <b>S_OK</b>, or zero items and return <b>S_FALSE</b>.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ienumshellitems-next#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> This method can return one of these values. </para>
    /// <para>This doc was truncated.</para>
    /// </returns>
    /// <remarks>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ienumshellitems-next">Learn more about this API from learn.microsoft.com</see>.</para>
    /// </remarks>
    unsafe void Next(uint celt, [Out] [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IShellItem[] rgelt,
        [Optional] uint* pceltFetched);

    /// <summary>Skips a given number of IShellItem interfaces in the enumeration. Used when retrieving interfaces.</summary>
    /// <param name="celt">
    /// <para>Type: <b>ULONG</b> The number of <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a> interfaces to skip.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ienumshellitems-skip#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> If this method succeeds, it returns <b>S_OK</b>. Otherwise, it returns an <b>HRESULT</b> error code.</para>
    /// </returns>
    /// <remarks>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ienumshellitems-skip">Learn more about this API from learn.microsoft.com</see>.</para>
    /// </remarks>
    void Skip(uint celt);

    /// <summary>Resets the internal count of retrieved IShellItem interfaces in the enumeration.</summary>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> If this method succeeds, it returns <b>S_OK</b>. Otherwise, it returns an <b>HRESULT</b> error code.</para>
    /// </returns>
    /// <remarks>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ienumshellitems-reset">Learn more about this API from learn.microsoft.com</see>.</para>
    /// </remarks>
    void Reset();

    /// <summary>Gets a copy of the current enumeration.</summary>
    /// <param name="ppenum">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ienumshellitems">IEnumShellItems</a>**</b> The address of a pointer that receives a copy of this enumeration.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ienumshellitems-clone#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> If this method succeeds, it returns <b>S_OK</b>. Otherwise, it returns an <b>HRESULT</b> error code.</para>
    /// </returns>
    /// <remarks>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ienumshellitems-clone">Learn more about this API from learn.microsoft.com</see>.</para>
    /// </remarks>
    void Clone(out IEnumShellItems ppenum);
}