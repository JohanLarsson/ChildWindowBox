using System;
using System.Collections.ObjectModel;

namespace ChildWindowBox
{
    public class ViewModel
    {
        public string Name { get; } = "Foo";
        public DateTime Begin { get; } = DateTime.Now.AddDays(-4);
        public DateTime End { get; } = DateTime.Now;

        public ObservableCollection<string> Empty { get; } = new ObservableCollection<string>();
    }
}
