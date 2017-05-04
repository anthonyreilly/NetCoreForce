namespace NetCoreForce.ModelGenerator
{
    /// <summary>
    /// Primitive and field data types
    /// suffixed with _sf to avoid reserved/keyword issues
    /// </summary>
    public enum FieldType
    {
        //primitives
        base64_sf,
        boolean_sf,
        byte_sf,
        date_sf,
        datetime_sf,
        double_sf,
        int_sf,
        string_sf,
        time_sf,
        //field types
        address_sf,
        anyType_sf,
        calculated_sf,
        combobox_sf,
        currency_sf,
        DataCategoryGroupReference_sf,
        email_sf,
        encryptedstring_sf,
        id_sf,
        JunctionIdList_sf,
        location_sf,
        masterrecord_sf,
        multipicklist_sf,
        percent_sf,
        phone_sf,
        picklist_sf,
        reference_sf,
        textarea_sf,
        url_sf
    }
}