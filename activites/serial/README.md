# Sérialise ma série

Voici le pitch de la saison 1 de la série "Eté et miel":

> Gérard et Maya dirigent la cafétéria d'une école professionnelle. Leur spécialité: les endives aux miel qui s'arrachent chaque jour à leur comptoir. Leur fournisseur de miel a décidé de tripler ses prix, Gérard et Maya sont pris au piège.
>
> Un groupe de profs et d'élèves de l'école décident de leur venir en aide en lançant dans l'apiculture pour produire leur précieux nectar en cachette dans la salle des serveurs de l'école... 

## Etape 1

Chacun crée un objet de la classe Character. Choisissez Gérard ou Maya, ou inventez un personnage fictif.

```csharp
public class Character
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Description { get; set; }
    public Actor PlayedBy { get; set; }
}
```
Le champ Actor reste `null`.

Sérialisez votre objet en JSON, déposez le résultat dans un dossier partagé (Teams)

Récupérez les fichiers des autres, dé-sérialisez-les tous !

## Etape 2

Faites pareile avec la classe `Actor`:

```csharp
public class Actor
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Country { get; set; }
    public bool IsAlive { get; set; }
}
```

## Etape 3

Faites jouer votre personnage par votre acteur: 1 seul fichier JSON doit vous permettre d'observer une structure de ce type au debugger après dé-sérialisation:

![](melissa.png)

## Etape 4

Inventez un épisode de la saison:

```csharp
public class Episode
{
    public string Title { get; set; }
    public int DurationMinutes { get; set; }
    public int SequenceNumber { get; set; }
    public string Director { get; set; }
    public string Synopsis { get; set; }
    public List<Character> Characters { get; set; } = new List<Character>();
}
```
(et partagez-le!)

## Etape 5

Assemblez la saison 1 de "Eté et miel" dans un seul fichier
