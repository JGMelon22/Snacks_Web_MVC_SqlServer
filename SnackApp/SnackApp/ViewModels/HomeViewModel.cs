// View Logic

using System.Collections.Generic;
using SnackApp.Models;

namespace SnackApp.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Lanche> LanchesPreferidos { get; set; }
    }
}