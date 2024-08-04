using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkishLocalFlavors.Business.Abstract;
using TurkishLocalFlavors.Entity.Entities;

namespace TurkishLocalFlavors.Business.Concrete
{
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureService _featureService;

        public FeatureManager(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public void TAdd(Feature entity)
        {
            _featureService.TAdd(entity);
        }

        public void TDelete(Feature entity)
        {
            _featureService.TDelete(entity);
        }

        public Feature TGetByID(int id)
        {
            return _featureService.TGetByID(id);
        }

        public List<Feature> TGetListAll()
        {
           return _featureService.TGetListAll();
        }

        public void TUpdate(Feature entity)
        {
            _featureService.TUpdate(entity);
        }
    }
}
