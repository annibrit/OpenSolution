using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;

namespace Open.Tests
{
    public class IsTestedBase
    {
        protected const string IsNotTestedMessage = "<{0}> is not tested";
        private const string no_classes_in_assembly_message = "No classes in assembly {0}";
        private const string no_classes_in_namespace_message = "No classes in namespace {0}";
        private const string test_assembly = "Open.Tests";
        private const string assembly = "Open";
        private const char generics_char = '`';
        private const char internal_class = '+';
        private const string display_class = "<>";
        private const string shell32 = "Shell32.";
        protected List<string> List;

        private void RemoveSurrogateClasses()
        {
            List.RemoveAll(o => o.Contains(shell32));
            List.RemoveAll(o => o.Contains(internal_class));
        }

        protected void GetMembers(string assemblyName, string namesapecName = null)
        {
            var l = LoadClasses(assemblyName);
            RemoveNotInNamespace(l, namesapecName);
            RemoveSurrogateClasses();
            //RemoveInterfacs(l);
            //RemoveAbstractClasses(l);
            RemoveTested();
        }

        private void RemoveNotInNamespace(List<Type> classes, string namesapecName)
        {
            List = classes.Select(o => o.FullName).ToList();
            if (string.IsNullOrEmpty(namesapecName)) return;
            if (!string.IsNullOrEmpty(namesapecName))
                List.RemoveAll(o => !o.StartsWith(namesapecName));
            if (List.Count > 0) return;
            Assert.Inconclusive(no_classes_in_namespace_message, namesapecName);
        }

        private void RemoveTested()
        {
            var tests = GetSolution.ClassesNames(test_assembly);
            for (var i = List.Count; i > 0; i--)
            {
                var member = List[i - 1];
                member = member.Substring(assembly.Length);
                var idx = member.IndexOf(generics_char);
                if (idx > 0)
                    member = member.Substring(0, idx);
                member = member + "Tests";
                var t = tests.Find(o => o.EndsWith(member));
                if (!ReferenceEquals(null, t))
                    List.RemoveAt(i - 1);
                if (member.Contains(display_class))
                    List.RemoveAt(i - 1);
            }
        }

        protected static List<Type> LoadClasses(string assemblyName)
        {
            var l = GetSolution.Classes(assemblyName);
            if (l.Count == 0)
                Assert.Inconclusive(no_classes_in_assembly_message, assemblyName);
            return l;
        }

        protected static void RemoveAbstractClasses(IList<Type> types)
        {
            for (var i = types.Count; i > 0; i--)
            {
                var e = types[i - 1];
                if (!e.IsInterface) continue;
                types.Remove(e);
            }
        }

        protected static void RemoveInterfacs(IList<Type> types)
        {
            for (var i = types.Count; i > 0; i--)
            {
                var e = types[i - 1];
                if (!e.IsAbstract) continue;
                types.Remove(e);
            }
        }

        [TestInitialize]
        public void CreateList()
        {
            List = new List<string>();
        }

        [TestCleanup]
        public void AreNotTested()
        {
            if (List.Count == 0)
                return;
            Assert.Inconclusive(IsNotTestedMessage, List[0]);
        }

        protected virtual string Namespace(string name)
        {
            return $"{assembly}.{name}";
        }
    }
}