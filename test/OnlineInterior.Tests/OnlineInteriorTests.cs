using Microsoft.EntityFrameworkCore;
using OnlineInterior.Database;
using OnlineInterior.Models;
using System;
using System.Linq;
using Xunit;

namespace OnlineInterior.Tests
{
    public class OnlineInteriorTests
    {
        [Fact]
        public void CalculateAverageProjectPrice()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "test")
            .Options;
            using(var _appDbContext = new AppDbContext(options))
            {
                IProjectRepository projectRepository = new ProjectRepository(_appDbContext);
                ICollectionOfProjects collectionOfProjectsRepository = new CollectionOfProjectsRepository(projectRepository, _appDbContext);

                var total = collectionOfProjectsRepository.GetCollectionTotalPrice();
                var amount = collectionOfProjectsRepository.AllProjects.Count();
                var expected = total / amount;

                var actual = collectionOfProjectsRepository.GetCollectionAveragePrice();

                Assert.NotNull(collectionOfProjectsRepository);
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CalculateProjectPrice()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "test")
            .Options;
            using (var _appDbContext = new AppDbContext(options))
            {
                IOrderlineRepository orderlineRepository = new OrderlineRepository(_appDbContext);
                IProjectRepository projectRepository = new ProjectRepository(_appDbContext);
                
                Project project = projectRepository.GetProjectById(1);
                var expected = 0;

                foreach (var ordeline in project.Orderlines)
                {
                    expected += ordeline.GetLineTotal();
                }
                var actual = project.GetProjectPrice();

                Assert.NotNull(project);
                Assert.Equal(expected, actual);
            }
        }
    }
}
