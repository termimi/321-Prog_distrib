// See https://aka.ms/new-console-template for more information
using serealization;
Character garmadon = new Character("Garmadon", "Lord", "Il est noir et a 4 bras",null);
Actor philippe = new Actor("philippe","heijkoop",new DateTime(2006,3,14),"Annecy",true);
garmadon.ToJson();
philippe.ToJson();
// TODO Désérialiser un seul fichier
garmadon.PlayedBy = philippe;
Console.WriteLine($"Le personnage de {garmadon.FirstName} {garmadon.LastName} est joué par {garmadon.PlayedBy.FirstName} {garmadon.PlayedBy.LastName}");
string filePath = $"Lucas-Le-Vrai-Character.json";
Character character1 = new Character();
character1 = character1.deserelizeJson(filePath);
character1.ToString();
