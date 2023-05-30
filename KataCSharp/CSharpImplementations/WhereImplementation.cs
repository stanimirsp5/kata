namespace KataCSharp.CSharpImplementations
{
    public class WhereImplementation
    {
        public void Start()
        {
            var list = new List<int>() { 1,2,3,4,5,6,7,8,9};
            var t = list.CWhere(x => x > 5);
        }
    }

    public static class WhereImpl
    {
        public static IEnumerable<T> CWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {

            foreach (var item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }

        }
    }
}
