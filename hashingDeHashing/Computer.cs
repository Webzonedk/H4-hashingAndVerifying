using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace hashingDeHashing
{
    internal static class Computer
    {

        //Method to compute and show hex
        public static string ComputeMACHex(string? algo, string? key, string? message)
        {
            try
            {
               return BitConverter.ToString(HashHandler.HashHMACFromHex(algo, key, message)).Replace("-", String.Empty);
            }
            catch (Exception)
            {
                return "De indtastede inputs var ikke korrekt. Prøv venligst igen";
            }


        }
        //Method to compute and show ascii
        public static string ComputeASCII(string? algo, string? key, string? message)
        {
            try
            {
                return Encoding.ASCII.GetString(HashHandler.HashHMACFromHex(algo, key, message));
            }
            catch (Exception)
            {
                return "De indtastede inputs var ikke korrekt. Prøv venligst igen";
            }


        }





















    }
}
