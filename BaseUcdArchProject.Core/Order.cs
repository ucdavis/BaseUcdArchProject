using System;
using System.ComponentModel.DataAnnotations;
using FluentNHibernate.Mapping;
using UCDArch.Core.DomainModel;
using UCDArch.Core.Utils;

namespace BaseUcdArchProject.Core
{
    public class Order : DomainObject
    {
        /// <summary>
        /// This is a placeholder constructor for NHibernate.
        /// A no-argument constructor must be avilable for NHibernate to create the object.
        /// </summary>
        public Order() { }

        public Order(Customer orderedBy)
        {
            Check.Require(orderedBy != null, "orderedBy may not be null");

            OrderedBy = orderedBy;
        }

        [DataType(DataType.Date)]
        public virtual DateTime OrderDate { get; set; }

        [Required]
        [StringLength(12)]
        public virtual string ShipAddress { get; set; }

        [Required]
        public virtual Customer OrderedBy { get; set; }
    }

    public class OrderMap : ClassMap<Order>
    {
        public OrderMap()
        {
            Id(x => x.Id, "OrderID");

            Map(x => x.OrderDate);
            Map(x => x.ShipAddress);

            References(x => x.OrderedBy);
        }
    }
}
