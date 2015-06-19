use AirFrance
go

insert into aeroport (
	code,
	nom,
	ville,
	pays
) values (
	'CDG',
	'C. De Gaulle',
	'Paris',
	'France'
)
go 

insert into aeroport (
	code,
	nom,
	ville,
	pays
) values (
	'PKN',
	'Capital intl',
	'Pekin',
	'Chine'
)
go 

insert into aeroport (
	code,
	nom,
	ville,
	pays
) values (
	'TKY',
	'Tokyo intl',
	'Tokyo',
	'Japon'
)
go 

insert into avion (
	numeroSerie,
	modele,
	nbPassagers
) values (
	3,
	'A320',
	300
)
go 

insert into avion (
	numeroSerie,
	modele,
	nbPassagers
) values (
	5,
	'Boing 737',
	280
)
go 


insert into vol (
	numero,
	heureDepart,
	heureArrivee,
	aeroportDepart,
	aeroportArrivee
) values (
	'FL035',
	'13:45:00',
	'23:30:00',
	'CDG',
	'PKN'
)
go 

insert into vol (
	numero,
	heureDepart,
	heureArrivee,
	aeroportDepart,
	aeroportArrivee
) values (
	'TK037',
	'03:05:00',
	'23:55:00',
	'PKN',
	'TKY'
)
go 

insert into vol (
	numero,
	heureDepart,
	heureArrivee,
	aeroportDepart,
	aeroportArrivee
) values (
	'RE036',
	'01:15:00',
	'14:35:00',
	'PKN',
	'CDG'
)
go 


insert into voyage (
	numero,
	aeroportDepart,
	aeroportArrivee
) values (
	1,
	'CDG',
	'PKN'
)
go 

insert into voyage (
	numero,
	aeroportDepart,
	aeroportArrivee
) values (
	2,
	'CDG',
	'TKY'
)
go 

insert into escale (
	ordre,
	numeroVol,
	numeroVoyage
) values (
	1,
	'FL035',
	2
)
go 

insert into escale (
	ordre,
	numeroVol,
	numeroVoyage
) values (
	2,
	'TK037',
	2
)
go 

insert into planification (
	dateDepart,
	numeroVol,
	numeroVoyage,
	dateArrivee,
	terminalDepart,
	terminalArrivee,
	numeroSerieAvion
) values (
	'2015-06-20',
	'FL035',
	1,
	'2015-06-21',
	'A3',
	'B5',
	3
)
go 