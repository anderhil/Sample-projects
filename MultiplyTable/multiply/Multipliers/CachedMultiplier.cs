using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using multiply.Interfaces;

namespace multiply.Multipliers
{

    /// <summary>
    /// Example of adding another multiplier which caches the data inside
    /// </summary>
    public class CachedMultiplier : IMultiplier
    {
        private readonly IMultiplier _multiplier;

        private readonly Dictionary<int, int[,]> _cacheDictionary = new Dictionary<int, int[,]>();

        public CachedMultiplier(IMultiplier multiplier)
        {
            _multiplier = multiplier;
        }

        private int GetHash(int rows, int columns)
        {
            int hash = 13;
            hash = (hash * 7) + rows.GetHashCode();
            hash = (hash * 7) + columns.GetHashCode();

            return hash;
        }

        public int[,] BuildMultiplierTable(int rows, int columns)
        {
            int[,] result;
            int key = GetHash(rows, columns);
            if (_cacheDictionary.ContainsKey(key))
            {
                result = _cacheDictionary[key];
            }
            else
            {
                result = _multiplier.BuildMultiplierTable(rows, columns);
                _cacheDictionary.Add(key, result);
            }

            return result;
        }
    }
}
