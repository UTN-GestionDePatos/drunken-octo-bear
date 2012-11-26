CREATE PROCEDURE GESTION_DE_PATOS.CambiarPassword (@user varchar(30), @passVieja varchar(50), @passNueva varchar(50),
												   @passNueva2 varchar(50), @ret int output)
AS
BEGIN
	/*
		0: ok
		1: passVieja incorrecta
		2: passN y passN2 no coinciden
	*/
	if not exists (select * from GESTION_DE_PATOS.Usuarios where username = @user and passwd = GESTION_DE_PATOS.SHA256(@passVieja))
	begin
		set @ret = 1
		return
	end
	
	if @passNueva != @passNueva2
	begin
		set @ret = 2
		return
	end
	
	update GESTION_DE_PATOS.Usuarios set passwd = GESTION_DE_PATOS.SHA256(@passNueva) where username = @user
	set @ret = 0
	return
END

GO

CREATE PROCEDURE GESTION_DE_PATOS.CambiarPasswordDesdeAdmin (@user varchar(30), @passNueva varchar(50),
												   @passNueva2 varchar(50), @ret int output)
AS
BEGIN
	/*
		0: ok
		1: passN y passN2 no coinciden
	*/
	
	IF @passNueva != @passNueva2
	BEGIN
		set @ret = 1
		RETURN
	END
	
	UPDATE GESTION_DE_PATOS.Usuarios SET passwd = GESTION_DE_PATOS.SHA256(@passNueva) where username = @user
	set @ret = 0
	RETURN
END

GO