# ICT-321 Programmation_distribuée

La compétence visée par ce module est: 
>>**Programmer des systèmes distribués**

Les détails sont décrits de manière formelle sur [le site ICT](https://www.modulbaukasten.ch/module/321/1/fr-FR?title=Programmer-des-syst%C3%A8mes-distribu%C3%A9s)

De manière simplifiée, ce module a pour but de vous montrer certaines techniques, pratiques et technologies qui permettent de répartir des fonctionnalités et/ou de la charge de travail sur plusieurs ordinateurs.

Le parcours emprunté par ce module est disponible [ici](https://roadmap.sh/r/embed?id=66ea73d4f34c8868ec042b2c)

(WIP:)

Le projet fil rouge qui accompagne ce cours est "PowerCher", une simulation de distribution d'énergie électrique dans un village.

Chaque élève a une parcelle sur laquelle il a une maison.

Chaque maison est reliée au réseau électrique national (REN), un très gros stockage.

"Mère Nature" est un service à disposition de tous, qui fournit:
- L'heure courante
- La force du vent (pas de direction)
- Taux d'ensoleillement (100% = midi, aucun nuage, 21 juin)

Chaque maison "existe" sous forme d'une application winforms qui tourne sur le poste de son propriétaire.

Le poste du prof héberge:

- Le REN
- Un système de supervision "PowerWatch" dans lequel chaque parcelle est représentée par un formulaire de 400 x 270

Au moins une fois par semaine, on fait une assemblée générale du village: on fait tout tourner ensemble et on observe ce qui se passe. Une minute réelle = 60 minutes simulées. Simuler une journée prend donc 24 minutes.

Les élèves peuvent faire tourner le REN et Mère Nature sur leur PC pendant qu'ils développent. Ils le configurent sur un autre port que le main.

Il y a trois types de noeud énergétique: les producteurs, les consommateurs et les stockages.

Un stockage ne restitue qu'une partie de ce qu'on y a mis (rendement)
- Batterie : 90%
- Supercondo : 99%
- Groupe H2 (electrolyseur+pile à combustible): 40%

Chaque maison est équipée d'un stockage d'entrée particulier: un bloc de [supercondensateurs](https://fr.wikipedia.org/wiki/Supercondensateur#:~:text=Un%20supercondensateur%20est%20un%20condensateur,et%20les%20condensateurs%20%C3%A9lectrolytiques%20classiques.) qui sert de tampon. La maison "pète un câble" si elle demande plus d'énergie au supercondo qu'il n'en possède.

## Projet

Chaque maison dispose d'une Mediathèque contenant des fichiers audio et vidéo.

Le contenu de chaque mediathèque est partagé avec tout le village par "BitRuisseau".

### Etape 1 
La classe définit, valide et publie le protocole BitRuisseau, qui permet à une médiathèque de:
- Demander sur le réseau (broadcast) quels sont les médiathèques qui sont opérationnelles
- S'annoncer opérationnelle
- Demander son catalogue à une médiathèque
- Publier son catalogue
- Demander un fragment de media à une mediatheque
- Fournir un fragment de media à une mediatheque

Le protocole doit être conçu pour supporter des évolutions.

### Etape 2

Définir l'UI du mediaplayer (maquette(s))  
Définir l'UX (User Stories)

Les fonctionnalités minimales à couvrir:
- Afficher le contenu de la mediathèque (dossier local)
- Afficher la liste des contenus disponibles dans la communauté

### Etape 3 

- Implémentation des catalogues

### Etape 4

- Définir l'UI/UX de l'importation d'un contenu externe dans sa mediatheque
- Implémenter

