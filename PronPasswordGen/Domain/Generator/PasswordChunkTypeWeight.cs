using System;
using System.Collections.Generic;

namespace PronPasswordGen.Domain.Generator
{
    public class PasswordChunkTypeWeight
    {
        public static readonly Dictionary<PasswordChunkType, int> ChunkTypeProbabilityDefault = new Dictionary<PasswordChunkType, int>()
        {
            {PasswordChunkType.Direct, 50 },
            {PasswordChunkType.DirectDiphtongue, 10 },
            {PasswordChunkType.Inverted, 10 },
            {PasswordChunkType.InvertedDiphtongue, 5 },
            {PasswordChunkType.Mixed, 20 },
            {PasswordChunkType.Liquidified, 20 }
        };


        public PasswordChunkType Type { get; set; }

        public int Weight { get; set; }


        public static List<PasswordChunkTypeWeight> GetChunkTypeWeights(Dictionary<PasswordChunkType, int> pWeights)
        {
            if ((pWeights == null) || (pWeights.Count == 0))
                return null;

            List<PasswordChunkTypeWeight> weights = new List<PasswordChunkTypeWeight>();
            foreach (KeyValuePair<PasswordChunkType, int> item in pWeights)
            {
                weights.Add(new PasswordChunkTypeWeight()
                    {
                        Type = item.Key,
                        Weight = item.Value
                    }
                );
            }

            return weights;
        }


        public static Dictionary<PasswordChunkType, int> ChunkTypeWeightsToProbabilities(List<PasswordChunkTypeWeight> pWeights)
        {
            if ((pWeights == null) || (pWeights.Count == 0))
                return null;

            List<PasswordChunkType> types = new List<PasswordChunkType>();
            Dictionary<PasswordChunkType, int> newProbabilities = new Dictionary<PasswordChunkType, int>();
            foreach (KeyValuePair<PasswordChunkType, int> item in ChunkTypeProbabilityDefault)
            {
                newProbabilities.Add(item.Key, -1);
            }

            foreach (PasswordChunkTypeWeight item in pWeights)
            {
                if (types.Contains(item.Type))
                    return null;
                if ((item.Weight < 0) || (item.Weight > 100))
                    return null;
                if (!newProbabilities.ContainsKey(item.Type))
                    return null;
                newProbabilities[item.Type] = item.Weight;
            }

            int totalWeight = 0;
            foreach (KeyValuePair<PasswordChunkType, int> item in newProbabilities)
            {
                if (item.Value < 0)
                    return null;
                totalWeight += item.Value;
            }

            if (totalWeight == 0)
                return null;

            return newProbabilities;
        }


        public static Dictionary<PasswordChunkType, int> GetAdjusted(Dictionary<PasswordChunkType, int> pWeights)
        {
            if ((pWeights == null) || (pWeights.Count == 0))
                return null;

            int totalWeight = 0;
            foreach (KeyValuePair<PasswordChunkType, int> item in pWeights)
            {
                totalWeight += item.Value;
            }

            if (totalWeight <=  0)
                return null;
            if (totalWeight == 100)
                return pWeights;

            double factor = 100.0 / totalWeight;

            Dictionary < PasswordChunkType, int> adjusted = new Dictionary<PasswordChunkType, int>();
            foreach (KeyValuePair<PasswordChunkType, int> item in pWeights)
            {
                adjusted.Add(item.Key, (int) Math.Round(item.Value * factor));
            }
            
            return adjusted;
        }


    }
}