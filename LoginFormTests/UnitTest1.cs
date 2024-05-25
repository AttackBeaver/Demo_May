//using Repair_OrgTech;

//namespace LoginFormTests
//{
//    public class Tests
//    {
//        [SetUp]
//        public void Setup()
//        {
//            // Подготовка к тестированию, если необходимо
//        }

//        [Test]
//        public void TestSuccessfulSignIn()
//        {
//            // Создаем форму для тестирования
//            Autorization_Form autorization_Form = new Autorization_Form();

//            // Заполняем логин и пароль для успешного входа
//            autorization_Form.box_Login.Text = "user1";
//            autorization_Form.box_Password.Text = "password1";

//            // Вызываем метод для проверки
//            autorization_Form.btn_SignIn_Click(null, null);
//        }

//        [Test]
//        public void TestInvalidCredentials()
//        {
//            // Создаем форму для тестирования
//            Autorization_Form loginForm = new Autorization_Form();

//            // Заполняем некорректные логин и пароль
//            loginForm.box_Login.Text = "invalidUser";
//            loginForm.box_Password.Text = "invalidPassword";

//            // Вызываем метод для проверки
//            loginForm.btn_SignIn_Click(null, null);

//            // Проверяем, что сообщение об ошибке выводится
//            Assert.IsTrue(loginForm.errorMessageShown);
//        }

//        [Test]
//        public void TestExceptionHandling()
//        {
//            // Создаем форму для тестирования
//            Autorization_Form loginForm = new Autorization_Form();

//            // Назначаем имитацию метода db_Connect.from_DB
//            db_Connect.from_DB = (query) => { throw new Exception("Simulated database error"); };

//            // Вызываем метод для проверки
//            loginForm.btn_SignIn_Click(null, null);

//            // Проверяем, что сообщение об ошибке выводится
//            Assert.IsTrue(loginForm.errorMessageShown);
//        }
//    }
//}
