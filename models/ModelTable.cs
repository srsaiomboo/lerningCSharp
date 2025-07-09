namespace Exercicio1_1.models
{
    public class ModelTable
    {
        private string id;
        private string rubric;
        private int currentYearInCents;
        private int lastYearInCents;
        private int variationInCents;
        private double evolutionInPercents;

        // Getters e Setters
        public string GetID() => id;
        public void SetID(string value) => id = value;

        public string GetRubric() => rubric;
        public void SetRubric(string value) => rubric = value;

        public int GetCurrentYearInCents() => currentYearInCents;
        public void SetCurrentYearInCents(int value) => currentYearInCents = value;

        public int GetLastYearInCents() => lastYearInCents;
        public void SetLastYearInCents(int value) => lastYearInCents = value;

        public int GetVariationInCents() => variationInCents;
        public void SetVariationInCents(int value) => variationInCents = value;

        public double GetEvolutionInPercents() => evolutionInPercents;
        public void SetEvolutionInPercents(double value) => evolutionInPercents = value;

        // Construtor padrão
        public ModelTable() { }

        // Construtor com parâmetros
        public ModelTable(string id, string rubric,
                          int currentYearInCents, int lastYearInCents,
                          int variationInCents, double evolutionInPercents)
        {
            this.id = id;
            this.rubric = rubric;
            this.currentYearInCents = currentYearInCents;
            this.lastYearInCents = lastYearInCents;
            this.variationInCents = variationInCents;
            this.evolutionInPercents = evolutionInPercents;
        }
    }
}
