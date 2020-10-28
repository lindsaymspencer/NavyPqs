using NavyPqs.Models;
using NUnit.Framework;

namespace NavyPqsTestFixture.Models
{
    public class OfficerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TearDown]
        public void TearDown()
        {
            Services.FileIoForTests.TearDown();
        }

        [Test]
        public void CreatesTwoBravoPqs()
        {
            var expected = "{\"FirstName\":\"Lindsay\",\"LastName\":\"Spencer\",\"Rank\":\"LTJG\",\"TwoBravo\":{\"Sections\":[{\"Name\":\"Safety Precautions Fundamentals\",\"Number\":\"101\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false,\"7\":false,\"8\":false}},{\"Name\":\"Maintenance Fundamentals\",\"Number\":\"102\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false}},{\"Name\":\"Security Fundamentals\",\"Number\":\"103\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false,\"7\":false,\"8\":false}},{\"Name\":\"Leadership Fundamentals\",\"Number\":\"104\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false,\"7\":false,\"8\":false,\"9\":false,\"10\":false,\"11\":false,\"12\":false,\"13\":false,\"14\":false,\"15\":false,\"16\":false,\"17\":false,\"18\":false,\"19\":false,\"20\":false}},{\"Name\":\"Terminology Fundamentals\",\"Number\":\"105\",\"Signatures\":{\"1\":false}},{\"Name\":\"U.S. Navy Org. and Naval/Joint Platforms\",\"Number\":\"106\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6.a\":false,\"6.b\":false,\"6.c\":false,\"6.d\":false,\"6.e\":false,\"6.f\":false,\"6.g\":false,\"6.h\":false,\"6.i\":false,\"6.j\":false,\"7\":false,\"8\":false,\"9\":false,\"10\":false,\"11\":false,\"12\":false}},{\"Name\":\"Navy Planning Process Fundamentals\",\"Number\":\"107\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false,\"7\":false,\"8\":false,\"9\":false,\"10\":false,\"11\":false,\"12\":false,\"13\":false}},{\"Name\":\"Roe and Authorities Fundamentals\",\"Number\":\"108\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false,\"7\":false}},{\"Name\":\"Intelligence Oversight Fundamentals\",\"Number\":\"109\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false}},{\"Name\":\"Radio Prop and Signal Char. Fundamentals\",\"Number\":\"110\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false,\"7\":false,\"8\":false,\"9\":false,\"10\":false,\"11\":false}},{\"Name\":\"Radar Fundamentals\",\"Number\":\"111\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false,\"7\":false,\"8\":false,\"9\":false}},{\"Name\":\"Electronic Warfare Fundamentals\",\"Number\":\"112\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false,\"7\":false,\"8\":false,\"9\":false,\"10\":false,\"11\":false,\"12\":false,\"13\":false,\"14\":false,\"15\":false,\"16\":false,\"17\":false}},{\"Name\":\"Antiship Ship Missile Defense (ASMD) Fundamentals\",\"Number\":\"113\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false,\"7\":false,\"8\":false,\"9\":false,\"10\":false}},{\"Name\":\"Countering Intelligence, Surveillance, Reconnaissance, and Targeting (C-ISRT) Fundamentals\",\"Number\":\"114\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false,\"7\":false,\"8\":false,\"9\":false,\"10\":false,\"11\":false,\"12\":false,\"13\":false,\"14\":false,\"15\":false,\"16\":false}},{\"Name\":\"National Collection Management Fundamentals\",\"Number\":\"115\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false,\"7\":false,\"8\":false,\"9\":false,\"10\":false,\"11\":false}},{\"Name\":\"Distributed Signals Intelligence (SIGINT) Operations (DSO) Fundamentals\",\"Number\":\"116\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false,\"7\":false,\"8\":false}},{\"Name\":\"Direction Finding and Geolocation Fundamentals\",\"Number\":\"117\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false,\"7\":false,\"8\":false}},{\"Name\":\"Signal Intelligence (SIGINT) Reporting Fundamentals\",\"Number\":\"118\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false,\"7\":false}},{\"Name\":\"Cryptologic Warfare Systems Fundamentals\",\"Number\":\"119\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false,\"7\":false}},{\"Name\":\"Communications Fundamentals\",\"Number\":\"120\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false,\"7\":false,\"8\":false,\"9\":false,\"10\":false,\"11\":false,\"12\":false,\"13\":false,\"14\":false,\"15\":false}},{\"Name\":\"Networking Fundamentals\",\"Number\":\"121\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false,\"7\":false,\"8\":false,\"9\":false,\"10\":false,\"11\":false}},{\"Name\":\"Cybersecurity Fundamentals\",\"Number\":\"122\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false,\"7\":false}},{\"Name\":\"Cyberspace Operations Fundamentals\",\"Number\":\"123\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false,\"7\":false,\"8\":false,\"9\":false}},{\"Name\":\"National/Theater Level Support Fundamentals\",\"Number\":\"124\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false}},{\"Name\":\"Fleet Cryptologic Operations Fundamentals\",\"Number\":\"125\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false,\"7\":false,\"8\":false,\"9\":false,\"10\":false}},{\"Name\":\"Naval Special Warfare Tactical Information Operations (TIO) Fundamentals\",\"Number\":\"126\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false}},{\"Name\":\"Information Operations Fundamentals\",\"Number\":\"127\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false,\"7\":false}},{\"Name\":\"Military Deception (MILDEC) Fundamentals\",\"Number\":\"128\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false,\"7\":false,\"8\":false,\"9\":false,\"10\":false,\"11\":false,\"12\":false}},{\"Name\":\"Military Information Support Operations (MISO) Fundamentals\",\"Number\":\"129\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false,\"7\":false,\"8\":false,\"9\":false,\"10\":false,\"11\":false,\"12\":false,\"13\":false,\"14\":false,\"15\":false}},{\"Name\":\"Operations Security (OPSEC) Fundamentals\",\"Number\":\"130\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false,\"6\":false,\"7\":false,\"8\":false,\"9\":false,\"10\":false,\"11\":false,\"12\":false,\"13\":false,\"14\":false,\"15\":false,\"16\":false}},{\"Name\":\"Publications and Mission Associated Directives Fundamentals\",\"Number\":\"131\",\"Signatures\":{\"1\":false,\"2\":false,\"3\":false,\"4\":false,\"5\":false}}]}}";
            var officer = new Officer();
            var actual = officer.ToJson();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ExportsTwoBravoPqs()
        {
            Services.FileIoForTests.CreateTestDirectory();
            var officer = new Officer();
            var actual = officer.Export(Services.FileIoForTests.TestDirectory);

            Assert.IsTrue(actual);

        }
    }
}