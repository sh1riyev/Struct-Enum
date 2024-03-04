using System;
namespace Sealed_Struct_Enum_Nullable
{
	public sealed class Book 
	{
		public string Name { get; set; }
		public int? Id { get; set; }
		public Author Author{ get; set; }

	}
}

