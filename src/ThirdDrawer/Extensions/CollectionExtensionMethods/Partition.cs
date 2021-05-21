namespace ThirdDrawer.Extensions.CollectionExtensionMethods
{
    using System.Collections.Generic;

    public sealed class Partition<T>
    {
        public Partition(IEnumerable<T> satisfies, IEnumerable<T> notsatisfies)
        {
            Satisfies = satisfies;
            DoesNotSatisfy = notsatisfies;
        }

        public IEnumerable<T> Satisfies { get; }

        public IEnumerable<T> DoesNotSatisfy { get; }
    }
}