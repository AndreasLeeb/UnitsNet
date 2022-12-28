//------------------------------------------------------------------------------
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
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Tests.TestsBase;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ApparentEnergy.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ApparentEnergyTestsBase : QuantityTestsBase
    {
        protected abstract double KilovoltampereHoursInOneVoltampereHour { get; }
        protected abstract double MegavoltampereHoursInOneVoltampereHour { get; }
        protected abstract double VoltampereHoursInOneVoltampereHour { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KilovoltampereHoursTolerance { get { return 1e-5; } }
        protected virtual double MegavoltampereHoursTolerance { get { return 1e-5; } }
        protected virtual double VoltampereHoursTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(ApparentEnergyUnit unit)
        {
            return unit switch
            {
                ApparentEnergyUnit.KilovoltampereHour => (KilovoltampereHoursInOneVoltampereHour, KilovoltampereHoursTolerance),
                ApparentEnergyUnit.MegavoltampereHour => (MegavoltampereHoursInOneVoltampereHour, MegavoltampereHoursTolerance),
                ApparentEnergyUnit.VoltampereHour => (VoltampereHoursInOneVoltampereHour, VoltampereHoursTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { ApparentEnergyUnit.KilovoltampereHour },
            new object[] { ApparentEnergyUnit.MegavoltampereHour },
            new object[] { ApparentEnergyUnit.VoltampereHour },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new ApparentEnergy();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ApparentEnergyUnit.VoltampereHour, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ApparentEnergy(double.PositiveInfinity, ApparentEnergyUnit.VoltampereHour));
            Assert.Throws<ArgumentException>(() => new ApparentEnergy(double.NegativeInfinity, ApparentEnergyUnit.VoltampereHour));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ApparentEnergy(double.NaN, ApparentEnergyUnit.VoltampereHour));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ApparentEnergy(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new ApparentEnergy(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (ApparentEnergy) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void ApparentEnergy_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new ApparentEnergy(1, ApparentEnergyUnit.VoltampereHour);

            QuantityInfo<ApparentEnergyUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(ApparentEnergy.Zero, quantityInfo.Zero);
            Assert.Equal("ApparentEnergy", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<ApparentEnergyUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void VoltampereHourToApparentEnergyUnits()
        {
            ApparentEnergy voltamperehour = ApparentEnergy.FromVoltampereHours(1);
            AssertEx.EqualTolerance(KilovoltampereHoursInOneVoltampereHour, voltamperehour.KilovoltampereHours, KilovoltampereHoursTolerance);
            AssertEx.EqualTolerance(MegavoltampereHoursInOneVoltampereHour, voltamperehour.MegavoltampereHours, MegavoltampereHoursTolerance);
            AssertEx.EqualTolerance(VoltampereHoursInOneVoltampereHour, voltamperehour.VoltampereHours, VoltampereHoursTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = ApparentEnergy.From(1, ApparentEnergyUnit.KilovoltampereHour);
            AssertEx.EqualTolerance(1, quantity00.KilovoltampereHours, KilovoltampereHoursTolerance);
            Assert.Equal(ApparentEnergyUnit.KilovoltampereHour, quantity00.Unit);

            var quantity01 = ApparentEnergy.From(1, ApparentEnergyUnit.MegavoltampereHour);
            AssertEx.EqualTolerance(1, quantity01.MegavoltampereHours, MegavoltampereHoursTolerance);
            Assert.Equal(ApparentEnergyUnit.MegavoltampereHour, quantity01.Unit);

            var quantity02 = ApparentEnergy.From(1, ApparentEnergyUnit.VoltampereHour);
            AssertEx.EqualTolerance(1, quantity02.VoltampereHours, VoltampereHoursTolerance);
            Assert.Equal(ApparentEnergyUnit.VoltampereHour, quantity02.Unit);

        }

        [Fact]
        public void FromVoltampereHours_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ApparentEnergy.FromVoltampereHours(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ApparentEnergy.FromVoltampereHours(double.NegativeInfinity));
        }

        [Fact]
        public void FromVoltampereHours_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ApparentEnergy.FromVoltampereHours(double.NaN));
        }

        [Fact]
        public void As()
        {
            var voltamperehour = ApparentEnergy.FromVoltampereHours(1);
            AssertEx.EqualTolerance(KilovoltampereHoursInOneVoltampereHour, voltamperehour.As(ApparentEnergyUnit.KilovoltampereHour), KilovoltampereHoursTolerance);
            AssertEx.EqualTolerance(MegavoltampereHoursInOneVoltampereHour, voltamperehour.As(ApparentEnergyUnit.MegavoltampereHour), MegavoltampereHoursTolerance);
            AssertEx.EqualTolerance(VoltampereHoursInOneVoltampereHour, voltamperehour.As(ApparentEnergyUnit.VoltampereHour), VoltampereHoursTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new ApparentEnergy(value: 1, unit: ApparentEnergy.BaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = (double) AsWithSIUnitSystem();
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
        }

        [Fact]
        public void Parse()
        {
            try
            {
                var parsed = ApparentEnergy.Parse("1 kVAh", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.KilovoltampereHours, KilovoltampereHoursTolerance);
                Assert.Equal(ApparentEnergyUnit.KilovoltampereHour, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ApparentEnergy.Parse("1 MVAh", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.MegavoltampereHours, MegavoltampereHoursTolerance);
                Assert.Equal(ApparentEnergyUnit.MegavoltampereHour, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ApparentEnergy.Parse("1 VAh", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.VoltampereHours, VoltampereHoursTolerance);
                Assert.Equal(ApparentEnergyUnit.VoltampereHour, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(ApparentEnergy.TryParse("1 kVAh", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.KilovoltampereHours, KilovoltampereHoursTolerance);
                Assert.Equal(ApparentEnergyUnit.KilovoltampereHour, parsed.Unit);
            }

            {
                Assert.True(ApparentEnergy.TryParse("1 MVAh", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.MegavoltampereHours, MegavoltampereHoursTolerance);
                Assert.Equal(ApparentEnergyUnit.MegavoltampereHour, parsed.Unit);
            }

            {
                Assert.True(ApparentEnergy.TryParse("1 VAh", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.VoltampereHours, VoltampereHoursTolerance);
                Assert.Equal(ApparentEnergyUnit.VoltampereHour, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = ApparentEnergy.ParseUnit("kVAh", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ApparentEnergyUnit.KilovoltampereHour, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ApparentEnergy.ParseUnit("MVAh", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ApparentEnergyUnit.MegavoltampereHour, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ApparentEnergy.ParseUnit("VAh", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ApparentEnergyUnit.VoltampereHour, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(ApparentEnergy.TryParseUnit("kVAh", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ApparentEnergyUnit.KilovoltampereHour, parsedUnit);
            }

            {
                Assert.True(ApparentEnergy.TryParseUnit("MVAh", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ApparentEnergyUnit.MegavoltampereHour, parsedUnit);
            }

            {
                Assert.True(ApparentEnergy.TryParseUnit("VAh", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ApparentEnergyUnit.VoltampereHour, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(ApparentEnergyUnit unit)
        {
            var inBaseUnits = ApparentEnergy.From(1.0, ApparentEnergy.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(ApparentEnergyUnit unit)
        {
            var quantity = ApparentEnergy.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(ApparentEnergyUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = ApparentEnergy.Units.First(u => u != ApparentEnergy.BaseUnit);

            var quantity = ApparentEnergy.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(ApparentEnergyUnit unit)
        {
            var quantity = default(ApparentEnergy);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ApparentEnergy voltamperehour = ApparentEnergy.FromVoltampereHours(1);
            AssertEx.EqualTolerance(1, ApparentEnergy.FromKilovoltampereHours(voltamperehour.KilovoltampereHours).VoltampereHours, KilovoltampereHoursTolerance);
            AssertEx.EqualTolerance(1, ApparentEnergy.FromMegavoltampereHours(voltamperehour.MegavoltampereHours).VoltampereHours, MegavoltampereHoursTolerance);
            AssertEx.EqualTolerance(1, ApparentEnergy.FromVoltampereHours(voltamperehour.VoltampereHours).VoltampereHours, VoltampereHoursTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ApparentEnergy v = ApparentEnergy.FromVoltampereHours(1);
            AssertEx.EqualTolerance(-1, -v.VoltampereHours, VoltampereHoursTolerance);
            AssertEx.EqualTolerance(2, (ApparentEnergy.FromVoltampereHours(3)-v).VoltampereHours, VoltampereHoursTolerance);
            AssertEx.EqualTolerance(2, (v + v).VoltampereHours, VoltampereHoursTolerance);
            AssertEx.EqualTolerance(10, (v*10).VoltampereHours, VoltampereHoursTolerance);
            AssertEx.EqualTolerance(10, (10*v).VoltampereHours, VoltampereHoursTolerance);
            AssertEx.EqualTolerance(2, (ApparentEnergy.FromVoltampereHours(10)/5).VoltampereHours, VoltampereHoursTolerance);
            AssertEx.EqualTolerance(2, ApparentEnergy.FromVoltampereHours(10)/ApparentEnergy.FromVoltampereHours(5), VoltampereHoursTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ApparentEnergy oneVoltampereHour = ApparentEnergy.FromVoltampereHours(1);
            ApparentEnergy twoVoltampereHours = ApparentEnergy.FromVoltampereHours(2);

            Assert.True(oneVoltampereHour < twoVoltampereHours);
            Assert.True(oneVoltampereHour <= twoVoltampereHours);
            Assert.True(twoVoltampereHours > oneVoltampereHour);
            Assert.True(twoVoltampereHours >= oneVoltampereHour);

            Assert.False(oneVoltampereHour > twoVoltampereHours);
            Assert.False(oneVoltampereHour >= twoVoltampereHours);
            Assert.False(twoVoltampereHours < oneVoltampereHour);
            Assert.False(twoVoltampereHours <= oneVoltampereHour);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ApparentEnergy voltamperehour = ApparentEnergy.FromVoltampereHours(1);
            Assert.Equal(0, voltamperehour.CompareTo(voltamperehour));
            Assert.True(voltamperehour.CompareTo(ApparentEnergy.Zero) > 0);
            Assert.True(ApparentEnergy.Zero.CompareTo(voltamperehour) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ApparentEnergy voltamperehour = ApparentEnergy.FromVoltampereHours(1);
            Assert.Throws<ArgumentException>(() => voltamperehour.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ApparentEnergy voltamperehour = ApparentEnergy.FromVoltampereHours(1);
            Assert.Throws<ArgumentNullException>(() => voltamperehour.CompareTo(null));
        }

        [Theory]
        [InlineData(1, ApparentEnergyUnit.VoltampereHour, 1, ApparentEnergyUnit.VoltampereHour, true)]  // Same value and unit.
        [InlineData(1, ApparentEnergyUnit.VoltampereHour, 2, ApparentEnergyUnit.VoltampereHour, false)] // Different value.
        [InlineData(2, ApparentEnergyUnit.VoltampereHour, 1, ApparentEnergyUnit.KilovoltampereHour, false)] // Different value and unit.
        [InlineData(1, ApparentEnergyUnit.VoltampereHour, 1, ApparentEnergyUnit.KilovoltampereHour, false)] // Different unit.
        public void Equals_ReturnsTrue_IfValueAndUnitAreEqual(double valueA, ApparentEnergyUnit unitA, double valueB, ApparentEnergyUnit unitB, bool expectEqual)
        {
            var a = new ApparentEnergy(valueA, unitA);
            var b = new ApparentEnergy(valueB, unitB);

            // Operator overloads.
            Assert.Equal(expectEqual, a == b);
            Assert.Equal(expectEqual, b == a);
            Assert.Equal(!expectEqual, a != b);
            Assert.Equal(!expectEqual, b != a);

            // IEquatable<T>
            Assert.Equal(expectEqual, a.Equals(b));
            Assert.Equal(expectEqual, b.Equals(a));

            // IEquatable
            Assert.Equal(expectEqual, a.Equals((object)b));
            Assert.Equal(expectEqual, b.Equals((object)a));
        }

        [Fact]
        public void Equals_Null_ReturnsFalse()
        {
            var a = ApparentEnergy.Zero;

            Assert.False(a.Equals((object)null));

            // "The result of the expression is always 'false'..."
            #pragma warning disable CS8073
            Assert.False(a == null);
            Assert.False(null == a);
            Assert.True(a != null);
            Assert.True(null != a);
            #pragma warning restore CS8073
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = ApparentEnergy.FromVoltampereHours(1);
            Assert.True(v.Equals(ApparentEnergy.FromVoltampereHours(1), VoltampereHoursTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ApparentEnergy.Zero, VoltampereHoursTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = ApparentEnergy.FromVoltampereHours(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(ApparentEnergy.FromVoltampereHours(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ApparentEnergy voltamperehour = ApparentEnergy.FromVoltampereHours(1);
            Assert.False(voltamperehour.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ApparentEnergy voltamperehour = ApparentEnergy.FromVoltampereHours(1);
            Assert.False(voltamperehour.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ApparentEnergyUnit)).Cast<ApparentEnergyUnit>();
            foreach (var unit in units)
            {
                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ApparentEnergy.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 kVAh", new ApparentEnergy(1, ApparentEnergyUnit.KilovoltampereHour).ToString());
                Assert.Equal("1 MVAh", new ApparentEnergy(1, ApparentEnergyUnit.MegavoltampereHour).ToString());
                Assert.Equal("1 VAh", new ApparentEnergy(1, ApparentEnergyUnit.VoltampereHour).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentCulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 kVAh", new ApparentEnergy(1, ApparentEnergyUnit.KilovoltampereHour).ToString(swedishCulture));
            Assert.Equal("1 MVAh", new ApparentEnergy(1, ApparentEnergyUnit.MegavoltampereHour).ToString(swedishCulture));
            Assert.Equal("1 VAh", new ApparentEnergy(1, ApparentEnergyUnit.VoltampereHour).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 VAh", new ApparentEnergy(0.123456, ApparentEnergyUnit.VoltampereHour).ToString("s1"));
                Assert.Equal("0.12 VAh", new ApparentEnergy(0.123456, ApparentEnergyUnit.VoltampereHour).ToString("s2"));
                Assert.Equal("0.123 VAh", new ApparentEnergy(0.123456, ApparentEnergyUnit.VoltampereHour).ToString("s3"));
                Assert.Equal("0.1235 VAh", new ApparentEnergy(0.123456, ApparentEnergyUnit.VoltampereHour).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentCulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 VAh", new ApparentEnergy(0.123456, ApparentEnergyUnit.VoltampereHour).ToString("s1", culture));
            Assert.Equal("0.12 VAh", new ApparentEnergy(0.123456, ApparentEnergyUnit.VoltampereHour).ToString("s2", culture));
            Assert.Equal("0.123 VAh", new ApparentEnergy(0.123456, ApparentEnergyUnit.VoltampereHour).ToString("s3", culture));
            Assert.Equal("0.1235 VAh", new ApparentEnergy(0.123456, ApparentEnergyUnit.VoltampereHour).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = ApparentEnergy.FromVoltampereHours(1.0);
            CultureInfo formatProvider = cultureName == null
                ? null
                : CultureInfo.GetCultureInfo(cultureName);

            Assert.Equal(quantity.ToString("g", formatProvider), quantity.ToString(null, formatProvider));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("g")]
        public void ToString_NullProvider_EqualsCurrentCulture(string format)
        {
            var quantity = ApparentEnergy.FromVoltampereHours(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = ApparentEnergy.FromVoltampereHours(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = ApparentEnergy.FromVoltampereHours(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = ApparentEnergy.FromVoltampereHours(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = ApparentEnergy.FromVoltampereHours(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = ApparentEnergy.FromVoltampereHours(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = ApparentEnergy.FromVoltampereHours(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = ApparentEnergy.FromVoltampereHours(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = ApparentEnergy.FromVoltampereHours(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = ApparentEnergy.FromVoltampereHours(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = ApparentEnergy.FromVoltampereHours(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = ApparentEnergy.FromVoltampereHours(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = ApparentEnergy.FromVoltampereHours(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = ApparentEnergy.FromVoltampereHours(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = ApparentEnergy.FromVoltampereHours(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = ApparentEnergy.FromVoltampereHours(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = ApparentEnergy.FromVoltampereHours(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(ApparentEnergy)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = ApparentEnergy.FromVoltampereHours(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(ApparentEnergyUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = ApparentEnergy.FromVoltampereHours(1.0);
            Assert.Equal(ApparentEnergy.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = ApparentEnergy.FromVoltampereHours(1.0);
            Assert.Equal(ApparentEnergy.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = ApparentEnergy.FromVoltampereHours(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = ApparentEnergy.FromVoltampereHours(1.0);
            Assert.Equal(new {ApparentEnergy.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = ApparentEnergy.FromVoltampereHours(value);
            Assert.Equal(ApparentEnergy.FromVoltampereHours(-value), -quantity);
        }
    }
}
