namespace MMKiwi.AotDialogs.Gtk;

[NativeMarshalling(typeof(ManagedToNative))]
public partial class GError
{
    private GError(uint domain, int code, string? message)
    {
        Domain = NativeMethods.Gtk4.g_quark_to_string(domain);
        Code = code;
        Message = message;
    }
    
    public string Domain { get; }
    public int Code { get; }
    public string? Message { get; }
        
    [CustomMarshaller(typeof(GError), MarshalMode.ManagedToUnmanagedOut, typeof(ManagedToNative))]
    [CustomMarshaller(typeof(GError), MarshalMode.UnmanagedToManagedIn, typeof(ManagedToNative))]
    internal static unsafe partial class ManagedToNative
    {
        public static GError? ConvertToManaged(Native* unmanaged)
        {
            if(unmanaged == null) return null;
            string? message = Utf8StringMarshaller.ConvertToManaged(unmanaged->Message);
            return new GError(unmanaged->Domain, unmanaged->Code, message);
            
        }

        public static void Free(Native* unmanaged)
        {
            g_error_free(unmanaged);
        }
        
        [LibraryImport("glib")]
        private static partial void g_error_free(Native* error);
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct Native
    {
        public readonly uint Domain;
        public readonly int Code;
        public readonly byte* Message;
    }
}