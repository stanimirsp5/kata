using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using static KataCSharp.Common.CommonObjects;

namespace KataCSharp.ProCSharpWithDotNET.DataStructures;

public class FunWithObservableCollection
{

	public void Start()
	{

		var observableList = new ObservableCollection<Employee>();
		observableList.CollectionChanged += ObservableList_CollectionChanged;

		observableList.Add(new Employee { Id = 1, Name = "Pesho" });
		observableList.Add(new Employee { Id = 2, Name = "Misho" });
		observableList.Move(0, 1);
		observableList[1] = new Employee { Id = 3, Name = "Gosho" };
		observableList.RemoveAt(0);

		observableList[0].Id = 5;

		observableList.Clear();
	}

	private void ObservableList_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
	{
		switch (e.Action)
		{
			case NotifyCollectionChangedAction.Add:
				foreach (Employee newItem in e.NewItems!)
					Console.WriteLine($"Added: {newItem.Name}");

				//foreach (INotifyPropertyChanged item in e.NewItems)
				//	item.PropertyChanged += Item_PropertyChanged;
				break;
			case NotifyCollectionChangedAction.Remove:
				foreach (Employee oldItem in e.OldItems!)
				{
					Console.WriteLine($"Removed: {oldItem.Name}");
				}
				break;
			case NotifyCollectionChangedAction.Reset:
				Console.WriteLine("Collection reset");
				break;
			case NotifyCollectionChangedAction.Replace:
				Console.WriteLine("Collection item replaced");
				break;
			case NotifyCollectionChangedAction.Move:
				Console.WriteLine("Collection item moved");
				break;
		}
	}

	private void Item_PropertyChanged(object? sender, PropertyChangedEventArgs e)
	{
		if (sender is Employee emp)
		{
			Console.WriteLine($"Employee {emp.Name} changed property: {e.PropertyName}");
		}
	}

}
