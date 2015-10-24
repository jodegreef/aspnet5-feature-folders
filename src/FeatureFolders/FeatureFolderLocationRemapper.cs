using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc.Razor;

namespace FeatureFolders
{
    public class FeatureFolderLocationRemapper : IViewLocationExpander
    {
        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context,
            IEnumerable<string> viewLocations)
        {
            return viewLocations.MoveViewsIntoFeaturesFolder().CutomizeSharedWithUnderScore();
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
            // do nothing.. not entirely needed for this 
        }
    }

    public static class FeatureFolderExtensions
    {
        public static IEnumerable<string> MoveViewsIntoFeaturesFolder(this IEnumerable<string> viewLocations)
        {
            // I added an additional "App" folder in my MVC project to separate the root configuration 
            // and package files from my application code. 
            return viewLocations.Select(f => f.Replace("/Views/", "/Features/"));
        }

        public static IEnumerable<string> CutomizeSharedWithUnderScore(this IEnumerable<string> viewLocations)
        {
            return viewLocations.Select(f => f.Replace("/Shared/", "/_Shared/"));
        }
    }
}
