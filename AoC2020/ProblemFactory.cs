using System.Reflection;

namespace AoC2020
{
    public static class ProblemFactory
    {
        public static IProblem Create<T>() where T : IProblem
        {
            return (IProblem)Assembly.GetExecutingAssembly()
                .CreateInstance(typeof(T).FullName);
        }
    }
}