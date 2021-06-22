using Core.Entities;

namespace Entities.Dtos
{
    public class GemiDetailDto:IDto
    {


        public int Id { get; set; }
        public int Tonnage { get; set; }
        public int IMONo { get; set; }

        public string GemiSahibiSirket { get; set; }
        public string GemiTipiName { get; set; }
        public string BayrakName { get; set; }
    }
}