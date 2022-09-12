using MVVMDemo.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo.MVVM.ViewModels
{
     public class PersonViewModel
     {
          public Person Person { get; set; }
          public PersonViewModel()
          {
               Person = new Person
               {
                    Name = "Héctor",
                    Age = 50,
                    Married = true,
                    BirthDate = new DateTime(2000, 08, 05),
                    Weight = 100,
                    Lunchtime = new TimeSpan(10, 0, 0)
               };

          }
     }
}
