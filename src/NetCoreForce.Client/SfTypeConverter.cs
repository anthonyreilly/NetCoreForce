using System;
using NetCoreForce.Client.Models;

namespace NetCoreForce.Client
{
    public static class SfTypeConverter
    {
        public static string GetTypeName(string sfType)
        {
            FieldType ft = parseType(sfType);

            string typeName = "string";
            Type type = typeof(string);

            switch (ft)
            {
                //primitives
                case FieldType.base64_sf:
                    type = typeof(string);
                    break;
                case FieldType.boolean_sf:
                    type = typeof(bool);
                    break;
                case FieldType.byte_sf:
                    type = typeof(byte);
                    break;
                case FieldType.datetime_sf:
                    type = typeof(DateTimeOffset);
                    break;
                case FieldType.double_sf:
                    type = typeof(double);
                    break;
                case FieldType.int_sf:
                    type = typeof(int);
                    break;
                case FieldType.string_sf:
                    type = typeof(string);
                    break;
                
                //TODO: review this type
                case FieldType.time_sf:
                    type = typeof(string);
                    break;

                //field types
                case FieldType.address_sf:
                    type = typeof(Address);
                    break;                    

                // The anyType field type is dynamic and returns string, date, number, or boolean data depending on the kind of field involved.
                // For example, the element in a SOAP message has an xsi:type="xsd:string" attribute if the field is of type string.
                // This field type is used in history objects for the NewValue and OldValue fields.
                // It is also a valid field type for fieldType and soapType.
                case FieldType.anyType_sf:
                    type = typeof(string);
                    break;
                case FieldType.calculated_sf:
                    type = typeof(string);
                    break;
                case FieldType.combobox_sf:
                    type = typeof(string);
                    break;
                case FieldType.currency_sf:
                    type = typeof(decimal);
                    break;

                // TODO: review this type choice
                case FieldType.DataCategoryGroupReference_sf:
                    type = typeof(string);
                    break;

                case FieldType.email_sf:
                    type = typeof(string);
                    break;
                case FieldType.encryptedstring_sf:
                    type = typeof(string);
                    break;
                case FieldType.id_sf:
                    type = typeof(string);
                    break;

                // TODO: review, may be List<string>
                case FieldType.JunctionIdList_sf:
                    type = typeof(string);
                    break;

                case FieldType.location_sf:
                    type = typeof(Location);
                    break;
                case FieldType.masterrecord_sf:
                    type = typeof(string);
                    break;
                case FieldType.multipicklist_sf:
                    type = typeof(string);
                    break;
                case FieldType.percent_sf:
                    type = typeof(double);
                    break;
                case FieldType.phone_sf:
                    type = typeof(string);
                    break;
                case FieldType.picklist_sf:
                    type = typeof(string);
                    break;
                case FieldType.reference_sf:
                    type = typeof(string);
                    break;
                case FieldType.textarea_sf:
                    type = typeof(string);
                    break;
                case FieldType.url_sf:
                    type = typeof(string);
                    break;
                default:
                    typeName = "string";
                    break;
            }

            typeName = type.Name;

            return typeName;
        }

        public static FieldType parseType(string sfType)
        {
            FieldType st;

            if (!sfType.EndsWith("_sf"))
            {
                sfType += "_sf";
            }

            if (Enum.TryParse(sfType, out st))
            {
                return st;
            }
            else
            {
                return FieldType.string_sf;
            }
        }

    }
}