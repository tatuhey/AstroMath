using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroMath
{
    public class AstroMath
    {
        // Star Velocity: Create a method to measure the Star velocity using the Doppler shift,
        // it should have two input parameters of type double (Observed Wavelength and Rest Wavelength)
        // and return a double which represents the velocity.
        // The Doppler shift of a star can be measured by using the change in wavelength of that object. 
        public static double StarVelocity (double ObsWavelength, double RestWavelength)
        {
            double SpeedOfLight = 299792458;
            double ChangeInWavelength = ObsWavelength - RestWavelength;
            double Velocity = SpeedOfLight * (ChangeInWavelength / RestWavelength);
            return Math.Round(Velocity, 2);
        }

        // Star Distance: Create a method to measure the star distance using the parallax angle,
        // it should have a single input parameter of type double (Arcseconds angle) and return a double.
        // The parallax angle is measured at two different points and works on nearby stars.
        // The method must return a double which is a value in parsecs.
        public static double StarDistance(double Parallax)
        {
            if (Parallax == 0)
            {
                throw new ArgumentException("Parallax cannot be zero.");
            }

            return Math.Round((1 / Parallax), 2);
        }

        // Temperature in Kelvin: The Kelvin temperature scale is the primary temperature used in science
        // and is easily converted from Celsius. Create a method that has a single input parameter of type double
        // (temperature in Celsius) and returns a double which is the temperature in degrees kelvin. 
        public static double TempInKelvin (double Celcius)
        {
            if (Celcius < -273)
            {
                throw new ArgumentException("Temperature cannot be lower than -273°c");
            }

            return Math.Round((Celcius + 273), 2);
        }

        // Event Horizon (Schwarzschild Radius): Create a method that will return the distance
        // from the centre of a blackhole to the event horizon.
        // The method must have a single input parameter of type double (Blackhole Mass)
        // and return a double which is the event horizon in metres
        public static double EventHorizon (double BlackholeMass)
        {
            double GravityConst = 6.674e-11;
            double SpeedOfLight = 299792458;
            double ScwarzschildRadius = (2 * GravityConst *  BlackholeMass) / (SpeedOfLight * SpeedOfLight);
            return ScwarzschildRadius;
        }
    }
}
