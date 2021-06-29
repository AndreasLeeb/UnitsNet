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

#nullable enable

namespace UnitsNet.NumberExtensions.NumberToMolarity
{
    /// <summary>
    /// A number to Molarity Extensions
    /// </summary>
    public static class NumberToMolarityExtensions
    {
        /// <inheritdoc cref="Molarity.FromCentimolesPerLiter(UnitsNet.QuantityValue)" />
        public static Molarity CentimolesPerLiter<T>(this T value) =>
            Molarity.FromCentimolesPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="Molarity.FromDecimolesPerLiter(UnitsNet.QuantityValue)" />
        public static Molarity DecimolesPerLiter<T>(this T value) =>
            Molarity.FromDecimolesPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="Molarity.FromMicromolesPerLiter(UnitsNet.QuantityValue)" />
        public static Molarity MicromolesPerLiter<T>(this T value) =>
            Molarity.FromMicromolesPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="Molarity.FromMillimolesPerLiter(UnitsNet.QuantityValue)" />
        public static Molarity MillimolesPerLiter<T>(this T value) =>
            Molarity.FromMillimolesPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="Molarity.FromMolesPerCubicMeter(UnitsNet.QuantityValue)" />
        public static Molarity MolesPerCubicMeter<T>(this T value) =>
            Molarity.FromMolesPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Molarity.FromMolesPerLiter(UnitsNet.QuantityValue)" />
        public static Molarity MolesPerLiter<T>(this T value) =>
            Molarity.FromMolesPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="Molarity.FromNanomolesPerLiter(UnitsNet.QuantityValue)" />
        public static Molarity NanomolesPerLiter<T>(this T value) =>
            Molarity.FromNanomolesPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="Molarity.FromPicomolesPerLiter(UnitsNet.QuantityValue)" />
        public static Molarity PicomolesPerLiter<T>(this T value) =>
            Molarity.FromPicomolesPerLiter(Convert.ToDouble(value));

    }
}