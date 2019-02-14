CREATE PROCEDURE [dbo].konyvekBeszurasa
	
@beszurEljaras nvarchar(10),
@KonyvAzonosito int,
@KonyvCime nvarchar(50),
@Mufaj int,
@Szerzo int,
@Allapot int,
@Kiado int,
@MegjelenesHelye nvarchar(50), 
@KiadasEve int,
@EredetiNyelv nvarchar(50),
@OldalakSzama int,
@BoritoTipusa nvarchar (50)
AS
	if @beszurEljaras='hozzaad'
	BEGIN
	INSERT INTO Konyvek
	(KonyvAzonosito,KonyvCime,Mufaj,Szerzo,Allapot,Kiado,MegjelenesHelye,KiadasEve,EredetiNyelv,OldalakSzama,BoritoTipusa)
	VALUES(@KonyvAzonosito,@KonyvCime,@Mufaj,@Szerzo,@Allapot,@Kiado,@MegjelenesHelye,@KiadasEve,@EredetiNyelv,@OldalakSzama,BoritoTipusa)
	END