--
-- si BD existe : la supprimer
-- ( Attention on ne travaille pas sur
-- l'environnement de production :
-- sinon on supprime la vraie BD
--
-- se positionner sur la BD système
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
--	créer la BD
--
--
create database .....
go
--
-- se positionne sur la bd
-- 
use ....
go
-- créer les tables avec clé primaire
-- mais sans les clés etrangères
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
-- créer les clés etrangères
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









