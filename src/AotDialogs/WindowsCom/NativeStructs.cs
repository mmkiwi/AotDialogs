using System.Diagnostics;

namespace MMKiwi.AotDialogs.WindownCom;

[SupportedOSPlatform("windows6.0.6000")]
public static class NativeStructs
{
    internal struct PROPERTYKEY
    {
        /// <summary>
        /// <para>Type: <b>GUID</b> A unique GUID for the property.</para>
        /// <para><see href="https://learn.microsoft.com/windows/win32/api/wtypes/ns-wtypes-propertykey#members">Read more on learn.microsoft.com</see>.</para>
        /// </summary>
        internal global::System.Guid fmtid;

        /// <summary>
        /// <para>Type: <b>DWORD</b> A property identifier (PID). This parameter is not used as in <a href="https://docs.microsoft.com/windows/desktop/shell/objects">SHCOLUMNID</a>. It is recommended that you set this value to PID_FIRST_USABLE. Any value greater than or equal to 2 is acceptable. <div class="alert"><b>Note</b>  Values of 0 and 1 are reserved and should not be used.</div> <div> </div></para>
        /// <para><see href="https://learn.microsoft.com/windows/win32/api/wtypes/ns-wtypes-propertykey#members">Read more on learn.microsoft.com</see>.</para>
        /// </summary>
        internal uint pid;
    }

    /// <summary>Used generically to filter elements.</summary>
    /// <remarks>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shtypes/ns-shtypes-comdlg_filterspec">Learn more about this API from learn.microsoft.com</see>.</para>
    /// </remarks>
    [NativeMarshalling(typeof(COMDLG_FILTERSPECMarshaller))]
    internal struct COMDLG_FILTERSPEC
    {
        /// <summary>
        /// <para>Type: <b>LPCWSTR</b> A pointer to a buffer that contains the friendly name of the filter.</para>
        /// <para><see href="https://learn.microsoft.com/windows/win32/api/shtypes/ns-shtypes-comdlg_filterspec#members">Read more on learn.microsoft.com</see>.</para>
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)] internal string? pszName;

        /// <summary>
        /// <para>Type: <b>LPCWSTR</b> A pointer to a buffer that contains the filter pattern.</para>
        /// <para><see href="https://learn.microsoft.com/windows/win32/api/shtypes/ns-shtypes-comdlg_filterspec#members">Read more on learn.microsoft.com</see>.</para>
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)] internal string? pszSpec;

        [CustomMarshaller(typeof(COMDLG_FILTERSPEC), MarshalMode.Default, typeof(COMDLG_FILTERSPECMarshaller))]
        internal static class COMDLG_FILTERSPECMarshaller
        {
            public static unsafe COMDLG_FILTERSPECNative ConvertToUnmanaged(COMDLG_FILTERSPEC managed)
            {
                ushort* pszName = Utf16StringMarshaller.ConvertToUnmanaged(managed.pszName);
                ushort* pszSpec = Utf16StringMarshaller.ConvertToUnmanaged(managed.pszSpec);
                return new COMDLG_FILTERSPECNative { pszName = pszName, pszSpec = pszSpec, };
            }

            public static unsafe COMDLG_FILTERSPEC ConvertToManaged(COMDLG_FILTERSPECNative unmanaged)
            {
                string? pszName = Utf16StringMarshaller.ConvertToManaged(unmanaged.pszName);
                string? pszSpec = Utf16StringMarshaller.ConvertToManaged(unmanaged.pszSpec);
                return new COMDLG_FILTERSPEC { pszName = pszName, pszSpec = pszSpec, };
            }

            public static unsafe void Free(COMDLG_FILTERSPECNative unmanaged)
            {
                Utf16StringMarshaller.Free(unmanaged.pszName);
                Utf16StringMarshaller.Free(unmanaged.pszSpec);
            }
        }

        internal unsafe struct COMDLG_FILTERSPECNative
        {
            /// <summary>
            /// <para>Type: <b>LPCWSTR</b> A pointer to a buffer that contains the friendly name of the filter.</para>
            /// <para><see href="https://learn.microsoft.com/windows/win32/api/shtypes/ns-shtypes-comdlg_filterspec#members">Read more on learn.microsoft.com</see>.</para>
            /// </summary>
            internal ushort* pszName;

            /// <summary>
            /// <para>Type: <b>LPCWSTR</b> A pointer to a buffer that contains the filter pattern.</para>
            /// <para><see href="https://learn.microsoft.com/windows/win32/api/shtypes/ns-shtypes-comdlg_filterspec#members">Read more on learn.microsoft.com</see>.</para>
            /// </summary>
            internal ushort* pszSpec;
        }
    }


    /// <remarks>
    /// <para>The **HRESULT** data type is the same as the [SCODE](scode.md) data type. An **HRESULT** value consists of the following fields: - A 1-bit code indicating severity, where zero represents success and 1 represents failure. - A 4-bit reserved value. - An 11-bit code indicating responsibility for the error or warning, also known as a facility code. - A 16-bit code describing the error or warning. Most MAPI interface methods and functions return **HRESULT** values to provide detailed cause formation. **HRESULT** values are also used widely in OLE interface methods. OLE provides several macros for converting between **HRESULT** values and **SCODE** values, another common data type for error handling. > [!NOTE] > In 64-bit MAPI, **HRESULT** is still a 32-bit value. For information about the OLE use of **HRESULT** values, see the  *OLE Programmer's Reference*. For more information about the use of these values in MAPI, see [Error Handling](error-handling-in-mapi.md) and any of the following interface methods: [IABLogon::GetLastError](iablogon-getlasterror.md) [IMAPISupport::GetLastError](imapisupport-getlasterror.md) [IMAPIControl::GetLastError](imapicontrol-getlasterror.md) [IMAPITable::GetLastError](imapitable-getlasterror.md) [IMAPIProp::GetLastError](imapiprop-getlasterror.md) [IMAPIViewAdviseSink::OnPrint](imapiviewadvisesink-onprint.md)</para>
    /// <para><see href="https://learn.microsoft.com/office/client-developer/outlook/mapi/hresult#">Read more on learn.microsoft.com</see>.</para>
    /// </remarks>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    [NativeMarshalling(typeof(HRESULTMarshaller))]
    internal readonly struct HRESULT : IEquatable<HRESULT>
    {
        [CustomMarshaller(typeof(HRESULT), MarshalMode.Default, typeof(HRESULTMarshaller))]
        internal static class HRESULTMarshaller
        {
            public static int ConvertToUnmanaged(HRESULT managed)
            {
                return managed.Value;
            }

            public static HRESULT ConvertToManaged(int unmanaged)
            {
                return new HRESULT(unmanaged);
            }
        }

        internal readonly int Value;

        internal HRESULT(int value) => this.Value = value;

        public static implicit operator int(HRESULT value) => value.Value;

        public static explicit operator HRESULT(int value) => new HRESULT(value);

        public static bool operator ==(HRESULT left, HRESULT right) => left.Value == right.Value;

        public static bool operator !=(HRESULT left, HRESULT right) => !(left == right);

        public bool Equals(HRESULT other) => this.Value == other.Value;

        public override bool Equals(object? obj) => obj is HRESULT other && this.Equals(other);

        public override int GetHashCode() => this.Value.GetHashCode();


        public override string ToString() =>
            string.Format(System.Globalization.CultureInfo.InvariantCulture, "0x{0:X8}", this.Value);

        public static implicit operator uint(HRESULT value) => (uint)value.Value;

        public static explicit operator HRESULT(uint value) => new HRESULT(unchecked((int)value));


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal bool Succeeded => this.Value >= 0;


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal bool Failed => this.Value < 0;


        /// <inheritdoc cref="Marshal.ThrowExceptionForHR(int,System.IntPtr)" />
        /// <param name="errorInfo">
        /// A pointer to the IErrorInfo interface that provides more information about the
        /// error. You can specify <see cref="IntPtr.Zero"/> to use the current IErrorInfo interface, or
        /// <c>new IntPtr(-1)</c> to ignore the current IErrorInfo interface and construct the exception
        /// just from the error code.
        /// </param>
        /// <returns><see langword="this"/> <see cref="HRESULT"/>, if it does not reflect an error.</returns>
        /// <seealso cref="Marshal.ThrowExceptionForHR(int, IntPtr)"/>
        internal HRESULT ThrowOnFailure(IntPtr errorInfo = default)

        {
            Marshal.ThrowExceptionForHR(this.Value, errorInfo);
            return this;
        }


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DebuggerDisplay
        {
            get
            {
                return string.Format("{0} {1}", ToString(),
                    new System.ComponentModel.Win32Exception((int)this.Value).Message);
            }
        }


        internal string ToString(string format, IFormatProvider formatProvider) =>
            ((uint)this.Value).ToString(format, formatProvider);
    }
}