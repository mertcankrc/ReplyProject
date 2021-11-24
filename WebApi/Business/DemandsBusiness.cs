using Models.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Data;

namespace WebApi.Business
{
    public class DemandsBusiness
    {
        public List<Demands> GetDemandList()
        {

            using (var ctx = new ReplyProjectContext())
            {
                var demands = ctx.demands.ToList();
                return demands;
            }
        }

        public bool DeleteDemand(int id)
        {
            using (var ctx = new ReplyProjectContext())
            {
                try
                {
                    var demand = ctx.demands.Where(x => x.Id == id).FirstOrDefault();
                    ctx.Remove(demand);
                    ctx.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
        }

        public bool AddDemand(Demands demand)
        {
            using (var ctx = new ReplyProjectContext())
            {
                try
                {
                    ctx.Add(demand);
                    ctx.SaveChanges();
                    return true;
                }
                catch (Exception Ex)
                {
                    return false;
                }

            }
        }

        public bool UpdateDemand(Demands demand)
        {
            using (var ctx = new ReplyProjectContext())
            {
                try
                {
                    var updateDemand = ctx.demands.Where(x => x.Id == demand.Id).FirstOrDefault();
                    updateDemand.CheckOutPlace = demand.CheckOutPlace;
                    updateDemand.CheckOutTime = demand.CheckOutTime;
                    updateDemand.CheckInPlace = demand.CheckInPlace;
                    updateDemand.CheckInTime = demand.CheckInTime;
                    updateDemand.DesiredModel = demand.DesiredModel;
                    updateDemand.DesiredEngine = demand.DesiredEngine;
                    updateDemand.DesiredInfotainmentSystem = demand.DesiredInfotainmentSystem;
                    updateDemand.DesiredDesign = demand.DesiredDesign;

                    ctx.SaveChanges();
                    return true;


                }
                catch
                {
                    return false;
                }

            }
        }
    }
}
