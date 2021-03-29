using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edusite_api.Helpers
{
    public class EncryptUtils
    {
        public static string Base64Encode(string plainText)
        {
            var encoded_string = string.Empty;
            if (!string.IsNullOrEmpty(plainText))
            {
                var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
                encoded_string = System.Convert.ToBase64String(plainTextBytes);
            }
            return encoded_string;
        }
        public static string Base64Decode(string base64EncodedData)
        {
            var decoded_string = string.Empty;
            if (!string.IsNullOrEmpty(base64EncodedData))
            {
                var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
                decoded_string = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            }
            return decoded_string;
        }
    }
}
