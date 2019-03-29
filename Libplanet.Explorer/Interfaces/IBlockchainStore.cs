using System;
using Libplanet.Store;

namespace Libplanet.Explorer.Interfaces
{
    public interface IBlockchainStore
    {
        IStore Store { get; }
        Guid ChainId { get; }
    }
}
