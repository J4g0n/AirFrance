use AirFrance
go

select v.numero, vo.aeroportDepart, vo.aeroportArrivee, e.ordre, e.numeroVol, vo.heureDepart, vo.heureArrivee, ad.nom as AeroportDepart, ad.ville as VilleDepart, ad.Pays as PaysDepart
from voyage as v 
join escale as e on v.numero = e.numeroVoyage 
join vol as vo on e.numeroVol = vo.numero
join aeroport as ad on ad.code = vo.aeroportDepart
where v.aeroportDepart = 'CDG' and v.aeroportArrivee = 'TKY'
order by e.ordre
go