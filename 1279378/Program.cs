using _1279378.DependencyInjection;
using _1279378.Repositoryfactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1279378
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRepoFactory repoFactory = new RepositoryFactory();
            Test test = new Test(repoFactory);
            test.Run();
            MethodTest methodTest = new MethodTest();
            methodTest.MethodRun(repoFactory);
            Console.ReadLine();
        }
    }
}
