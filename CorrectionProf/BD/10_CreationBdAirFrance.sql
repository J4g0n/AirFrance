--
-- si BD existe : la supprimer
-- ( Attention on ne travaille pas sur
-- l'environnement de production :
-- sinon on supprime la vraie BD
--
-- se positionner sur la BD syst�me
use master
go
if exists(select * 
		from sys.databases
		where name='BDAirFrance')
begin
		-- supprimer la bd
		Drop database BDAirFrance
end
go
--
--	cr�er la BD
--
--
create database .....
go
--
-- se positionne sur la bd
-- 
use ....
go
-- cr�er les tables avec cl� primaire
-- mais sans les cl�s etrang�res
create table .....
(
	.....
)
go
create table .....
(
	.....
)
go
-- cr�er les cl�s etrang�res
Alter table .....
	add constraint .....
go
Alter table .....
	add constraint .....
go
...
--
-- ajouter un jeu d'essais dans
-- la bd
insert into Avion (...) values(...)









