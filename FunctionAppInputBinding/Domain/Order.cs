using System;

namespace FunctionAppInputBinding.Domain
{
    public class Order
    {
        public Guid? Id { get; set; }
        public string CustName { get; set; }

        public DateTime Received { get; set; }
    }
}
