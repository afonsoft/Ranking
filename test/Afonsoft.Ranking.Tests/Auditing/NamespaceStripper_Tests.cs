using Afonsoft.Ranking.Auditing;
using Afonsoft.Ranking.Test.Base;
using Shouldly;
using Xunit;

namespace Afonsoft.Ranking.Tests.Auditing
{
    // ReSharper disable once InconsistentNaming
    public class NamespaceStripper_Tests: AppTestBase
    {
        private readonly INamespaceStripper _namespaceStripper;

        public NamespaceStripper_Tests()
        {
            _namespaceStripper = Resolve<INamespaceStripper>();
        }

        [Fact]
        public void Should_Stripe_Namespace()
        {
            var controllerName = _namespaceStripper.StripNameSpace("Afonsoft.Ranking.Web.Controllers.HomeController");
            controllerName.ShouldBe("HomeController");
        }

        [Theory]
        [InlineData("Afonsoft.Ranking.Auditing.GenericEntityService`1[[Afonsoft.Ranking.Storage.BinaryObject, Afonsoft.Ranking.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null]]", "GenericEntityService<BinaryObject>")]
        [InlineData("CompanyName.ProductName.Services.Base.EntityService`6[[CompanyName.ProductName.Entity.Book, CompanyName.ProductName.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[CompanyName.ProductName.Services.Dto.Book.CreateInput, N...", "EntityService<Book, CreateInput>")]
        [InlineData("Afonsoft.Ranking.Auditing.XEntityService`1[Afonsoft.Ranking.Auditing.AService`5[[Afonsoft.Ranking.Storage.BinaryObject, Afonsoft.Ranking.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[Afonsoft.Ranking.Storage.TestObject, Afonsoft.Ranking.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],]]", "XEntityService<AService<BinaryObject, TestObject>>")]
        public void Should_Stripe_Generic_Namespace(string serviceName, string result)
        {
            var genericServiceName = _namespaceStripper.StripNameSpace(serviceName);
            genericServiceName.ShouldBe(result);
        }
    }
}
