namespace _03.MissionPrivatImpossible
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class Spy
    {
        public string StealFieldInfo(string className, params string[] fieldNames)
        {
            var classType = Type.GetType($"Stealer.{className}");

            var fields = classType
                .GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
                .Where(x => fieldNames.Contains(x.Name));

            var classInstance = Activator.CreateInstance(classType);

            var fieldsInfo = new StringBuilder();

            fieldsInfo.AppendLine($"Class under investigation: {className}");

            foreach (var field in fields)
            {
                fieldsInfo.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return fieldsInfo.ToString().TrimEnd();
        }

        public string AnalyzeAcessModifiers(string className)
        {
            var classType = Type.GetType(className);

            var nonPublicFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public);

            var nonPublicGetters = classType
                .GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                .Where(x => x.Name.StartsWith("get"));

            var publicSetters = classType
                .GetMethods(BindingFlags.Instance | BindingFlags.Public)
                .Where(x => x.Name.StartsWith("set"));

            var result = new StringBuilder();

            foreach (var field in nonPublicFields)
            {
                result.AppendLine($"{field.Name} must be private!");
            }

            foreach (var getter in nonPublicGetters)
            {
                result.AppendLine($"{getter.Name} have to be public!");
            }

            foreach (var setter in publicSetters)
            {
                result.AppendLine($"{setter.Name} have to be private!");
            }

            return result.ToString().TrimEnd();
        }

        public string RevealPrivateMethods(string className)
        {
            var classType = Type.GetType(className);

            var privateMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            var result = new StringBuilder();

            result.AppendLine($"All Private Methods of Class: {className}");
            result.AppendLine($"Base Class: {classType.BaseType.Name}");

            foreach (var method in privateMethods)
            {
                result.AppendLine($"{method.Name}");
            }

            return result.ToString().TrimEnd();
        }
    }
}
