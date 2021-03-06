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
    /// Test of CoefficientOfThermalExpansion.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class CoefficientOfThermalExpansionTestsBase
    {
        protected abstract double InverseDegreeCelsiusInOneInverseKelvin { get; }
        protected abstract double InverseDegreeFahrenheitInOneInverseKelvin { get; }
        protected abstract double InverseKelvinInOneInverseKelvin { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double InverseDegreeCelsiusTolerance { get { return 1e-5; } }
        protected virtual double InverseDegreeFahrenheitTolerance { get { return 1e-5; } }
        protected virtual double InverseKelvinTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new CoefficientOfThermalExpansion((double)0.0, CoefficientOfThermalExpansionUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new CoefficientOfThermalExpansion(double.PositiveInfinity, CoefficientOfThermalExpansionUnit.InverseKelvin));
            Assert.Throws<ArgumentException>(() => new CoefficientOfThermalExpansion(double.NegativeInfinity, CoefficientOfThermalExpansionUnit.InverseKelvin));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new CoefficientOfThermalExpansion(double.NaN, CoefficientOfThermalExpansionUnit.InverseKelvin));
        }

        [Fact]
        public void InverseKelvinToCoefficientOfThermalExpansionUnits()
        {
            CoefficientOfThermalExpansion inversekelvin = CoefficientOfThermalExpansion.FromInverseKelvin(1);
            AssertEx.EqualTolerance(InverseDegreeCelsiusInOneInverseKelvin, inversekelvin.InverseDegreeCelsius, InverseDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(InverseDegreeFahrenheitInOneInverseKelvin, inversekelvin.InverseDegreeFahrenheit, InverseDegreeFahrenheitTolerance);
            AssertEx.EqualTolerance(InverseKelvinInOneInverseKelvin, inversekelvin.InverseKelvin, InverseKelvinTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, CoefficientOfThermalExpansion.From(1, CoefficientOfThermalExpansionUnit.InverseDegreeCelsius).InverseDegreeCelsius, InverseDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(1, CoefficientOfThermalExpansion.From(1, CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit).InverseDegreeFahrenheit, InverseDegreeFahrenheitTolerance);
            AssertEx.EqualTolerance(1, CoefficientOfThermalExpansion.From(1, CoefficientOfThermalExpansionUnit.InverseKelvin).InverseKelvin, InverseKelvinTolerance);
        }

        [Fact]
        public void FromInverseKelvin_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => CoefficientOfThermalExpansion.FromInverseKelvin(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => CoefficientOfThermalExpansion.FromInverseKelvin(double.NegativeInfinity));
        }

        [Fact]
        public void FromInverseKelvin_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => CoefficientOfThermalExpansion.FromInverseKelvin(double.NaN));
        }

        [Fact]
        public void As()
        {
            var inversekelvin = CoefficientOfThermalExpansion.FromInverseKelvin(1);
            AssertEx.EqualTolerance(InverseDegreeCelsiusInOneInverseKelvin, inversekelvin.As(CoefficientOfThermalExpansionUnit.InverseDegreeCelsius), InverseDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(InverseDegreeFahrenheitInOneInverseKelvin, inversekelvin.As(CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit), InverseDegreeFahrenheitTolerance);
            AssertEx.EqualTolerance(InverseKelvinInOneInverseKelvin, inversekelvin.As(CoefficientOfThermalExpansionUnit.InverseKelvin), InverseKelvinTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var inversekelvin = CoefficientOfThermalExpansion.FromInverseKelvin(1);

            var inversedegreecelsiusQuantity = inversekelvin.ToUnit(CoefficientOfThermalExpansionUnit.InverseDegreeCelsius);
            AssertEx.EqualTolerance(InverseDegreeCelsiusInOneInverseKelvin, (double)inversedegreecelsiusQuantity.Value, InverseDegreeCelsiusTolerance);
            Assert.Equal(CoefficientOfThermalExpansionUnit.InverseDegreeCelsius, inversedegreecelsiusQuantity.Unit);

            var inversedegreefahrenheitQuantity = inversekelvin.ToUnit(CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit);
            AssertEx.EqualTolerance(InverseDegreeFahrenheitInOneInverseKelvin, (double)inversedegreefahrenheitQuantity.Value, InverseDegreeFahrenheitTolerance);
            Assert.Equal(CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit, inversedegreefahrenheitQuantity.Unit);

            var inversekelvinQuantity = inversekelvin.ToUnit(CoefficientOfThermalExpansionUnit.InverseKelvin);
            AssertEx.EqualTolerance(InverseKelvinInOneInverseKelvin, (double)inversekelvinQuantity.Value, InverseKelvinTolerance);
            Assert.Equal(CoefficientOfThermalExpansionUnit.InverseKelvin, inversekelvinQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            CoefficientOfThermalExpansion inversekelvin = CoefficientOfThermalExpansion.FromInverseKelvin(1);
            AssertEx.EqualTolerance(1, CoefficientOfThermalExpansion.FromInverseDegreeCelsius(inversekelvin.InverseDegreeCelsius).InverseKelvin, InverseDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(1, CoefficientOfThermalExpansion.FromInverseDegreeFahrenheit(inversekelvin.InverseDegreeFahrenheit).InverseKelvin, InverseDegreeFahrenheitTolerance);
            AssertEx.EqualTolerance(1, CoefficientOfThermalExpansion.FromInverseKelvin(inversekelvin.InverseKelvin).InverseKelvin, InverseKelvinTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            CoefficientOfThermalExpansion v = CoefficientOfThermalExpansion.FromInverseKelvin(1);
            AssertEx.EqualTolerance(-1, -v.InverseKelvin, InverseKelvinTolerance);
            AssertEx.EqualTolerance(2, (CoefficientOfThermalExpansion.FromInverseKelvin(3)-v).InverseKelvin, InverseKelvinTolerance);
            AssertEx.EqualTolerance(2, (v + v).InverseKelvin, InverseKelvinTolerance);
            AssertEx.EqualTolerance(10, (v*10).InverseKelvin, InverseKelvinTolerance);
            AssertEx.EqualTolerance(10, (10*v).InverseKelvin, InverseKelvinTolerance);
            AssertEx.EqualTolerance(2, (CoefficientOfThermalExpansion.FromInverseKelvin(10)/5).InverseKelvin, InverseKelvinTolerance);
            AssertEx.EqualTolerance(2, CoefficientOfThermalExpansion.FromInverseKelvin(10)/CoefficientOfThermalExpansion.FromInverseKelvin(5), InverseKelvinTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            CoefficientOfThermalExpansion oneInverseKelvin = CoefficientOfThermalExpansion.FromInverseKelvin(1);
            CoefficientOfThermalExpansion twoInverseKelvin = CoefficientOfThermalExpansion.FromInverseKelvin(2);

            Assert.True(oneInverseKelvin < twoInverseKelvin);
            Assert.True(oneInverseKelvin <= twoInverseKelvin);
            Assert.True(twoInverseKelvin > oneInverseKelvin);
            Assert.True(twoInverseKelvin >= oneInverseKelvin);

            Assert.False(oneInverseKelvin > twoInverseKelvin);
            Assert.False(oneInverseKelvin >= twoInverseKelvin);
            Assert.False(twoInverseKelvin < oneInverseKelvin);
            Assert.False(twoInverseKelvin <= oneInverseKelvin);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            CoefficientOfThermalExpansion inversekelvin = CoefficientOfThermalExpansion.FromInverseKelvin(1);
            Assert.Equal(0, inversekelvin.CompareTo(inversekelvin));
            Assert.True(inversekelvin.CompareTo(CoefficientOfThermalExpansion.Zero) > 0);
            Assert.True(CoefficientOfThermalExpansion.Zero.CompareTo(inversekelvin) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            CoefficientOfThermalExpansion inversekelvin = CoefficientOfThermalExpansion.FromInverseKelvin(1);
            Assert.Throws<ArgumentException>(() => inversekelvin.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            CoefficientOfThermalExpansion inversekelvin = CoefficientOfThermalExpansion.FromInverseKelvin(1);
            Assert.Throws<ArgumentNullException>(() => inversekelvin.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = CoefficientOfThermalExpansion.FromInverseKelvin(1);
            var b = CoefficientOfThermalExpansion.FromInverseKelvin(2);

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
            var a = CoefficientOfThermalExpansion.FromInverseKelvin(1);
            var b = CoefficientOfThermalExpansion.FromInverseKelvin(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = CoefficientOfThermalExpansion.FromInverseKelvin(1);
            Assert.True(v.Equals(CoefficientOfThermalExpansion.FromInverseKelvin(1), InverseKelvinTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(CoefficientOfThermalExpansion.Zero, InverseKelvinTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            CoefficientOfThermalExpansion inversekelvin = CoefficientOfThermalExpansion.FromInverseKelvin(1);
            Assert.False(inversekelvin.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            CoefficientOfThermalExpansion inversekelvin = CoefficientOfThermalExpansion.FromInverseKelvin(1);
            Assert.False(inversekelvin.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(CoefficientOfThermalExpansionUnit.Undefined, CoefficientOfThermalExpansion.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(CoefficientOfThermalExpansionUnit)).Cast<CoefficientOfThermalExpansionUnit>();
            foreach(var unit in units)
            {
                if(unit == CoefficientOfThermalExpansionUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(CoefficientOfThermalExpansion.BaseDimensions is null);
        }
    }
}
