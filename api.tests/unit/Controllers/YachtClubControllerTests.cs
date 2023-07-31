using api.Controllers;
using domain.entities;
using infrastructure.tests.Database;
using Microsoft.AspNetCore.Mvc;

namespace api.tests.unit.Controllers;


public class YachClubControllerUnitTestDbContext : UnitTestDbContext
{
    protected override IEnumerable<YachtClub> GenerateYachtClubs() =>
        new YachtClub[]
        {
            new YachtClub
            {
                Id = 1,
                Address1 = "123 some street",
                Address2 = null,
                City = "some city",
                State = "XX",
                Country = "USA",
                Name = "Some yacht club",
                PostalCode = "12345"

            }
        };

}


public abstract class YachtClubControllerTests
{
    protected YachtClubController SystemUnderTest { get; set; }
    public YachtClubControllerTests()
    {
        var db = new YachClubControllerUnitTestDbContext();
        db.Database.EnsureCreated();
        this.SystemUnderTest = new YachtClubController(db);
    }
}

[TestClass]
public class WhenGetIsCalled : YachtClubControllerTests
{
    [TestMethod]
    public async Task ThenAllRecordsAreReturned()
    {
        //arrange

        //act
        var eval = await SystemUnderTest.Get();

        //assert
        eval.Should().BeOfType<OkObjectResult>();
        ((OkObjectResult)eval).Value.Should().NotBeNull();
        ((IEnumerable<YachtClub>)((OkObjectResult)eval).Value).Should().HaveCount(1);

    }


}

