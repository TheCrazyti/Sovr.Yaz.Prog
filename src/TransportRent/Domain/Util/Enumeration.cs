using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Util
{
    public abstract record Enumeration<T> where T : Enumeration<T>
    {
        public int Key { get; }
        public string Name { get; }

        protected Enumeration(int key, string name)
        {
            Key = key;
            Name = name;
        }

        public static T FromName(string name)
        {
            foreach(KeyValuePair<int, Func<T>> element in _factories)
            {
                Func<T> factory = element.Value;
                T enumeration = factory();
                if(enumeration.Name == name)
                {
                    return enumeration;
                }
            }
            throw new ArgumentException("Перечисления с таким названием не существует");
        }

        public static T FromKey(int key)
        {
            if(_factories.TryGetValue(key, out Func<T>? factory) == false)
            {
                throw new InvalidOperationException("Перечисления с таким ключом не существует");
            }
            return factory();
        }

        private static Dictionary<int, Func<T>> _factories = ScanEnumeration();

        private static Dictionary<int, Func<T>> ScanEnumeration()
        {
            Type type = typeof(T);
            Type[] types = type.Assembly.GetTypes();
            types = types.Where(t=>t.IsSubclassOf(type)&&t.IsAbstract==false).ToArray();
            Dictionary<int, Func<T>> factories = [];
            foreach (Type arrayEntry in types)
            {
                System.Reflection.ConstructorInfo? constructor = arrayEntry.GetConstructors().SingleOrDefault(t => t.GetParameters().Length == 0);
                Func<T> factory = () =>
                {
                    object concretenum = constructor.Invoke(null);
                    T enumeration = (T)concretenum;
                    return enumeration;
                };
                T enumeration = factory();
                int key = enumeration.Key;
                factories.Add(key, factory);
            }
            return factories;
        }
    }
}
