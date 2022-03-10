namespace Swashbuckle.AspNetCore.CrashDemo.Crash;

public record CrashObject(Dictionary<CrashEnum, string> Test); // CrashEnum causes NullReferenceException

public enum CrashEnum
{
    A,
    B
}