namespace NetCoreForce.Client.Tests
{
    /// <summary>
    /// Fixed test-only keys. Not used anywhere outside these tests.
    /// </summary>
    internal static class TestKeys
    {
        /// <summary>
        /// A 1024 bit RSA key, chosen because its D and DQ values are shorter than the modulus/half the modulus,
        /// so they must be zero-padded for .NET Framework's RSA.ImportParameters
        /// </summary>
        internal const string RsaPkcs1Pem = @"-----BEGIN RSA PRIVATE KEY-----
MIICWgIBAAKBgQCsReEJOy5FWO+cmTgyw28TnhxZ8qU9zmuWpJ++IDoprF4Rc3XQ
4q60fTS+xK5ZydXE2OMsVyhJbEJoBO3ajhKw2SPcl2Zl/jeSDbIOUOZkbguE1a2D
em+YkK/cQRwCcLJYFBEmzbo4btVxmE/9veBlP9+MKOGBaUNVpFTp22VgZQIDAQAB
An9rq0D6hAJnVS5ssVZuY7cIi8ksbnrYJisX+8vbCElRwmkIfyEjbInERHyyvjo5
4+u3G9bf35lOSls2p94AusrytWjEqGSvrGpggC3uqsFXt0BbI3gSwM/qTOgHK5Ya
0txvO3TqMI1MT24x0CoG9i3UAJiEnH2QUhLLbEmakyOBAkEA45gTGpgvQ68iS7mr
frq6O3vUV2Srs3YHTQkz5BMT9QnbUDvQfz5NowPbrMlg7lh/E7J30xfRrRJMOEaN
ipLS4wJBAMHGOWFY3QWR9LEUfkRFP9gCxkT252v1TEi8iD2m5Doc39DOs6wjIwRA
xyFaEWjNCRUZDAD5aAmSc9Pst7xvOhcCQEGTeLWp8bxbwtL0zV/3Z19qP3Vq0Tol
INdmdmgZwx9QVruYcGupRO9aVjpDz8T9BKhlPLc63rQyWHnCglfSFCcCQADfSozU
oJIQ2SAe7n6SLTpksM3IqrwCq6g8KQTWBnr4fE1tUMO6mMLBI+RTinaFTcApj7NF
bCF25kyS6TTQ71sCQQCLHFGkrl4AY4Mh2ha3TQNrnEKGcWgWDbXVKRkyBFRuw+Hd
6EC1pvGIGB5xXJbt3FCtZVQ+F+J2OqIciEulrz02
-----END RSA PRIVATE KEY-----";

        /// <summary>
        /// The same key as <see cref="RsaPkcs1Pem"/>, in PKCS#8 format
        /// </summary>
        internal const string RsaPkcs8Pem = @"-----BEGIN PRIVATE KEY-----
MIICdAIBADANBgkqhkiG9w0BAQEFAASCAl4wggJaAgEAAoGBAKxF4Qk7LkVY75yZ
ODLDbxOeHFnypT3Oa5akn74gOimsXhFzddDirrR9NL7ErlnJ1cTY4yxXKElsQmgE
7dqOErDZI9yXZmX+N5INsg5Q5mRuC4TVrYN6b5iQr9xBHAJwslgUESbNujhu1XGY
T/294GU/34wo4YFpQ1WkVOnbZWBlAgMBAAECf2urQPqEAmdVLmyxVm5jtwiLySxu
etgmKxf7y9sISVHCaQh/ISNsicREfLK+Ojnj67cb1t/fmU5KWzan3gC6yvK1aMSo
ZK+samCALe6qwVe3QFsjeBLAz+pM6AcrlhrS3G87dOowjUxPbjHQKgb2LdQAmISc
fZBSEstsSZqTI4ECQQDjmBMamC9DryJLuat+uro7e9RXZKuzdgdNCTPkExP1CdtQ
O9B/Pk2jA9usyWDuWH8TsnfTF9GtEkw4Ro2KktLjAkEAwcY5YVjdBZH0sRR+REU/
2ALGRPbna/VMSLyIPabkOhzf0M6zrCMjBEDHIVoRaM0JFRkMAPloCZJz0+y3vG86
FwJAQZN4tanxvFvC0vTNX/dnX2o/dWrROiUg12Z2aBnDH1BWu5hwa6lE71pWOkPP
xP0EqGU8tzretDJYecKCV9IUJwJAAN9KjNSgkhDZIB7ufpItOmSwzciqvAKrqDwp
BNYGevh8TW1Qw7qYwsEj5FOKdoVNwCmPs0VsIXbmTJLpNNDvWwJBAIscUaSuXgBj
gyHaFrdNA2ucQoZxaBYNtdUpGTIEVG7D4d3oQLWm8YgYHnFclu3cUK1lVD4X4nY6
ohyIS6WvPTY=
-----END PRIVATE KEY-----";

        /// <summary>
        /// A P-256 EC key in PKCS#8 format - not usable for the JWT Bearer flow
        /// </summary>
        internal const string EcPkcs8Pem = @"-----BEGIN PRIVATE KEY-----
MIGHAgEAMBMGByqGSM49AgEGCCqGSM49AwEHBG0wawIBAQQgwvoeOXh/heZ/4CmW
m8JojbBGZ385Rn24hJx1odiAhWShRANCAAS5oiYvu/2CGKgNEG/WLzFCUb3JYmcY
b14qtMLhtDPuyIeC/JbszkavbVrcRHH31OJ1b7BGGDi1rM+bkdS3MvaI
-----END PRIVATE KEY-----";

        /// <summary>
        /// The base64 body of a PEM block
        /// </summary>
        internal static byte[] DecodePem(string pem)
        {
            int start = pem.IndexOf("-----", 5) + 5;
            int end = pem.IndexOf("-----END");
            return System.Convert.FromBase64String(pem.Substring(start, end - start));
        }
    }
}
