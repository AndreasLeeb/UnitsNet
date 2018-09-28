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
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToLength
{
    public static class NumberToLengthExtensions
    {
        /// <inheritdoc cref="Length.FromCentimeters(UnitsNet.QuantityValue)" />
        public static Length Centimeters<T>(this T value) => Length.FromCentimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromDecimeters(UnitsNet.QuantityValue)" />
        public static Length Decimeters<T>(this T value) => Length.FromDecimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromDtpPicas(UnitsNet.QuantityValue)" />
        public static Length DtpPicas<T>(this T value) => Length.FromDtpPicas(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromDtpPoints(UnitsNet.QuantityValue)" />
        public static Length DtpPoints<T>(this T value) => Length.FromDtpPoints(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromFathoms(UnitsNet.QuantityValue)" />
        public static Length Fathoms<T>(this T value) => Length.FromFathoms(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromFeet(UnitsNet.QuantityValue)" />
        public static Length Feet<T>(this T value) => Length.FromFeet(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromInches(UnitsNet.QuantityValue)" />
        public static Length Inches<T>(this T value) => Length.FromInches(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromKilometers(UnitsNet.QuantityValue)" />
        public static Length Kilometers<T>(this T value) => Length.FromKilometers(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromMeters(UnitsNet.QuantityValue)" />
        public static Length Meters<T>(this T value) => Length.FromMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromMicroinches(UnitsNet.QuantityValue)" />
        public static Length Microinches<T>(this T value) => Length.FromMicroinches(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromMicrometers(UnitsNet.QuantityValue)" />
        public static Length Micrometers<T>(this T value) => Length.FromMicrometers(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromMils(UnitsNet.QuantityValue)" />
        public static Length Mils<T>(this T value) => Length.FromMils(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromMiles(UnitsNet.QuantityValue)" />
        public static Length Miles<T>(this T value) => Length.FromMiles(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromMillimeters(UnitsNet.QuantityValue)" />
        public static Length Millimeters<T>(this T value) => Length.FromMillimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromNanometers(UnitsNet.QuantityValue)" />
        public static Length Nanometers<T>(this T value) => Length.FromNanometers(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromNauticalMiles(UnitsNet.QuantityValue)" />
        public static Length NauticalMiles<T>(this T value) => Length.FromNauticalMiles(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromPrinterPicas(UnitsNet.QuantityValue)" />
        public static Length PrinterPicas<T>(this T value) => Length.FromPrinterPicas(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromPrinterPoints(UnitsNet.QuantityValue)" />
        public static Length PrinterPoints<T>(this T value) => Length.FromPrinterPoints(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromShackles(UnitsNet.QuantityValue)" />
        public static Length Shackles<T>(this T value) => Length.FromShackles(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromTwips(UnitsNet.QuantityValue)" />
        public static Length Twips<T>(this T value) => Length.FromTwips(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromUsSurveyFeet(UnitsNet.QuantityValue)" />
        public static Length UsSurveyFeet<T>(this T value) => Length.FromUsSurveyFeet(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromYards(UnitsNet.QuantityValue)" />
        public static Length Yards<T>(this T value) => Length.FromYards(Convert.ToDouble(value));

    }
}
#endif
