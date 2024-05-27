using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repair_OrgTech.Forms;

namespace Repair_OrgTech.Tests
{
    [TestClass]
    public class AutorizationFormTests
    {
        [TestMethod]
        public void Test_Authorization_Success()
        {
            // Arrange
            var authorizationForm = new Autorization_Form();
            var expectedLogin = "login1"; 
            var expectedPassword = "pass1";

            // Act
            authorizationForm.box_Login.Text = "login2";
            authorizationForm.box_Password.Text = "pass1";
            authorizationForm.btn_SignIn_Click(null, null);

            // Assert
            Assert.AreEqual(expectedLogin, authorizationForm.box_Login.Text);
            Assert.AreEqual(expectedPassword, authorizationForm.box_Password.Text);
        }
    }
}
