using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aether_Windows.Models;

namespace Aether_Windows.Helpers
{
    internal class VaultHelpers
    {
    }
}

public class RecentVaultState
{
    public ObservableCollection<RecentVaults> RecentVault { get; } = new();
}

