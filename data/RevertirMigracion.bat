sqlcmd -S localhost\SQLSERVER2008 -U gd -P gd2012 -i sha256.sql -a 32767 -o resultado_output.txt -v varPath="%~dp0"
PAUSE