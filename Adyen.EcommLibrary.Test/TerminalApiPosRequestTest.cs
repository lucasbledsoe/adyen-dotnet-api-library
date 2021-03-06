﻿using Adyen.EcommLibrary.Security;
using Adyen.EcommLibrary.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Adyen.EcommLibrary.Model.Nexo;

namespace Adyen.EcommLibrary.Test
{
    [TestClass]
    public class TerminalApiPosRequestTest : BaseTest
    {
        private EncryptionCredentialDetails _encryptionCredentialDetails;

        [TestInitialize]
        public void Initialize()
        {
            _encryptionCredentialDetails = new EncryptionCredentialDetails
            {
                AdyenCryptoVersion = 1,
                KeyIdentifier = "CryptoKeyIdentifier12345",
                Password = "p@ssw0rd123456"
            };
        }
        
        [TestMethod]
        public void TestTerminalApiRequest()
        {
            try
            {
                //dummy header
                var messageHeader = MockNexoMessageHeaderRequest();

                //encrypt the request using encryption credentials
                var paymentRequest = MockPosApiRequest.CreatePosPaymentRequest("Request");
                //create a mock client
                var client = CreateMockTestClientPosApiRequest("Mocks/pospayment-encrypted-success.json");
                var payment = new PosPayment(client);
                var saleToPoiResponse = payment.TerminalApiLocal(paymentRequest, messageHeader, _encryptionCredentialDetails);

                Assert.IsNotNull(saleToPoiResponse);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}
