# API Entity Framework
CRUD sur une table personne , API en ASP.Core 3.1 et Entity Framework en code first.

Pour l'ajout et la mise à jour d'une personne, si l'utilisateur venait à ne pas respecter la casse, le service qui correspond
transforme la donnée. exemple : xaVIER DUboiS deviendra Xavier Dubois.

Les filtres sur le nom et le prénom fonctionne de la manière, exemple : pour rechercher "Coralie"
- "coralie"
- "co"
- "ra"
- "lie"
- "Lie" fonctionnent


