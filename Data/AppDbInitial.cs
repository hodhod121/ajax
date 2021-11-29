using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MyGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame.Data
{
    public class AppDbInitial
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<MyGameContext>();
                if (!context.Person.Any())
                {
                    context.Person.AddRange(
                        new PersonModel {name="Mozafar",phone_number="0345432",city="Bodjnord" },
                        new PersonModel {name="Samandar",phone_number="076584358",city="Byar" },
                        new PersonModel {name="Mamy",phone_number="086875423",city="Ashkhaneh" }
                        );
                }
                context.SaveChanges();
            }
        }
    }
}
