using OnlineInterior.Database;

namespace OnlineInterior.Models
{
    public class DesignerRepository : IDesignerRepository
    {
        private readonly AppDbContext _appDbContext;

        public DesignerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public string UserName
        {
            get
            {
                return UserName;
            }
        }
    }
}
