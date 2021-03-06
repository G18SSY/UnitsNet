﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Linq;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of SolidAngle.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class SolidAngleTestsBase
    {
        protected abstract double SteradiansInOneSteradian { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double SteradiansTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new SolidAngle((double)0.0, SolidAngleUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new SolidAngle(double.PositiveInfinity, SolidAngleUnit.Steradian));
            Assert.Throws<ArgumentException>(() => new SolidAngle(double.NegativeInfinity, SolidAngleUnit.Steradian));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new SolidAngle(double.NaN, SolidAngleUnit.Steradian));
        }

        [Fact]
        public void SteradianToSolidAngleUnits()
        {
            SolidAngle steradian = SolidAngle.FromSteradians(1);
            AssertEx.EqualTolerance(SteradiansInOneSteradian, steradian.Steradians, SteradiansTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, SolidAngle.From(1, SolidAngleUnit.Steradian).Steradians, SteradiansTolerance);
        }

        [Fact]
        public void FromSteradians_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => SolidAngle.FromSteradians(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => SolidAngle.FromSteradians(double.NegativeInfinity));
        }

        [Fact]
        public void FromSteradians_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => SolidAngle.FromSteradians(double.NaN));
        }

        [Fact]
        public void As()
        {
            var steradian = SolidAngle.FromSteradians(1);
            AssertEx.EqualTolerance(SteradiansInOneSteradian, steradian.As(SolidAngleUnit.Steradian), SteradiansTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var steradian = SolidAngle.FromSteradians(1);

            var steradianQuantity = steradian.ToUnit(SolidAngleUnit.Steradian);
            AssertEx.EqualTolerance(SteradiansInOneSteradian, (double)steradianQuantity.Value, SteradiansTolerance);
            Assert.Equal(SolidAngleUnit.Steradian, steradianQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            SolidAngle steradian = SolidAngle.FromSteradians(1);
            AssertEx.EqualTolerance(1, SolidAngle.FromSteradians(steradian.Steradians).Steradians, SteradiansTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            SolidAngle v = SolidAngle.FromSteradians(1);
            AssertEx.EqualTolerance(-1, -v.Steradians, SteradiansTolerance);
            AssertEx.EqualTolerance(2, (SolidAngle.FromSteradians(3)-v).Steradians, SteradiansTolerance);
            AssertEx.EqualTolerance(2, (v + v).Steradians, SteradiansTolerance);
            AssertEx.EqualTolerance(10, (v*10).Steradians, SteradiansTolerance);
            AssertEx.EqualTolerance(10, (10*v).Steradians, SteradiansTolerance);
            AssertEx.EqualTolerance(2, (SolidAngle.FromSteradians(10)/5).Steradians, SteradiansTolerance);
            AssertEx.EqualTolerance(2, SolidAngle.FromSteradians(10)/SolidAngle.FromSteradians(5), SteradiansTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            SolidAngle oneSteradian = SolidAngle.FromSteradians(1);
            SolidAngle twoSteradians = SolidAngle.FromSteradians(2);

            Assert.True(oneSteradian < twoSteradians);
            Assert.True(oneSteradian <= twoSteradians);
            Assert.True(twoSteradians > oneSteradian);
            Assert.True(twoSteradians >= oneSteradian);

            Assert.False(oneSteradian > twoSteradians);
            Assert.False(oneSteradian >= twoSteradians);
            Assert.False(twoSteradians < oneSteradian);
            Assert.False(twoSteradians <= oneSteradian);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            SolidAngle steradian = SolidAngle.FromSteradians(1);
            Assert.Equal(0, steradian.CompareTo(steradian));
            Assert.True(steradian.CompareTo(SolidAngle.Zero) > 0);
            Assert.True(SolidAngle.Zero.CompareTo(steradian) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            SolidAngle steradian = SolidAngle.FromSteradians(1);
            Assert.Throws<ArgumentException>(() => steradian.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            SolidAngle steradian = SolidAngle.FromSteradians(1);
            Assert.Throws<ArgumentNullException>(() => steradian.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = SolidAngle.FromSteradians(1);
            var b = SolidAngle.FromSteradians(2);

 // ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            var a = SolidAngle.FromSteradians(1);
            var b = SolidAngle.FromSteradians(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = SolidAngle.FromSteradians(1);
            Assert.True(v.Equals(SolidAngle.FromSteradians(1), SteradiansTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(SolidAngle.Zero, SteradiansTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            SolidAngle steradian = SolidAngle.FromSteradians(1);
            Assert.False(steradian.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            SolidAngle steradian = SolidAngle.FromSteradians(1);
            Assert.False(steradian.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(SolidAngleUnit.Undefined, SolidAngle.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(SolidAngleUnit)).Cast<SolidAngleUnit>();
            foreach(var unit in units)
            {
                if(unit == SolidAngleUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(SolidAngle.BaseDimensions is null);
        }
    }
}
