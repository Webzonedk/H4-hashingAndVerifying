using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace hashingDeHashing
{
    internal static class Verifier
    {
        public static string VerifyMAC(string? algo, string? key, string? message, string? hashInput)
        {
            try
            {


                string hashedMessageKey = BitConverter.ToString(HashHandler.HashHMACFromHex(algo, key, message)).Replace("-", String.Empty); ;

                if (hashedMessageKey == hashInput)
                {
                    return "Beskeden er verificeret. Alt OK, Ingen har pillet ved indholdet.";
                }
                else
                {
                    return "De indtastede data stemmer ikke overens, og er muligvis blevet ændret undervejs. Kontakt straks afsenderen og få dem til at sende en ny besked!";
                }
            }
            catch (Exception)
            {
                return "De indtastede data stemmer ikke overens, og er muligvis blevet ændret undervejs. Kontakt straks afsenderen og få dem til at sende en ny besked!";
            }


        }
    }
}
