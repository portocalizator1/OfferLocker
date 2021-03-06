﻿using FluentAssertions;
using OfferLocker.Business.Identity.Validators;
using OfferLocker.UnitTests.Shared.Factories;
using Xunit;

namespace OfferLocker.UnitTests.OfferLocker.Business.Identity.Validators
{
    public class AuthenticationRequestValidatorTests
    {
        [Fact]
        public void GivenValidate_WhenHavingValidInput_ThenResultShouldBeValid()
        {
            var request = AuthenticationRequestFactory.Default();
            var validator = new AuthenticationRequestValidator();

            var result = validator.Validate(request);

            result.IsValid.Should().BeTrue();
            result.Errors.Count.Should().Be(0);
        }


        [Fact]
        public void GivenInvalidEmail_WhenHavingInvalidInput_ThenResultShouldBeInvalid()
        {
            var request = AuthenticationRequestFactory.WithEmailNull();
            var validator = new AuthenticationRequestValidator();

            var result = validator.Validate(request);

            result.IsValid.Should().BeFalse();
        }

        [Fact]
        public void GivenNoPassword_WhenHavingInvalidInput_ThenResultShouldBeInvalid()
        {
            var request = AuthenticationRequestFactory.WithPasswordNull();
            var validator = new AuthenticationRequestValidator();

            var result = validator.Validate(request);

            result.IsValid.Should().BeFalse();
        }
    }
}
