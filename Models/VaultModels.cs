using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aether_Windows.Models;

public class RecentVaults
{
    public string VaultName { get; set; } = string.Empty;
    public string VaultId { get; set; } = string.Empty; // ID = the tail of url after filebin.net/*
    public string VaultCreated { get; set; } = string.Empty; // Time when vault was created
}
