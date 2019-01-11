using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Linq_Assignment
{
    public class linq
    {
        public int[] GEtCube_values(int[] a)
        {

            int[] Cube = (from l in a
                          let k = l * l * l
                          where k > 100 && k < 1000
                          select l).ToArray();

            return Cube;

        }

        public List<string> Get_TennisMatch_Players(List<Players> Team1,List<Players> Team2)
        {
            List<string> match = (from l in Team1
                                  from l1 in Team2
                                  where l.Country != l1.Country
                                  select l.playerName + "vs" + l1.playerName).ToList();

            return match;
        }

        public List<Order> Get_Order_Details(List<Order> orders)
        {
            List<Order> order = (from l in orders
                                 orderby l.OrderDate,l.Quantity descending
                                 select new Order
                                 {
                                     ItemName = l.ItemName,
                                     OrderID = l.OrderID,
                                     OrderDate = l.OrderDate,
                                     Quantity = l.Quantity
                                 }).ToList();

            return order;
        }

        public List<Order> Get_Order_GroupedbyMonth(List<Order> orders)
        {
           var o = (from l in orders
                     orderby l.OrderDate.Month descending
                     group l by l.OrderDate.Month
                     );

            List<Order> order = new List<Order>();
            foreach (var item in o)
            {
                Order OR = new Order();

                OR.Month = item.Key;

                foreach (var l in item)
                {
                   

                    OR.OrderID = l.OrderID;
                    OR.ItemName = l.ItemName;
                    OR.OrderDate = l.OrderDate;
                    OR.Quantity = l.Quantity;

                    order.Add(OR);
                }
                
            }

            return order;
        }

        public List<Order> Get_Order_Price_GroupedbyMonth(List<Order> orders,List<Items> items)
        {
            var o = (from l in orders
                     from l1 in items
                     where l.ItemName ==  l1.itemName
                     orderby l.OrderDate.Month descending
                     group new { l.OrderID,l.ItemName,l.OrderDate, l.Quantity , l1.price} by l.OrderDate.Month
                      );

            List<Order> order = new List<Order>();
            foreach (var item in o)
            {
                Order OR = new Order();
                OR.Month = item.Key;

                foreach (var l in item)
                {                  

                    OR.OrderID = l.OrderID;
                    OR.ItemName = l.ItemName;
                    OR.OrderDate = l.OrderDate;
                    OR.totalPrice = l.Quantity * l.price;
                    order.Add(OR);
                }

            }

            
            return order;
        }

        public List<Order> Get_Order_Price_GroupedbyMonth_anonymous_type(List<Order> orders, List<Items> items)
        {
            var o = (from l in orders
                     from l1 in items
                     where l.ItemName == l1.itemName
                     orderby l.OrderDate.Month descending
                     group new { l.OrderID, l.ItemName, l.OrderDate, l.Quantity, l1.price } by l.OrderDate.Month into t
                     select t.ToList()                  
                    
                      );

            List<Order> order = new List<Order>();
            foreach (var item in o)
            {
                foreach (var l in item)
                {
                    Order OR = new Order();
                    OR.Month = l.OrderDate.Month;
                    OR.OrderID = l.OrderID;
                    OR.ItemName = l.ItemName;
                    OR.OrderDate = l.OrderDate;
                    OR.totalPrice = l.Quantity * l.price;
                    order.Add(OR);
                }

            }            
            return order;
        }

        public List<Order> Get_Order_OnConditions_Quantity(List<Order> orders)
        {
            List<Order> order = (from l in orders
                                 where l.Quantity > 0 
                                 select new Order
                                 {
                                     ItemName = l.ItemName,
                                     OrderID = l.OrderID,
                                     OrderDate = l.OrderDate,
                                     Quantity = l.Quantity
                                 }).ToList();

            return order;
        }
        public List<Order> Get_Order_OnConditions_Year(List<Order> orders)
        {
            List<Order> order = (from l in orders
                           where l.OrderDate.Year < DateTime.Now.Year
                           select new Order
                           {
                               ItemName = l.ItemName,
                               OrderID = l.OrderID,
                               OrderDate = l.OrderDate,
                               Quantity = l.Quantity
                           }).ToList();

            return order;
        }

        public Order Get_Order_OnConditions_Lagrest_Quantity(List<Order> orders)
        {
            Order order = (from l in orders
                           orderby l.Quantity descending
                           select new Order
                           {
                               ItemName = l.ItemName,
                               OrderID = l.OrderID,
                               OrderDate = l.OrderDate,
                               Quantity = l.Quantity
                           }).Take(1).SingleOrDefault();



            return order;
        }

        public List<Order> Get_Order_QueryMethod(List<Order> orders)
        {
            List<Order> order = orders.Where(o => o.Quantity > 0 && o.OrderDate.Year < DateTime.Now.Year).OrderByDescending(o => o.Quantity).Select(o => o).ToList();            

            return order;
        }

        public int[] Get_even_number(int[] num)
        {
            int[] output = num.Where(n => n % 2 == 0).Select(n => n).ToArray();

            return output;
        }

        public List<Order> Get_Order_Quantity_Sum(List<Order> orders)
        {
            var o = (from l in orders
                     group new {  l.ItemName, l.Quantity } by l.ItemName into s
                     select new
                     {
                         sum = s.Sum(t=>t.Quantity).ToString(),
                         Name = s.Select(n => n.ItemName).ToString()
                     }
                     );

            List<Order> order = new List<Order>();
            foreach (var item in o)
            {
                Order OR = new Order();
                OR.ItemName = item.Name;
                OR.Quantity = Convert.ToInt32(item.sum);

                order.Add(OR);
            }
            return order;
        }

        public Order Get_Order_Quantity_Maximum(List<Order> orders)
        {
            var o = (from l in orders
                     group l by   l.ItemName into s
                     select new
                     {
                         sum = s.Sum(t => t.Quantity).ToString(),
                         Name = s.Key.ToString()
                     }
                     );


            var od = (from l in orders
                     group l by l.ItemName into s
                     select new
                     {
                         quantity = s.Sum(t => t.Quantity).ToString(),
                         Name = s.Select(n => n.ItemName).ToString()
                     }
                     ).Max(a=>a.quantity);

            var Maximum_order = o.Select(s => s).Where(s => s.sum.ToString() == od.ToString() );
            Order OR = new Order();
            foreach (var item in Maximum_order)
            {
                
                OR.ItemName = item.Name;
                OR.Quantity = Convert.ToInt32(item.sum);
            }
           


            return OR;
        }



    }


}
