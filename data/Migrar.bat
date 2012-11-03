sqlcmd -S localhost\SQLSERVER2008 -U gd -P gd2012 -i sql\sha256.sql -a 32767 -v varPath="%~dp0"
sqlcmd -S localhost\SQLSERVER2008 -U gd -P gd2012 -i sql\script_creacion_inicial.sql -a 32767 -o resultado_migracion.txt -v varPath="%~dp0"

ECHO 'Migración finalizada'
PAUSE