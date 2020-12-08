using System.Linq;
using System.Reflection;

namespace AdventOfCode.Problem
{
    public static class ProblemFactory
    {
        public static IProblem Create<T>() where T : IProblem
        {
            return (IProblem)Assembly.GetExecutingAssembly()
                .CreateInstance(typeof(T).FullName);
        }

        public static void Execute<T>() where T : IProblem
        {
            Create<T>()
                .AppendTime()
                .Solve()
                .ToConsole(GetName<T>());
        }

        private static string GetName<T>() where T : IProblem
        {
            var parts = typeof(T).FullName?.Split('.').TakeLast(3).ToArray();
            return $"{parts[0]}-{parts[2]}";
        }
    }
}