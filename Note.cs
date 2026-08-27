namespace HNI_TPmoyennes
{
    // Classes fournies par HNI Institut
    // Ne pas modifier
    class Note
    {
        public int matiere { get; private set; }
        public float note { get; private set; }
        public Note(int m, float n)
        {
            matiere = m;
            note = n;
        }
    }
}
