using System;

namespace homework11
{
    public class Order
    {
        public string ProductName;
        public readonly int VendorCode;
        public string СourierSurname;
        public readonly int RequestNumber;
        public DateTime DeliveryTime;
        public DType OrderType;
        public Order(string productname, int vendorcode, string couriersurname, int requestnumber, string deliverytime, DType ordertype)
        {
            ProductName = productname;
            VendorCode = vendorcode;
            СourierSurname = couriersurname;
            OrderType = ordertype;
        }
        public override string ToString()
        {
            return $" Имя товара:{ProductName}. Артикул: {VendorCode}.";
        }
        public void PrintInfo()
        {
            Console.WriteLine(this);

            var ordertype = "";
            switch (OrderType)
            {
                case DType.Regular:
                    ordertype = "обычный";
                    break;
                case DType.Express:
                    ordertype = "срочный";
                    break;
            }
            Console.WriteLine($"Фамилия курьера: {СourierSurname}. Номер заявки: {RequestNumber}. Дата доставки: {DeliveryTime:d}. Тип заказа: {ordertype}.");
        }

        }
    }

