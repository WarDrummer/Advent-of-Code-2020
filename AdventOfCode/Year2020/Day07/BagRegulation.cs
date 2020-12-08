using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Year2020.Day07
{
    public class BagRegulation
    {
        private int? _nestedBagCount;
        
        private readonly IDictionary<string, int> _bagCapacities = new Dictionary<string, int>();
        private int this[string bagColor] => _bagCapacities.ContainsKey(bagColor) ? _bagCapacities[bagColor] : 0;
        private IEnumerable<string> ContainedBags => _bagCapacities.Keys;
        public string BagColor { get; }
        
        public BagRegulation(IReadOnlyList<string> regulationData)
        {
            BagColor = regulationData[0];
            for (var i = 1; i < regulationData.Count; i++)
            {
                var parts = regulationData[i].Split(new[] { ' ' }, 2);
                _bagCapacities[parts[1]] = int.Parse(parts[0]);
            }
        }

        public int ContainedBagCount(IDictionary<string, BagRegulation> regulationLookup)
        {
            if (_nestedBagCount == null)
            {
                var count = 0;
                foreach (var containedBag in ContainedBags)
                {
                    count += _bagCapacities[containedBag] + _bagCapacities[containedBag] * regulationLookup[containedBag].ContainedBagCount(regulationLookup);
                }

                _nestedBagCount = count;
            }
            
            return _nestedBagCount ?? -1;
        }
        
        public bool CanContainBag(string bagColor, IDictionary<string, BagRegulation> regulationLookup)
        {
            if (BagColor == bagColor)
            {
                return false;
            }
            
            if (this[bagColor] > 0)
            {
                return true;
            }

            foreach (var containedBag in ContainedBags)
            {
                if (regulationLookup[containedBag].CanContainBag(bagColor, regulationLookup))
                {
                    return true;
                }
            }

            return false;
        }
        
        public static IEnumerable<BagRegulation> GetBagRegulations(IEnumerable<string> data)
        {
            var bagRegulations = 
                data.Select(line => line.Split(
                        new[] {" bags contain ", " bag, ", " bags, ", " bags.", " bag.", "no other"},
                        StringSplitOptions.RemoveEmptyEntries))
                    .Select(parts => new BagRegulation(parts));
            return bagRegulations;
        }
        
        public static IDictionary<string, BagRegulation> GetRegulationsLookup(IEnumerable<string> data)
        {
            var regulations = GetBagRegulations(data);
            var regulationLookup = new Dictionary<string, BagRegulation>();
            foreach (var regulation in regulations)
            {
                regulationLookup[regulation.BagColor] = regulation;
            }
            return regulationLookup;
        }

        public static IDictionary<string, BagRegulation> GetRegulationsLookup(IEnumerable<BagRegulation> regulations)
        {
            var regulationLookup = new Dictionary<string, BagRegulation>();
            foreach (var regulation in regulations)
            {
                regulationLookup[regulation.BagColor] = regulation;
            }
            return regulationLookup;
        }
    }
}