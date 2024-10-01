# ICT-321 Programmation_distribuée

La compétence visée par ce module est: 
>>**Programmer des systèmes distribués**

Les détails sont décrits de manière formelle sur [le site ICT](https://www.modulbaukasten.ch/module/321/1/fr-FR?title=Programmer-des-syst%C3%A8mes-distribu%C3%A9s)

De manière simplifiée, ce module a pour but de vous montrer certaines techniques, pratiques et technologies qui permettent de répartir des fonctionnalités et/ou de la charge de travail sur plusieurs ordinateurs.

Le parcours emprunté par ce module est disponible [ici]("https://roadmap.sh/r/embed?id=66ea73d4f34c8868ec042b2c")

(WIP:)

Le projet fil rouge qui accompagne ce cours est "Disténé", une simulation de distribution d'énergie dans un village.

Chaque élève a une parcelle sur laquelle il a une maison.
Chaque maison est reliée au réseau électrique national.
La météo est simulée par:
- Force du vent (pas de direction)
- Taux d'ensoleillement (100% = midi, aucun nuage, 21 juin)
Chaque maison "existe" sous forme d'une application winforms qui tourne sur le poste de son propriétaire.
Il y a un système de supervision qui tourne sur le poste du prof et dans lequel chaque parcelle est représentée par un formulaire de 400 x 270

Au moins une fois par semaine, on fait une assemblée générale du village: on fait tout tourner ensemble et on observe ce qui se passe. Une minute réelle = 60 minutes simulées. Simuler une journée prend donc 24 minutes.

