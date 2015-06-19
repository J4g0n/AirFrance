--
-- recherche de voyages
--  à partir d'aéroport
-- de départ et d'aéroport
-- arrivée
--
use BDAirFrance
go
select	v.NumeroVoyage,
		vo.CodeAeroportDepart,
		vo.CodeAeroportArrivee,
		e.OrdreEtape,
		e.NumeroVol,
		vo.HeureDepart,
		vo.HeureArrivee,
		ad.Nom		as AeroportDep,
		ad.Ville	as VilleDepart,
		ad.Pays		as PaysDepart,
		ar.Nom		as AeroportArr,
		ar.Ville	as VilleArrivee,
		ar.Pays		as PaysArrivee
	from Voyage as v
	join Etape as e
	on v.NumeroVoyage=e.NumeroVoyage
	join Vol as vo
	on e.NumeroVol=vo.NumeroVol
	join Aeroport as ad
	on ad.CodeAeroport=vo.CodeAeroportDepart
	join Aeroport as ar
	on ar.CodeAeroport=vo.CodeAeroportArrivee
	where CodeAeroportDebut='CDG'
	and CodeAeroportFin='BSB'
	order by e.OrdreEtape