namespace ListFiltering;

public class ListFilterer
{
    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        var result = new List<int>() { };
        for (var index = 0; index < listOfItems.Count; index++)
        {
            var item = listOfItems[index];
            if (item.GetType().Name == "Int32" || item.GetType().Name == "Int64" || item.GetType().Name == "Double")
            {
                result.Add((int)item);
            }
        }
        return result;
    }
}