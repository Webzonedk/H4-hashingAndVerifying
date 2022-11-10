using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace hashingDeHashing
{
    internal class HashHandler
    {
        public static HMAC? myMAC;
        internal static HMAC MACHandler(string selection, byte[] key)
        {

            switch (selection)
            {

                case "1":
                    myMAC = new HMACSHA1(key);
                    break;

                case "2":
                    myMAC = new HMACMD5(key);
                    break;

                case "3":
                    myMAC = new HMACSHA256(key);
                    break;

                case "4":
                    myMAC = new HMACSHA384(key);
                    break;

                case "5":
                    myMAC = new HMACSHA512(key);
                    break;
            }
            return myMAC;

        }


        //Hashing the message
        internal static byte[] HashHMACFromHex(string algo, string hexKey, string messageHex)
        {
            byte[]? key = Convert.FromHexString(hexKey);
            byte[]? message = Convert.FromHexString(messageHex);
            HMAC? myMAC = HashHandler.MACHandler(algo, key);
            return myMAC.ComputeHash(message);
        }


        //Hashing using the normal sha versions algorithm
        //private static byte[] HashSHA(byte[] innerKey, byte[] outerKey, byte[] message)
        //{
        //    //var hash = new SHA256(innerKey); //Just for testing

        //    //// Compute the inner data
        //    //byte[] innerData = new byte[innerKey.Length + message.Length];
        //    //Buffer.BlockCopy(innerKey, 0, innerData, 0, innerKey.Length);
        //    //Buffer.BlockCopy(message, 0, innerData, innerKey.Length, message.Length);
        //    //byte[] innerHash = hash.ComputeHash(innerData);

        //    //// Compute the entire hash
        //    //byte[] data = new byte[outerKey.Length + innerHash.Length];
        //    //Buffer.BlockCopy(outerKey, 0, data, 0, outerKey.Length);
        //    //Buffer.BlockCopy(innerHash, 0, data, outerKey.Length, innerHash.Length);
        //    //byte[] result = hash.ComputeHash(data);

        //    //return result;
        //}

    }
}
