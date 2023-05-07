using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankersAlgorithmGUIProgram
{
    static class globalDataMembers
    {
        public static int processesCount;
        public static int resourcesCount;
        public static int[][] maxNeed = new int [processesCount][];
        public static int[][] currentAllocation = new int [processesCount][];
        public static int[][] remainingNeed = new int [processesCount][];
        public static int[] availableResources = new int [resourcesCount];
        public static int[] totalResources = new int [resourcesCount];
        public static int[] resourcesRequested = new int[resourcesCount];
        public static int processRequesting = 0;
        
    }
}
