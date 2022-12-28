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
    /// Test of Entropy.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class EntropyTestsBase : QuantityTestsBase
    {
        protected abstract double CaloriesPerKelvinInOneJoulePerKelvin { get; }
        protected abstract double JoulesPerDegreeCelsiusInOneJoulePerKelvin { get; }
        protected abstract double JoulesPerKelvinInOneJoulePerKelvin { get; }
        protected abstract double KilocaloriesPerKelvinInOneJoulePerKelvin { get; }
        protected abstract double KilojoulesPerDegreeCelsiusInOneJoulePerKelvin { get; }
        protected abstract double KilojoulesPerKelvinInOneJoulePerKelvin { get; }
        protected abstract double MegajoulesPerKelvinInOneJoulePerKelvin { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CaloriesPerKelvinTolerance { get { return 1e-5; } }
        protected virtual double JoulesPerDegreeCelsiusTolerance { get { return 1e-5; } }
        protected virtual double JoulesPerKelvinTolerance { get { return 1e-5; } }
        protected virtual double KilocaloriesPerKelvinTolerance { get { return 1e-5; } }
        protected virtual double KilojoulesPerDegreeCelsiusTolerance { get { return 1e-5; } }
        protected virtual double KilojoulesPerKelvinTolerance { get { return 1e-5; } }
        protected virtual double MegajoulesPerKelvinTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(EntropyUnit unit)
        {
            return unit switch
            {
                EntropyUnit.CaloriePerKelvin => (CaloriesPerKelvinInOneJoulePerKelvin, CaloriesPerKelvinTolerance),
                EntropyUnit.JoulePerDegreeCelsius => (JoulesPerDegreeCelsiusInOneJoulePerKelvin, JoulesPerDegreeCelsiusTolerance),
                EntropyUnit.JoulePerKelvin => (JoulesPerKelvinInOneJoulePerKelvin, JoulesPerKelvinTolerance),
                EntropyUnit.KilocaloriePerKelvin => (KilocaloriesPerKelvinInOneJoulePerKelvin, KilocaloriesPerKelvinTolerance),
                EntropyUnit.KilojoulePerDegreeCelsius => (KilojoulesPerDegreeCelsiusInOneJoulePerKelvin, KilojoulesPerDegreeCelsiusTolerance),
                EntropyUnit.KilojoulePerKelvin => (KilojoulesPerKelvinInOneJoulePerKelvin, KilojoulesPerKelvinTolerance),
                EntropyUnit.MegajoulePerKelvin => (MegajoulesPerKelvinInOneJoulePerKelvin, MegajoulesPerKelvinTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { EntropyUnit.CaloriePerKelvin },
            new object[] { EntropyUnit.JoulePerDegreeCelsius },
            new object[] { EntropyUnit.JoulePerKelvin },
            new object[] { EntropyUnit.KilocaloriePerKelvin },
            new object[] { EntropyUnit.KilojoulePerDegreeCelsius },
            new object[] { EntropyUnit.KilojoulePerKelvin },
            new object[] { EntropyUnit.MegajoulePerKelvin },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new Entropy();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(EntropyUnit.JoulePerKelvin, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Entropy(double.PositiveInfinity, EntropyUnit.JoulePerKelvin));
            Assert.Throws<ArgumentException>(() => new Entropy(double.NegativeInfinity, EntropyUnit.JoulePerKelvin));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Entropy(double.NaN, EntropyUnit.JoulePerKelvin));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Entropy(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new Entropy(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (Entropy) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void Entropy_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new Entropy(1, EntropyUnit.JoulePerKelvin);

            QuantityInfo<EntropyUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(Entropy.Zero, quantityInfo.Zero);
            Assert.Equal("Entropy", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<EntropyUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void JoulePerKelvinToEntropyUnits()
        {
            Entropy jouleperkelvin = Entropy.FromJoulesPerKelvin(1);
            AssertEx.EqualTolerance(CaloriesPerKelvinInOneJoulePerKelvin, jouleperkelvin.CaloriesPerKelvin, CaloriesPerKelvinTolerance);
            AssertEx.EqualTolerance(JoulesPerDegreeCelsiusInOneJoulePerKelvin, jouleperkelvin.JoulesPerDegreeCelsius, JoulesPerDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(JoulesPerKelvinInOneJoulePerKelvin, jouleperkelvin.JoulesPerKelvin, JoulesPerKelvinTolerance);
            AssertEx.EqualTolerance(KilocaloriesPerKelvinInOneJoulePerKelvin, jouleperkelvin.KilocaloriesPerKelvin, KilocaloriesPerKelvinTolerance);
            AssertEx.EqualTolerance(KilojoulesPerDegreeCelsiusInOneJoulePerKelvin, jouleperkelvin.KilojoulesPerDegreeCelsius, KilojoulesPerDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(KilojoulesPerKelvinInOneJoulePerKelvin, jouleperkelvin.KilojoulesPerKelvin, KilojoulesPerKelvinTolerance);
            AssertEx.EqualTolerance(MegajoulesPerKelvinInOneJoulePerKelvin, jouleperkelvin.MegajoulesPerKelvin, MegajoulesPerKelvinTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = Entropy.From(1, EntropyUnit.CaloriePerKelvin);
            AssertEx.EqualTolerance(1, quantity00.CaloriesPerKelvin, CaloriesPerKelvinTolerance);
            Assert.Equal(EntropyUnit.CaloriePerKelvin, quantity00.Unit);

            var quantity01 = Entropy.From(1, EntropyUnit.JoulePerDegreeCelsius);
            AssertEx.EqualTolerance(1, quantity01.JoulesPerDegreeCelsius, JoulesPerDegreeCelsiusTolerance);
            Assert.Equal(EntropyUnit.JoulePerDegreeCelsius, quantity01.Unit);

            var quantity02 = Entropy.From(1, EntropyUnit.JoulePerKelvin);
            AssertEx.EqualTolerance(1, quantity02.JoulesPerKelvin, JoulesPerKelvinTolerance);
            Assert.Equal(EntropyUnit.JoulePerKelvin, quantity02.Unit);

            var quantity03 = Entropy.From(1, EntropyUnit.KilocaloriePerKelvin);
            AssertEx.EqualTolerance(1, quantity03.KilocaloriesPerKelvin, KilocaloriesPerKelvinTolerance);
            Assert.Equal(EntropyUnit.KilocaloriePerKelvin, quantity03.Unit);

            var quantity04 = Entropy.From(1, EntropyUnit.KilojoulePerDegreeCelsius);
            AssertEx.EqualTolerance(1, quantity04.KilojoulesPerDegreeCelsius, KilojoulesPerDegreeCelsiusTolerance);
            Assert.Equal(EntropyUnit.KilojoulePerDegreeCelsius, quantity04.Unit);

            var quantity05 = Entropy.From(1, EntropyUnit.KilojoulePerKelvin);
            AssertEx.EqualTolerance(1, quantity05.KilojoulesPerKelvin, KilojoulesPerKelvinTolerance);
            Assert.Equal(EntropyUnit.KilojoulePerKelvin, quantity05.Unit);

            var quantity06 = Entropy.From(1, EntropyUnit.MegajoulePerKelvin);
            AssertEx.EqualTolerance(1, quantity06.MegajoulesPerKelvin, MegajoulesPerKelvinTolerance);
            Assert.Equal(EntropyUnit.MegajoulePerKelvin, quantity06.Unit);

        }

        [Fact]
        public void FromJoulesPerKelvin_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Entropy.FromJoulesPerKelvin(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => Entropy.FromJoulesPerKelvin(double.NegativeInfinity));
        }

        [Fact]
        public void FromJoulesPerKelvin_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Entropy.FromJoulesPerKelvin(double.NaN));
        }

        [Fact]
        public void As()
        {
            var jouleperkelvin = Entropy.FromJoulesPerKelvin(1);
            AssertEx.EqualTolerance(CaloriesPerKelvinInOneJoulePerKelvin, jouleperkelvin.As(EntropyUnit.CaloriePerKelvin), CaloriesPerKelvinTolerance);
            AssertEx.EqualTolerance(JoulesPerDegreeCelsiusInOneJoulePerKelvin, jouleperkelvin.As(EntropyUnit.JoulePerDegreeCelsius), JoulesPerDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(JoulesPerKelvinInOneJoulePerKelvin, jouleperkelvin.As(EntropyUnit.JoulePerKelvin), JoulesPerKelvinTolerance);
            AssertEx.EqualTolerance(KilocaloriesPerKelvinInOneJoulePerKelvin, jouleperkelvin.As(EntropyUnit.KilocaloriePerKelvin), KilocaloriesPerKelvinTolerance);
            AssertEx.EqualTolerance(KilojoulesPerDegreeCelsiusInOneJoulePerKelvin, jouleperkelvin.As(EntropyUnit.KilojoulePerDegreeCelsius), KilojoulesPerDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(KilojoulesPerKelvinInOneJoulePerKelvin, jouleperkelvin.As(EntropyUnit.KilojoulePerKelvin), KilojoulesPerKelvinTolerance);
            AssertEx.EqualTolerance(MegajoulesPerKelvinInOneJoulePerKelvin, jouleperkelvin.As(EntropyUnit.MegajoulePerKelvin), MegajoulesPerKelvinTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new Entropy(value: 1, unit: Entropy.BaseUnit);
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
                var parsed = Entropy.Parse("1 cal/K", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.CaloriesPerKelvin, CaloriesPerKelvinTolerance);
                Assert.Equal(EntropyUnit.CaloriePerKelvin, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = Entropy.Parse("1 J/C", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.JoulesPerDegreeCelsius, JoulesPerDegreeCelsiusTolerance);
                Assert.Equal(EntropyUnit.JoulePerDegreeCelsius, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = Entropy.Parse("1 J/K", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.JoulesPerKelvin, JoulesPerKelvinTolerance);
                Assert.Equal(EntropyUnit.JoulePerKelvin, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = Entropy.Parse("1 kcal/K", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.KilocaloriesPerKelvin, KilocaloriesPerKelvinTolerance);
                Assert.Equal(EntropyUnit.KilocaloriePerKelvin, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = Entropy.Parse("1 kJ/C", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.KilojoulesPerDegreeCelsius, KilojoulesPerDegreeCelsiusTolerance);
                Assert.Equal(EntropyUnit.KilojoulePerDegreeCelsius, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = Entropy.Parse("1 kJ/K", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.KilojoulesPerKelvin, KilojoulesPerKelvinTolerance);
                Assert.Equal(EntropyUnit.KilojoulePerKelvin, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = Entropy.Parse("1 MJ/K", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.MegajoulesPerKelvin, MegajoulesPerKelvinTolerance);
                Assert.Equal(EntropyUnit.MegajoulePerKelvin, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(Entropy.TryParse("1 cal/K", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.CaloriesPerKelvin, CaloriesPerKelvinTolerance);
                Assert.Equal(EntropyUnit.CaloriePerKelvin, parsed.Unit);
            }

            {
                Assert.True(Entropy.TryParse("1 J/C", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.JoulesPerDegreeCelsius, JoulesPerDegreeCelsiusTolerance);
                Assert.Equal(EntropyUnit.JoulePerDegreeCelsius, parsed.Unit);
            }

            {
                Assert.True(Entropy.TryParse("1 J/K", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.JoulesPerKelvin, JoulesPerKelvinTolerance);
                Assert.Equal(EntropyUnit.JoulePerKelvin, parsed.Unit);
            }

            {
                Assert.True(Entropy.TryParse("1 kcal/K", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.KilocaloriesPerKelvin, KilocaloriesPerKelvinTolerance);
                Assert.Equal(EntropyUnit.KilocaloriePerKelvin, parsed.Unit);
            }

            {
                Assert.True(Entropy.TryParse("1 kJ/C", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.KilojoulesPerDegreeCelsius, KilojoulesPerDegreeCelsiusTolerance);
                Assert.Equal(EntropyUnit.KilojoulePerDegreeCelsius, parsed.Unit);
            }

            {
                Assert.True(Entropy.TryParse("1 kJ/K", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.KilojoulesPerKelvin, KilojoulesPerKelvinTolerance);
                Assert.Equal(EntropyUnit.KilojoulePerKelvin, parsed.Unit);
            }

            {
                Assert.True(Entropy.TryParse("1 MJ/K", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.MegajoulesPerKelvin, MegajoulesPerKelvinTolerance);
                Assert.Equal(EntropyUnit.MegajoulePerKelvin, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = Entropy.ParseUnit("cal/K", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(EntropyUnit.CaloriePerKelvin, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = Entropy.ParseUnit("J/C", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(EntropyUnit.JoulePerDegreeCelsius, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = Entropy.ParseUnit("J/K", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(EntropyUnit.JoulePerKelvin, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = Entropy.ParseUnit("kcal/K", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(EntropyUnit.KilocaloriePerKelvin, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = Entropy.ParseUnit("kJ/C", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(EntropyUnit.KilojoulePerDegreeCelsius, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = Entropy.ParseUnit("kJ/K", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(EntropyUnit.KilojoulePerKelvin, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = Entropy.ParseUnit("MJ/K", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(EntropyUnit.MegajoulePerKelvin, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(Entropy.TryParseUnit("cal/K", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(EntropyUnit.CaloriePerKelvin, parsedUnit);
            }

            {
                Assert.True(Entropy.TryParseUnit("J/C", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(EntropyUnit.JoulePerDegreeCelsius, parsedUnit);
            }

            {
                Assert.True(Entropy.TryParseUnit("J/K", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(EntropyUnit.JoulePerKelvin, parsedUnit);
            }

            {
                Assert.True(Entropy.TryParseUnit("kcal/K", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(EntropyUnit.KilocaloriePerKelvin, parsedUnit);
            }

            {
                Assert.True(Entropy.TryParseUnit("kJ/C", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(EntropyUnit.KilojoulePerDegreeCelsius, parsedUnit);
            }

            {
                Assert.True(Entropy.TryParseUnit("kJ/K", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(EntropyUnit.KilojoulePerKelvin, parsedUnit);
            }

            {
                Assert.True(Entropy.TryParseUnit("MJ/K", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(EntropyUnit.MegajoulePerKelvin, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(EntropyUnit unit)
        {
            var inBaseUnits = Entropy.From(1.0, Entropy.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(EntropyUnit unit)
        {
            var quantity = Entropy.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(EntropyUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = Entropy.Units.First(u => u != Entropy.BaseUnit);

            var quantity = Entropy.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(EntropyUnit unit)
        {
            var quantity = default(Entropy);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Entropy jouleperkelvin = Entropy.FromJoulesPerKelvin(1);
            AssertEx.EqualTolerance(1, Entropy.FromCaloriesPerKelvin(jouleperkelvin.CaloriesPerKelvin).JoulesPerKelvin, CaloriesPerKelvinTolerance);
            AssertEx.EqualTolerance(1, Entropy.FromJoulesPerDegreeCelsius(jouleperkelvin.JoulesPerDegreeCelsius).JoulesPerKelvin, JoulesPerDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(1, Entropy.FromJoulesPerKelvin(jouleperkelvin.JoulesPerKelvin).JoulesPerKelvin, JoulesPerKelvinTolerance);
            AssertEx.EqualTolerance(1, Entropy.FromKilocaloriesPerKelvin(jouleperkelvin.KilocaloriesPerKelvin).JoulesPerKelvin, KilocaloriesPerKelvinTolerance);
            AssertEx.EqualTolerance(1, Entropy.FromKilojoulesPerDegreeCelsius(jouleperkelvin.KilojoulesPerDegreeCelsius).JoulesPerKelvin, KilojoulesPerDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(1, Entropy.FromKilojoulesPerKelvin(jouleperkelvin.KilojoulesPerKelvin).JoulesPerKelvin, KilojoulesPerKelvinTolerance);
            AssertEx.EqualTolerance(1, Entropy.FromMegajoulesPerKelvin(jouleperkelvin.MegajoulesPerKelvin).JoulesPerKelvin, MegajoulesPerKelvinTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Entropy v = Entropy.FromJoulesPerKelvin(1);
            AssertEx.EqualTolerance(-1, -v.JoulesPerKelvin, JoulesPerKelvinTolerance);
            AssertEx.EqualTolerance(2, (Entropy.FromJoulesPerKelvin(3)-v).JoulesPerKelvin, JoulesPerKelvinTolerance);
            AssertEx.EqualTolerance(2, (v + v).JoulesPerKelvin, JoulesPerKelvinTolerance);
            AssertEx.EqualTolerance(10, (v*10).JoulesPerKelvin, JoulesPerKelvinTolerance);
            AssertEx.EqualTolerance(10, (10*v).JoulesPerKelvin, JoulesPerKelvinTolerance);
            AssertEx.EqualTolerance(2, (Entropy.FromJoulesPerKelvin(10)/5).JoulesPerKelvin, JoulesPerKelvinTolerance);
            AssertEx.EqualTolerance(2, Entropy.FromJoulesPerKelvin(10)/Entropy.FromJoulesPerKelvin(5), JoulesPerKelvinTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Entropy oneJoulePerKelvin = Entropy.FromJoulesPerKelvin(1);
            Entropy twoJoulesPerKelvin = Entropy.FromJoulesPerKelvin(2);

            Assert.True(oneJoulePerKelvin < twoJoulesPerKelvin);
            Assert.True(oneJoulePerKelvin <= twoJoulesPerKelvin);
            Assert.True(twoJoulesPerKelvin > oneJoulePerKelvin);
            Assert.True(twoJoulesPerKelvin >= oneJoulePerKelvin);

            Assert.False(oneJoulePerKelvin > twoJoulesPerKelvin);
            Assert.False(oneJoulePerKelvin >= twoJoulesPerKelvin);
            Assert.False(twoJoulesPerKelvin < oneJoulePerKelvin);
            Assert.False(twoJoulesPerKelvin <= oneJoulePerKelvin);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Entropy jouleperkelvin = Entropy.FromJoulesPerKelvin(1);
            Assert.Equal(0, jouleperkelvin.CompareTo(jouleperkelvin));
            Assert.True(jouleperkelvin.CompareTo(Entropy.Zero) > 0);
            Assert.True(Entropy.Zero.CompareTo(jouleperkelvin) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Entropy jouleperkelvin = Entropy.FromJoulesPerKelvin(1);
            Assert.Throws<ArgumentException>(() => jouleperkelvin.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Entropy jouleperkelvin = Entropy.FromJoulesPerKelvin(1);
            Assert.Throws<ArgumentNullException>(() => jouleperkelvin.CompareTo(null));
        }

        [Theory]
        [InlineData(1, EntropyUnit.JoulePerKelvin, 1, EntropyUnit.JoulePerKelvin, true)]  // Same value and unit.
        [InlineData(1, EntropyUnit.JoulePerKelvin, 2, EntropyUnit.JoulePerKelvin, false)] // Different value.
        [InlineData(2, EntropyUnit.JoulePerKelvin, 1, EntropyUnit.CaloriePerKelvin, false)] // Different value and unit.
        [InlineData(1, EntropyUnit.JoulePerKelvin, 1, EntropyUnit.CaloriePerKelvin, false)] // Different unit.
        public void Equals_ReturnsTrue_IfValueAndUnitAreEqual(double valueA, EntropyUnit unitA, double valueB, EntropyUnit unitB, bool expectEqual)
        {
            var a = new Entropy(valueA, unitA);
            var b = new Entropy(valueB, unitB);

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
            var a = Entropy.Zero;

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
            var v = Entropy.FromJoulesPerKelvin(1);
            Assert.True(v.Equals(Entropy.FromJoulesPerKelvin(1), JoulesPerKelvinTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Entropy.Zero, JoulesPerKelvinTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = Entropy.FromJoulesPerKelvin(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(Entropy.FromJoulesPerKelvin(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Entropy jouleperkelvin = Entropy.FromJoulesPerKelvin(1);
            Assert.False(jouleperkelvin.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Entropy jouleperkelvin = Entropy.FromJoulesPerKelvin(1);
            Assert.False(jouleperkelvin.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(EntropyUnit)).Cast<EntropyUnit>();
            foreach (var unit in units)
            {
                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(Entropy.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 cal/K", new Entropy(1, EntropyUnit.CaloriePerKelvin).ToString());
                Assert.Equal("1 J/C", new Entropy(1, EntropyUnit.JoulePerDegreeCelsius).ToString());
                Assert.Equal("1 J/K", new Entropy(1, EntropyUnit.JoulePerKelvin).ToString());
                Assert.Equal("1 kcal/K", new Entropy(1, EntropyUnit.KilocaloriePerKelvin).ToString());
                Assert.Equal("1 kJ/C", new Entropy(1, EntropyUnit.KilojoulePerDegreeCelsius).ToString());
                Assert.Equal("1 kJ/K", new Entropy(1, EntropyUnit.KilojoulePerKelvin).ToString());
                Assert.Equal("1 MJ/K", new Entropy(1, EntropyUnit.MegajoulePerKelvin).ToString());
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

            Assert.Equal("1 cal/K", new Entropy(1, EntropyUnit.CaloriePerKelvin).ToString(swedishCulture));
            Assert.Equal("1 J/C", new Entropy(1, EntropyUnit.JoulePerDegreeCelsius).ToString(swedishCulture));
            Assert.Equal("1 J/K", new Entropy(1, EntropyUnit.JoulePerKelvin).ToString(swedishCulture));
            Assert.Equal("1 kcal/K", new Entropy(1, EntropyUnit.KilocaloriePerKelvin).ToString(swedishCulture));
            Assert.Equal("1 kJ/C", new Entropy(1, EntropyUnit.KilojoulePerDegreeCelsius).ToString(swedishCulture));
            Assert.Equal("1 kJ/K", new Entropy(1, EntropyUnit.KilojoulePerKelvin).ToString(swedishCulture));
            Assert.Equal("1 MJ/K", new Entropy(1, EntropyUnit.MegajoulePerKelvin).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 J/K", new Entropy(0.123456, EntropyUnit.JoulePerKelvin).ToString("s1"));
                Assert.Equal("0.12 J/K", new Entropy(0.123456, EntropyUnit.JoulePerKelvin).ToString("s2"));
                Assert.Equal("0.123 J/K", new Entropy(0.123456, EntropyUnit.JoulePerKelvin).ToString("s3"));
                Assert.Equal("0.1235 J/K", new Entropy(0.123456, EntropyUnit.JoulePerKelvin).ToString("s4"));
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
            Assert.Equal("0.1 J/K", new Entropy(0.123456, EntropyUnit.JoulePerKelvin).ToString("s1", culture));
            Assert.Equal("0.12 J/K", new Entropy(0.123456, EntropyUnit.JoulePerKelvin).ToString("s2", culture));
            Assert.Equal("0.123 J/K", new Entropy(0.123456, EntropyUnit.JoulePerKelvin).ToString("s3", culture));
            Assert.Equal("0.1235 J/K", new Entropy(0.123456, EntropyUnit.JoulePerKelvin).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = Entropy.FromJoulesPerKelvin(1.0);
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
            var quantity = Entropy.FromJoulesPerKelvin(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = Entropy.FromJoulesPerKelvin(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = Entropy.FromJoulesPerKelvin(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = Entropy.FromJoulesPerKelvin(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = Entropy.FromJoulesPerKelvin(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = Entropy.FromJoulesPerKelvin(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = Entropy.FromJoulesPerKelvin(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = Entropy.FromJoulesPerKelvin(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = Entropy.FromJoulesPerKelvin(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = Entropy.FromJoulesPerKelvin(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = Entropy.FromJoulesPerKelvin(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = Entropy.FromJoulesPerKelvin(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = Entropy.FromJoulesPerKelvin(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = Entropy.FromJoulesPerKelvin(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = Entropy.FromJoulesPerKelvin(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = Entropy.FromJoulesPerKelvin(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = Entropy.FromJoulesPerKelvin(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(Entropy)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = Entropy.FromJoulesPerKelvin(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(EntropyUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = Entropy.FromJoulesPerKelvin(1.0);
            Assert.Equal(Entropy.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = Entropy.FromJoulesPerKelvin(1.0);
            Assert.Equal(Entropy.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = Entropy.FromJoulesPerKelvin(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = Entropy.FromJoulesPerKelvin(1.0);
            Assert.Equal(new {Entropy.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = Entropy.FromJoulesPerKelvin(value);
            Assert.Equal(Entropy.FromJoulesPerKelvin(-value), -quantity);
        }
    }
}
