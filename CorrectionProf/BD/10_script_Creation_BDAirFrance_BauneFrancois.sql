--
-- si BD existe la supprimer
-- (attention on ne travaille pas sur l'environnement de prod.

--on se positionne sur la BD systeme
USE master
GO
IF EXISTS(SELECT * FROM sys.databases WHERE name='BDAirFrance')
begin 
	DROP DATABASE BDAirFrance
end
GO

CREATE DATABASE BDAirFrance
GO
USE BDAirFrance

--
-- creer les tables avec clé primaire
-- mais sans les clés étrangères
CREATE TABLE Aeroport(
	CodeAeroport NVARCHAR(10) PRIMARY KEY NOT NULL,
	Nom NVARCHAR(50) NOT NULL,
	Ville NVARCHAR(50) NOT NULL,
	Pays  NVARCHAR(50) NOT NULL
)

CREATE TABLE Vol (
	NumeroVol NVARCHAR(10) PRIMARY KEY NOT NULL,
	HeureDepart TIME NOT NULL,
    HeureArrivee TIME NOT NULL,
	CodeAeroportDepart NVARCHAR(10) NOT NULL,
	CodeAeroportArrivee NVARCHAR(10) NOT NULL
)


CREATE TABLE Voyage(
	NumeroVoyage INT IDENTITY(1,1) PRIMARY KEY NOT NULL ,
	CodeAeroportDebut NVARCHAR(10) NOT NULL,
	CodeAeroportFin NVARCHAR(10) NOT NULL
)

CREATE TABLE Etape (
	NumeroVoyage INT NOT NULL ,
	NumeroVol NVARCHAR(10) NOT NULL,
	OrdreEtape INT NOT NULL
	CONSTRAINT PK_Etape PRIMARY KEY (NumeroVoyage , NumeroVol)
)

CREATE TABLE Planification(
	NumeroVoyage INT NOT NULL,
	NumeroVol NVARCHAR(10) NOT NULL,
	DateDepart DATE NOT NULL,
	DateArrivee  DATE NOT NULL,
	TerminalDepart NVARCHAR(10),
	TerminalArivee NVARCHAR(10),
	NumeroSerieAvion NVARCHAR(10) NOT NULL,
	CONSTRAINT PK_Planification PRIMARY KEY (NumeroVoyage , NumeroVol, DateDepart)
)

CREATE TABLE Avion(
	NumeroSerieAvion NVARCHAR(10) PRIMARY KEY NOT NULL,
	Modele NVARCHAR(10) NOT NULL,
	NombrePassager INT,

)


--
-- creer les cles etrangères
--

ALTER TABLE Vol 
ADD 
	CONSTRAINT fk_Vol_CodeAeroportDepart FOREIGN KEY (CodeAeroportDepart) REFERENCES Aeroport(CodeAeroport),
	CONSTRAINT fk_Vol_CodeAeroportArrivee FOREIGN KEY (CodeAeroportArrivee)REFERENCES Aeroport(CodeAeroport)

ALTER TABLE Voyage
ADD
	CONSTRAINT fk_Voyage_CodeAeroportDebut FOREIGN KEY (CodeAeroportDebut) REFERENCES Aeroport(CodeAeroport),
	CONSTRAINT fk_Voyage_CodeAeroportFin FOREIGN KEY (CodeAeroportFin)REFERENCES Aeroport(CodeAeroport)

ALTER TABLE Etape
ADD
	CONSTRAINT fk_Etape_Voyage FOREIGN KEY (NumeroVoyage) REFERENCES Voyage(NumeroVoyage),
	CONSTRAINT fk_Etape_Vol FOREIGN KEY (NumeroVol) REFERENCES Vol(NumeroVol)

ALTER TABLE Planification
ADD 
	CONSTRAINT fk_Planification_Etape FOREIGN KEY(NumeroVoyage,NumeroVol) REFERENCES Etape(NumeroVoyage,NumeroVol)





-- maintenant que la database et les tables sont crées : 
-- on remplis les tables via INSERT :
--

USE [BDAirFrance]
GO


--
-- 1) les aeroports
--


INSERT INTO [Aeroport]
           ([CodeAeroport]
           ,[Nom]
           ,[Ville]
           ,[Pays])
     VALUES
           ('CDG',
			'Charle de gaulle',
			'Paris',
			'France'
)
GO


INSERT INTO [Aeroport]
           ([CodeAeroport]
           ,[Nom]
           ,[Ville]
           ,[Pays])
     VALUES
           ('PEK', 
		   'Capital International Kennedy',
		   'Pékin',
		   'chine'

)
GO


INSERT INTO [Aeroport]
           ([CodeAeroport]
           ,[Nom]
           ,[Ville]
           ,[Pays])
     VALUES
           ('PVG',
		    'Shanghai Pudong International Airport',
			'Shangai',
			'Chine'
)
GO

INSERT INTO [Aeroport]
           ([CodeAeroport]
           ,[Nom]
           ,[Ville]
           ,[Pays])
     VALUES
           ('XIY',
			'Xian Xianyang International Airport',
			'Xianyang',
			'Chine'

)
GO

INSERT INTO [Aeroport]
           ([CodeAeroport]
           ,[Nom]
           ,[Ville]
           ,[Pays])
     VALUES
           (
			'GIG',
			'Rio de Janeiro International Airport',
			'Rio de Janeiro',
			'Bresil'
			)
GO


INSERT INTO [Aeroport]
           ([CodeAeroport]
           ,[Nom]
           ,[Ville]
           ,[Pays])
     VALUES
           (
			'BSB',
			'Brasília International Airport ',
			'Lago Sul',
			'Bresil'
			)
GO


--
-- 2)  les Vols
--


INSERT INTO [Vol]
           ([NumeroVol]
           ,[HeureDepart]
           ,[HeureArrivee]
           ,[CodeAeroportDepart]
           ,[CodeAeroportArrivee])
     VALUES
           ('AF022',
			'13:45',
			'05:50',
			'CDG',
			'PEK')
GO

INSERT INTO [Vol]
           ([NumeroVol]
           ,[HeureDepart]
           ,[HeureArrivee]
           ,[CodeAeroportDepart]
           ,[CodeAeroportArrivee])
     VALUES
           ('AF442',
			'23:20',
			'05:25',
			'CDG',
			'GIG'
			)
GO

INSERT INTO [Vol]
           ([NumeroVol]
           ,[HeureDepart]
           ,[HeureArrivee]
           ,[CodeAeroportDepart]
           ,[CodeAeroportArrivee])
     VALUES
           ('AF2066',
			'07:20',
			'09:04',
			'GIG',
			'BSB'
	)
GO


--
-- 3) les voyages
--

INSERT INTO [Voyage]
           ([CodeAeroportDebut]
           ,[CodeAeroportFin])
     VALUES
           ('CDG',
			'PEK'
)
GO

INSERT INTO [Voyage]
           ([CodeAeroportDebut]
           ,[CodeAeroportFin])
     VALUES
           ('CDG',
			'BSB'
)
GO


--
-- 4) les etapes 
--

INSERT INTO [Etape]
           ([NumeroVoyage]
           ,[NumeroVol]
           ,[OrdreEtape])
     VALUES
           (1,
			'AF022',
			1
)
GO

INSERT INTO [Etape]
           ([NumeroVoyage]
           ,[NumeroVol]
           ,[OrdreEtape])
     VALUES
           (2,
			'AF442',
			1

)
GO

INSERT INTO [Etape]
           ([NumeroVoyage]
           ,[NumeroVol]
           ,[OrdreEtape])
     VALUES
           (2,
			'AF2066',
			2

)
GO

--
-- 5) Avion
--

USE [BDAirFrance]
GO

INSERT INTO [Avion]
           ([NumeroSerieAvion]
           ,[Modele]
           ,[NombrePassager])
     VALUES
           ('AX324432',
			'A320',
			'300'
)
GO


INSERT INTO [Avion]
           ([NumeroSerieAvion]
           ,[Modele]
           ,[NombrePassager])
     VALUES
           ('AX00001',
			'A380',
			'150'
)
GO


INSERT INTO [Avion]
           ([NumeroSerieAvion]
           ,[Modele]
           ,[NombrePassager])
     VALUES
           ('AX00002',
			'A380',
			'180'
)
GO

--
--6) Planification 
--

INSERT INTO [Planification]
           ([NumeroVoyage]
           ,[NumeroVol]
           ,[DateDepart]
           ,[DateArrivee]
           ,[TerminalDepart]
           ,[TerminalArivee]
           ,[NumeroSerieAvion])
     VALUES
           (1,
			'AF022',
			 '19/06/15',
			' 20/06/15 ',
			'2E',
			'2',
			'AX324432'
)
GO



INSERT INTO [Planification]
           ([NumeroVoyage]
           ,[NumeroVol]
           ,[DateDepart]
           ,[DateArrivee]
           ,[TerminalDepart]
           ,[TerminalArivee]
           ,[NumeroSerieAvion])
     VALUES
           (2,
			'AF442',
			 '20/06/15',
			 '21/06/15', 
			'2E',
			'1',
			'AX00001'
)
GO

INSERT INTO [Planification]
           ([NumeroVoyage]
           ,[NumeroVol]
           ,[DateDepart]
           ,[DateArrivee]
           ,[TerminalDepart]
           ,[TerminalArivee]
           ,[NumeroSerieAvion])
     VALUES
           (2,
			'AF2066',
			'21/06/15',
			'21/06/15',
			'1',
			'1',
			'AX00002'
)
GO