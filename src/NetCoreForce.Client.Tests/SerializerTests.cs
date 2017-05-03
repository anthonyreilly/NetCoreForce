using NetCoreForce.Client;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;
using Xunit;

namespace NetCoreForce.Client.Tests
{
    public class SampleObject
    {
        [JsonProperty(PropertyName = "noAttributes")]
        public string NoAttributes { get; set; }

        [JsonProperty(PropertyName = "nullProperty")]
		public string NullProperty { get { return null; } }


        [JsonProperty(PropertyName = "createableTrue")]
		[Createable(true)]
		public string CreateableTrue { get; set; }

        [JsonProperty(PropertyName = "createableFalse")]
		[Createable(false)]
		public string CreateableFalse { get; set; }
        

        [JsonProperty(PropertyName = "updateableTrue")]
		[Updateable(true)]
		public string UpdateableTrue { get; set; }

        [JsonProperty(PropertyName = "updateableFalse")]
		[Updateable(false)]
		public string UpdateableFalse { get; set; }        

        public SampleObject()
        {
            const string sampleValue = "sample value";
            NoAttributes = sampleValue;
            CreateableTrue = sampleValue;
            CreateableFalse = sampleValue;
            UpdateableTrue = sampleValue;
            UpdateableFalse = sampleValue;            
        }
    }

    public class SerializerTests
    {
        [Fact]
        public void SerializeForCreate()
        {
            string serialized = JsonSerializer.SerializeForCreate(new SampleObject());

            Assert.True(serialized.Contains("noAttributes"));
            Assert.True(serialized.Contains("createableTrue"));
            Assert.False(serialized.Contains("createableFalse"));
        }

        [Fact]
        public void SerializeForUpdate()
        {
            string serialized = JsonSerializer.SerializeForUpdate(new SampleObject());

            Assert.True(serialized.Contains("noAttributes"));
            Assert.True(serialized.Contains("updateableTrue"));
            Assert.False(serialized.Contains("updateableFalse"));
        }

        [Fact]
        public void NullValueHandlingForUpdate()
        {
            string serialized = JsonSerializer.SerializeForUpdate(new SampleObject());

            Assert.False(serialized.Contains("nullProperty"));
        }

        [Fact]
        public void NullValueHandlingForCreate()
        {
            string serialized = JsonSerializer.SerializeForCreate(new SampleObject());

            Assert.False(serialized.Contains("nullProperty"));
        }

        //TODO: test deserialize
        //TODO: test date formatting
    }
}
