# EonixAPI
CRUD sur une table personne , API en ASP.Core 3.1 et Entity Framework en code first.

Pour l'ajout et la mise à jour d'une personne, si l'utilisateur venait à ne pas respecter la casse, le service qui correspond
transforme la donnée. exemple : xaVIER DUboiS deviendra Xavier Dubois.

Les filtres sur le nom et le prénom fonctionne de la manière, exemple : pour rechercher "Coralie"
-"coralie"
-"co"
-"ra"
-"lie"
-"Lie" fonctionnent

ATTENTION, le projet "test" pour les tests unitaires est bien présent dans la solution, je n'ai cependant pas réussis à les rendres fonctionnels,
en effet, n'ayant pas eu ce cours (celui d'entity non plus d'ailleurs mais pour sur ce point j'ai su m'en sortir) et malgré la documentation, 
j'ai des lacunes dans ce domaine.
