

using Microsoft.SqlServer.Server;
using System.Linq;

public static class SQLExternalFunctions
{
    [SqlFunction]
	public static int GetCharacterOccurence(string str, char chr)
	{
		if (string.IsNullOrWhiteSpace(str))
			return 0;

		return str.Where(f => f == chr).Count();
	}

}
