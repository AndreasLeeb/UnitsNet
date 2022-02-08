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

namespace UnitsNet.NumberExtensions.NumberToVolumeFlowPerArea
{
    /// <summary>
    /// A number to VolumeFlowPerArea Extensions
    /// </summary>
    public static class NumberToVolumeFlowPerAreaExtensions
    {
        /// <inheritdoc cref="VolumeFlowPerArea.FromCubicFeetPerMinutePerSquareFoot(UnitsNet.QuantityValue)" />
        public static VolumeFlowPerArea CubicFeetPerMinutePerSquareFoot<T>(this T value) =>
            VolumeFlowPerArea.FromCubicFeetPerMinutePerSquareFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(UnitsNet.QuantityValue)" />
        public static VolumeFlowPerArea CubicMetersPerSecondPerSquareMeter<T>(this T value) =>
            VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(Convert.ToDouble(value));

    }
}
