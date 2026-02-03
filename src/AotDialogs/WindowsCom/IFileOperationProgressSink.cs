namespace MMKiwi.AotDialogs.WindownCom;

[Guid("04B0F1A7-9490-44BC-96E1-4296A31252E2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
 GeneratedComInterface()]
[SupportedOSPlatform("windows6.0.6000")]
internal partial interface IFileOperationProgressSink
{
    /// <summary>Performs caller-implemented actions before any specific file operations are performed.</summary>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> If this method succeeds, it returns <b>S_OK</b>. Otherwise, it returns an <b>HRESULT</b> error code.</para>
    /// </returns>
    /// <remarks><b>StartOperations</b> is the first of the <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ifileoperationprogresssink">IFileOperationProgressSink</a> methods to be called after <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nf-shobjidl_core-ifileoperation-performoperations">PerformOperations</a>. It can be used to perform any setup or initialization that you require before the file operations begin.</remarks>
    void StartOperations();

    /// <summary>Performs caller-implemented actions after the last operation performed by the call to IFileOperation is complete.</summary>
    /// <param name="hrResult">
    /// <para>Type: <b>HRESULT</b> The return value of the final operation. Note that this is not the HRESULT returned by one of the <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ifileoperation">IFileOperation</a> methods, which simply queue the operations. Instead, this is the result of the actual operation, such as copy, delete, or move.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-finishoperations#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> Not used.</para>
    /// </returns>
    /// <remarks>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-finishoperations">Learn more about this API from learn.microsoft.com</see>.</para>
    /// </remarks>
    void FinishOperations(NativeStructs.HRESULT hrResult);

    /// <summary>Performs caller-implemented actions before the rename process for each item begins.</summary>
    /// <param name="dwFlags">
    /// <para>Type: <b>DWORD</b> bitwise value that contains flags that control the operation. See <a href="https://docs.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-_transfer_source_flags">TRANSFER_SOURCE_FLAGS</a> for flag descriptions.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-prerenameitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="psiItem">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a>*</b> Pointer to an <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a> that specifies the item to be renamed.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-prerenameitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="pszNewName">
    /// <para>Type: <b>LPCWSTR</b> Pointer to the new <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nf-shobjidl_core-ishellitem-getdisplayname">display name</a> of the item. This is a null-terminated, Unicode string.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-prerenameitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> Returns S_OK if successful, or an error value otherwise. In the case of an error value, the rename operation and all subsequent operations pending from the call to <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ifileoperation">IFileOperation</a> are canceled.</para>
    /// </returns>
    /// <remarks>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-prerenameitem">Learn more about this API from learn.microsoft.com</see>.</para>
    /// </remarks>
    void PreRenameItem(uint dwFlags, IShellItem psiItem, [MarshalAs(UnmanagedType.LPWStr)] string pszNewName);

    /// <summary>Performs caller-implemented actions after the rename process for each item is complete.</summary>
    /// <param name="dwFlags">
    /// <para>Type: <b>DWORD</b> bitwise value that contains flags that were used during the rename operation. Some values can be set or changed during the rename operation. See <a href="https://docs.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-_transfer_source_flags">TRANSFER_SOURCE_FLAGS</a> for flag descriptions.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postrenameitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="psiItem">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a>*</b> Pointer to an <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a> that specifies the item before it was renamed.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postrenameitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="pszNewName">
    /// <para>Type: <b>LPCWSTR</b> Pointer to the new <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nf-shobjidl_core-ishellitem-getdisplayname">display name</a> of the item. This is a null-terminated, Unicode string. Note that this might not be the name that you asked for, given collisions and other naming rules.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postrenameitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="hrRename">
    /// <para>Type: <b>HRESULT</b> The return value of the rename operation. Note that this is not the HRESULT returned by <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nf-shobjidl_core-ifileoperation-renameitem">RenameItem</a>, which simply queues the rename operation. Instead, this is the result of the actual rename operation.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postrenameitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="psiNewlyCreated">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a>*</b> Pointer to an <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a> that represents the item with its new name.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postrenameitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> Returns S_OK if successful, or an error value otherwise. In the case of an error value, all subsequent operations pending from the call to <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ifileoperation">IFileOperation</a> are canceled.</para>
    /// </returns>
    /// <remarks>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postrenameitem">Learn more about this API from learn.microsoft.com</see>.</para>
    /// </remarks>
    void PostRenameItem(uint dwFlags, IShellItem psiItem, [MarshalAs(UnmanagedType.LPWStr)] string pszNewName,
        NativeStructs.HRESULT hrRename, IShellItem psiNewlyCreated);

    /// <summary>Performs caller-implemented actions before the move process for each item begins.</summary>
    /// <param name="dwFlags">
    /// <para>Type: <b>DWORD</b> bitwise value that contains flags that control the operation. See <a href="https://docs.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-_transfer_source_flags">TRANSFER_SOURCE_FLAGS</a> for flag descriptions.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-premoveitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="psiItem">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a>*</b> Pointer to an <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a> that specifies the item to be moved.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-premoveitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="psiDestinationFolder">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a>*</b> Pointer to an <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a> that specifies the destination folder to contain the moved item.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-premoveitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="pszNewName">
    /// <para>Type: <b>LPCWSTR</b> Pointer to a new name for the item in its new location. This is a null-terminated Unicode string and can be <b>NULL</b>. If <b>NULL</b>, the name of the destination item is the same as the source.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-premoveitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> Returns S_OK if successful, or an error value otherwise. In the case of an error value, the move operation and all subsequent operations pending from the call to <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ifileoperation">IFileOperation</a> are canceled.</para>
    /// </returns>
    /// <remarks>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-premoveitem">Learn more about this API from learn.microsoft.com</see>.</para>
    /// </remarks>
    void PreMoveItem(uint dwFlags, IShellItem psiItem,
        IShellItem psiDestinationFolder, [MarshalAs(UnmanagedType.LPWStr)] string pszNewName);

    /// <summary>Performs caller-implemented actions after the move process for each item is complete.</summary>
    /// <param name="dwFlags">
    /// <para>Type: <b>DWORD</b> bitwise value that contains flags that were used during the move operation. Some values can be set or changed during the move operation. See <a href="https://docs.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-_transfer_source_flags">TRANSFER_SOURCE_FLAGS</a> for flag descriptions.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postmoveitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="psiItem">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a>*</b> Pointer to an <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a> that specifies the source item.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postmoveitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="psiDestinationFolder">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a>*</b> Pointer to an <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a> that specifies the destination folder that contains the moved item.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postmoveitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="pszNewName">
    /// <para>Type: <b>LPCWSTR</b> Pointer to the name that was given to the item after it was moved. This is a null-terminated Unicode string. Note that this might not be the name that you asked for, given collisions and other naming rules.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postmoveitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="hrMove">
    /// <para>Type: <b>HRESULT</b> The return value of the move operation. Note that this is not the HRESULT returned by <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nf-shobjidl_core-ifileoperation-moveitem">MoveItem</a>, which simply queues the move operation. Instead, this is the result of the actual move.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postmoveitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="psiNewlyCreated">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a>*</b> Pointer to an <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a> that represents the moved item in its new location.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postmoveitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> Returns S_OK if successful, or an error value otherwise. In the case of an error value, all subsequent operations pending from the call to <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ifileoperation">IFileOperation</a> are canceled.</para>
    /// </returns>
    /// <remarks>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postmoveitem">Learn more about this API from learn.microsoft.com</see>.</para>
    /// </remarks>
    void PostMoveItem(uint dwFlags, IShellItem psiItem,
        IShellItem psiDestinationFolder, [MarshalAs(UnmanagedType.LPWStr)] string pszNewName,
        NativeStructs.HRESULT hrMove, IShellItem psiNewlyCreated);

    /// <summary>Performs caller-implemented actions before the copy process for each item begins.</summary>
    /// <param name="dwFlags">
    /// <para>Type: <b>DWORD</b> bitwise value that contains flags that control the operation. See <a href="https://docs.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-_transfer_source_flags">TRANSFER_SOURCE_FLAGS</a> for flag descriptions.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-precopyitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="psiItem">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a>*</b> Pointer to an <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a> that specifies the source item.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-precopyitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="psiDestinationFolder">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a>*</b> Pointer to an <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a> that specifies the destination folder to contain the copy of the item.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-precopyitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="pszNewName">
    /// <para>Type: <b>LPCWSTR</b> Pointer to a new name for the item after it has been copied. This is a null-terminated Unicode string and can be <b>NULL</b>. If <b>NULL</b>, the name of the destination item is the same as the source.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-precopyitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> Returns S_OK if successful, or an error value otherwise. In the case of an error value, the copy operation and all subsequent operations pending from the call to <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ifileoperation">IFileOperation</a> are canceled.</para>
    /// </returns>
    /// <remarks>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-precopyitem">Learn more about this API from learn.microsoft.com</see>.</para>
    /// </remarks>
    void PreCopyItem(uint dwFlags, IShellItem psiItem, IShellItem psiDestinationFolder,
        [MarshalAs(UnmanagedType.LPWStr)] string pszNewName);

    /// <summary>Performs caller-implemented actions after the copy process for each item is complete.</summary>
    /// <param name="dwFlags">
    /// <para>Type: <b>DWORD</b> bitwise value that contains flags that were used during the copy operation. Some values can be set or changed during the copy operation. See <a href="https://docs.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-_transfer_source_flags">TRANSFER_SOURCE_FLAGS</a> for flag descriptions.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postcopyitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="psiItem">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a>*</b> Pointer to an <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a> that specifies the source item.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postcopyitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="psiDestinationFolder">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a>*</b> Pointer to an <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a> that specifies the destination folder to which the item was copied.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postcopyitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="pszNewName">
    /// <para>Type: <b>LPCWSTR</b> Pointer to the new name that was given to the item after it was copied. This is a null-terminated Unicode string. Note that this might not be the name that you asked for, given collisions and other naming rules.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postcopyitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="hrCopy">
    /// <para>Type: <b>HRESULT</b> The return value of the copy operation. Note that this is not the HRESULT returned by <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nf-shobjidl_core-ifileoperation-copyitem">CopyItem</a>, which simply queues the copy operation. Instead, this is the result of the actual copy.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postcopyitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="psiNewlyCreated">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a>*</b> Pointer to an <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a> that represents the new copy of the item.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postcopyitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> Returns S_OK if successful, or an error value otherwise. In the case of an error value, all subsequent operations pending from the call to <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ifileoperation">IFileOperation</a> are canceled.</para>
    /// </returns>
    /// <remarks>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postcopyitem">Learn more about this API from learn.microsoft.com</see>.</para>
    /// </remarks>
    void PostCopyItem(uint dwFlags, IShellItem psiItem,
        IShellItem psiDestinationFolder, [MarshalAs(UnmanagedType.LPWStr)] string pszNewName,
        NativeStructs.HRESULT hrCopy, IShellItem psiNewlyCreated);

    /// <summary>Performs caller-implemented actions before the delete process for each item begins.</summary>
    /// <param name="dwFlags">
    /// <para>Type: <b>DWORD</b> bitwise value that contains flags that control the operation. See <a href="https://docs.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-_transfer_source_flags">TRANSFER_SOURCE_FLAGS</a> for flag descriptions.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-predeleteitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="psiItem">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a>*</b> Pointer to an <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a> that specifies the item to be deleted.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-predeleteitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> Returns S_OK if successful, or an error value otherwise. In the case of an error value, the delete operation and all subsequent operations pending from the call to <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ifileoperation">IFileOperation</a> are canceled.</para>
    /// </returns>
    /// <remarks>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-predeleteitem">Learn more about this API from learn.microsoft.com</see>.</para>
    /// </remarks>
    void PreDeleteItem(uint dwFlags, IShellItem psiItem);

    /// <summary>Performs caller-implemented actions after the delete process for each item is complete.</summary>
    /// <param name="dwFlags">
    /// <para>Type: <b>DWORD</b> bitwise value that contains flags that were used during the delete operation. Some values can be set or changed during the delete operation. See <a href="https://docs.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-_transfer_source_flags">TRANSFER_SOURCE_FLAGS</a> for flag descriptions.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postdeleteitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="psiItem">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a>*</b> Pointer to an <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a> that specifies the item that was deleted.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postdeleteitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="hrDelete">
    /// <para>Type: <b>HRESULT</b> The return value of the delete operation. Note that this is not the HRESULT returned by <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nf-shobjidl_core-ifileoperation-deleteitem">DeleteItem</a>, which simply queues the delete operation. Instead, this is the result of the actual deletion.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postdeleteitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="psiNewlyCreated">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a>*</b> A pointer to an <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a> that specifies the deleted item, now in the Recycle Bin. If the item was fully deleted, this value is <b>NULL</b>.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postdeleteitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> Returns S_OK if successful, or an error value otherwise. In the case of an error value, all subsequent operations pending from the call to <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ifileoperation">IFileOperation</a> are canceled.</para>
    /// </returns>
    /// <remarks>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postdeleteitem">Learn more about this API from learn.microsoft.com</see>.</para>
    /// </remarks>
    void PostDeleteItem(uint dwFlags, IShellItem psiItem, NativeStructs.HRESULT hrDelete, IShellItem psiNewlyCreated);

    /// <summary>Performs caller-implemented actions before the process to create a new item begins.</summary>
    /// <param name="dwFlags">
    /// <para>Type: <b>DWORD</b> bitwise value that contains flags that control the operation. See <a href="https://docs.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-_transfer_source_flags">TRANSFER_SOURCE_FLAGS</a> for flag descriptions.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-prenewitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="psiDestinationFolder">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a>*</b> Pointer to an <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a> that specifies the destination folder that will contain the new item.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-prenewitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="pszNewName">
    /// <para>Type: <b>LPCWSTR</b> Pointer to the file name of the new item, for instance <b>Newfile.txt</b>. This is a null-terminated, Unicode string.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-prenewitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> Returns S_OK if successful, or an error value otherwise. In the case of an error value, this operation and all subsequent operations pending from the call to <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ifileoperation">IFileOperation</a> are canceled.</para>
    /// </returns>
    /// <remarks>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-prenewitem">Learn more about this API from learn.microsoft.com</see>.</para>
    /// </remarks>
    void PreNewItem(uint dwFlags, IShellItem psiDestinationFolder, [MarshalAs(UnmanagedType.LPWStr)] string pszNewName);

    /// <summary>Performs caller-implemented actions after the new item is created.</summary>
    /// <param name="dwFlags">
    /// <para>Type: <b>DWORD</b> bitwise value that contains flags that were used during the creation operation. Some values can be set or changed during the creation operation. See <a href="https://docs.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-_transfer_source_flags">TRANSFER_SOURCE_FLAGS</a> for flag descriptions.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postnewitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="psiDestinationFolder">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a>*</b> Pointer to an <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a> that specifies the destination folder to which the new item was added.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postnewitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="pszNewName">
    /// <para>Type: <b>LPCWSTR</b> Pointer to the file name of the new item, for instance <b>Newfile.txt</b>. This is a null-terminated, Unicode string.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postnewitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="pszTemplateName">
    /// <para>Type: <b>LPCWSTR</b> Pointer to the name of the template file (for example <b>Excel9.xls</b>) that the new item is based on, stored in one of the following locations:</para>
    /// <para></para>
    /// <para>This doc was truncated.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postnewitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="dwFileAttributes">
    /// <para>Type: <b>DWORD</b> The file attributes applied to the new item. One or more of the values found at <a href="https://docs.microsoft.com/windows/desktop/api/fileapi/nf-fileapi-getfileattributesa">GetFileAttributes</a>.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postnewitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="hrNew">
    /// <para>Type: <b>HRESULT</b> The return value of the creation operation. Note that this is not the HRESULT returned by <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nf-shobjidl_core-ifileoperation-newitem">NewItem</a>, which simply queues the creation operation. Instead, this is the result of the actual creation.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postnewitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="psiNewItem">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a>*</b> Pointer to an <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ishellitem">IShellItem</a> that represents the new item.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postnewitem#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> Returns S_OK if successful, or an error value otherwise. In the case of an error value, all subsequent operations pending from the call to <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nn-shobjidl_core-ifileoperation">IFileOperation</a> are canceled.</para>
    /// </returns>
    /// <remarks>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postnewitem">Learn more about this API from learn.microsoft.com</see>.</para>
    /// </remarks>
    void PostNewItem(uint dwFlags, IShellItem psiDestinationFolder, [MarshalAs(UnmanagedType.LPWStr)] string pszNewName,
        [MarshalAs(UnmanagedType.LPWStr)] string pszTemplateName, uint dwFileAttributes, NativeStructs.HRESULT hrNew,
        IShellItem psiNewItem);

    /// <summary>Provides an estimate of the total amount of work currently done in relation to the total amount of work.</summary>
    /// <param name="iWorkTotal">
    /// <para>Type: <b>UINT</b> An estimate of the amount of work to be completed.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-updateprogress#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <param name="iWorkSoFar">
    /// <para>Type: <b>UINT</b> The portion of <i>iWorkTotal</i> that has been completed so far.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-updateprogress#parameters">Read more on learn.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> If this method succeeds, it returns <b>S_OK</b>. Otherwise, it returns an <b>HRESULT</b> error code.</para>
    /// </returns>
    /// <remarks>The <i>iWorkTotal</i> and <i>iWorkSoFar</i> values are "points" or estimates of the amount of work to be done, and how much is completed. They are not specified in any particular units, but should be roughly proportional to how much time the total process takes. For example, to copy one small file might be considered two points, and a large file might be considered ten points. If a process is performing an operation that copies five small files and one large file, and the process has completed four of the small files, <i>iWorkSoFar</i> would be eight points (4 x 2 = 8) and <i>iWorkTotal</i> would be twenty points (5 x 2 + 10 = 20), so the estimate would be 8 of 20 points (or 40%) complete.</remarks>
    void UpdateProgress(uint iWorkTotal, uint iWorkSoFar);

    /// <summary>Not supported. (IFileOperationProgressSink.ResetTimer)</summary>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> If this method succeeds, it returns <b>S_OK</b>. Otherwise, it returns an <b>HRESULT</b> error code.</para>
    /// </returns>
    /// <remarks>This method should return S_OK rather than E_NOTIMPL.</remarks>
    void ResetTimer();

    /// <summary>Not supported. (IFileOperationProgressSink.PauseTimer)</summary>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> If this method succeeds, it returns <b>S_OK</b>. Otherwise, it returns an <b>HRESULT</b> error code.</para>
    /// </returns>
    /// <remarks>This method should return S_OK rather than E_NOTIMPL.</remarks>
    void PauseTimer();

    /// <summary>Not supported. (IFileOperationProgressSink.ResumeTimer)</summary>
    /// <returns>
    /// <para>Type: <b>HRESULT</b> If this method succeeds, it returns <b>S_OK</b>. Otherwise, it returns an <b>HRESULT</b> error code.</para>
    /// </returns>
    /// <remarks>This method should return S_OK rather than E_NOTIMPL.</remarks>
    void ResumeTimer();
}