//using Repair_OrgTech;

//namespace LoginFormTests
//{
//    public class Tests
//    {
//        [SetUp]
//        public void Setup()
//        {
//            // ���������� � ������������, ���� ����������
//        }

//        [Test]
//        public void TestSuccessfulSignIn()
//        {
//            // ������� ����� ��� ������������
//            Autorization_Form autorization_Form = new Autorization_Form();

//            // ��������� ����� � ������ ��� ��������� �����
//            autorization_Form.box_Login.Text = "user1";
//            autorization_Form.box_Password.Text = "password1";

//            // �������� ����� ��� ��������
//            autorization_Form.btn_SignIn_Click(null, null);
//        }

//        [Test]
//        public void TestInvalidCredentials()
//        {
//            // ������� ����� ��� ������������
//            Autorization_Form loginForm = new Autorization_Form();

//            // ��������� ������������ ����� � ������
//            loginForm.box_Login.Text = "invalidUser";
//            loginForm.box_Password.Text = "invalidPassword";

//            // �������� ����� ��� ��������
//            loginForm.btn_SignIn_Click(null, null);

//            // ���������, ��� ��������� �� ������ ���������
//            Assert.IsTrue(loginForm.errorMessageShown);
//        }

//        [Test]
//        public void TestExceptionHandling()
//        {
//            // ������� ����� ��� ������������
//            Autorization_Form loginForm = new Autorization_Form();

//            // ��������� �������� ������ db_Connect.from_DB
//            db_Connect.from_DB = (query) => { throw new Exception("Simulated database error"); };

//            // �������� ����� ��� ��������
//            loginForm.btn_SignIn_Click(null, null);

//            // ���������, ��� ��������� �� ������ ���������
//            Assert.IsTrue(loginForm.errorMessageShown);
//        }
//    }
//}
