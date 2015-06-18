use master
go

if exists(select * from sys.databases where name = 'AirFrance')
	begin
		drop database AirFrance;
	end
go

create database AirFrance;
go

use AirFrance
go

create table aeroport (
	code varchar(3) primary key,
	nom varchar(20),
	ville varchar(30),
	pays varchar(30)
)
go

create table avion (
	numeroSerie int primary key,
	modele varchar(30),
	nbPassagers integer
)
go

create table vol (
	numero varchar(10) primary key,
	heureDepart time(7),
	heureArrivee time(7),
	aeroportDepart varchar(3) foreign key references aeroport(code),
	aeroportArrivee varchar(3) foreign key references aeroport(code),
)
go

create table voyage (
	numero int identity primary key,
	aeroportDepart varchar(3) foreign key references aeroport(code),
	aeroportArrivee varchar(3) foreign key references aeroport(code),
)
go

create table escale (
	ordre int,
	numeroVol varchar(10) foreign key references vol(numero),
	numeroVoyage int foreign key references voyage(numero),
	CONSTRAINT PK_escale PRIMARY KEY CLUSTERED (numeroVol, numeroVoyage)
)
go

create table planification (
	dateDepart date,
	numeroVol varchar(10) foreign key references vol(numero),
	numeroVoyage int foreign key references voyage(numero),
	dateArrivee date,
	terminalDepart varchar(10),
	terminalArrivee varchar(10),
	numeroSerieAvion int foreign key references avion(numeroSerie),
	CONSTRAINT PK_planification PRIMARY KEY CLUSTERED (dateDepart, numeroVol, numeroVoyage)
)
go

-- alter table { add | drop } { column | constraint }
--alter table ...
	--add constraint ...