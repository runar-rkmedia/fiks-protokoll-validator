#nullable enable
using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using FluentAssertions;
using KS.FiksProtokollValidator.WebAPI.Validation;
using NUnit.Framework;

namespace KS.FiksProtokollValidator.Tests.UnitTest
{
    public class ArkivMeldingUnitTest
    {
        private List<string> _xmlValidationMessages;
        private readonly XmlReaderSettings _xmlReaderSettings;
        private readonly string _baseFilePath;

        
        [DatapointSource]
        public string[] TestCasesValues = 
        {
            "NyJournalpostN1",
            "NyJournalpostN6",
            "NyJournalpostN8",
            "NySaksmappeN1",
            "NySokN1"
        };


        public ArkivMeldingUnitTest()
        {
            _baseFilePath = "./TestCases/no.ks.fiks.gi.arkivintegrasjon.oppdatering.basis.arkivmelding.v1/";
            // Process the message
            var arkivmeldingXmlSchemaSet = new XmlSchemaSet();
            arkivmeldingXmlSchemaSet.Add("http://www.arkivverket.no/standarder/noark5/arkivmelding/v2", "./Schema/arkivmelding.xsd");
            arkivmeldingXmlSchemaSet.Add("http://www.arkivverket.no/standarder/noark5/metadatakatalog/v2", "./Schema/metadatakatalog.xsd");
            arkivmeldingXmlSchemaSet.Add("http://www.ks.no/standarder/fiks/arkiv/sok/v1", "./Schema/sok.xsd");
            _xmlReaderSettings = new XmlReaderSettings
            {
                ValidationType = ValidationType.Schema
            };
            _xmlReaderSettings.Schemas.Add(arkivmeldingXmlSchemaSet);
            _xmlReaderSettings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
            _xmlReaderSettings.ValidationEventHandler += XmlReaderSettingsValidationEventHandler;
        }
        

        [Theory]
        public void ValidateArkivMelding(string caseFolder)
        {
            _xmlValidationMessages = new List<string>();
            try
            {
                using (XmlReader validationReader = XmlReader.Create($"{_baseFilePath}{caseFolder}/arkivmelding.xml", _xmlReaderSettings))
                {
                    try
                    {
                        while (validationReader.Read())
                        { }
                    }
                    catch (XmlException ex)
                    {
                        _xmlValidationMessages.Add(ex.Message + " XSD validering");
                    }
                }
            }
            catch (Exception e)
            {
                _xmlValidationMessages.Add(e.Message + " XSD validering");
            }
            _xmlValidationMessages.Should().BeEmpty();
        }
        
     
        
        private void XmlReaderSettingsValidationEventHandler(object? sender, ValidationEventArgs e)
        {
            switch (e.Severity)
            {
                case XmlSeverityType.Warning:
                    _xmlValidationMessages.Add("linje " + e.Exception.LineNumber + ", posisjon " + e.Exception.LinePosition + " " + e.Message);
                    break;
                case XmlSeverityType.Error:
                    _xmlValidationMessages.Add("linje " + e.Exception.LineNumber + ", posisjon " + e.Exception.LinePosition + " " + e.Message);
                    break;
            }
        }

    }
}