﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using KS.FiksProtokollValidator.WebAPI.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json.Linq;

namespace KS.FiksProtokollValidator.WebAPI.Data
{
    public class TestSeeder : ITestSeeder
    {
        private readonly FiksIOMessageDBContext _context;

        public TestSeeder(FiksIOMessageDBContext context)
        {
            _context = context;

            Seed();
        }

        private void Seed()
        {
            var tests = new DirectoryInfo(@"TestCases/");

            foreach (var testDirectory in tests.GetDirectories())
            {
                var testInformationJson =
                    File.ReadAllText(Path.Combine(testDirectory.FullName, "testInformation.json"));
                var testInformation = JObject.Parse(testInformationJson);

                var updateTest = _context.TestCases.Find((string)testInformation["testName"]);
                if (updateTest != null)
                {
                    _context.TestCases.Update(UpdateTest(testDirectory, updateTest, testInformation));
                }
                else
                {
                    var newTestEntry = new TestCase();
                    newTestEntry.TestName = (string) testInformation["testName"];
                    _context.TestCases.Add(UpdateTest(testDirectory, newTestEntry, testInformation));
                }
                _context.SaveChanges();
            }
        }

        private TestCase UpdateTest(DirectoryInfo testDirectory, TestCase testCase, JObject testInformation)
        {
            testCase.MessageType = (string)testInformation["messageType"];
            testCase.PayloadFileName = "arkivmelding.xml";
            testCase.FiksResponseTests = new List<FiksResponseTest>();
            testCase.Description = (string)testInformation["description"];
            testCase.TestStep = (string)testInformation["testStep"];
            testCase.Operation = (string)testInformation["operation"];
            testCase.Situation = (string)testInformation["situation"];
            testCase.ExpectedResult = (string)testInformation["expectedResult"];
            testCase.Supported = (bool)testInformation["supported"];

            var attachmentDirectory = Path.Combine(testDirectory.FullName, "Attachments");
            if (Directory.Exists(attachmentDirectory))
            {
                var payloadAttachmentFileNames = "";

                foreach (var fileInfo in new DirectoryInfo(attachmentDirectory)
                    .GetFiles())
                {
                    payloadAttachmentFileNames += fileInfo.Name + ";";
                }

                testCase.PayloadAttachmentFileNames = payloadAttachmentFileNames.TrimEnd(';');
            }

            foreach (var queryWithExpectedValue in testInformation["queriesWithExpectedValues"])
            {
                var fiksResponseTest = new FiksResponseTest
                {
                    PayloadQuery = (string)queryWithExpectedValue["payloadQuery"],
                    ExpectedValue = (string)queryWithExpectedValue["expectedValue"],
                    ValueType = (SearchValueType)(int)queryWithExpectedValue["valueType"]
                };

                testCase.FiksResponseTests.Add(fiksResponseTest);
            }
            return testCase;
        }
    }
}