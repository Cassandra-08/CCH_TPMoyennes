namespace HNI_TPmoyennes;

class Eleve
{
	public string prenom { get; }
	public string nom { get; }
	public List<Note> notes { get; set; } = new List<Note>();


	public Eleve(string Prenom, string Nom)
	{
		prenom = Prenom;
		nom = Nom;
	}

    public void ajouterNote(Note note)
	{
		if (notes.Count < 200)
		{
			notes.Add(note);
		}
		else
		{
			Console.Write("L'élève a atteint le nombre maximal de notes ; impossible d'en ajouter une nouvelle.");
		}
	}

	public double? moyenneMatiere(int matiere)
	{
		double moyenne = 0;
		int nbNotes = 0;
		for(int i = 0; i < notes.Count; i++)
		{
			if (notes[i].matiere == matiere)
			{
                moyenne += notes[i].note;
				nbNotes++;
			}
		}
		if (nbNotes > 0)
		{
            return Math.Truncate(moyenne / nbNotes * 100) / 100;
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
        for(int m = 0; m < 10; m++)
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
