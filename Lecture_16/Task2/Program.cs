using System;
using System.Linq;
using System.Reflection;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Type typeProduct = typeof(Product);
            ConstructorInfo ctor = typeProduct.GetTypeInfo()
                .DeclaredConstructors.Single();

            Object[] parameters = new Object[0];
            object obj = ctor.Invoke(parameters);
            Console.WriteLine($"Created is {obj.GetType()}");

            FieldInfo fieldInfo = obj.GetType().GetTypeInfo().GetDeclaredField("_id");
            Console.WriteLine($"Field Name is {fieldInfo.Name}");
            Console.WriteLine($"Is Private - {fieldInfo.IsPrivate}");
            Console.WriteLine(obj.ToString());
            
            fieldInfo.SetValue(obj, Guid.NewGuid());
            Console.WriteLine(obj.ToString());

            PropertyInfo propertyInfo = obj.GetType().GetTypeInfo().GetDeclaredProperty("Name");
            propertyInfo.SetValue(obj, "Iphone 12 PRo");
            Console.WriteLine(obj.ToString());
            FieldInfo fieldInfo1 = obj.GetType().GetTypeInfo().GetDeclaredField("ProductType");
            Console.WriteLine($"Field Name is {fieldInfo1.Name}");
            Console.WriteLine($"Is Private - {fieldInfo1.IsPrivate}");

            //С константой не понятно
            FieldInfo fieldInfo3 = obj.GetType().GetTypeInfo().GetDeclaredField("ProductType");
            object obj3 = fieldInfo.GetRawConstantValue();
            obj3 = 123;
            Console.WriteLine(obj.ToString());
           
        }
    }
    public class Product
    {
        public const string ProductType = "Phone";
        private Guid _id;
        public Guid Id { get { return _id; } }

        public string Name { get; set; }

        public Product()
        {
            _id = Guid.NewGuid();
        }
        public override string ToString()
        {
            return $"Your Id = {Id}, Name - {Name}.";
        }
    }
}
