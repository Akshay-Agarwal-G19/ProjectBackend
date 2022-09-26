using DemoProject.Data;
using DemoProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Repository
{
    public class WasteProdRepo
    {
        public DemoProjectDbContext _dbContext;
        public WasteProdRepo(DemoProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<WasteProducer> GetWasteProd()
        {
            return _dbContext.WasteProducers;
        }

        public IEnumerable<WasteProducer> GetWasteProdbyfname(string firstName)
        {
            return _dbContext.WasteProducers.Where(i => i.First_Name == firstName);
        }

        public WasteProducer Addwasteprod(WasteProducer wasteprod)
        {
            _dbContext.WasteProducers.Add(wasteprod);
            _dbContext.SaveChanges();
            return wasteprod;
        }
    }
}
