<Query Kind="Program" />

//namespace TypesSamp
//{
	//define class 1
	public class Class1: object
	{
		private void Method1()
		{
		Console.WriteLine("1 method");
		}
	}
	//define class 2
	public class Class2: Class1
	{
		private void Method2()
		{
			Console.WriteLine("2 method");
		}
	}
	
	class TypeClass
	{
		static void Main(string[] args)
		{
			Class1 cls1 = new Class1();
			Class2 cls2 = new Class2();
			Console.WriteLine("*****************************************************");
			Console.WriteLine("Type Information");
			Console.WriteLine("*****************************************************");
			//Getting type information
			Type type1 = cls1.GetType();
			Type type2 = cls2.GetType();
			Console.WriteLine(type1.BaseType);
			Console.WriteLine(type1.Name);
			Console.WriteLine(type1.FullName);
			Console.WriteLine(type1.Namespace);
			Console.WriteLine("");
			//comparing two objects
			string str1 = "Test";
			string str2 = "Test";
			Console.WriteLine("****************************************************");
			Console.WriteLine("Comparison of two objects");
			Console.WriteLine(Object.Equals(cls1, cls2));
			Console.WriteLine(Object.Equals(str1, str2));
			
		}
	}
//}