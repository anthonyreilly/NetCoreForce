using System.Collections.Generic;
using System.Net;
using NetCoreForce.Client;
using NetCoreForce.Client.Models;
using Xunit;

namespace NetCoreForce.Client.Tests
{
    public class ForceApiExceptionTests
    {
        [Fact]
        public void MessageOnly_HasEmptyErrorsAndDefaultStatusCode()
        {
            var ex = new ForceApiException("something went wrong");

            Assert.Equal("something went wrong", ex.Message);
            Assert.NotNull(ex.Errors);
            Assert.Empty(ex.Errors);
            Assert.Equal(new HttpStatusCode(), ex.HttpStatusCode);
        }

        [Fact]
        public void MessageAndErrors_PopulatesErrorsWithDefaultStatusCode()
        {
            var errors = new List<ErrorResponse> { new ErrorResponse { Message = "bad request" } };

            var ex = new ForceApiException("something went wrong", errors);

            Assert.Same(errors, ex.Errors);
            Assert.Equal(new HttpStatusCode(), ex.HttpStatusCode);
        }

        [Fact]
        public void MessageAndSingleError_WrapsErrorInList()
        {
            var error = new ErrorResponse { Message = "bad request" };

            var ex = new ForceApiException("something went wrong", error, HttpStatusCode.BadRequest);

            Assert.Single(ex.Errors);
            Assert.Same(error, ex.Errors[0]);
            Assert.Equal(HttpStatusCode.BadRequest, ex.HttpStatusCode);
        }

        [Fact]
        public void MessageErrorsAndStatusCode_PopulatesAllProperties()
        {
            var errors = new List<ErrorResponse> { new ErrorResponse { Message = "bad request" } };

            var ex = new ForceApiException("something went wrong", errors, HttpStatusCode.BadRequest);

            Assert.Same(errors, ex.Errors);
            Assert.Equal(HttpStatusCode.BadRequest, ex.HttpStatusCode);
        }
    }
}
