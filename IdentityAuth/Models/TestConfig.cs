using System.Collections.Generic;

namespace IdentityAuth.Models
{
    public class TestConfig
    {
        public int Id { get; set; }
        public int  AdmissionReferenceId { get; set; }
        public int BatchId { get; set; }
        public int SesionId { get; set; }
        public decimal MinimumGPA { get; set; }
        public decimal PassMark { get; set; }
        public virtual List<TestConfigDetails> TestConfigDetails { get; set; } = new List<TestConfigDetails>();
    }
}
