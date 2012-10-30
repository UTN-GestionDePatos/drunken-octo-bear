sqlcmd -S localhost\SQLSERVER2008 -U gd -P gd2012 -i sql\script_revertir_migracion.sql -a 32767 -o resultado_reversión.txt
PAUSE