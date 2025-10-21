using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models;

public partial class Customer : BaseEntity, IEnumerable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; } = string.Empty;
    public Address WorkAddress { get; set; }
    public Address ShippingAddress { get; set; }
    public string FullName => $"{FirstName} {LastName}";

    // Fody.Timer
    // [Timer]
    public void DoWork()
    {
        // Stopwatch stopwatch = Stopwatch.StartNew();

        Console.WriteLine("working...");

       // stopwatch.Stop();

       // Console.WriteLine(stopwatch.Elapsed.ToString());
    }

    public IEnumerator GetEnumerator()
    {
        yield return FirstName;
        yield return LastName;
        yield return Email;
    }
}

public partial class Customer
{
    public void Remove()
    {

    }

    public void Update()
    {

    }
}
