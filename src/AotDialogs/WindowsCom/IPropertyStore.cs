// SPDX-License-Identifier: MIT
// Copyright 2026 Micah Makaiwi
// This source code is subject to the terms of the MIT license.
// If a copy of the license was not distributed with this file,
// you can obtain one at https://github.com/mmkiwi/AotDialogs/blob/main/LICENSE.md

// This interface is unused; removing it from the compilation, but keeping the file in case it's useful later.

#if FALSE
[Guid("886D8EEB-8CF2-4446-8D02-CDBA1DBDCF99")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[GeneratedComInterface]
internal unsafe partial interface IPropertyStore
{
    /// <summary>This method returns a count of the number of properties that are attached to the file.</summary>
    /// <param name="cProps">A pointer to a value that indicates the property count.</param>
    /// <returns>The <c>IpropertyStore::GetCount</c> method returns a value of S_OK when the call is successful, even if the file has no properties attached. Any other code returned is an error code.</returns>
    /// <remarks>
    /// <para><b>IPropertyStore</b> provides an abstraction over an array of property keys via the <c>IPropertyStore::GetCount</c> and <a href="https://docs.microsoft.com/windows/desktop/api/propsys/nf-propsys-ipropertystore-getat">IPropertyStore::GetAt</a> methods. The property keys in this array represent the properties that are currently stored by the <b>IPropertyStore</b>. When <c>GetCount</c> succeeds, the value pointed to by cProps is a count of property keys in the array. The caller can expect calls to <b>IPropertyStore::GetAt</b> to succeed for values of iProp less than cProps. In the case of failures such as E_OUTOFMEMORY, you should set cProps to zero. It is preferable that errors are discovered during creation or initialization of the property store.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertystore-getcount#">Read more on learn.microsoft.com</see>.</para>
    /// </remarks>
    void GetCount(out uint cProps);

    /// <summary>Gets a property key from the property array of an item.</summary>
    /// <param name="iProp">The index of the property key in the array of PROPERTYKEY structures. This is a zero-based index.</param>
    /// <param name="pkey">TBD</param>
    /// <returns>The <c>IPropertyStore::GetAt</c> method returns a value of S_OK if successful. Otherwise, any other code it returns must be considered to be an error code.</returns>
    /// <remarks>None</remarks>
    void GetAt(uint iProp,  out NativeStructs.PROPERTYKEY pkey);

    /// <summary>This method retrieves the data for a specific property.</summary>
    /// <param name="key">TBD</param>
    /// <param name="pv">After the <c>IPropertyStore::GetValue</c> method returns successfully, this parameter points to a <a href="https://docs.microsoft.com/previous-versions/aa912007(v=msdn.10)">PROPVARIANT </a> structure that contains data about the property.</param>
    /// <returns>
    /// <para>Returns S_OK or INPLACE_S_TRUNCATED if successful, or an error value otherwise. INPLACE_S_TRUNCATED is returned to indicate that the returned PROPVARIANT was converted into a more canonical form. For example, this would be done to trim leading or trailing spaces from a string value. You must use the SUCCEEDED macro to check the return value, which treats INPLACE_S_TRUNCATED as a success code. The SUCCEEDED macro is defined in the Winerror.h file.</para>
    /// </returns>
    /// <remarks>If the PROPERTYKEY referenced in key is not present in the property store, this method returns S_OK and the <a href="https://docs.microsoft.com/previous-versions/aa912007(v=msdn.10)">vt </a> member of the structure that is pointed to by pv is set to VT_EMPTY.</remarks>
    void GetValue( in NativeStructs.PROPERTYKEY key, 
        out /* PROPVARIANT */ void* pv);

    /// <summary>This method sets a property value or replaces or removes an existing value.</summary>
    /// <param name="key">TBD</param>
    /// <param name="propvar">TBD</param>
    /// <returns>
    /// <para>The <c>IPropertyStore::SetValue</c> method can return any one of the following: </para>
    /// <para>This doc was truncated.</para>
    /// </returns>
    /// <remarks>
    /// <para><c>IPropertyStore::SetValue</code> affects the current property store instance only. A property handler implements <code>IPropertyStore::SetValue</c> by accumulating property changes in an in-memory data structure. Property changes are written to the stream only when <a href="https://docs.microsoft.com/windows/desktop/api/propsys/nf-propsys-ipropertystore-commit">IPropertyStore::Commit</a> is called. If <b>IPropertyStore::Commit</b> is called on a read-only property store, the property handler determines this and returns STG_E_ACCESSDENIED. If a value was added or removed as a result of <c>SetValue</code>, subsequent enumerations by <a href="https://docs.microsoft.com/windows/desktop/api/propsys/nf-propsys-ipropertystore-getcount">IPropertyStore::GetCount</a> and <a href="https://docs.microsoft.com/windows/desktop/api/propsys/nf-propsys-ipropertystore-getat">IPropertyStore::GetAt</a> reflect that change and subsequent calls to <code>IPropertyStore::SetValue</c> reflect the changed value. <b>Adding a New Property</b> If the property value that was pointed to by key does not exist in the store, <c>IPropertyStore::SetValue</c> adds the value to the store. <b>Replacing an Existing Property Value</b> If the property value that was pointed to by key already exists in the store, the stored value is replaced. <b>Removing an Existing Property</b> To remove a value from the property store, set the vt member of the structure that is pointed to by pv to VT_EMPTY. If that value is not present, do nothing and the method returns S_OK.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertystore-setvalue#">Read more on learn.microsoft.com</see>.</para>
    /// </remarks>
    void SetValue(in NativeStructs.PROPERTYKEY key, /*PROPVARIANT*/ void* propvar);

    /// <summary>After a change has been made, this method saves the changes.</summary>
    /// <returns>
    /// <para>The <c>IPropertyStore::Commit</c> method returns any one of the following: </para>
    /// <para>This doc was truncated.</para>
    /// </returns>
    /// <remarks>
    /// <para>Before the <c>Commit</code> method returns, it releases the file stream or path that was initialized to be used by the method. Therefore, no <b>IPropertyStore</b> methods succeed after <code>Commit</c> returns. At that point, they return E_FAIL. Property handlers must ensure that property changes result in a valid destination file, even if the <c>Commit</c> process terminates abnormally, or encounters any errors.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertystore-commit#">Read more on learn.microsoft.com</see>.</para>
    /// </remarks>
    void Commit();
}
#endif