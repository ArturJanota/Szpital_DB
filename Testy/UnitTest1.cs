using Moq;
using NUnit.Framework;
using Projekt_Szpital.Interface;
using Projekt_Szpital.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace Testy
{
    public class UnitTest1      //dummy
    {
        [Test]
        public void Test1()
        {
            string stan = null;
            int pesel = It.IsAny<int>();



            Action act = () => new Pacjent(pesel, stan);

            act.ShouldThrow<ArgumentNullException>();
        }
        [Test]
        public void Test2()     //stub
        {
            var pacjentVali = new PacjentVali();
            var pacjent = Mock.Of<IPacjent>(c => c.getPacjentById(2).ID == 2);
            bool validate = pacjentVali.Validate(pacjent);
            validate.Should().BeTrue();
        }

        public class FakeRepo      //fake
        {
            private readonly IPacjent pacjent;


            public FakeRepo(IPacjent a)
            {
                pacjent = a;
            }


            public string raport()
            {
                return string.Join(pacjent.getAll.Select(x => x.Pesel));
            }
        }

        public class fakerepo : IPacjent
        {


            public IReadOnlyList<IPacjent> pacjents = new List<IPacjent>();

            IReadOnlyList<IPacjent> IPacjent.pacjents => throw new NotImplementedException();

            public Pacjent getPacjentById(int id)
            {
                throw new NotImplementedException();
            }

            public void post(Pacjent pacjent)
            {
                this.pacjents.Add(pacjent);
            }

            public void put(int pacjentID, int pesel)
            {
                throw new NotImplementedException();
            }

        }


        [Test]
        public void Fakexample()
        {
            var pacjentRepository = new fakerepo();
            pacjentRepository.Add(Mock.Of<IPacjent>)(c => c.Pesel == 12345678912 && c.Stan_przyjecia == "Uraz nogi");
            pacjentRepository.Add(Mock.Of<IPacjent>)(c => c.Pesel == 12345678913 && c.Stan_przyjecia == "Uraz reki");
            var reportservis = new FakeRepo(pacjentRepository);
            string report = reportservis.raport();

            report.Should().Be("12345678912\n12345678913");

        }
        [Test]
        public void mock()
        {
            var pacjentVali = new PacjentVali();
            var pacjent = Mock.Of<IPacjent>(c => c.getPacjentById(2).ID == 2);
            pacjentVali.Validate(pacjent);
            Mock.Get(pacjent).Verify(x => x.getPacjentById(2));

        }
        [Test]
        public void inmemorytestcontroller()
        {
            _contextOptions = new DbContextOptionsBuilder<FakeRepo>()
       .UseInMemoryDatabase("inmemorytestcontroller test")
       .ConfigureWarnings(b => b.Ignore(InMemoryEventId.TransactionIgnoredWarning))
       .Options;

            using var context = new FakeRepo(_contextOptions);
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.AddRange(
                new Pacjent { ID = 1, Pesel = 12345678 },
                new Pacjent { ID = 2, Pesel = 12345679 });

            context.SaveChanges();
        }
    }
         
}
