namespace FactoryMethod
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class ResumeCreator : DocumentCreator
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}
