using Microsoft.CodeAnalysis.CSharp.Syntax;
using SanskariVidhyalay.Models;

namespace SanskariVidhyalay.Services
{
    public interface ICities
    {
        IEnumerable <Cities> GetAllCities();
    }
}
