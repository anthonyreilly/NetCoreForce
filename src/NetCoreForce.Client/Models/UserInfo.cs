using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    //https://developer.salesforce.com/docs/atlas.en-us.mobile_sdk.meta/mobile_sdk/oauth_using_identity_urls.htm
    
    /// <summary>
    /// Identity URL Response
    /// </summary>
    public class UserInfo
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "asserted_user")]
        public bool AssertedUser { get; set; }

        [JsonProperty(PropertyName = "user_id")]
        public string UserId { get; set; }

        [JsonProperty(PropertyName = "organization_id")]
        public string OrganizationId { get; set; }

        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        [JsonProperty(PropertyName = "nick_name")]
        public string NickName { get; set; }

        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "email_verified")]
        public bool EmailVerified { get; set; }

        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// Map of URLs to the user’s profile pictures
        /// </summary>
        [JsonProperty(PropertyName = "photos")]
        public ProfilePictures Photos { get; set; }

        [JsonProperty(PropertyName = "addr_street")]
        public string AddressStreet { get; set; }

        [JsonProperty(PropertyName = "addr_city")]
        public string AddressCity { get; set; }

        [JsonProperty(PropertyName = "addr_state")]
        public string AddressState { get; set; }

        [JsonProperty(PropertyName = "addr_country")]
        public string AddressCountry { get; set; }

        [JsonProperty(PropertyName = "addr_zip")]
        public string AddressZip { get; set; }

        [JsonProperty(PropertyName = "mobile_phone")]
        public string MobilePhone { get; set; }

        [JsonProperty(PropertyName = "mobile_phone_verified")]
        public bool MobilePhoneVerified { get; set; }

        /// <summary>
        /// User's current Chatter status
        /// </summary>
        /// <returns></returns>
        [JsonProperty(PropertyName = "status")]
        public ChatterStatus Status { get; set; }

        [JsonProperty(PropertyName = "urls")]
        public Dictionary<string, string> Urls { get; set; }

        [JsonProperty(PropertyName = "active")]
        public bool Active { get; set; }

        [JsonProperty(PropertyName = "user_type")]
        public string UserType { get; set; }

        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }

        /// <summary>
        /// Offset from UTC of the time zone of the queried user, in milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "utcOffset")]
        public int UtcOffset { get; set; }

        /// <summary>
        /// xsd datetime format of the last modification of the user
        /// </summary>
        [JsonProperty(PropertyName = "last_modified_date")]
        public DateTimeOffset LastModifiedDate { get; set; }

        [JsonProperty(PropertyName = "is_app_installed")]
        public bool IsAppInstalled { get; set; }

        //unverified
        // [JsonProperty(PropertyName = "custom_attributes")]
        // public Dictionary<string, string> CustomAttributes { get; set; }
    }

    /// <summary>
    /// User’s current Chatter status
    /// </summary>
    public class ChatterStatus
    {
        /// <summary>
        /// datetime value of the creation date of the last post by the user
        /// </summary>
        [JsonProperty(PropertyName = "created_date")]
        public DateTimeOffset? CreatedDate { get; set; }

        /// <summary>
        /// Body of the post
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }
    }

    /// <summary>
    /// User’s profile pictures
    /// <remarks>Accessing these URLs requires passing an access token</remarks>
    /// </summary>
    public class ProfilePictures
    {
        /// <summary>
        /// User profile picture URL
        /// </summary>
        [JsonProperty(PropertyName = "picture")]
        public string Picture { get; set; }

        /// <summary>
        /// User profile picture thumbnail URL
        /// </summary>
        [JsonProperty(PropertyName = "thumbnail")]
        public string Thumbnail { get; set; }
    }
}
