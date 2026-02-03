namespace MMKiwi.AotDialogs.WindowsCom;

[SupportedOSPlatform("windows6.0.6000")]
static class NativeEnums
{
    [Flags]
    internal enum SIATTRIBFLAGS
    {
        SIATTRIBFLAGS_AND = 0x00000001,
        SIATTRIBFLAGS_OR = 0x00000002,
        SIATTRIBFLAGS_APPCOMPAT = 0x00000003,
        SIATTRIBFLAGS_MASK = 0x00000003,
        SIATTRIBFLAGS_ALLITEMS = 0x00004000,
    }

    [Flags]
    internal enum SFGAO_FLAGS : uint
    {
        SFGAO_CANCOPY = 0x00000001,
        SFGAO_CANMOVE = 0x00000002,
        SFGAO_CANLINK = 0x00000004,
        SFGAO_STORAGE = 0x00000008,
        SFGAO_CANRENAME = 0x00000010,
        SFGAO_CANDELETE = 0x00000020,
        SFGAO_HASPROPSHEET = 0x00000040,
        SFGAO_DROPTARGET = 0x00000100,
        SFGAO_CAPABILITYMASK = 0x00000177,
        SFGAO_PLACEHOLDER = 0x00000800,
        SFGAO_SYSTEM = 0x00001000,
        SFGAO_ENCRYPTED = 0x00002000,
        SFGAO_ISSLOW = 0x00004000,
        SFGAO_GHOSTED = 0x00008000,
        SFGAO_LINK = 0x00010000,
        SFGAO_SHARE = 0x00020000,
        SFGAO_READONLY = 0x00040000,
        SFGAO_HIDDEN = 0x00080000,
        SFGAO_DISPLAYATTRMASK = 0x000FC000,
        SFGAO_FILESYSANCESTOR = 0x10000000,
        SFGAO_FOLDER = 0x20000000,
        SFGAO_FILESYSTEM = 0x40000000,
        SFGAO_HASSUBFOLDER = 0x80000000,
        SFGAO_CONTENTSMASK = 0x80000000,
        SFGAO_VALIDATE = 0x01000000,
        SFGAO_REMOVABLE = 0x02000000,
        SFGAO_COMPRESSED = 0x04000000,
        SFGAO_BROWSABLE = 0x08000000,
        SFGAO_NONENUMERATED = 0x00100000,
        SFGAO_NEWCONTENT = 0x00200000,
        SFGAO_CANMONIKER = 0x00400000,
        SFGAO_HASSTORAGE = 0x00400000,
        SFGAO_STREAM = 0x00400000,
        SFGAO_STORAGEANCESTOR = 0x00800000,
        SFGAO_STORAGECAPMASK = 0x70C50008,
        SFGAO_PKEYSFGAOMASK = 0x81044000,
    }

    [Flags]
    internal enum GETPROPERTYSTOREFLAGS
    {
        /// <summary>
        /// <para>Meaning to a calling process: Return a read-only property store that contains all properties. Slow items (offline files) are not opened.</para>
        /// <para>Combination with other flags: Can be overridden by other flags.</para>
        /// <para><see href="https://learn.microsoft.com/windows/win32/api/propsys/ne-propsys-getpropertystoreflags#members">Read more on learn.microsoft.com</see>.</para>
        /// </summary>
        GPS_DEFAULT = 0x00000000,

        /// <summary>
        /// <para>Meaning to a calling process: Include only properties directly from the property handler, which opens the file on the disk, network, or device.</para>
        /// <para>Meaning to a file folder: Only include properties directly from the handler. Meaning to other folders: When delegating to a file folder, pass this flag on to the file folder; do not do any multiplexing (MUX). When not delegating to a file folder, ignore this flag instead of returning a failure code. Combination with other flags: Cannot be combined with GPS_TEMPORARY, GPS_FASTPROPERTIESONLY, or GPS_BESTEFFORT.</para>
        /// <para><see href="https://learn.microsoft.com/windows/win32/api/propsys/ne-propsys-getpropertystoreflags#members">Read more on learn.microsoft.com</see>.</para>
        /// </summary>
        GPS_HANDLERPROPERTIESONLY = 0x00000001,

        /// <summary>
        /// <para>Meaning to a calling process: Can write properties to the item. Note: The store may contain fewer properties than a read-only store.</para>
        /// <para>Meaning to a file folder: ReadWrite. Meaning to other folders: ReadWrite. Note: When using default MUX, return a single unmultiplexed store because the default MUX does not support ReadWrite. Combination with other flags: Cannot be combined with GPS_TEMPORARY, GPS_FASTPROPERTIESONLY, GPS_BESTEFFORT, or GPS_DELAYCREATION. Implies GPS_HANDLERPROPERTIESONLY.</para>
        /// <para><see href="https://learn.microsoft.com/windows/win32/api/propsys/ne-propsys-getpropertystoreflags#members">Read more on learn.microsoft.com</see>.</para>
        /// </summary>
        GPS_READWRITE = 0x00000002,

        /// <summary>
        /// <para>Meaning to a calling process: Provides a writable store, with no initial properties, that exists for the lifetime of the Shell item instance; basically, a property bag attached to the item instance.</para>
        /// <para>Meaning to a file folder: Not applicable. Handled by the Shell item. Meaning to other folders: Not applicable. Handled by the Shell item. Combination with other flags: Cannot be combined with any other flag. Implies GPS_READWRITE.</para>
        /// <para><see href="https://learn.microsoft.com/windows/win32/api/propsys/ne-propsys-getpropertystoreflags#members">Read more on learn.microsoft.com</see>.</para>
        /// </summary>
        GPS_TEMPORARY = 0x00000004,

        /// <summary>
        /// <para>Meaning to a calling process: Provides a store that does not involve reading from the disk or network. Note: Some values may be different, or missing, compared to a store without this flag.</para>
        /// <para>Meaning to a file folder: Include the "innate" and "fallback" stores only. Do not load the handler. Meaning to other folders: Include only properties that are available in memory or can be computed very quickly (no properties from disk, network, or peripheral IO devices). This is normally only data sources from the IDLIST. When delegating to other folders, pass this flag on to them. Combination with other flags: Cannot be combined with GPS_TEMPORARY, GPS_READWRITE, GPS_HANDLERPROPERTIESONLY, or GPS_DELAYCREATION.</para>
        /// <para><see href="https://learn.microsoft.com/windows/win32/api/propsys/ne-propsys-getpropertystoreflags#members">Read more on learn.microsoft.com</see>.</para>
        /// </summary>
        GPS_FASTPROPERTIESONLY = 0x00000008,

        /// <summary>
        /// <para>Meaning to a calling process: Open a slow item (offline file) if necessary.</para>
        /// <para>Meaning to a file folder: Retrieve a file from offline storage, if necessary. Note: Without this flag, the handler is not created for offline files. Meaning to other folders: Do not return any properties that are very slow. Combination with other flags: Cannot be combined with GPS_TEMPORARY or GPS_FASTPROPERTIESONLY.</para>
        /// <para><see href="https://learn.microsoft.com/windows/win32/api/propsys/ne-propsys-getpropertystoreflags#members">Read more on learn.microsoft.com</see>.</para>
        /// </summary>
        GPS_OPENSLOWITEM = 0x00000010,

        /// <summary>
        /// <para>Meaning to a calling process: Delay memory-intensive operations, such as file access, until a property is requested that requires such access.</para>
        /// <para>Meaning to a file folder: Do not create the handler until needed; for example, either <a href="https://docs.microsoft.com/windows/desktop/api/gdipluspath/nf-gdipluspath-graphicspathiterator-getcount">GetCount</a>/<a href="https://docs.microsoft.com/windows/desktop/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcolorprofileresourcecollection-getat">GetAt</a> or <a href="https://docs.microsoft.com/windows/desktop/api/gdipluscolor/nf-gdipluscolor-color-getvalue">GetValue</a>, where the innate store does not satisfy the request. Note: <b>GetValue</b> might fail due to file access problems. Meaning to other folders: If the folder has memory-intensive properties, such as delegating to a file folder or network access, it can optimize performance by supporting <a href="https://docs.microsoft.com/windows/desktop/api/propsys/nn-propsys-idelayedpropertystorefactory">IDelayedPropertyStoreFactory</a> and splitting up its properties into a fast and a slow store. It can then use delayed MUX to recombine them. Combination with other flags: Cannot be combined with GPS_TEMPORARY or GPS_READWRITE.</para>
        /// <para><see href="https://learn.microsoft.com/windows/win32/api/propsys/ne-propsys-getpropertystoreflags#members">Read more on learn.microsoft.com</see>.</para>
        /// </summary>
        GPS_DELAYCREATION = 0x00000020,

        /// <summary>
        /// <para>Meaning to a calling process: Succeed at getting the store, even if some properties are not returned. Note: Some values may be different, or missing, compared to a store without this flag.</para>
        /// <para>Meaning to a file folder: Succeed and return a store, even if the handler or innate store has an error during creation. Only fail if substores fail. Meaning to other folders: Succeed on getting the store, even if some properties are not returned. Combination with other flags: Cannot be combined with GPS_TEMPORARY, GPS_READWRITE, or GPS_HANDLERPROPERTIESONLY.</para>
        /// <para><see href="https://learn.microsoft.com/windows/win32/api/propsys/ne-propsys-getpropertystoreflags#members">Read more on learn.microsoft.com</see>.</para>
        /// </summary>
        GPS_BESTEFFORT = 0x00000040,

        /// <summary>
        /// <para><b>Windows 7 and later</b>. Callers should use this flag only if they are already holding an opportunistic lock (oplock) on the file because without an oplock, the bind operation cannot continue. By default, the Shell requests an oplock on a file before binding to the property handler. This flag disables the default behavior. <b>Windows Server 2008 and Windows Vista:  </b>This flag is not available.</para>
        /// <para><see href="https://learn.microsoft.com/windows/win32/api/propsys/ne-propsys-getpropertystoreflags#members">Read more on learn.microsoft.com</see>.</para>
        /// </summary>
        GPS_NO_OPLOCK = 0x00000080,

        /// <summary><b>Windows 8 and later</b>. Use this flag to retrieve only properties from the indexer for WDS results.</summary>
        GPS_PREFERQUERYPROPERTIES = 0x00000100,

        /// <summary>Include properties from the file's secondary stream.</summary>
        GPS_EXTRINSICPROPERTIES = 0x00000200,

        /// <summary>Include only properties from the file's secondary stream.</summary>
        GPS_EXTRINSICPROPERTIESONLY = 0x00000400,

        /// <summary></summary>
        GPS_VOLATILEPROPERTIES = 0x00000800,

        /// <summary></summary>
        GPS_VOLATILEPROPERTIESONLY = 0x00001000,

        /// <summary>Mask for valid <a href="https://docs.microsoft.com/windows/desktop/api/propsys/ne-propsys-getpropertystoreflags">GETPROPERTYSTOREFLAGS</a> values.</summary>
        GPS_MASK_VALID = 0x00001FFF,
    }
    
    [Flags]
    internal enum FILEOPENDIALOGOPTIONS : uint
    {
        FOS_OVERWRITEPROMPT = 0x00000002,
        FOS_STRICTFILETYPES = 0x00000004,
        FOS_NOCHANGEDIR = 0x00000008,
        FOS_PICKFOLDERS = 0x00000020,
        FOS_FORCEFILESYSTEM = 0x00000040,
        FOS_ALLNONSTORAGEITEMS = 0x00000080,
        FOS_NOVALIDATE = 0x00000100,
        FOS_ALLOWMULTISELECT = 0x00000200,
        FOS_PATHMUSTEXIST = 0x00000800,
        FOS_FILEMUSTEXIST = 0x00001000,
        FOS_CREATEPROMPT = 0x00002000,
        FOS_SHAREAWARE = 0x00004000,
        FOS_NOREADONLYRETURN = 0x00008000,
        FOS_NOTESTFILECREATE = 0x00010000,
        FOS_HIDEMRUPLACES = 0x00020000,
        FOS_HIDEPINNEDPLACES = 0x00040000,
        FOS_NODEREFERENCELINKS = 0x00100000,
        FOS_OKBUTTONNEEDSINTERACTION = 0x00200000,
        FOS_DONTADDTORECENT = 0x02000000,
        FOS_FORCESHOWHIDDEN = 0x10000000,
        FOS_DEFAULTNOMINIMODE = 0x20000000,
        FOS_FORCEPREVIEWPANEON = 0x40000000,
        FOS_SUPPORTSTREAMABLEITEMS = 0x80000000,
    }
    
    /// <summary>Specifies list placement.</summary>
    /// <remarks>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-fdap">Learn more about this API from learn.microsoft.com</see>.</para>
    /// </remarks>
    internal enum FDAP
    {
        /// <summary>The place is added to the bottom of the default list.</summary>
        FDAP_BOTTOM = 0,
        /// <summary>The place is added to the top of the default list.</summary>
        FDAP_TOP = 1,
    }
    
    		/// <summary>Requests the form of an item's display name to retrieve through IShellItem::GetDisplayName and SHGetNameFromIDList.</summary>
		/// <remarks>
		/// <para>Different forms of an item's name can be retrieved through the item's properties, including those listed here. Note that not all properties are present on all items, so only those appropriate to the item will appear.</para>
		/// <para></para>
		/// <para>This doc was truncated.</para>
		/// <para><see href="https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-sigdn#">Read more on learn.microsoft.com</see>.</para>
		/// </remarks>
		internal enum SIGDN
		{
			/// <summary>0x00000000. Returns the display name relative to the parent folder. In UI this name is generally ideal for display to the user.</summary>
			SIGDN_NORMALDISPLAY = 0,
			/// <summary>(int)0x80018001. Returns the parsing name relative to the parent folder. This name is not suitable for use in UI.</summary>
			SIGDN_PARENTRELATIVEPARSING = -2147385343,
			/// <summary>(int)0x80028000. Returns the parsing name relative to the desktop. This name is not suitable for use in UI.</summary>
			SIGDN_DESKTOPABSOLUTEPARSING = -2147319808,
			/// <summary>(int)0x80031001. Returns the editing name relative to the parent folder. In UI this name is suitable for display to the user.</summary>
			SIGDN_PARENTRELATIVEEDITING = -2147282943,
			/// <summary>(int)0x8004c000. Returns the editing name relative to the desktop. In UI this name is suitable for display to the user.</summary>
			SIGDN_DESKTOPABSOLUTEEDITING = -2147172352,
			/// <summary>(int)0x80058000. Returns the item's file system path, if it has one. Only items that report <a href="https://docs.microsoft.com/windows/desktop/shell/sfgao">SFGAO_FILESYSTEM</a> have a file system path. When an item does not have a file system path, a call to <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nf-shobjidl_core-ishellitem-getdisplayname">IShellItem::GetDisplayName</a> on that item will fail. In UI this name is suitable for display to the user in some cases, but note that it might not be specified for all items.</summary>
			SIGDN_FILESYSPATH = -2147123200,
			/// <summary>(int)0x80068000. Returns the item's URL, if it has one. Some items do not have a URL, and in those cases a call to <a href="https://docs.microsoft.com/windows/desktop/api/shobjidl_core/nf-shobjidl_core-ishellitem-getdisplayname">IShellItem::GetDisplayName</a> will fail. This name is suitable for display to the user in some cases, but note that it might not be specified for all items.</summary>
			SIGDN_URL = -2147057664,
			/// <summary>(int)0x8007c001. Returns the path relative to the parent folder in a friendly format as displayed in an address bar. This name is suitable for display to the user.</summary>
			SIGDN_PARENTRELATIVEFORADDRESSBAR = -2146975743,
			/// <summary>(int)0x80080001. Returns the path relative to the parent folder.</summary>
			SIGDN_PARENTRELATIVE = -2146959359,
			/// <summary>(int)0x80094001. <b>Introduced in Windows 8</b>.</summary>
			SIGDN_PARENTRELATIVEFORUI = -2146877439,
		}
            
            /// <summary>Values that are used in activation calls to indicate the execution contexts in which an object is to be run.</summary>
		/// <remarks>
		/// <para>Values from the <b>CLSCTX</b> enumeration are used in activation calls (<a href="https://docs.microsoft.com/windows/desktop/api/combaseapi/nf-combaseapi-cocreateinstance">CoCreateInstance</a>, <a href="https://docs.microsoft.com/windows/desktop/api/combaseapi/nf-combaseapi-cocreateinstanceex">CoCreateInstanceEx</a>, <a href="https://docs.microsoft.com/windows/desktop/api/combaseapi/nf-combaseapi-cogetclassobject">CoGetClassObject</a>, and so on) to indicate the preferred execution contexts (in-process, local, or remote) in which an object is to be run. They are also used in calls to <a href="https://docs.microsoft.com/windows/desktop/api/combaseapi/nf-combaseapi-coregisterclassobject">CoRegisterClassObject</a> to indicate the set of execution contexts in which a class object is to be made available for requests to construct instances (<b>IClassFactory::CreateInstance</b>). To indicate that more than one context is acceptable, you can combine multiple values with Boolean ORs. The contexts are tried in the order in which they are listed.</para>
		/// <para>Given a set of <b>CLSCTX</b> flags, the execution context to be used depends on the availability of registered class codes and other parameters according to the following algorithm.</para>
		/// <para></para>
		/// <para>This doc was truncated.</para>
		/// <para><see href="https://learn.microsoft.com/windows/win32/api/wtypesbase/ne-wtypesbase-clsctx#">Read more on learn.microsoft.com</see>.</para>
		/// </remarks>
		[Flags]
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.3.269+368685089b.RR")]
		internal enum CLSCTX : uint
		{
			/// <summary>The code that creates and manages objects of this class is a DLL that runs in the same process as the caller of the function specifying the class context.</summary>
			CLSCTX_INPROC_SERVER = 0x00000001,
			/// <summary>The code that manages objects of this class is an in-process handler. This is a DLL that runs in the client process and implements client-side structures of this class when instances of the class are accessed remotely.</summary>
			CLSCTX_INPROC_HANDLER = 0x00000002,
			/// <summary>The EXE code that creates and manages objects of this class runs on same machine but is loaded in a separate process space.</summary>
			CLSCTX_LOCAL_SERVER = 0x00000004,
			/// <summary>Obsolete.</summary>
			CLSCTX_INPROC_SERVER16 = 0x00000008,
			/// <summary>A remote context. The <a href="https://docs.microsoft.com/windows/desktop/com/localserver32">LocalServer32</a> or <a href="https://docs.microsoft.com/windows/desktop/com/localservice">LocalService</a> code that creates and manages objects of this class is run on a different computer.</summary>
			CLSCTX_REMOTE_SERVER = 0x00000010,
			/// <summary>Obsolete.</summary>
			CLSCTX_INPROC_HANDLER16 = 0x00000020,
			/// <summary>Reserved.</summary>
			CLSCTX_RESERVED1 = 0x00000040,
			/// <summary>Reserved.</summary>
			CLSCTX_RESERVED2 = 0x00000080,
			/// <summary>Reserved.</summary>
			CLSCTX_RESERVED3 = 0x00000100,
			/// <summary>Reserved.</summary>
			CLSCTX_RESERVED4 = 0x00000200,
			/// <summary>Disables the downloading of code from the directory service or the Internet. This flag cannot be set at the same time as CLSCTX_ENABLE_CODE_DOWNLOAD.</summary>
			CLSCTX_NO_CODE_DOWNLOAD = 0x00000400,
			/// <summary>Reserved.</summary>
			CLSCTX_RESERVED5 = 0x00000800,
			/// <summary>Specify if you want the activation to fail if it uses custom marshalling.</summary>
			CLSCTX_NO_CUSTOM_MARSHAL = 0x00001000,
			/// <summary>Enables the downloading of code from the directory service or the Internet. This flag cannot be set at the same time as CLSCTX_NO_CODE_DOWNLOAD.</summary>
			CLSCTX_ENABLE_CODE_DOWNLOAD = 0x00002000,
			/// <summary>
			/// <para>The CLSCTX_NO_FAILURE_LOG can be used to override the logging of failures in <a href="https://docs.microsoft.com/windows/desktop/api/combaseapi/nf-combaseapi-cocreateinstanceex">CoCreateInstanceEx</a>. If the ActivationFailureLoggingLevel is created, the following values can determine the status of event logging: </para>
			/// <para>This doc was truncated.</para>
			/// <para><see href="https://learn.microsoft.com/windows/win32/api/wtypesbase/ne-wtypesbase-clsctx#members">Read more on learn.microsoft.com</see>.</para>
			/// </summary>
			CLSCTX_NO_FAILURE_LOG = 0x00004000,
			/// <summary>
			/// <para>Disables activate-as-activator (AAA) activations for this activation only. This flag overrides the setting of the EOAC_DISABLE_AAA flag from the EOLE_AUTHENTICATION_CAPABILITIES enumeration. This flag cannot be set at the same time as CLSCTX_ENABLE_AAA. Any activation where a server process would be launched under the caller's identity is known as an activate-as-activator (AAA) activation. Disabling AAA activations allows an application that runs under a privileged account (such as LocalSystem) to help prevent its identity from being used to launch untrusted components. Library applications that use activation calls should always set this flag during those calls. This helps prevent the library application from being used in an escalation-of-privilege security attack. This is the only way to disable AAA activations in a library application because the EOAC_DISABLE_AAA flag from the EOLE_AUTHENTICATION_CAPABILITIES enumeration is applied only to the server process and not to the library application. <b>Windows 2000:  </b>This flag is not supported.</para>
			/// <para><see href="https://learn.microsoft.com/windows/win32/api/wtypesbase/ne-wtypesbase-clsctx#members">Read more on learn.microsoft.com</see>.</para>
			/// </summary>
			CLSCTX_DISABLE_AAA = 0x00008000,
			/// <summary>
			/// <para>Enables activate-as-activator (AAA) activations for this activation only. This flag overrides the setting of the EOAC_DISABLE_AAA flag from the EOLE_AUTHENTICATION_CAPABILITIES enumeration. This flag cannot be set at the same time as CLSCTX_DISABLE_AAA. Any activation where a server process would be launched under the caller's identity is known as an activate-as-activator (AAA) activation. Enabling this flag allows an application to transfer its identity to an activated component. <b>Windows 2000:  </b>This flag is not supported.</para>
			/// <para><see href="https://learn.microsoft.com/windows/win32/api/wtypesbase/ne-wtypesbase-clsctx#members">Read more on learn.microsoft.com</see>.</para>
			/// </summary>
			CLSCTX_ENABLE_AAA = 0x00010000,
			/// <summary>Begin this activation from the default context of the current apartment.</summary>
			CLSCTX_FROM_DEFAULT_CONTEXT = 0x00020000,
			/// <summary></summary>
			CLSCTX_ACTIVATE_X86_SERVER = 0x00040000,
			/// <summary>Activate or connect to a 32-bit version of the server; fail if one is not registered.</summary>
			CLSCTX_ACTIVATE_32_BIT_SERVER = 0x00040000,
			/// <summary>Activate or connect to a 64 bit version of the server; fail if one is not registered.</summary>
			CLSCTX_ACTIVATE_64_BIT_SERVER = 0x00080000,
			/// <summary>
			/// <para>When this flag is specified, COM uses the impersonation token of the thread, if one is present, for the activation request made by the thread. When this flag is not specified or if the thread does not have an impersonation token, COM uses the process token of the thread's process for the activation request made by the thread.</para>
			/// <para><b>Windows Vista or later:  </b>This flag is supported.</para>
			/// <para><see href="https://learn.microsoft.com/windows/win32/api/wtypesbase/ne-wtypesbase-clsctx#members">Read more on learn.microsoft.com</see>.</para>
			/// </summary>
			CLSCTX_ENABLE_CLOAKING = 0x00100000,
			/// <summary>
			/// <para>Indicates activation is for an app container.</para>
			/// <para><div class="alert"><b>Note</b>  This flag is reserved for internal use and is not intended to be used directly from your code.</div> <div> </div></para>
			/// <para><see href="https://learn.microsoft.com/windows/win32/api/wtypesbase/ne-wtypesbase-clsctx#members">Read more on learn.microsoft.com</see>.</para>
			/// </summary>
			CLSCTX_APPCONTAINER = 0x00400000,
			/// <summary>
			/// <para>Specify this flag for Interactive User activation behavior for As-Activator servers. A strongly named Medium IL Windows Store app can use this flag to launch an "As Activator" COM server without a strong name. Also, you can use this flag to bind to a running instance of the COM server that's launched by a desktop application. The client must be Medium IL, it must be strongly named, which means that it has a SysAppID in the client token, it can't be in session 0,  and it must have the same user as the session ID's user in the client token. If  the server is out-of-process and "As Activator", it launches the server with the token of the client token's session user. This token won't be strongly named. If the server is out-of-process and RunAs "Interactive User", this flag has no effect. If the server is out-of-process and is any other RunAs type, the activation fails. This flag has no effect for in-process servers. Off-machine activations fail when they use this flag.</para>
			/// <para><see href="https://learn.microsoft.com/windows/win32/api/wtypesbase/ne-wtypesbase-clsctx#members">Read more on learn.microsoft.com</see>.</para>
			/// </summary>
			CLSCTX_ACTIVATE_AAA_AS_IU = 0x00800000,
			/// <summary></summary>
			CLSCTX_RESERVED6 = 0x01000000,
			/// <summary></summary>
			CLSCTX_ACTIVATE_ARM32_SERVER = 0x02000000,
			CLSCTX_ALLOW_LOWER_TRUST_REGISTRATION = 0x04000000,
			CLSCTX_SERVER_MUST_BE_EQUAL_OR_GREATER_PRIVILEGE = 0x08000000,
			CLSCTX_DO_NOT_ELEVATE_SERVER = 0x10000000,
			/// <summary>
			/// <para>Used for loading Proxy/Stub DLLs.</para>
			/// <para><div class="alert"><b>Note</b>  This flag is reserved for internal use and is not intended to be used directly from your code.</div> <div> </div></para>
			/// <para><see href="https://learn.microsoft.com/windows/win32/api/wtypesbase/ne-wtypesbase-clsctx#members">Read more on learn.microsoft.com</see>.</para>
			/// </summary>
			CLSCTX_PS_DLL = 0x80000000,
			CLSCTX_ALL = 0x00000017,
			CLSCTX_SERVER = 0x00000015,
		}

}