using System.Collections.Generic;
using SnackApp.Models;

namespace SnackApp.Repositories
{
    public interface ILancheRepository
    {
        // Methods
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
        Lanche GetLancheById<Lanche>(int lancheId);
    }
}