namespace Milkman
{
    public class LocalizedStrings
    {
        private static AppResources resources = new AppResources();
        
        public AppResources Localization
        {
            get
            {
                return resources;            
            }          
        }
    }
}
