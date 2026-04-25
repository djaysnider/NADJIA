using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Nadjia
{
    public class SortableBindingList<T> : BindingList<T>
    {
        private bool _isSorted;
        private ListSortDirection _sortDirection;
        private PropertyDescriptor _sortProperty;

        public SortableBindingList()
        {
        }

        public SortableBindingList(IList<T> list) : base(list)
        {
        }

        protected override bool SupportsSortingCore
        {
            get { return true; }
        }

        protected override bool IsSortedCore
        {
            get { return _isSorted; }
        }

        protected override PropertyDescriptor SortPropertyCore
        {
            get { return _sortProperty; }
        }

        protected override ListSortDirection SortDirectionCore
        {
            get { return _sortDirection; }
        }

        protected override void ApplySortCore(
            PropertyDescriptor property,
            ListSortDirection direction)
        {
            List<T> items = this.Items as List<T>;

            if (items == null)
                return;

            if (direction == ListSortDirection.Ascending)
            {
                items.Sort((x, y) => CompareValues(
                    property.GetValue(x),
                    property.GetValue(y)));
            }
            else
            {
                items.Sort((x, y) => CompareValues(
                    property.GetValue(y),
                    property.GetValue(x)));
            }

            _sortProperty = property;
            _sortDirection = direction;
            _isSorted = true;

            this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        protected override void RemoveSortCore()
        {
            _isSorted = false;
        }

        private int CompareValues(object x, object y)
        {
            if (x == null && y == null)
                return 0;

            if (x == null)
                return -1;

            if (y == null)
                return 1;

            IComparable comparable = x as IComparable;

            if (comparable != null)
                return comparable.CompareTo(y);

            return x.ToString().CompareTo(y.ToString());
        }
    }
}