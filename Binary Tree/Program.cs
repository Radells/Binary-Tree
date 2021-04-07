using System;

namespace Binary_Tree
{
	public class Program
	{
		static void Main(string[] args)
		{
			Tree t = new Tree();
			int repeatСount;
			var checkavAilability = false;
			var tree = new TreeElement();
			var mas = new int[]
			{
				5,
				7,
				8,
				32,
				2,
				73,
				81,
				1,
				3,
				15,
				4,
				0,
				18,
				47,
				9,
				1,
				10,
				1,
				45,
				40,
				1,
			};
			for (var i = 0; i < mas.Length; i++)
			{
				tree = t.AddElement(mas[i], tree);
			}
			for(var i = 0; i < mas.Length; i++)
            {
				tree = t.SearchItem(out repeatСount, mas[i], tree, ref checkavAilability);
				Console.WriteLine($"Отправлено число {mas[i]}, количество повторений: {repeatСount}");
			}
		}
	}
}
