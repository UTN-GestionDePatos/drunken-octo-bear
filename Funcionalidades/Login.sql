CREATE PROCEDURE Loguearse (@user varchar(30), @pass varchar(30), @ret int output)

/*
	0: ok
	1: error login
	2: inhabilitacion
	3: no existe usuario
*/
AS
BEGIN
	
	if exists (select * from Logins where username = @user)
	begin
     IF(Select 1 from Logins Where username= @user AND passwd=dbo.SHA256( @pass) )is NULL
          BEGIN
               Update Logins set intentos_fallidos =intentos_fallidos+1 Where username = @user
               if(select intentos_fallidos from Logins) = 3
               begin
					Update Logins set intentos_fallidos = 0, estado = 2 Where username = @user
					set @ret = 2
					return
               end
               set @ret = 1
               return
          END
     ELSE
          BEGIN
              set @ret = 0
              return
          END
	end
	else
		begin
			set @ret = 3
			return
		end
END

-->volver a mostrar el login y ver cuando los intentos fueron 3 (trigger?)
