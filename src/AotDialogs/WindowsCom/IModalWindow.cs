namespace MMKiwi.AotDialogs.WindownCom;

[Guid("B4DB1657-70D7-485E-8E3E-6FCB5A5C1802")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[GeneratedComInterface]
[SupportedOSPlatform("windows5.1.2600")]
internal partial interface IModalWindow
{
    /// <summary>Launches the modal window.</summary>
    /// <param name="hwndOwner">
    /// <para>Type: <b>HWND</b> The handle of the owner window. This value can be <b>NULL</b>.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-imodalwindow-show#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code, including the following: </para>
    /// <para>This doc was truncated.</para>
    /// </returns>
    /// <remarks>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-imodalwindow-show">Learn more about this API from learn.microsoft.com</see>.</para>
    /// </remarks>
    [PreserveSig]
    NativeStructs.HRESULT Show([Optional] nint hwndOwner);
}