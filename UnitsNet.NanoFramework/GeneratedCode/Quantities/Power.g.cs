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
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     In physics, power is the rate of doing work. It is equivalent to an amount of energy consumed per unit time.
    /// </summary>
    public struct  Power
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly PowerUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public PowerUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Power(double value, PowerUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static PowerUnit BaseUnit { get; } = PowerUnit.Watt;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static Power MaxValue { get; } = new Power(79228162514264337593543950335d, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static Power MinValue { get; } = new Power(-79228162514264337593543950335d, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Power Zero { get; } = new Power(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PowerUnit.BoilerHorsepower"/>
        /// </summary>
        public double BoilerHorsepower => As(PowerUnit.BoilerHorsepower);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PowerUnit.BritishThermalUnitPerHour"/>
        /// </summary>
        public double BritishThermalUnitsPerHour => As(PowerUnit.BritishThermalUnitPerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PowerUnit.Decawatt"/>
        /// </summary>
        public double Decawatts => As(PowerUnit.Decawatt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PowerUnit.Deciwatt"/>
        /// </summary>
        public double Deciwatts => As(PowerUnit.Deciwatt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PowerUnit.ElectricalHorsepower"/>
        /// </summary>
        public double ElectricalHorsepower => As(PowerUnit.ElectricalHorsepower);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PowerUnit.Femtowatt"/>
        /// </summary>
        public double Femtowatts => As(PowerUnit.Femtowatt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PowerUnit.GigajoulePerHour"/>
        /// </summary>
        public double GigajoulesPerHour => As(PowerUnit.GigajoulePerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PowerUnit.Gigawatt"/>
        /// </summary>
        public double Gigawatts => As(PowerUnit.Gigawatt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PowerUnit.HydraulicHorsepower"/>
        /// </summary>
        public double HydraulicHorsepower => As(PowerUnit.HydraulicHorsepower);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PowerUnit.JoulePerHour"/>
        /// </summary>
        public double JoulesPerHour => As(PowerUnit.JoulePerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PowerUnit.KilobritishThermalUnitPerHour"/>
        /// </summary>
        public double KilobritishThermalUnitsPerHour => As(PowerUnit.KilobritishThermalUnitPerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PowerUnit.KilojoulePerHour"/>
        /// </summary>
        public double KilojoulesPerHour => As(PowerUnit.KilojoulePerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PowerUnit.Kilowatt"/>
        /// </summary>
        public double Kilowatts => As(PowerUnit.Kilowatt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PowerUnit.MechanicalHorsepower"/>
        /// </summary>
        public double MechanicalHorsepower => As(PowerUnit.MechanicalHorsepower);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PowerUnit.MegabritishThermalUnitPerHour"/>
        /// </summary>
        public double MegabritishThermalUnitsPerHour => As(PowerUnit.MegabritishThermalUnitPerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PowerUnit.MegajoulePerHour"/>
        /// </summary>
        public double MegajoulesPerHour => As(PowerUnit.MegajoulePerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PowerUnit.Megawatt"/>
        /// </summary>
        public double Megawatts => As(PowerUnit.Megawatt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PowerUnit.MetricHorsepower"/>
        /// </summary>
        public double MetricHorsepower => As(PowerUnit.MetricHorsepower);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PowerUnit.Microwatt"/>
        /// </summary>
        public double Microwatts => As(PowerUnit.Microwatt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PowerUnit.MillijoulePerHour"/>
        /// </summary>
        public double MillijoulesPerHour => As(PowerUnit.MillijoulePerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PowerUnit.Milliwatt"/>
        /// </summary>
        public double Milliwatts => As(PowerUnit.Milliwatt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PowerUnit.Nanowatt"/>
        /// </summary>
        public double Nanowatts => As(PowerUnit.Nanowatt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PowerUnit.Petawatt"/>
        /// </summary>
        public double Petawatts => As(PowerUnit.Petawatt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PowerUnit.Picowatt"/>
        /// </summary>
        public double Picowatts => As(PowerUnit.Picowatt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PowerUnit.Terawatt"/>
        /// </summary>
        public double Terawatts => As(PowerUnit.Terawatt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PowerUnit.Watt"/>
        /// </summary>
        public double Watts => As(PowerUnit.Watt);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="Power"/> from <see cref="PowerUnit.BoilerHorsepower"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromBoilerHorsepower(double boilerhorsepower) => new Power(boilerhorsepower, PowerUnit.BoilerHorsepower);

        /// <summary>
        ///     Creates a <see cref="Power"/> from <see cref="PowerUnit.BritishThermalUnitPerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromBritishThermalUnitsPerHour(double britishthermalunitsperhour) => new Power(britishthermalunitsperhour, PowerUnit.BritishThermalUnitPerHour);

        /// <summary>
        ///     Creates a <see cref="Power"/> from <see cref="PowerUnit.Decawatt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromDecawatts(double decawatts) => new Power(decawatts, PowerUnit.Decawatt);

        /// <summary>
        ///     Creates a <see cref="Power"/> from <see cref="PowerUnit.Deciwatt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromDeciwatts(double deciwatts) => new Power(deciwatts, PowerUnit.Deciwatt);

        /// <summary>
        ///     Creates a <see cref="Power"/> from <see cref="PowerUnit.ElectricalHorsepower"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromElectricalHorsepower(double electricalhorsepower) => new Power(electricalhorsepower, PowerUnit.ElectricalHorsepower);

        /// <summary>
        ///     Creates a <see cref="Power"/> from <see cref="PowerUnit.Femtowatt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromFemtowatts(double femtowatts) => new Power(femtowatts, PowerUnit.Femtowatt);

        /// <summary>
        ///     Creates a <see cref="Power"/> from <see cref="PowerUnit.GigajoulePerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromGigajoulesPerHour(double gigajoulesperhour) => new Power(gigajoulesperhour, PowerUnit.GigajoulePerHour);

        /// <summary>
        ///     Creates a <see cref="Power"/> from <see cref="PowerUnit.Gigawatt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromGigawatts(double gigawatts) => new Power(gigawatts, PowerUnit.Gigawatt);

        /// <summary>
        ///     Creates a <see cref="Power"/> from <see cref="PowerUnit.HydraulicHorsepower"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromHydraulicHorsepower(double hydraulichorsepower) => new Power(hydraulichorsepower, PowerUnit.HydraulicHorsepower);

        /// <summary>
        ///     Creates a <see cref="Power"/> from <see cref="PowerUnit.JoulePerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromJoulesPerHour(double joulesperhour) => new Power(joulesperhour, PowerUnit.JoulePerHour);

        /// <summary>
        ///     Creates a <see cref="Power"/> from <see cref="PowerUnit.KilobritishThermalUnitPerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromKilobritishThermalUnitsPerHour(double kilobritishthermalunitsperhour) => new Power(kilobritishthermalunitsperhour, PowerUnit.KilobritishThermalUnitPerHour);

        /// <summary>
        ///     Creates a <see cref="Power"/> from <see cref="PowerUnit.KilojoulePerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromKilojoulesPerHour(double kilojoulesperhour) => new Power(kilojoulesperhour, PowerUnit.KilojoulePerHour);

        /// <summary>
        ///     Creates a <see cref="Power"/> from <see cref="PowerUnit.Kilowatt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromKilowatts(double kilowatts) => new Power(kilowatts, PowerUnit.Kilowatt);

        /// <summary>
        ///     Creates a <see cref="Power"/> from <see cref="PowerUnit.MechanicalHorsepower"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromMechanicalHorsepower(double mechanicalhorsepower) => new Power(mechanicalhorsepower, PowerUnit.MechanicalHorsepower);

        /// <summary>
        ///     Creates a <see cref="Power"/> from <see cref="PowerUnit.MegabritishThermalUnitPerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromMegabritishThermalUnitsPerHour(double megabritishthermalunitsperhour) => new Power(megabritishthermalunitsperhour, PowerUnit.MegabritishThermalUnitPerHour);

        /// <summary>
        ///     Creates a <see cref="Power"/> from <see cref="PowerUnit.MegajoulePerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromMegajoulesPerHour(double megajoulesperhour) => new Power(megajoulesperhour, PowerUnit.MegajoulePerHour);

        /// <summary>
        ///     Creates a <see cref="Power"/> from <see cref="PowerUnit.Megawatt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromMegawatts(double megawatts) => new Power(megawatts, PowerUnit.Megawatt);

        /// <summary>
        ///     Creates a <see cref="Power"/> from <see cref="PowerUnit.MetricHorsepower"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromMetricHorsepower(double metrichorsepower) => new Power(metrichorsepower, PowerUnit.MetricHorsepower);

        /// <summary>
        ///     Creates a <see cref="Power"/> from <see cref="PowerUnit.Microwatt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromMicrowatts(double microwatts) => new Power(microwatts, PowerUnit.Microwatt);

        /// <summary>
        ///     Creates a <see cref="Power"/> from <see cref="PowerUnit.MillijoulePerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromMillijoulesPerHour(double millijoulesperhour) => new Power(millijoulesperhour, PowerUnit.MillijoulePerHour);

        /// <summary>
        ///     Creates a <see cref="Power"/> from <see cref="PowerUnit.Milliwatt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromMilliwatts(double milliwatts) => new Power(milliwatts, PowerUnit.Milliwatt);

        /// <summary>
        ///     Creates a <see cref="Power"/> from <see cref="PowerUnit.Nanowatt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromNanowatts(double nanowatts) => new Power(nanowatts, PowerUnit.Nanowatt);

        /// <summary>
        ///     Creates a <see cref="Power"/> from <see cref="PowerUnit.Petawatt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromPetawatts(double petawatts) => new Power(petawatts, PowerUnit.Petawatt);

        /// <summary>
        ///     Creates a <see cref="Power"/> from <see cref="PowerUnit.Picowatt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromPicowatts(double picowatts) => new Power(picowatts, PowerUnit.Picowatt);

        /// <summary>
        ///     Creates a <see cref="Power"/> from <see cref="PowerUnit.Terawatt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromTerawatts(double terawatts) => new Power(terawatts, PowerUnit.Terawatt);

        /// <summary>
        ///     Creates a <see cref="Power"/> from <see cref="PowerUnit.Watt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromWatts(double watts) => new Power(watts, PowerUnit.Watt);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="PowerUnit" /> to <see cref="Power" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Power unit value.</returns>
        public static Power From(double value, PowerUnit fromUnit)
        {
            return new Power(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(PowerUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public Power ToUnit(PowerUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new Power(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double GetValueInBaseUnit()
        {
            return Unit switch
            {
                PowerUnit.BoilerHorsepower => _value * 9812.5d,
                PowerUnit.BritishThermalUnitPerHour => _value * 0.293071d,
                PowerUnit.Decawatt => (_value) * 1e1d,
                PowerUnit.Deciwatt => (_value) * 1e-1d,
                PowerUnit.ElectricalHorsepower => _value * 746d,
                PowerUnit.Femtowatt => (_value) * 1e-15d,
                PowerUnit.GigajoulePerHour => (_value / 3600d) * 1e9d,
                PowerUnit.Gigawatt => (_value) * 1e9d,
                PowerUnit.HydraulicHorsepower => _value * 745.69988145d,
                PowerUnit.JoulePerHour => _value / 3600d,
                PowerUnit.KilobritishThermalUnitPerHour => (_value * 0.293071d) * 1e3d,
                PowerUnit.KilojoulePerHour => (_value / 3600d) * 1e3d,
                PowerUnit.Kilowatt => (_value) * 1e3d,
                PowerUnit.MechanicalHorsepower => _value * 745.69d,
                PowerUnit.MegabritishThermalUnitPerHour => (_value * 0.293071d) * 1e6d,
                PowerUnit.MegajoulePerHour => (_value / 3600d) * 1e6d,
                PowerUnit.Megawatt => (_value) * 1e6d,
                PowerUnit.MetricHorsepower => _value * 735.49875d,
                PowerUnit.Microwatt => (_value) * 1e-6d,
                PowerUnit.MillijoulePerHour => (_value / 3600d) * 1e-3d,
                PowerUnit.Milliwatt => (_value) * 1e-3d,
                PowerUnit.Nanowatt => (_value) * 1e-9d,
                PowerUnit.Petawatt => (_value) * 1e15d,
                PowerUnit.Picowatt => (_value) * 1e-12d,
                PowerUnit.Terawatt => (_value) * 1e12d,
                PowerUnit.Watt => _value,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(PowerUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                PowerUnit.BoilerHorsepower => baseUnitValue / 9812.5d,
                PowerUnit.BritishThermalUnitPerHour => baseUnitValue / 0.293071d,
                PowerUnit.Decawatt => (baseUnitValue) / 1e1d,
                PowerUnit.Deciwatt => (baseUnitValue) / 1e-1d,
                PowerUnit.ElectricalHorsepower => baseUnitValue / 746d,
                PowerUnit.Femtowatt => (baseUnitValue) / 1e-15d,
                PowerUnit.GigajoulePerHour => (baseUnitValue * 3600d) / 1e9d,
                PowerUnit.Gigawatt => (baseUnitValue) / 1e9d,
                PowerUnit.HydraulicHorsepower => baseUnitValue / 745.69988145d,
                PowerUnit.JoulePerHour => baseUnitValue * 3600d,
                PowerUnit.KilobritishThermalUnitPerHour => (baseUnitValue / 0.293071d) / 1e3d,
                PowerUnit.KilojoulePerHour => (baseUnitValue * 3600d) / 1e3d,
                PowerUnit.Kilowatt => (baseUnitValue) / 1e3d,
                PowerUnit.MechanicalHorsepower => baseUnitValue / 745.69d,
                PowerUnit.MegabritishThermalUnitPerHour => (baseUnitValue / 0.293071d) / 1e6d,
                PowerUnit.MegajoulePerHour => (baseUnitValue * 3600d) / 1e6d,
                PowerUnit.Megawatt => (baseUnitValue) / 1e6d,
                PowerUnit.MetricHorsepower => baseUnitValue / 735.49875d,
                PowerUnit.Microwatt => (baseUnitValue) / 1e-6d,
                PowerUnit.MillijoulePerHour => (baseUnitValue * 3600d) / 1e-3d,
                PowerUnit.Milliwatt => (baseUnitValue) / 1e-3d,
                PowerUnit.Nanowatt => (baseUnitValue) / 1e-9d,
                PowerUnit.Petawatt => (baseUnitValue) / 1e15d,
                PowerUnit.Picowatt => (baseUnitValue) / 1e-12d,
                PowerUnit.Terawatt => (baseUnitValue) / 1e12d,
                PowerUnit.Watt => baseUnitValue,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion
    }
}

