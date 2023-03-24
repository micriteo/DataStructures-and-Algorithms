namespace FinalAssignment;

public abstract class MemoryHandler
{
    public const int MAX_MEMORY = 2;
    public static bool IsMemoryAvailable()
    {
        long memoryUsage = GC.GetTotalMemory(true);
        double memoryUsageInGB = BytesToGB(memoryUsage);
        
        return memoryUsageInGB < MemoryHandler.MAX_MEMORY;
    }

    private static double BytesToGB(long bytes)
    {
        const double GB = 1024 * 1024 * 1024;
        return bytes / GB;
    }
}