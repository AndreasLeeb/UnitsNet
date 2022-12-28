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
    /// Test of PowerRatio.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class PowerRatioTestsBase : QuantityTestsBase
    {
        protected abstract double DecibelMilliwattsInOneDecibelWatt { get; }
        protected abstract double DecibelWattsInOneDecibelWatt { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DecibelMilliwattsTolerance { get { return 1e-5; } }
        protected virtual double DecibelWattsTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(PowerRatioUnit unit)
        {
            return unit switch
            {
                PowerRatioUnit.DecibelMilliwatt => (DecibelMilliwattsInOneDecibelWatt, DecibelMilliwattsTolerance),
                PowerRatioUnit.DecibelWatt => (DecibelWattsInOneDecibelWatt, DecibelWattsTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { PowerRatioUnit.DecibelMilliwatt },
            new object[] { PowerRatioUnit.DecibelWatt },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new PowerRatio();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(PowerRatioUnit.DecibelWatt, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new PowerRatio(double.PositiveInfinity, PowerRatioUnit.DecibelWatt));
            Assert.Throws<ArgumentException>(() => new PowerRatio(double.NegativeInfinity, PowerRatioUnit.DecibelWatt));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new PowerRatio(double.NaN, PowerRatioUnit.DecibelWatt));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new PowerRatio(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new PowerRatio(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (PowerRatio) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void PowerRatio_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new PowerRatio(1, PowerRatioUnit.DecibelWatt);

            QuantityInfo<PowerRatioUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(PowerRatio.Zero, quantityInfo.Zero);
            Assert.Equal("PowerRatio", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<PowerRatioUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void DecibelWattToPowerRatioUnits()
        {
            PowerRatio decibelwatt = PowerRatio.FromDecibelWatts(1);
            AssertEx.EqualTolerance(DecibelMilliwattsInOneDecibelWatt, decibelwatt.DecibelMilliwatts, DecibelMilliwattsTolerance);
            AssertEx.EqualTolerance(DecibelWattsInOneDecibelWatt, decibelwatt.DecibelWatts, DecibelWattsTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = PowerRatio.From(1, PowerRatioUnit.DecibelMilliwatt);
            AssertEx.EqualTolerance(1, quantity00.DecibelMilliwatts, DecibelMilliwattsTolerance);
            Assert.Equal(PowerRatioUnit.DecibelMilliwatt, quantity00.Unit);

            var quantity01 = PowerRatio.From(1, PowerRatioUnit.DecibelWatt);
            AssertEx.EqualTolerance(1, quantity01.DecibelWatts, DecibelWattsTolerance);
            Assert.Equal(PowerRatioUnit.DecibelWatt, quantity01.Unit);

        }

        [Fact]
        public void FromDecibelWatts_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => PowerRatio.FromDecibelWatts(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => PowerRatio.FromDecibelWatts(double.NegativeInfinity));
        }

        [Fact]
        public void FromDecibelWatts_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => PowerRatio.FromDecibelWatts(double.NaN));
        }

        [Fact]
        public void As()
        {
            var decibelwatt = PowerRatio.FromDecibelWatts(1);
            AssertEx.EqualTolerance(DecibelMilliwattsInOneDecibelWatt, decibelwatt.As(PowerRatioUnit.DecibelMilliwatt), DecibelMilliwattsTolerance);
            AssertEx.EqualTolerance(DecibelWattsInOneDecibelWatt, decibelwatt.As(PowerRatioUnit.DecibelWatt), DecibelWattsTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new PowerRatio(value: 1, unit: PowerRatio.BaseUnit);
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
                var parsed = PowerRatio.Parse("1 dBmW", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.DecibelMilliwatts, DecibelMilliwattsTolerance);
                Assert.Equal(PowerRatioUnit.DecibelMilliwatt, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = PowerRatio.Parse("1 dBm", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.DecibelMilliwatts, DecibelMilliwattsTolerance);
                Assert.Equal(PowerRatioUnit.DecibelMilliwatt, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = PowerRatio.Parse("1 dBW", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.DecibelWatts, DecibelWattsTolerance);
                Assert.Equal(PowerRatioUnit.DecibelWatt, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(PowerRatio.TryParse("1 dBmW", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.DecibelMilliwatts, DecibelMilliwattsTolerance);
                Assert.Equal(PowerRatioUnit.DecibelMilliwatt, parsed.Unit);
            }

            {
                Assert.True(PowerRatio.TryParse("1 dBm", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.DecibelMilliwatts, DecibelMilliwattsTolerance);
                Assert.Equal(PowerRatioUnit.DecibelMilliwatt, parsed.Unit);
            }

            {
                Assert.True(PowerRatio.TryParse("1 dBW", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.DecibelWatts, DecibelWattsTolerance);
                Assert.Equal(PowerRatioUnit.DecibelWatt, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = PowerRatio.ParseUnit("dBmW", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(PowerRatioUnit.DecibelMilliwatt, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = PowerRatio.ParseUnit("dBm", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(PowerRatioUnit.DecibelMilliwatt, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = PowerRatio.ParseUnit("dBW", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(PowerRatioUnit.DecibelWatt, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(PowerRatio.TryParseUnit("dBmW", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(PowerRatioUnit.DecibelMilliwatt, parsedUnit);
            }

            {
                Assert.True(PowerRatio.TryParseUnit("dBm", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(PowerRatioUnit.DecibelMilliwatt, parsedUnit);
            }

            {
                Assert.True(PowerRatio.TryParseUnit("dBW", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(PowerRatioUnit.DecibelWatt, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(PowerRatioUnit unit)
        {
            var inBaseUnits = PowerRatio.From(1.0, PowerRatio.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(PowerRatioUnit unit)
        {
            var quantity = PowerRatio.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(PowerRatioUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = PowerRatio.Units.First(u => u != PowerRatio.BaseUnit);

            var quantity = PowerRatio.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(PowerRatioUnit unit)
        {
            var quantity = default(PowerRatio);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            PowerRatio decibelwatt = PowerRatio.FromDecibelWatts(1);
            AssertEx.EqualTolerance(1, PowerRatio.FromDecibelMilliwatts(decibelwatt.DecibelMilliwatts).DecibelWatts, DecibelMilliwattsTolerance);
            AssertEx.EqualTolerance(1, PowerRatio.FromDecibelWatts(decibelwatt.DecibelWatts).DecibelWatts, DecibelWattsTolerance);
        }

        [Fact]
        public void LogarithmicArithmeticOperators()
        {
            PowerRatio v = PowerRatio.FromDecibelWatts(40);
            AssertEx.EqualTolerance(-40, -v.DecibelWatts, DecibelWattsTolerance);
            AssertLogarithmicAddition();
            AssertLogarithmicSubtraction();
            AssertEx.EqualTolerance(50, (v*10).DecibelWatts, DecibelWattsTolerance);
            AssertEx.EqualTolerance(50, (10*v).DecibelWatts, DecibelWattsTolerance);
            AssertEx.EqualTolerance(35, (v/5).DecibelWatts, DecibelWattsTolerance);
            AssertEx.EqualTolerance(35, v/PowerRatio.FromDecibelWatts(5), DecibelWattsTolerance);
        }

        protected abstract void AssertLogarithmicAddition();

        protected abstract void AssertLogarithmicSubtraction();

        [Fact]
        public void ComparisonOperators()
        {
            PowerRatio oneDecibelWatt = PowerRatio.FromDecibelWatts(1);
            PowerRatio twoDecibelWatts = PowerRatio.FromDecibelWatts(2);

            Assert.True(oneDecibelWatt < twoDecibelWatts);
            Assert.True(oneDecibelWatt <= twoDecibelWatts);
            Assert.True(twoDecibelWatts > oneDecibelWatt);
            Assert.True(twoDecibelWatts >= oneDecibelWatt);

            Assert.False(oneDecibelWatt > twoDecibelWatts);
            Assert.False(oneDecibelWatt >= twoDecibelWatts);
            Assert.False(twoDecibelWatts < oneDecibelWatt);
            Assert.False(twoDecibelWatts <= oneDecibelWatt);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            PowerRatio decibelwatt = PowerRatio.FromDecibelWatts(1);
            Assert.Equal(0, decibelwatt.CompareTo(decibelwatt));
            Assert.True(decibelwatt.CompareTo(PowerRatio.Zero) > 0);
            Assert.True(PowerRatio.Zero.CompareTo(decibelwatt) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            PowerRatio decibelwatt = PowerRatio.FromDecibelWatts(1);
            Assert.Throws<ArgumentException>(() => decibelwatt.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            PowerRatio decibelwatt = PowerRatio.FromDecibelWatts(1);
            Assert.Throws<ArgumentNullException>(() => decibelwatt.CompareTo(null));
        }

        [Theory]
        [InlineData(1, PowerRatioUnit.DecibelWatt, 1, PowerRatioUnit.DecibelWatt, true)]  // Same value and unit.
        [InlineData(1, PowerRatioUnit.DecibelWatt, 2, PowerRatioUnit.DecibelWatt, false)] // Different value.
        [InlineData(2, PowerRatioUnit.DecibelWatt, 1, PowerRatioUnit.DecibelMilliwatt, false)] // Different value and unit.
        [InlineData(1, PowerRatioUnit.DecibelWatt, 1, PowerRatioUnit.DecibelMilliwatt, false)] // Different unit.
        public void Equals_ReturnsTrue_IfValueAndUnitAreEqual(double valueA, PowerRatioUnit unitA, double valueB, PowerRatioUnit unitB, bool expectEqual)
        {
            var a = new PowerRatio(valueA, unitA);
            var b = new PowerRatio(valueB, unitB);

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
            var a = PowerRatio.Zero;

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
            var v = PowerRatio.FromDecibelWatts(1);
            Assert.True(v.Equals(PowerRatio.FromDecibelWatts(1), DecibelWattsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(PowerRatio.Zero, DecibelWattsTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = PowerRatio.FromDecibelWatts(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(PowerRatio.FromDecibelWatts(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            PowerRatio decibelwatt = PowerRatio.FromDecibelWatts(1);
            Assert.False(decibelwatt.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            PowerRatio decibelwatt = PowerRatio.FromDecibelWatts(1);
            Assert.False(decibelwatt.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(PowerRatioUnit)).Cast<PowerRatioUnit>();
            foreach (var unit in units)
            {
                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(PowerRatio.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 dBmW", new PowerRatio(1, PowerRatioUnit.DecibelMilliwatt).ToString());
                Assert.Equal("1 dBW", new PowerRatio(1, PowerRatioUnit.DecibelWatt).ToString());
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

            Assert.Equal("1 dBmW", new PowerRatio(1, PowerRatioUnit.DecibelMilliwatt).ToString(swedishCulture));
            Assert.Equal("1 dBW", new PowerRatio(1, PowerRatioUnit.DecibelWatt).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 dBW", new PowerRatio(0.123456, PowerRatioUnit.DecibelWatt).ToString("s1"));
                Assert.Equal("0.12 dBW", new PowerRatio(0.123456, PowerRatioUnit.DecibelWatt).ToString("s2"));
                Assert.Equal("0.123 dBW", new PowerRatio(0.123456, PowerRatioUnit.DecibelWatt).ToString("s3"));
                Assert.Equal("0.1235 dBW", new PowerRatio(0.123456, PowerRatioUnit.DecibelWatt).ToString("s4"));
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
            Assert.Equal("0.1 dBW", new PowerRatio(0.123456, PowerRatioUnit.DecibelWatt).ToString("s1", culture));
            Assert.Equal("0.12 dBW", new PowerRatio(0.123456, PowerRatioUnit.DecibelWatt).ToString("s2", culture));
            Assert.Equal("0.123 dBW", new PowerRatio(0.123456, PowerRatioUnit.DecibelWatt).ToString("s3", culture));
            Assert.Equal("0.1235 dBW", new PowerRatio(0.123456, PowerRatioUnit.DecibelWatt).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = PowerRatio.FromDecibelWatts(1.0);
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
            var quantity = PowerRatio.FromDecibelWatts(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = PowerRatio.FromDecibelWatts(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = PowerRatio.FromDecibelWatts(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = PowerRatio.FromDecibelWatts(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = PowerRatio.FromDecibelWatts(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = PowerRatio.FromDecibelWatts(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = PowerRatio.FromDecibelWatts(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = PowerRatio.FromDecibelWatts(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = PowerRatio.FromDecibelWatts(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = PowerRatio.FromDecibelWatts(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = PowerRatio.FromDecibelWatts(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = PowerRatio.FromDecibelWatts(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = PowerRatio.FromDecibelWatts(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = PowerRatio.FromDecibelWatts(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = PowerRatio.FromDecibelWatts(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = PowerRatio.FromDecibelWatts(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = PowerRatio.FromDecibelWatts(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(PowerRatio)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = PowerRatio.FromDecibelWatts(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(PowerRatioUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = PowerRatio.FromDecibelWatts(1.0);
            Assert.Equal(PowerRatio.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = PowerRatio.FromDecibelWatts(1.0);
            Assert.Equal(PowerRatio.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = PowerRatio.FromDecibelWatts(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = PowerRatio.FromDecibelWatts(1.0);
            Assert.Equal(new {PowerRatio.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = PowerRatio.FromDecibelWatts(value);
            Assert.Equal(PowerRatio.FromDecibelWatts(-value), -quantity);
        }
    }
}
