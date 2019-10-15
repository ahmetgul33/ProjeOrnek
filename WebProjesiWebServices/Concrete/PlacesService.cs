using System;
using System.Collections.Generic;
using System.Text;
using WebProjesiDataAccess.Models;

namespace WebProjesiWebServices.Concrete
{
    public class PlacesService : Abstract.IPlacesService
    {
        
            private readonly WebProjesiPosData.Abstract.IPlaceRepository _placeRepository;

            public PlacesService(WebProjesiPosData.Abstract.IPlaceRepository placeRepository)
            {
                _placeRepository = placeRepository;
            }
            public void Add(Place dPlaces)
        {
            _placeRepository.Add(dPlaces);
        }

        public void Delete(Place dPlaces)
        {
            _placeRepository.Delete(dPlaces);
        }

        public IEnumerable<Place> GetAllPlaces()
        {
            return _placeRepository.GetAll();
        }

        public Place GetPlaces(int id)
        {
            return _placeRepository.Get(x => x.Id == id);
        }

        public void Update(Place dPlaces)
        {
            throw new NotImplementedException();
        }
    }
}
