using Microsoft.AspNetCore.Mvc;
using IdentityAuth.Models;

namespace IdentityAuth.Controllers
{
    public class TestConfigController : Controller
    {
        private readonly ApplicationDbContext context;

        public TestConfigController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            TestConfig testConfig = new TestConfig();
            testConfig.TestConfigDetails.Add(new TestConfigDetails());
            testConfig.TestConfigDetails.Add(new TestConfigDetails());
            testConfig.TestConfigDetails.Add(new TestConfigDetails());
            testConfig.TestConfigDetails.Add(new TestConfigDetails());
            testConfig.TestConfigDetails.Add(new TestConfigDetails());
            testConfig.TestConfigDetails.Add(new TestConfigDetails());
            return View(testConfig);
        }

        [HttpPost]
        public IActionResult Create(TestConfig testConfig)
        {
            for (int i = 0; i < testConfig.TestConfigDetails.Count; i++)
            {

               var index = testConfig.TestConfigDetails.FindIndex(tcd => tcd.SubjectId == -1);
                testConfig.TestConfigDetails.RemoveAt(index);
            }
            context.Add(testConfig);
            context.SaveChanges();
            return View(testConfig);
        }
    }
}
