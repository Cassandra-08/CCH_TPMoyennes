using System.Text.Json.Serialization.Metadata;

namespace HNI_TPmoyennes;

class Classe
{
	public string nomClasse { get; }
	public List<Eleve> eleves { get; set; } = new List<Eleve>();
	public List<string> matieres { get; set; } = new List<string>();

	public Classe(string nom)
	{
		nomClasse = nom;
	}
	
	public void ajouterEleve(Eleve nouvelEleve)
	{
		if (eleves.Count < 30)
		{
            eleves.Add(nouvelEleve);
        }
		else
		{
            Console.Write("La classe est déjà pleine ; impossible d'ajouter un nouvel élève.");

        }
    }
	public void ajouterEleve(string prenom, string nom)
	{
        if (eleves.Count < 30)
        {
			eleves.Add(new Eleve(prenom, nom));
        }
        else
        {
			Console.Write("La classe est déjà pleine ; impossible d'ajouter un nouvel élève.");
        }
    }


    public void ajouterMatiere(string matiere)
	{
		if (matieres.Count <= 10)
		{
			matieres.Add(matiere);
		}
		else
		{
			Console.Write("Impossible d'ajouter une matière supplémentaire pour cette classe.");
		}
	}

	public double? moyenneMatiere(int matiere)
	{
		double moyenne = 0;
		int nbEleves = 0;
		for (int e = 0; e < eleves.Count; e++)
		{
			if (eleves[e].moyenneMatiere(matiere) is not null)
			{
				moyenne += (double)eleves[e].moyenneMatiere(matiere);
	            nbEleves++;
            }
		}
		if (nbEleves > 0)
		{
			return Math.Truncate(moyenne / nbEleves * 100) / 100;
        }
		else
		{
			return null;
		}
	}

	public double? moyenneGeneral()
	{
		double moyenne = 0;
		int nbMatieres = 0;
		for(int m = 0; m < matieres.Count; m++)
		{
			if (moyenneMatiere(m) is not null)
			{
				moyenne += (double)moyenneMatiere(m);
				nbMatieres++;
            }
        }
		if (nbMatieres > 0)
		{
			return Math.Truncate(moyenne / nbMatieres * 100) / 100;
		}
		else
		{
			return null;
		}
	}
}
