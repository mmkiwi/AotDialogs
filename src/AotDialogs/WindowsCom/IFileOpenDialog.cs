namespace MMKiwi.AotDialogs.WindowsCom;

[Guid("D57C7288-D4AD-4768-BE02-9D969532D960")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[GeneratedComInterface]
[SupportedOSPlatform("windows6.0.6000")]
internal partial interface IFileOpenDialog : IFileDialog
{
    /// <summary>Gets the user's choices in a dialog that allows multiple selection.</summary>
    /// <param name="ppenum">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitemarray">IShellItemArray</a>**</b> The address of a pointer to an <b>IShellItemArray</b> through which the items selected in the dialog can be accessed.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileopendialog-getresults#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> If this method succeeds, it returns <b>S_OK</b>. Otherwise, it returns an <b>HRESULT</b> error code.</para>
    /// </returns>
    /// <remarks>
    /// <para>This method can be used whether the selection consists of a single item or multiple items. <b>IFileOpenDialog::GetResults</b> can be called after the dialog has closed or during the handling of an IFileDialogEvents::OnFileOk event. Calling this method at any other time will fail.</para>
    /// <para><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nf-shobjidl_core-imodalwindow-show">Show</a> must return a success code for a result to be available to <b>IFileOpenDialog::GetResults</b>.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileopendialog-getresults#">Read more on learn.microsoft.com</see>.</para>
    /// </remarks>
    void GetResults(out IShellItemArray ppenum);

    /// <summary>Gets the currently selected items in the dialog. These items may be items selected in the view, or text selected in the file name edit box.</summary>
    /// <param name="ppsai">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitemarray">IShellItemArray</a>**</b> The address of a pointer to an <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitemarray">IShellItemArray</a> through which the selected items can be accessed.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileopendialog-getselecteditems#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> If this method succeeds, it returns <b>S_OK</b>. Otherwise, it returns an <b>HRESULT</b> error code.</para>
    /// </returns>
    /// <remarks>This method can be used for single item or multiple item selections. If the user has entered new text in the file name field, this can be a time-consuming operation. When the application calls this method, the application parses the text in the <c>filename</c> field. For example, if this is a network share, the operation could take some time. However, this operation will not block the UI, since the user should able to stop the operation, which will result in <b>IFileOpenDialog::GetSelectedItems</b> returning a failure code).</remarks>
    void GetSelectedItems(out IShellItemArray ppsai);
}