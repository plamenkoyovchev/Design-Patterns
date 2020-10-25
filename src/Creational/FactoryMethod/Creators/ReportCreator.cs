namespace FactoryMethod
{
    /// <summary>
    /// A 'Concrete Creator' class
    /// </summary>
    public class ReportCreator : DocumentCreator
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
