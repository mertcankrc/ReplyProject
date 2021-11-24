using Microsoft.AspNetCore.Mvc;
using Models.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Business;

namespace WebApi.Controllers
{
    public class DemandsController : Controller
    {
        [HttpGet]
        [Route("GetDemandsList")]
        public List<Demands> GetDemandsList()
        {
            DemandsBusiness demandB = new DemandsBusiness();
            return demandB.GetDemandList();
        }

        [HttpDelete]
        [Route("DeleteDemandsById")]

        public bool DeleteDemandsById(int id)
        {
            DemandsBusiness demandB = new DemandsBusiness();
            return demandB.DeleteDemand(id);
        }

        [HttpPost]
        [Route("AddDemands")]

        public bool AddDemands(Demands demand)
        {
            DemandsBusiness demandB = new DemandsBusiness();
            return demandB.AddDemand(demand);
        }

        [HttpPut]
        [Route("UpdateDemands")]

        public bool UpdateDemands(Demands demand)
        {
            DemandsBusiness demandB = new DemandsBusiness();
            return demandB.UpdateDemand(demand);
        }
    }
}
