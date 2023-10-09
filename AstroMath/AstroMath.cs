using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroMath
{
    public class AstroMath
    {
        // NOT ERROR TRAPPED YET

        public static double StarVelocity (double ObsWavelength, double RestWavelength)
        {
            double SpeedOfLight = 299792458;
            double ChangeInWavelength = ObsWavelength - RestWavelength;
            double Velocity = SpeedOfLight * (ChangeInWavelength / RestWavelength);
            return Math.Round(Velocity, 2);
        }

        public static double StarDistance(double Parallax)
        {
            if (Parallax == 0)
            {
                throw new ArgumentException("Parallax cannot be zero.");
            }

            return Math.Round((1 / Parallax), 2);
        }


        public static double TempInKelvin (double Celcius)
        {
            if (Celcius < -273)
            {
                throw new ArgumentException("Temperature cannot be lower than -273°c");
            }

            return Math.Round((Celcius + 273), 2);
        }

        public static double EventHorizon (double BlackholeMass)
        {
            double GravityConst = 6.674e-11;
            double SpeedOfLight = 299792458;
            double ScwarzschildRadius = (2 * GravityConst *  BlackholeMass) / (SpeedOfLight * SpeedOfLight);
            return ScwarzschildRadius;
        }
    }
}
