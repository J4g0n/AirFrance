use master
go

if exists(select * from sys.databases where name = 'AirFrance')
	begin
		drop database AirFrance
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
	heureDepart time(7) not null,
	heureArrivee time(7) not null,
	aeroportDepart varchar(3) foreign key references aeroport(code) not null,
	aeroportArrivee varchar(3) foreign key references aeroport(code) not null,
)
go

create table voyage (
	numero int primary key,
	aeroportDepart varchar(3) foreign key references aeroport(code) not null,
	aeroportArrivee varchar(3) foreign key references aeroport(code) not null,
)
go

create table escale (
	ordre int,
	numeroVol varchar(10) foreign key references vol(numero) not null,
	numeroVoyage int foreign key references voyage(numero) not null
)
go

create table planification (
	dateDepart date not null,
	numeroVol varchar(10) foreign key references vol(numero) not null,
	numeroVoyage int foreign key references voyage(numero) not null,
	dateArrivee date not null,
	terminalDepart varchar(10) not null,
	terminalArrivee varchar(10) not null,
	numeroSerieAvion int foreign key references avion(numeroSerie) not null
)
go

--alter table { add | drop } { column | constraint }
alter table escale
	add constraint PK_escale PRIMARY KEY CLUSTERED (numeroVol, numeroVoyage);
go

alter table planification
	add constraint PK_planification PRIMARY KEY CLUSTERED (dateDepart, numeroVol, numeroVoyage);
go