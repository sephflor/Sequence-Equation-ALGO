using System;
using System.Collections.Generic;
using System.Linq;

class Solution {
    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> p = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(pTemp => Convert.ToInt32(pTemp)).ToList();
        
        List<int> result = permutationEquation(p);
        
        foreach (int item in result) {
            Console.WriteLine(item);
        }
    }
    
    public static List<int> permutationEquation(List<int> p) {
        Dictionary<int, int> position = new Dictionary<int, int>();
        
        for (int i = 0; i < p.Count; i++) {
            position[p[i]] = i + 1;
        }
        
        List<int> result = new List<int>();
        
        for (int x = 1; x <= p.Count; x++) {
            int firstStep = position[x];
            int secondStep = position[firstStep];
            result.Add(secondStep);
        }
        
        return result;
    }
}
