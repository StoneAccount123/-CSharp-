using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work
{
    class OrderService
    {
        Dictionary<int,Order> ordermap;

        public OrderService()
        {
            ordermap = new Dictionary<int,Order>();
        }

        public void addOrUpdate(Order o)
        {
            ordermap.Add(o.ods.id,o);
        }

        public bool removeById(Order o)
        {
            return ordermap.Remove(o.ods.id);
        }

        public List<Order> selectAll()
        {
            return(from order
             in ordermap.Values
             orderby order.ods.id
             select order
              ).ToList();
        }

        public Order selectByid(int ID)
        {
            return (Order)(from order
              in ordermap.Values
              where order.ods.id == ID
                    select order
              );
        }

        public Order selectBypname(string pname)
        {
            return (Order)(from order
              in ordermap.Values
                           where order.ods.pname == pname
                           select order
              );
        }

        public List<Order> selectByclient(string client)
        {
            return (from order
              in ordermap.Values
                           where order.ods.client == client
                           orderby order.ods.id
                           select order
              ).ToList();
        }

        public List<Order> selectBymoney(int money)
        {
            return (from order
              in ordermap.Values
                    where order.ods.money == money
                    orderby order.ods.id
                    select order
              ).ToList();
        }

    }
}
