
namespace Binary_Tree
{
	public class Tree
	{
		private TreeElement _first;

		private TreeElement _current;
		public int CountElements { get; private set; }
		public Tree()
		{
			CountElements = 0;
		}

		public TreeElement AddElement(int value, TreeElement currentAdd)
		{
			if (CountElements == 0)
			{
				_first = _current = new TreeElement
				{
					Left = null,
					Right = null,
					Parent = null,
					Value = value
				};
				CountElements++;
			}
            if (value == currentAdd.Value)
            {
				currentAdd.NumberRepetitions++;
            }
            if (value > currentAdd.Value)
			{
				if (currentAdd.Right != null)
				{
					AddElement(value, currentAdd.Right);
				}
				else
				{
					var newElemnet = new TreeElement
					{
						Left = null,
						Right = null,
						Parent = _current,
						Value = value,
					};
					currentAdd.Right = newElemnet;
					currentAdd = _first;
					CountElements++;
				}
			}
			if (value < currentAdd.Value)
			{
				if (currentAdd.Left != null)
				{
					AddElement(value, currentAdd.Left);
				}
				else
				{
					var newElemnet = new TreeElement
					{
						Left = null,
						Right = null,
						Parent = _current,
						Value = value,
					};
					currentAdd.Left = newElemnet;
					currentAdd = _first;
					CountElements++;
				}
			}
			return currentAdd;
		}

		public TreeElement SearchItem(out int repeatСount, int value, TreeElement currentSearch, ref bool checkavAilability)
		{
			repeatСount = 0;

			if (value > currentSearch.Value)
			{
				if (currentSearch.Right != null)
				{
					SearchItem(out repeatСount, value, currentSearch.Right, ref checkavAilability);
				}
                else
                {
					currentSearch = _first;
				}
			}
			if (value < currentSearch.Value)
			{
				if (currentSearch.Left != null)
				{
					SearchItem(out repeatСount, value, currentSearch.Left, ref checkavAilability);
                }
                else
                {
					currentSearch = _first;
				}
			}
			if (value == currentSearch.Value)
            {
				repeatСount = currentSearch.NumberRepetitions;
				currentSearch = _first;
				checkavAilability = true;
            }
			return currentSearch;
		}
	}
}
