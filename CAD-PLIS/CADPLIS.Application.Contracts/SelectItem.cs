using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts
{
    public class SelectItem<T> : IEquatable<SelectItem<T>>
    {
        public T Id { get; set; }

        public bool Selected { get; set; }

        public string DisplayValue { get; set; }
        public int? ParentId { get; set; }
        public int MId { get; set; }
        public List<SelectItem<T>> Children { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as SelectItem<T>);
        }

        public bool Equals(SelectItem<T> other)
        {
            return other != null &&
                   Id.Equals(other.Id);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return DisplayValue ?? " - ";
        }

        public static bool operator ==(SelectItem<T> left, SelectItem<T> right)
        {
            return EqualityComparer<SelectItem<T>>.Default.Equals(left, right);
        }

        public static bool operator !=(SelectItem<T> left, SelectItem<T> right)
        {
            return !(left == right);
        }
    }
}
