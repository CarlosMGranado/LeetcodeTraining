public class Solution
{
    public int MinCost(int n, int[][] edges)
    {
        int nodeCount = n;
        if (nodeCount <= 1) return 0;

        var graph = new List<(int Neighbor, long Cost)>[nodeCount];
        for (int i = 0; i < nodeCount; i++) graph[i] = new List<(int, long)>();

        foreach (var edge in edges)
        {
            int from = edge[0];
            int to = edge[1];
            long weight = edge[2];

            graph[from].Add((to, weight));
            graph[to].Add((from, 2L * weight));
        }

        var minDistance = new long[nodeCount];
        Array.Fill(minDistance, long.MaxValue);
        minDistance[0] = 0;

        var priorityQueue = new PriorityQueue<int, long>();
        priorityQueue.Enqueue(0, 0);

        while (priorityQueue.TryDequeue(out int currentNode, out long currentDistance))
        {
            if (currentDistance != minDistance[currentNode]) continue;
            if (currentNode == nodeCount - 1) return (int)currentDistance;

            foreach (var (neighborNode, edgeCost) in graph[currentNode])
            {
                long candidateDistance = currentDistance + edgeCost;
                if (candidateDistance < minDistance[neighborNode])
                {
                    minDistance[neighborNode] = candidateDistance;
                    priorityQueue.Enqueue(neighborNode, candidateDistance);
                }
            }
        }

        return -1;
    }
}
