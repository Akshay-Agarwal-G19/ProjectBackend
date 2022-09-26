using DemoProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Data
{
    public static class InitialData
    {
        public static void Seed(this DemoProjectDbContext dbContext)
        {
            

            if (!dbContext.WasteProducers.Any())
            {
                dbContext.WasteProducers.Add(new WasteProducer
                {
                    Username = "Akshay1",
                    Password = "1234",
                    First_Name = "Akshay",
                    Last_Name = "Agarwal",
                    Phone_No = 1234567809,
                });

                dbContext.WasteProducers.Add(new WasteProducer
                {
                    Username = "Anand1",
                    Password = "5678",
                    First_Name = "Anand",
                    Last_Name = "Bhalotia",
                    Phone_No = 1234567089,
                });

                dbContext.WasteProducers.Add(new WasteProducer
                {
                    Username = "Arjun1",
                    Password = "4567",
                    First_Name = "Arjun",
                    Last_Name = "Nigam",
                    Phone_No = 1234560789,
                });

                dbContext.SaveChanges();
            }

           
        }
    }
}
