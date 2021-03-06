﻿using NUnit.Framework;
using Rhino.Mocks;

namespace FizzWare.NBuilder.Tests.Unit.Picking
{
    [TestFixture]
    public class ExactlyConstraintTests
    {
        private MockRepository mocks;

        [SetUp]
        public void SetUp()
        {
            mocks = new MockRepository();
        }

        [Test]
        public void ShouldBeAbleToUseBetweenPickerConstraint()
        {
            var constraint = new ExactlyConstraint(5);

            int end = constraint.GetEnd();

            Assert.That(end, Is.EqualTo(5));
        }
    }
}
