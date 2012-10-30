using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Data;
using Microsoft.SqlServer.Server;
using System.Data.SqlTypes;

public class Crypt
{
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlBytes Sha256(SqlString text)
    {
        HashAlgorithm hash = new SHA256Managed();
        return new SqlBytes(hash.ComputeHash(text.GetUnicodeBytes()));
    }
}
