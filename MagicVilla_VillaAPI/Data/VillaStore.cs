using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
            {
                new VillaDTO{Id = 1, Name ="Pool View", occupancy = 3, sqft = 90},
                new VillaDTO{Id = 2, Name = "Beach View", occupancy = 5 , sqft = 150}
            };
    }
}
