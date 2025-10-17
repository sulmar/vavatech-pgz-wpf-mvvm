using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models;

public class Customer : BaseEntity
{
  
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; } = string.Empty;
    public Address WorkAddress { get; set; }
    public Address ShippingAddress { get; set; }

}
