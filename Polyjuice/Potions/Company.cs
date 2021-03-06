using Polyjuice.Extension;

namespace Polyjuice.Potions
{
    /// <summary>
    /// An organization that sells things or services
    /// </summary>
    public static class Company
    {
        // Private Data
        private static string[] Suffixes { get; } =
        {
            "Inc", "Inc and Sons", "LLC", "Group"
        };        
        
        // Methods
        public static string CompanyName
        {
            get
            {
                switch (3.Randomize())
                {
                    case 0:
                        return $"{Name.LastName} {Suffixes.Rand()}";
                    case 1:
                        return $"{Name.LastName}-{Name.LastName}";
                    case 2:
                        return
                            $"{Name.LastName}, {Name.LastName} and {Name.LastName}";
                    default:
                        return string.Empty;
                }
            }
        }
    }
}